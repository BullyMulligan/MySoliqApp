namespace MySoliqApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabMySoliq = new System.Windows.Forms.TabPage();
            this.infoAboutStatusCheck = new System.Windows.Forms.Label();
            this.buttonOpenPDF = new System.Windows.Forms.Button();
            this.exampleJson = new System.Windows.Forms.Label();
            this.selectStatusToStart = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelVisibleTypeCheck = new System.Windows.Forms.Label();
            this.selectTypeCheckVisible = new System.Windows.Forms.ComboBox();
            this.checkBoxes = new System.Windows.Forms.CheckedListBox();
            this.panelProductInfo = new System.Windows.Forms.Panel();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProduct = new System.Windows.Forms.Label();
            this.dataGridheckInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.jsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOpenJson = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSaveJson = new System.Windows.Forms.ToolStripMenuItem();
            this.toolChecks = new System.Windows.Forms.ToolStripComboBox();
            this.labelCheck = new System.Windows.Forms.Label();
            this.tabTasnif = new System.Windows.Forms.TabPage();
            this.panelProductTasnif = new System.Windows.Forms.Panel();
            this.labelProductInfoTasnif = new System.Windows.Forms.Label();
            this.labelProductTasnif = new System.Windows.Forms.Label();
            this.comboBoxSelectModeTasnif = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.psic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedListTasnif = new System.Windows.Forms.CheckedListBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.buttonOpenPsic = new System.Windows.Forms.ToolStripButton();
            this.comboBoxSelectPSICTasnif = new System.Windows.Forms.ComboBox();
            this.buttonTasnifStart = new System.Windows.Forms.Button();
            this.openFileJson = new System.Windows.Forms.OpenFileDialog();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.saveDialogJson = new System.Windows.Forms.SaveFileDialog();
            this.openDialogPDF = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openPsicFile = new System.Windows.Forms.OpenFileDialog();
            this.savePsicDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControlMain.SuspendLayout();
            this.tabMySoliq.SuspendLayout();
            this.panelProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridheckInfo)).BeginInit();
            this.miniToolStrip.SuspendLayout();
            this.tabTasnif.SuspendLayout();
            this.panelProductTasnif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabMySoliq);
            this.tabControlMain.Controls.Add(this.tabTasnif);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(798, 458);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabMySoliq
            // 
            this.tabMySoliq.Controls.Add(this.infoAboutStatusCheck);
            this.tabMySoliq.Controls.Add(this.buttonOpenPDF);
            this.tabMySoliq.Controls.Add(this.exampleJson);
            this.tabMySoliq.Controls.Add(this.selectStatusToStart);
            this.tabMySoliq.Controls.Add(this.buttonStart);
            this.tabMySoliq.Controls.Add(this.labelVisibleTypeCheck);
            this.tabMySoliq.Controls.Add(this.selectTypeCheckVisible);
            this.tabMySoliq.Controls.Add(this.checkBoxes);
            this.tabMySoliq.Controls.Add(this.panelProductInfo);
            this.tabMySoliq.Controls.Add(this.dataGridheckInfo);
            this.tabMySoliq.Controls.Add(this.miniToolStrip);
            this.tabMySoliq.Controls.Add(this.labelCheck);
            this.tabMySoliq.Location = new System.Drawing.Point(4, 25);
            this.tabMySoliq.Name = "tabMySoliq";
            this.tabMySoliq.Padding = new System.Windows.Forms.Padding(3);
            this.tabMySoliq.Size = new System.Drawing.Size(790, 429);
            this.tabMySoliq.TabIndex = 0;
            this.tabMySoliq.Text = "My Soliq";
            this.tabMySoliq.UseVisualStyleBackColor = true;
            // 
            // infoAboutStatusCheck
            // 
            this.infoAboutStatusCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.infoAboutStatusCheck.BackColor = System.Drawing.Color.PowderBlue;
            this.infoAboutStatusCheck.Location = new System.Drawing.Point(470, 330);
            this.infoAboutStatusCheck.Name = "infoAboutStatusCheck";
            this.infoAboutStatusCheck.Size = new System.Drawing.Size(302, 41);
            this.infoAboutStatusCheck.TabIndex = 17;
            this.infoAboutStatusCheck.Visible = false;
            // 
            // buttonOpenPDF
            // 
            this.buttonOpenPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenPDF.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonOpenPDF.Location = new System.Drawing.Point(473, 382);
            this.buttonOpenPDF.Name = "buttonOpenPDF";
            this.buttonOpenPDF.Size = new System.Drawing.Size(132, 28);
            this.buttonOpenPDF.TabIndex = 16;
            this.buttonOpenPDF.Text = "PDF-file";
            this.buttonOpenPDF.UseVisualStyleBackColor = false;
            this.buttonOpenPDF.Visible = false;
            this.buttonOpenPDF.Click += new System.EventHandler(this.button1_Click);
            // 
            // exampleJson
            // 
            this.exampleJson.BackColor = System.Drawing.Color.Bisque;
            this.exampleJson.Location = new System.Drawing.Point(30, 113);
            this.exampleJson.Name = "exampleJson";
            this.exampleJson.Size = new System.Drawing.Size(334, 234);
            this.exampleJson.TabIndex = 15;
            this.exampleJson.Text = resources.GetString("exampleJson.Text");
            // 
            // selectStatusToStart
            // 
            this.selectStatusToStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.selectStatusToStart.FormattingEnabled = true;
            this.selectStatusToStart.Items.AddRange(new object[] { "Не пройденные", "Успешные", "ИКПУ не найден", "Все, кроме успешных", "Все" });
            this.selectStatusToStart.Location = new System.Drawing.Point(473, 297);
            this.selectStatusToStart.Name = "selectStatusToStart";
            this.selectStatusToStart.Size = new System.Drawing.Size(298, 24);
            this.selectStatusToStart.TabIndex = 14;
            this.selectStatusToStart.Tag = "notVisibleBeforeOpenJson";
            this.selectStatusToStart.Text = "Не пройденные";
            this.selectStatusToStart.Visible = false;
            this.selectStatusToStart.SelectedIndexChanged += new System.EventHandler(this.selectStatusToStart_SelectedIndexChanged);
            this.selectStatusToStart.SelectionChangeCommitted += new System.EventHandler(this.selectStatusToStart_SelectedIndexChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.BackColor = System.Drawing.Color.Wheat;
            this.buttonStart.Location = new System.Drawing.Point(628, 382);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(144, 28);
            this.buttonStart.TabIndex = 13;
            this.buttonStart.Tag = "notVisibleBeforeOpenJson";
            this.buttonStart.Text = "Запустить правки";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Visible = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelVisibleTypeCheck
            // 
            this.labelVisibleTypeCheck.Location = new System.Drawing.Point(470, 53);
            this.labelVisibleTypeCheck.Name = "labelVisibleTypeCheck";
            this.labelVisibleTypeCheck.Size = new System.Drawing.Size(301, 24);
            this.labelVisibleTypeCheck.TabIndex = 12;
            this.labelVisibleTypeCheck.Tag = "notVisibleBeforeOpenJson";
            this.labelVisibleTypeCheck.Text = "Показать чеки со статусом:";
            this.labelVisibleTypeCheck.Visible = false;
            // 
            // selectTypeCheckVisible
            // 
            this.selectTypeCheckVisible.FormattingEnabled = true;
            this.selectTypeCheckVisible.Items.AddRange(new object[] { "Все", "Успешные", "ИКПУ не найден", "Все, кроме успешных", "Не пройденные" });
            this.selectTypeCheckVisible.Location = new System.Drawing.Point(473, 80);
            this.selectTypeCheckVisible.Name = "selectTypeCheckVisible";
            this.selectTypeCheckVisible.Size = new System.Drawing.Size(298, 24);
            this.selectTypeCheckVisible.TabIndex = 11;
            this.selectTypeCheckVisible.Tag = "notVisibleBeforeOpenJson";
            this.selectTypeCheckVisible.Text = "Все";
            this.selectTypeCheckVisible.Visible = false;
            this.selectTypeCheckVisible.SelectedIndexChanged += new System.EventHandler(this.selectTypeCheckVisible_SelectedIndexChanged);
            // 
            // checkBoxes
            // 
            this.checkBoxes.BackColor = System.Drawing.SystemColors.Info;
            this.checkBoxes.FormattingEnabled = true;
            this.checkBoxes.Items.AddRange(new object[] { "Сохранять изменения", "Автозамена ИКПУ", "Авто-бэкап до запуска", "Сохранить json после запуска" });
            this.checkBoxes.Location = new System.Drawing.Point(473, 199);
            this.checkBoxes.Name = "checkBoxes";
            this.checkBoxes.Size = new System.Drawing.Size(299, 89);
            this.checkBoxes.TabIndex = 10;
            this.checkBoxes.Tag = "notVisibleBeforeOpenJson";
            this.checkBoxes.Visible = false;
            // 
            // panelProductInfo
            // 
            this.panelProductInfo.BackColor = System.Drawing.Color.MistyRose;
            this.panelProductInfo.Controls.Add(this.labelProductName);
            this.panelProductInfo.Controls.Add(this.labelProduct);
            this.panelProductInfo.Location = new System.Drawing.Point(470, 113);
            this.panelProductInfo.Name = "panelProductInfo";
            this.panelProductInfo.Size = new System.Drawing.Size(301, 74);
            this.panelProductInfo.TabIndex = 9;
            this.panelProductInfo.Tag = "notVisibleBeforeOpenJson";
            this.panelProductInfo.Visible = false;
            // 
            // labelProductName
            // 
            this.labelProductName.Location = new System.Drawing.Point(0, 29);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(301, 44);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "\r\n";
            this.labelProductName.Visible = false;
            // 
            // labelProduct
            // 
            this.labelProduct.Location = new System.Drawing.Point(3, 0);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(100, 23);
            this.labelProduct.TabIndex = 0;
            this.labelProduct.Tag = "notVisibleBeforeOpenJson";
            this.labelProduct.Text = "Product";
            this.labelProduct.Visible = false;
            // 
            // dataGridheckInfo
            // 
            this.dataGridheckInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridheckInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridheckInfo.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridheckInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridheckInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridheckInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Column1, this.Column2, this.Column3, this.colStatus });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridheckInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridheckInfo.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridheckInfo.Location = new System.Drawing.Point(15, 56);
            this.dataGridheckInfo.Name = "dataGridheckInfo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridheckInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridheckInfo.RowTemplate.Height = 24;
            this.dataGridheckInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridheckInfo.Size = new System.Drawing.Size(438, 354);
            this.dataGridheckInfo.TabIndex = 8;
            this.dataGridheckInfo.Tag = "notVisibleBeforeOpenJson";
            this.dataGridheckInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridheckInfo_CellContentClick);
            this.dataGridheckInfo.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridheckInfo_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Чек";
            this.Column1.Name = "Column1";
            this.Column1.Width = 58;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "ИКПУ";
            this.Column2.Name = "Column2";
            this.Column2.Width = 71;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "НДС";
            this.Column3.Name = "Column3";
            this.Column3.Width = 63;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.HeaderText = "Статус";
            this.colStatus.Name = "colStatus";
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.Color.PapayaWhip;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.jsonToolStripMenuItem });
            this.miniToolStrip.Location = new System.Drawing.Point(15, 14);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(756, 31);
            this.miniToolStrip.TabIndex = 4;
            // 
            // jsonToolStripMenuItem
            // 
            this.jsonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.buttonOpenJson, this.buttonSaveJson, this.toolChecks });
            this.jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
            this.jsonToolStripMenuItem.Size = new System.Drawing.Size(49, 27);
            this.jsonToolStripMenuItem.Text = "Json";
            this.jsonToolStripMenuItem.Click += new System.EventHandler(this.toolChecks_Click);
            // 
            // buttonOpenJson
            // 
            this.buttonOpenJson.Name = "buttonOpenJson";
            this.buttonOpenJson.Size = new System.Drawing.Size(152, 24);
            this.buttonOpenJson.Text = "Открыть";
            this.buttonOpenJson.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click_1);
            // 
            // buttonSaveJson
            // 
            this.buttonSaveJson.Name = "buttonSaveJson";
            this.buttonSaveJson.Size = new System.Drawing.Size(152, 24);
            this.buttonSaveJson.Text = "Сохранить";
            this.buttonSaveJson.Visible = false;
            this.buttonSaveJson.Click += new System.EventHandler(this.buttonSaveJson_Click);
            // 
            // toolChecks
            // 
            this.toolChecks.Name = "toolChecks";
            this.toolChecks.Size = new System.Drawing.Size(80, 28);
            this.toolChecks.Visible = false;
            this.toolChecks.DropDown += new System.EventHandler(this.toolStripComboBox1_TextUpdate);
            this.toolChecks.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_SelectedIndexChanged);
            // 
            // labelCheck
            // 
            this.labelCheck.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelCheck.Location = new System.Drawing.Point(15, 56);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(439, 357);
            this.labelCheck.TabIndex = 7;
            this.labelCheck.Text = "Нажмите на кнопку \"Json\" и выбирите файл формата *.json\r\nПример разметки файла;";
            // 
            // tabTasnif
            // 
            this.tabTasnif.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabTasnif.Controls.Add(this.panelProductTasnif);
            this.tabTasnif.Controls.Add(this.comboBoxSelectModeTasnif);
            this.tabTasnif.Controls.Add(this.dataGridView1);
            this.tabTasnif.Controls.Add(this.checkedListTasnif);
            this.tabTasnif.Controls.Add(this.toolStrip2);
            this.tabTasnif.Controls.Add(this.comboBoxSelectPSICTasnif);
            this.tabTasnif.Controls.Add(this.buttonTasnifStart);
            this.tabTasnif.Location = new System.Drawing.Point(4, 25);
            this.tabTasnif.Name = "tabTasnif";
            this.tabTasnif.Padding = new System.Windows.Forms.Padding(3);
            this.tabTasnif.Size = new System.Drawing.Size(790, 429);
            this.tabTasnif.TabIndex = 1;
            this.tabTasnif.Text = "Tasnif";
            // 
            // panelProductTasnif
            // 
            this.panelProductTasnif.BackColor = System.Drawing.Color.MistyRose;
            this.panelProductTasnif.Controls.Add(this.labelProductInfoTasnif);
            this.panelProductTasnif.Controls.Add(this.labelProductTasnif);
            this.panelProductTasnif.Location = new System.Drawing.Point(461, 101);
            this.panelProductTasnif.Name = "panelProductTasnif";
            this.panelProductTasnif.Size = new System.Drawing.Size(301, 74);
            this.panelProductTasnif.TabIndex = 14;
            this.panelProductTasnif.Tag = "notVisibleBeforeOpenJson";
            this.panelProductTasnif.Visible = false;
            // 
            // labelProductInfoTasnif
            // 
            this.labelProductInfoTasnif.Location = new System.Drawing.Point(0, 29);
            this.labelProductInfoTasnif.Name = "labelProductInfoTasnif";
            this.labelProductInfoTasnif.Size = new System.Drawing.Size(301, 44);
            this.labelProductInfoTasnif.TabIndex = 1;
            this.labelProductInfoTasnif.Text = "\r\n";
            this.labelProductInfoTasnif.Visible = false;
            // 
            // labelProductTasnif
            // 
            this.labelProductTasnif.Location = new System.Drawing.Point(3, 0);
            this.labelProductTasnif.Name = "labelProductTasnif";
            this.labelProductTasnif.Size = new System.Drawing.Size(100, 23);
            this.labelProductTasnif.TabIndex = 0;
            this.labelProductTasnif.Tag = "notVisibleBeforeOpenJson";
            this.labelProductTasnif.Text = "Product";
            this.labelProductTasnif.Visible = false;
            // 
            // comboBoxSelectModeTasnif
            // 
            this.comboBoxSelectModeTasnif.FormattingEnabled = true;
            this.comboBoxSelectModeTasnif.Items.AddRange(new object[] { "добавление категорий", "изменение ИКПУ" });
            this.comboBoxSelectModeTasnif.Location = new System.Drawing.Point(464, 324);
            this.comboBoxSelectModeTasnif.Name = "comboBoxSelectModeTasnif";
            this.comboBoxSelectModeTasnif.Size = new System.Drawing.Size(298, 24);
            this.comboBoxSelectModeTasnif.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.psic, this.status });
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(15, 46);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(419, 336);
            this.dataGridView1.TabIndex = 12;
            // 
            // psic
            // 
            this.psic.HeaderText = "psic";
            this.psic.Name = "psic";
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.status.HeaderText = "status";
            this.status.Name = "status";
            this.status.Width = 71;
            // 
            // checkedListTasnif
            // 
            this.checkedListTasnif.BackColor = System.Drawing.SystemColors.Info;
            this.checkedListTasnif.FormattingEnabled = true;
            this.checkedListTasnif.Items.AddRange(new object[] { "Сохранять изменения", "Авто-бэкап до запуска", "Сохранить json после запуска" });
            this.checkedListTasnif.Location = new System.Drawing.Point(463, 213);
            this.checkedListTasnif.Name = "checkedListTasnif";
            this.checkedListTasnif.Size = new System.Drawing.Size(299, 89);
            this.checkedListTasnif.TabIndex = 11;
            this.checkedListTasnif.Tag = "notVisibleBeforeOpenJson";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.buttonOpenPsic });
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(784, 27);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // buttonOpenPsic
            // 
            this.buttonOpenPsic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonOpenPsic.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenPsic.Image")));
            this.buttonOpenPsic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonOpenPsic.Name = "buttonOpenPsic";
            this.buttonOpenPsic.Size = new System.Drawing.Size(41, 24);
            this.buttonOpenPsic.Text = "Json";
            this.buttonOpenPsic.Click += new System.EventHandler(this.toolStripSplitButton1_Click);
            // 
            // comboBoxSelectPSICTasnif
            // 
            this.comboBoxSelectPSICTasnif.FormattingEnabled = true;
            this.comboBoxSelectPSICTasnif.Items.AddRange(new object[] { "все ИКПУ", "только корректные ИКПУ", "измененные ИКПУ", "все ИКПУ, кроме корректных", "ИКПУ без статусов" });
            this.comboBoxSelectPSICTasnif.Location = new System.Drawing.Point(464, 59);
            this.comboBoxSelectPSICTasnif.Name = "comboBoxSelectPSICTasnif";
            this.comboBoxSelectPSICTasnif.Size = new System.Drawing.Size(299, 24);
            this.comboBoxSelectPSICTasnif.TabIndex = 2;
            this.comboBoxSelectPSICTasnif.Text = "все ИКПУ";
            // 
            // buttonTasnifStart
            // 
            this.buttonTasnifStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTasnifStart.AutoSize = true;
            this.buttonTasnifStart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonTasnifStart.Location = new System.Drawing.Point(640, 382);
            this.buttonTasnifStart.Name = "buttonTasnifStart";
            this.buttonTasnifStart.Size = new System.Drawing.Size(123, 33);
            this.buttonTasnifStart.TabIndex = 1;
            this.buttonTasnifStart.Text = "Запуск";
            this.buttonTasnifStart.UseVisualStyleBackColor = false;
            this.buttonTasnifStart.Click += new System.EventHandler(this.buttonTasnifStart_Click);
            // 
            // openFileJson
            // 
            this.openFileJson.FileName = "openFileDialog1";
            this.openFileJson.Filter = "Json|*.json";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.Width = -1;
            // 
            // saveDialogJson
            // 
            this.saveDialogJson.Filter = "Json|*json";
            // 
            // openDialogPDF
            // 
            this.openDialogPDF.FileName = "openFileDialog1";
            this.openDialogPDF.Filter = "Rar|*rar";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Rar|*rar";
            // 
            // openPsicFile
            // 
            this.openPsicFile.Filter = "Json|*.json";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(798, 458);
            this.Controls.Add(this.tabControlMain);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.tabControlMain.ResumeLayout(false);
            this.tabMySoliq.ResumeLayout(false);
            this.panelProductInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridheckInfo)).EndInit();
            this.miniToolStrip.ResumeLayout(false);
            this.miniToolStrip.PerformLayout();
            this.tabTasnif.ResumeLayout(false);
            this.tabTasnif.PerformLayout();
            this.panelProductTasnif.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn psic;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.ComboBox comboBoxSelectModeTasnif;
        private System.Windows.Forms.Panel panelProductTasnif;
        private System.Windows.Forms.Label labelProductInfoTasnif;
        private System.Windows.Forms.Label labelProductTasnif;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.CheckedListBox checkedListTasnif;

        private System.Windows.Forms.ToolStripButton buttonOpenPsic;

        private System.Windows.Forms.ToolStripButton toolStripButton1;

        private System.Windows.Forms.ToolStrip toolStrip2;

        private System.Windows.Forms.ComboBox comboBoxSelectPSICTasnif;

        private System.Windows.Forms.SaveFileDialog savePsicDialog;

        private System.Windows.Forms.OpenFileDialog openPsicFile;
        private System.Windows.Forms.Button buttonTasnifStart;

        private System.Windows.Forms.Label infoAboutStatusCheck;

        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        private System.Windows.Forms.OpenFileDialog openDialogPDF;

        private System.Windows.Forms.Button buttonOpenPDF;

        private System.Windows.Forms.Label exampleJson;

        private System.Windows.Forms.ComboBox selectStatusToStart;

        private System.Windows.Forms.Button buttonStart;

        private System.Windows.Forms.Label labelVisibleTypeCheck;

        private System.Windows.Forms.ComboBox selectTypeCheckVisible;

        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;

        private System.Windows.Forms.CheckedListBox checkBoxes;

        private System.Windows.Forms.SaveFileDialog saveDialogJson;

        private System.Windows.Forms.ToolStripMenuItem buttonSaveJson;

        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelProductName;

        private System.Windows.Forms.Panel panelProductInfo;

        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;

        private System.Windows.Forms.DataGridView dataGridheckInfo;

        private System.Windows.Forms.ToolStripComboBox toolChecks;


        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabMySoliq;
        private System.Windows.Forms.TabPage tabTasnif;

        private System.Windows.Forms.Label labelCheck;

        private System.Windows.Forms.OpenFileDialog openFileJson;

        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.ToolStripMenuItem jsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonOpenJson;

        #endregion
    }
}