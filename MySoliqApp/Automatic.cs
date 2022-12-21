using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using NUnit.Framework;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Interactions;
using Cookie = OpenQA.Selenium.Cookie;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Keys = OpenQA.Selenium.Keys;

namespace MySoliqApp
{
    public class Automatic : Overloads
    {
        
        private By _row = By.XPath("//div[@id='check-edit']");

        public void Tasnif()
        {
            driver = new ChromeDriver(); //открываем Хром
            driver.Manage().Window.Maximize(); //открыть в полном окне
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            driver.Navigate().GoToUrl("https://tasnif.soliq.uz");
            Click(_switchSaliqLanguage, 0);
            Click(_languageRu, 2);
            Click(_buttonEnter, 0);
            Click(_buttonEnter, 0);
            Click(_buttonEnter, 1);
            while (driver.FindElements(By.XPath("//div[@class='ant-col ant-col-7 Header_avatarPart__1jsPv']")).Count == 0) { }

            Click(_labelEkpu);
            string json =
                System.IO.File.ReadAllText("C:/Users/ipopov/RiderProjects/TestsPaymart/TestsPaymart/json/psic.json");
            var psic = Newtonsoft.Json.JsonConvert.DeserializeObject<string[]>(json);
            driver.Navigate().GoToUrl($"https://tasnif.soliq.uz/attribute/{psic[0]}");
            List<string> list = new List<string>();
            for (int i = psic.Length - 1; i > 0; i--)
            {
                driver.Navigate().GoToUrl($"https://tasnif.soliq.uz/attribute/{psic[i]}");
                if (driver.FindElements(_buttonSaveCategory).Count == 0)
                {
                    list.Add($"Error: {psic[i]}");
                }
                else
                {
                    Click(_buttonSaveCategory, 0);
                    list.Add($"Success: {psic[i]}");
                }
            }

            string path_json = "C:/Users/ipopov/RiderProjects/TestsPaymart/TestsPaymart/json/test1.json";
            string jsondata = Newtonsoft.Json.JsonConvert.SerializeObject(list);
            File.WriteAllText(path_json, jsondata);
        }
        [Test]
        public Check[] MySoligUniversal( Check[] checks, InfoAboutMethod info)
        {
            driver = new ChromeDriver(); //открываем Хром
            driver.Manage().Window.Maximize(); //открыть в полном окне
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            driver.Navigate().GoToUrl("https://my.soliq.uz/main/");
            Click(_buttonLanguageRu); //меняем язык
            Click(_buttonEnterCabinet);
            Click(_buttonsEsiOrUsb, 0);
            Click(_buttonsSignIn, 0);
            //var checks = LoadJson(jsonName); //загружаем джейсон по названию.
            Thread.Sleep(2000); //ожидание на случай капчи
            while (driver.FindElements(By.XPath("//li[@class='type-18 ff-rCondensedBold']")).Count <= 0)
            {
            } //ожидаем, пока кнопка "войти" не исчезнет

            driver.Navigate().GoToUrl("https://my.soliq.uz/cashregister/check/edit/marketplays");
            try
            {
                for (int i = 0; i < checks.Length; i++)
                {
                    double totalPrice = 0f;
                    if (CheckStatus(checks[i].status,info._statusCheck))//checks[i].status != "Success") //если статус чека не Success, то проходим по чеку
                    {
                        Clear(_fieldcheckNumber); //очищаем поле номера чека
                        SendKeys(_fieldcheckNumber, checks[i].qr_code_url); //вводим номер чека
                        Click(_buttonFindCheck); //жмем кнопку поиска чека
                        if (driver.FindElements(By.XPath("//div[@class='toast toast-error']")).Count==0)
                        {
                            while (driver.FindElements(By.XPath("//div[@id='check-edit'][1]//input[@name='vat']")).Count==0) {} //ждем, пока кнопка с заливкой ПДФ не прогрузится

                            
                            int checkCount = driver.FindElements(By.XPath("//div[@class='row no-gutters text-center']")).Count; //определяем количество товаров в чеке

                            for (int j = 0; j < checkCount; j++) //прохоим по всем товарам в чеке
                            {
                                Scroll(By.XPath($"//div[@class='row no-gutters text-center'][{j + 1}]//span[@role='textbox']"));
                                string psic = "";
                                Clear(By.XPath($"//div[@class='row no-gutters text-center'][{j + 1}]//input[@name='vat']"));
                                SendKeys(driver.FindElement(By.XPath($"//div[@class='row no-gutters text-center'][{j + 1}]//input[@name='vat']")), checks[i].product[j].vat);
                                psic = $"psic({checks[i].product[j].psic}) not found";//готовим статус, если ИКПУ не найден
                                driver.FindElement(By.XPath($"//div[@class='row no-gutters text-center'][{j + 1}]//span[@role='textbox']")).Click(); //открываем список ИКПУ
                               
                                Thread.Sleep(1000);
                                Click(By.XPath("//li[@role='option']"));
                                Thread.Sleep(1000);
                                driver.FindElement(By.XPath($"//div[@class='row no-gutters text-center'][{j + 1}]//span[@role='textbox']")).Click();
                                SendKeys(_fieldIkpu, checks[i].product[j].psic);//заполняем поле ИКПУ
                                Thread.Sleep(200);
                                
                                if (info._auto)//если чек на автозамену ИКПУ включен, то начинаем исправлять
                                {
                                    if (driver.FindElements(By.XPath("//li[@role='alert']")).Count != 0)//проверяем на наличие ошибки ИКПУ
                                    {
                                        int coutChange = 4;//число попыток удалить крайнее значение
                                        while (coutChange!=0)//цикл крутится, пока не попыток не останется 0
                                        {
                                            SendKeys(_fieldIkpu,Keys.Backspace);//заполняем поле ИКПУ ,без одного символа
                                            if (driver.FindElements(By.XPath("//li[@role='alert']")).Count == 0)//если ошибки нет, и ПСИК прошел
                                            {
                                                checks[i].product[j].psic = driver.FindElement(_fieldIkpu).GetAttribute("value");//если все-таки удаление чисел помогло - заменяем ИКПУ в джейсоне
                                                break;//выходим из цикла
                                            }
                                            coutChange--;//отнимаем попытку при рохождении цикла
                                        }
                                        if (driver.FindElements(By.XPath("//li[@role='alert']")).Count != 0)//если и после этого псика нет
                                        {
                                            checks[i].product[j].psic = checks[i - 1].product[0].psic;//заменяем псик ну псик из предыдущего чека
                                            Clear(_fieldIkpu);//чистим поле ИКПУ
                                            SendKeys(_fieldIkpu, checks[i].product[j].psic);//вбиваем старый, уже новый ИКПУ
                                        }
                                    }
                                }
                                
                                if (driver.FindElements(By.XPath("//li[@role='alert']")).Count == 0) //если нет поля "ИКПУ не найден"
                                {
                                    
                                    Click(_labelSelectIkpu); //жмем на лейбл ЕКПУ
                                    //Thread.Sleep(200);
                                    //Scroll(_fieldTotalPrice); //прокручиваем до тотал прайс
                                    driver.FindElement(By.XPath($"//div[@class='row no-gutters text-center'][{j+1}]//button[@data-toggle='dropdown']")).Click();
                                    //Thread.Sleep(200);
                                    
                                    //Click(_buttonUnit); //открываем поле единицы измерения
                                    if (driver.FindElements(By.XPath($"//div[@class='row no-gutters text-center'][{j+1}]//ul[@class='dropdown-menu inner ']//a[@role='option']")).Count > 5) //Если нет лейбла об отсутсвия ед. измерения
                                    {
                                        driver.FindElements(By.XPath($"//div[@class='row no-gutters text-center'][{j + 1}]//span[@class='text']"))[1].Click(); //жмем на второе поле едюизмерения
                                        Click(_buttonInn); //открываем вкладку с ИНН
                                        //Thread.Sleep(200);
                                        driver.FindElements(By.XPath($"//div[@class='row no-gutters text-center'][{j + 1}]//input[@role='textbox']"))[1].SendKeys(checks[i].TIN); //вводим ИНН
                                        //Thread.Sleep(200);
                                        if (driver.FindElements(By.XPath("//div[@class='row no-gutters text-center']")).Count != 0) //если нет сообщения об отсутствия поля ИНН
                                        {
                                            driver.FindElements(By.XPath($"//span[text()='{checks[i].TIN}']"))[j].Click(); //жмем на лейбл ИНН
                                            //Thread.Sleep(200);
                                            totalPrice += double.Parse(driver.FindElement(By.XPath("//input[@name='price']")).GetAttribute("value").Replace('.',','));
                                            if (checkCount - j == 1) //если мы заполнили последний товар в чеке
                                            {
                                               
                                                AttachFile(_loadPdf, info._adressPDF); //заливаем ПДФ-файл
                                                Scroll(_buttonSend);
                                                Thread.Sleep(200);
                                                Click(_buttonSend); //жмем кнопку отправить обновленные данные
                                                int countWhile = 0;
                                                bool success = true;
                                                while (driver.FindElements(By.Id("toast-container")).Count == 0  )
                                                {
                                                    Thread.Sleep(200);
                                                    countWhile++;
                                                    if (countWhile == 20)
                                                    {
                                                        success = false;
                                                        break;
                                                    }
                                                    
                                                } //ждем, пока не появится сообщение о успешном сохранении
                                                if (success)
                                                {
                                                    checks[i].status = "Success"; //меняем статус чека в json
                                                }
                                                
                                            
                                            }
                                        }
                                        else
                                        {
                                            checks[i].status = "bug TIN field"; //назначаем статус ошибки поля ИНН
                                            break;
                                        }

                                    }
                                    else
                                    {
                                        checks[i].status = $"not unit field{j + 1}"; //назначаем статус ошибки ед.значения
                                        break;
                                    }

                                }
                                else
                                {
                                    checks[i].status = psic; //статус ошибки ИКПУ не найден
                                    break;
                                }
                            }
                        }
                        else
                        {
                            checks[i].status = "Cancel";
                        }
                    }
                    //Scroll(_fieldcheckNumber);
                    Clear(_fieldcheckNumber); //очищаем поле "номер чека"
                    driver.Navigate().GoToUrl("https://my.soliq.uz/cashregister/check/edit/marketplays");
                }
            }
            catch (Exception e) //при ошибке или сбое
            {
                //SaveJson(checks, jsonName); //сохраняем изменения json
                Console.WriteLine(e);
                //driver.Quit();
                throw;
            }
            //driver.Quit();
            MessageBox.Show("Все чеки пройдены");
            return checks;
            
            //SaveJson(checks, jsonName); //сохраняем json
        }

        public Check[] LoadJson(string name) //метод загружающий json. Принимает имя файла
        {
            Check[] checks = new Check[0];
            using (StreamReader r = new StreamReader($"/Json/{name}.json"))
            {
                string json = r.ReadToEnd();
                Check[] list = JsonConvert.DeserializeObject<Check[]>(json);
                checks = list;
            }

            return checks;
        }

        public void SaveJson(Check[] checks, string name)
        {

            string adress = $"C:/Users/ipopov/Test/TestsPaymart/Json/{name}.json";
            string json = JsonConvert.SerializeObject(checks);
            File.WriteAllText(adress, json);
        } //Метод сохраняющий json, принимает имя

        public bool CheckStatus(string status,int indexStatus)//проверяем, проходит ли чек
        {
            bool flag=false;
            switch (indexStatus)
            {
                case 0:
                    if (status=="")//все, кто не прошел проверку, проходят
                    {
                        flag = true;
                    }
                    break;
                case 1:
                    if (status.Contains("Success"))//прогоняем успешные чеки
                    {
                        flag = true;
                    }
                    break;
                case 2:
                    if (status.Contains("psic"))//с ошибкой ИКПУ
                    {
                        flag = true;
                    }
                    break;
                case 3:
                    if (!status.Contains("Success"))//все, кроме успешно пройденных
                    {
                        flag = true;
                    }
                    break;
                case 4:
                    flag = true;//все чеки без исключения
                    break;
            }
            return flag;
        }

        public string AutoChangePsic(string psic)
        {
            psic.Remove(psic.Length-1);
            return psic;
        }
        public class Check
        {
            public string qr_code_url { get; set; }

            public string TIN { get; set; }
            public string status = "";
            public Product[] product;

            public class Product
            {
                public string vat { get; set; }
                public string psic { get; set; }
                public string price { get; set; }
                public string old_vat {get;set;}
                public string old_price { get; set; }
            }
            
        }

        public class PsicInfo//класс, который мы вытаскиваем из ответа о псике
        {
            public Data data { get; set; }
            public class Data
            {
                public Content[] content { get; set; }
                public class Content
                {
                    public string brandName  {get;set;}//имя бренда, например, Apple
                    public string mxikName { get; set;}//категория и название продукта
                    public string attributeName { get; set; }//название продукта
                }
            }
        }

        public class InfoAboutMethod//класс, передающий информацию об имени файлов, включенных чекбоксах
        {
            public int _statusCheck;//передаем информацию о чекбоксах статусов
            public bool _auto;//статус включенной функции автозамены псика
            public string _adressPDF;//передаем адрес пдф-файла
        }
    }
}