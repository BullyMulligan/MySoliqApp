using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MySoliqApp
{
    public partial class Form1 : Form
    {
        private string _jsonName = "";
        private string _adressJson = "";
        private string _adressPDF = "";

        private int _countSuccess = 0;
        private int _countNotSuccess = 0;
        private int _countEmpty = 0;
        private int _countPsicNotFound = 0;
        
        
        private Automatic.Check[] _checks = Array.Empty<Automatic.Check>();
        private WebRequest _request = new WebRequest();
        Automatic _test =new Automatic();
        private Automatic.InfoAboutMethod info = new Automatic.InfoAboutMethod();
        public Form1()
        {
            InitializeComponent();
            dataGridheckInfo.Visible = false;
            //checkBoxes.SetItemChecked(0,true);//включаем чек сохранения по умолчанию
            //test.MySoligUniversal(_checks,selectStatusToStart.SelectedIndex);//эта херня ломает программу
        }
        
        private void OpenJsonFile(string name)//метод, открывающий файл
        {
            ;//создаем массив чеков
            using (StreamReader r = new StreamReader(openFileJson.OpenFile()))//используем файл как поток
            {
                string json = r.ReadToEnd();//преобразуем его в стринг
                Automatic.Check[] list = JsonConvert.DeserializeObject<Automatic.Check[]>(json);//сериализация джейсона в массив чеков
                _checks = list;
            }
            jsonToolStripMenuItem.Text = name;
            labelCheck.Text = "Выберите номер чека";
        }
        

        private void SaveJsonFile() //метод, сохраняющий файл
        {
            saveDialogJson.ShowDialog();
            string json = JsonConvert.SerializeObject(_checks);
            File.WriteAllText(saveDialogJson.FileName, json);
        }
       

        private void открытьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = openFileJson.ShowDialog();
                if (res == DialogResult.OK)
                {
                    
                    _jsonName = openFileJson.SafeFileName;
                    _adressJson = openFileJson.FileName;
                    OpenJsonFile(_jsonName);
                    //если файл успешно загружен, то делаем видимыми следующие элементы:
                    exampleJson.Visible = false;
                    toolChecks.Visible = true;
                    buttonSaveJson.Visible = true;
                    selectTypeCheckVisible.Visible = true;
                    labelVisibleTypeCheck.Visible = true;
                    checkBoxes.Visible = true;
                    selectStatusToStart.Visible = true;
                    buttonOpenPDF.Visible = true;
                    CheckCounting();
                    ChangeInfoAboutCheckStatus();
                    //изменяем текст подсказки
                    labelCheck.Text = "Нажмите на название json-файла и выберите номер чека\nТакже можете выбрать сортировку чеков по статусу";

                }
                else
                {
                    throw new Exception("Файл не найден!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckCounting()
        {
            _countEmpty= _checks.Where(i => i.status == "").Count();
            _countSuccess = _checks.Where(i => i.status == "Success").Count();
            _countPsicNotFound = _checks.Where(i => i.status.Contains("psic")).Count();
            _countNotSuccess = _checks.Where(i => i.status != "Success").Count();
        }
        private void ChangeInfoAboutCheckStatus()//меняем информацию о чеках вместе с комбобоксом
        {
            infoAboutStatusCheck.Visible = true;
            switch (selectStatusToStart.SelectedIndex)
            {
                case 0:
                    infoAboutStatusCheck.Text =
                        $"Общее число чеков: {_checks.Length}\nЧисло непройденных чеков: {_countEmpty}";
                    break;
                case 1:
                    infoAboutStatusCheck.Text =
                        $"Общее число чеков: {_checks.Length}\nЧисло успешно пройденных чеков: {_countSuccess}";
                    break;
                case 2:
                    infoAboutStatusCheck.Text =
                        $"Общее число чеков: {_checks.Length}\nЧисло чеков с ненайденным ИКПУ: {_countPsicNotFound}";
                    break;
                case 3:
                    infoAboutStatusCheck.Text =
                        $"Общее число чеков: {_checks.Length}\nВсе чеки, кроме статусов \"Успешно\": {_countNotSuccess}";
                    break;
                case 4:
                    infoAboutStatusCheck.Text =
                        $"Общее число чеков: {_checks.Length}";
                    break;
                
                
            }
        }

        private void toolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)//метод, меняющий значение поля информации
        {
            dataGridheckInfo.Rows.Clear();
            for (int i = 0; i < _checks[toolChecks.SelectedIndex].product.Length; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridheckInfo.Rows[0].Clone();
                row.Cells[1].Value =_checks[toolChecks.SelectedIndex].product[i].psic;
                row.Cells[2].Value =_checks[toolChecks.SelectedIndex].product[i].vat;
                dataGridheckInfo.Rows.Add(row);
            }
            dataGridheckInfo.Rows[0].Cells[0].Value = _checks[toolChecks.SelectedIndex].qr_code_url;
            dataGridheckInfo[3,0].Value =_checks[toolChecks.SelectedIndex].status;
            dataGridheckInfo.Visible = true;

        }

        private void toolStripComboBox1_TextUpdate(object sender, EventArgs e)
        {
            for (var i=0; i< toolChecks.Items.Count;i++)
            {
                if (Convert.ToString(toolChecks.Items[i]).Contains(toolChecks.Text))
                {
                    toolChecks.SelectedIndex = i;
                }
            }
            
        }

        private void dataGridheckInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)//при нажатии на элемент таблицы
        {
            try
            {
                labelProductName.Visible = true;
                labelProduct.Visible = true;
                panelProductInfo.Visible = true;
                labelProductName.Text = "";//обнуляем поле с именем продукта
                if (e.ColumnIndex == 1)//работает только при клике на солонку "ИКПУ"
                {
                    var senderGrid = (DataGridView)sender;
                    string text = _request.Get($"https://tasnif.soliq.uz/api/cls-api/mxik/search/by-params?mxikCode={senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value}&size=1");//отправляем GET с екпу
                    Automatic.PsicInfo psicInfo = _request.GetPsicInfoOnGet(text);//ответ пересобираем в объект
                    if (psicInfo.data.content.Length > 0)//если ИКПУ несет информуцию
                    {
                        var name =psicInfo.data.content[0].attributeName;
                        byte[] bytes = Encoding.Default.GetBytes(name);
                        name = Encoding.UTF8.GetString(bytes);//энкодим текст
                        labelProductName.Text = name;//пишем ее в поле о продукте
                    }
                    else
                    {
                        labelProductName.Text = "ИКПУ отсутствует в базе Tasnif";//пишем, что ИКПУ отсутствует
                    } 
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Выберите ячейку с ИКПУ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void buttonSaveJson_Click(object sender, EventArgs e)
        {
            SaveJsonFile();
        }

        private void dataGridheckInfo_CellEndEdit(object sender, DataGridViewCellEventArgs e)//при изменении значения в ячейке меняет данные в массиве чеков
        {
            var senderGrid = (DataGridView)sender;
            switch (e.ColumnIndex)//если колонка
            {
                case 1://1(псик)
                    if (checkBoxes.GetItemChecked(0) )
                    {
                        for (int i = 0; i < _checks.Length; i++)
                        {
                            if (_checks[i].qr_code_url == dataGridheckInfo[0, 0].Value)
                            {
                                _checks[i].product[e.RowIndex].psic = dataGridheckInfo[e.ColumnIndex, e.RowIndex].Value.ToString();
                                //меняет значение псика на измененное значение в ячейке
                            }
                        }
                    }
                    break;
                case 3:
                    if (checkBoxes.GetItemChecked(0) )
                    {
                        for (int i = 0; i < _checks.Length; i++)
                        {
                            if (_checks[i].qr_code_url == dataGridheckInfo[0, 0].Value)
                            {
                                _checks[i].status = dataGridheckInfo[e.ColumnIndex, e.RowIndex].Value.ToString();
                                //меняет значение статуса на измененное значение в ячейке
                            }
                        }
                    }
                    break;
            }
        }

        private void toolChecks_Click(object sender, EventArgs e)//пересчитывает число видимых чеков
        {
            toolChecks.Items.Clear();
            toolChecks.Text = "";
            dataGridheckInfo.Visible = false;
            labelProductName.Visible = false;
            labelProduct.Visible = false;
            panelProductInfo.Visible = false;
            switch (selectTypeCheckVisible.SelectedIndex)//смотря какой вид статуса выбран
            {
                case 1 :
                    
                    for (int i = 0; i < _checks.Length; i++)
                    {
                        if (_checks[i].status=="Success")
                        {
                            toolChecks.Items.Add(_checks[i].qr_code_url);
                        }
                    }
                    
                    break;
                case 2 :
                    toolChecks.Items.Clear();
                    for (int i = 0; i < _checks.Length; i++)
                    {
                        if (_checks[i].status.Contains("psic"))
                        {
                            toolChecks.Items.Add(_checks[i].qr_code_url);
                        }
                    }
                    
                    break;
                case 3 :
                    
                    for (int i = 0; i < _checks.Length; i++)
                    {
                        if (_checks[i].status!="Success")
                        {
                            toolChecks.Items.Add(_checks[i].qr_code_url);
                        }
                    }
                    
                    break;
                case 4 :
                    for (int i = 0; i < _checks.Length; i++)
                    {
                        if (_checks[i].status=="")
                        {
                            toolChecks.Items.Add(_checks[i].qr_code_url);
                        }
                    }
                    
                    break;
                case 0:
                    for (int i = 0; i < _checks.Length; i++)
                    {
                        toolChecks.Items.Add(_checks[i].qr_code_url);
                    }
                    break;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxes.GetItemChecked(2))//если чек-бокс 3 включен
                {
                    string json = JsonConvert.SerializeObject(_checks);//сереализуем массив чеков в строку
                    File.WriteAllText($"{_adressJson}.backup.json", json);//делаем бэкап до запуска 
                }

                info._statusCheck = selectStatusToStart.SelectedIndex;//передаем информацию о выбранных для проверке статусах
                info._auto = checkBoxes.GetItemChecked(1);//параметр автозамены ИКПУ
                
                _checks=_test.MySoligUniversal(_checks,info);//передаем чеки и информацию о включенных чекбоксах/функций и запускаем проход чеков
                CheckCounting();
                ChangeInfoAboutCheckStatus();
                if(checkBoxes.GetItemChecked(0))
                {
                    string json = JsonConvert.SerializeObject(_checks);//сереализуем массив чеков в строку
                    File.WriteAllText(_adressJson, json);//сохраняем джейсон после запуска
                }
                if (checkBoxes.GetItemChecked(3))//если чек-бокс 4 включен
                {
                    string json = JsonConvert.SerializeObject(_checks);//сереализуем массив чеков в строку
                    File.WriteAllText($"{_adressJson}.done.json", json);//сохраняем джейсон после запуска
                }
            }
            catch (Exception ex)
            {
                if (checkBoxes.GetItemChecked(3))
                {
                    string json = JsonConvert.SerializeObject(_checks);//сереализуем массив чеков в строку
                    File.WriteAllText($"{_adressJson}.done.json", json);//сохраняем джейсон после запуска
                }
                MessageBox.Show(ex.Message,"Ошибка Браузера");
                //throw;
            }
            
            
        }

        private void selectTypeCheckVisible_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridheckInfo.Visible=false;
            labelProductName.Visible = false;
            labelProduct.Visible = false;
            panelProductInfo.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)//выираем ПДФ файл
        {
            DialogResult res = openDialogPDF.ShowDialog();
            if (res == DialogResult.OK)
            {
                info._adressPDF = openDialogPDF.FileName;
                buttonStart.Visible = true;
            }
            else
            {
                throw new Exception("Файл не найден!");
            }
        }


        private void selectStatusToStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeInfoAboutCheckStatus();
        }

        
    }
}