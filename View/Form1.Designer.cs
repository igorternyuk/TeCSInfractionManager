namespace View
{
    partial class MainWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabInfractions = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblInfraxtionSearchResults = new System.Windows.Forms.Label();
            this.btnInfractionSearch = new System.Windows.Forms.Button();
            this.btnLoadFullList = new System.Windows.Forms.Button();
            this.btnRemoveInfraction = new System.Windows.Forms.Button();
            this.btnUpdateInfraction = new System.Windows.Forms.Button();
            this.btnInsertInfraction = new System.Windows.Forms.Button();
            this.txtSearchInfraction = new System.Windows.Forms.TextBox();
            this.spinnerFine = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInfractionDetails = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.cmbVehicleModel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPatent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableInfractions = new System.Windows.Forms.DataGridView();
            this.tabModels = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVehicleModelSearchResults = new System.Windows.Forms.Label();
            this.btnSearchModel = new System.Windows.Forms.Button();
            this.txtSearchVehicleModel = new System.Windows.Forms.TextBox();
            this.btnLoadVehicleModelFullList = new System.Windows.Forms.Button();
            this.btnRemoveVehicleModel = new System.Windows.Forms.Button();
            this.btnUpdateVehicleModel = new System.Windows.Forms.Button();
            this.btnInsertModel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbModelBrand = new System.Windows.Forms.ComboBox();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.lblModelName = new System.Windows.Forms.Label();
            this.tableVehicleModels = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSearchResults = new System.Windows.Forms.Label();
            this.btnReloadAllBrands = new System.Windows.Forms.Button();
            this.txtSearchBrand = new System.Windows.Forms.TextBox();
            this.btnSearchBrand = new System.Windows.Forms.Button();
            this.btnRemoveBrand = new System.Windows.Forms.Button();
            this.btnUpdateBrand = new System.Windows.Forms.Button();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsertBrand = new System.Windows.Forms.Button();
            this.tableBrands = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabInfractions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerFine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableInfractions)).BeginInit();
            this.tabModels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableVehicleModels)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBrands)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabInfractions);
            this.tabControl.Controls.Add(this.tabModels);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(792, 586);
            this.tabControl.TabIndex = 0;
            // 
            // tabInfractions
            // 
            this.tabInfractions.Controls.Add(this.splitContainer1);
            this.tabInfractions.Location = new System.Drawing.Point(4, 22);
            this.tabInfractions.Name = "tabInfractions";
            this.tabInfractions.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfractions.Size = new System.Drawing.Size(784, 560);
            this.tabInfractions.TabIndex = 1;
            this.tabInfractions.Text = "Infractions";
            this.tabInfractions.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableInfractions);
            this.splitContainer1.Size = new System.Drawing.Size(778, 554);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblInfraxtionSearchResults);
            this.groupBox3.Controls.Add(this.btnInfractionSearch);
            this.groupBox3.Controls.Add(this.btnLoadFullList);
            this.groupBox3.Controls.Add(this.btnRemoveInfraction);
            this.groupBox3.Controls.Add(this.btnUpdateInfraction);
            this.groupBox3.Controls.Add(this.btnInsertInfraction);
            this.groupBox3.Controls.Add(this.txtSearchInfraction);
            this.groupBox3.Controls.Add(this.spinnerFine);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtInfractionDetails);
            this.groupBox3.Controls.Add(this.lblDate);
            this.groupBox3.Controls.Add(this.txtDate);
            this.groupBox3.Controls.Add(this.cmbVehicleModel);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtPatent);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 554);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Infraction form";
            // 
            // lblInfraxtionSearchResults
            // 
            this.lblInfraxtionSearchResults.AutoSize = true;
            this.lblInfraxtionSearchResults.Location = new System.Drawing.Point(20, 519);
            this.lblInfraxtionSearchResults.Name = "lblInfraxtionSearchResults";
            this.lblInfraxtionSearchResults.Size = new System.Drawing.Size(16, 13);
            this.lblInfraxtionSearchResults.TabIndex = 17;
            this.lblInfraxtionSearchResults.Text = "...";
            // 
            // btnInfractionSearch
            // 
            this.btnInfractionSearch.Location = new System.Drawing.Point(20, 473);
            this.btnInfractionSearch.Name = "btnInfractionSearch";
            this.btnInfractionSearch.Size = new System.Drawing.Size(165, 23);
            this.btnInfractionSearch.TabIndex = 16;
            this.btnInfractionSearch.Text = "Search";
            this.btnInfractionSearch.UseVisualStyleBackColor = true;
            this.btnInfractionSearch.Click += new System.EventHandler(this.btnInfractionSearch_Click);
            // 
            // btnLoadFullList
            // 
            this.btnLoadFullList.Location = new System.Drawing.Point(103, 387);
            this.btnLoadFullList.Name = "btnLoadFullList";
            this.btnLoadFullList.Size = new System.Drawing.Size(82, 23);
            this.btnLoadFullList.TabIndex = 15;
            this.btnLoadFullList.Text = "Load full list";
            this.btnLoadFullList.UseVisualStyleBackColor = true;
            this.btnLoadFullList.Click += new System.EventHandler(this.btnLoadFullList_Click);
            // 
            // btnRemoveInfraction
            // 
            this.btnRemoveInfraction.Location = new System.Drawing.Point(20, 387);
            this.btnRemoveInfraction.Name = "btnRemoveInfraction";
            this.btnRemoveInfraction.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveInfraction.TabIndex = 14;
            this.btnRemoveInfraction.Text = "Remove";
            this.btnRemoveInfraction.UseVisualStyleBackColor = true;
            this.btnRemoveInfraction.Click += new System.EventHandler(this.btnRemoveInfraction_Click);
            // 
            // btnUpdateInfraction
            // 
            this.btnUpdateInfraction.Location = new System.Drawing.Point(101, 348);
            this.btnUpdateInfraction.Name = "btnUpdateInfraction";
            this.btnUpdateInfraction.Size = new System.Drawing.Size(84, 23);
            this.btnUpdateInfraction.TabIndex = 13;
            this.btnUpdateInfraction.Text = "Update";
            this.btnUpdateInfraction.UseVisualStyleBackColor = true;
            this.btnUpdateInfraction.Click += new System.EventHandler(this.btnUpdateInfraction_Click);
            // 
            // btnInsertInfraction
            // 
            this.btnInsertInfraction.Location = new System.Drawing.Point(20, 348);
            this.btnInsertInfraction.Name = "btnInsertInfraction";
            this.btnInsertInfraction.Size = new System.Drawing.Size(75, 23);
            this.btnInsertInfraction.TabIndex = 12;
            this.btnInsertInfraction.Text = "Insert";
            this.btnInsertInfraction.UseVisualStyleBackColor = true;
            this.btnInsertInfraction.Click += new System.EventHandler(this.btnInsertInfraction_Click);
            // 
            // txtSearchInfraction
            // 
            this.txtSearchInfraction.Location = new System.Drawing.Point(20, 432);
            this.txtSearchInfraction.Name = "txtSearchInfraction";
            this.txtSearchInfraction.Size = new System.Drawing.Size(165, 20);
            this.txtSearchInfraction.TabIndex = 11;
            // 
            // spinnerFine
            // 
            this.spinnerFine.Location = new System.Drawing.Point(62, 304);
            this.spinnerFine.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.spinnerFine.Name = "spinnerFine";
            this.spinnerFine.Size = new System.Drawing.Size(120, 20);
            this.spinnerFine.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description";
            // 
            // txtInfractionDetails
            // 
            this.txtInfractionDetails.Location = new System.Drawing.Point(20, 184);
            this.txtInfractionDetails.Multiline = true;
            this.txtInfractionDetails.Name = "txtInfractionDetails";
            this.txtInfractionDetails.Size = new System.Drawing.Size(162, 101);
            this.txtInfractionDetails.TabIndex = 6;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 112);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(61, 112);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(121, 20);
            this.txtDate.TabIndex = 4;
            // 
            // cmbVehicleModel
            // 
            this.cmbVehicleModel.FormattingEnabled = true;
            this.cmbVehicleModel.Location = new System.Drawing.Point(61, 66);
            this.cmbVehicleModel.Name = "cmbVehicleModel";
            this.cmbVehicleModel.Size = new System.Drawing.Size(121, 21);
            this.cmbVehicleModel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Model";
            // 
            // txtPatent
            // 
            this.txtPatent.Location = new System.Drawing.Point(61, 27);
            this.txtPatent.Name = "txtPatent";
            this.txtPatent.Size = new System.Drawing.Size(117, 20);
            this.txtPatent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Patent";
            // 
            // tableInfractions
            // 
            this.tableInfractions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableInfractions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableInfractions.Location = new System.Drawing.Point(0, 0);
            this.tableInfractions.Name = "tableInfractions";
            this.tableInfractions.ReadOnly = true;
            this.tableInfractions.Size = new System.Drawing.Size(554, 554);
            this.tableInfractions.TabIndex = 0;
            this.tableInfractions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableInfractions_CellClick);
            // 
            // tabModels
            // 
            this.tabModels.Controls.Add(this.splitContainer3);
            this.tabModels.Location = new System.Drawing.Point(4, 22);
            this.tabModels.Name = "tabModels";
            this.tabModels.Padding = new System.Windows.Forms.Padding(3);
            this.tabModels.Size = new System.Drawing.Size(784, 560);
            this.tabModels.TabIndex = 2;
            this.tabModels.Text = "Models";
            this.tabModels.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tableVehicleModels);
            this.splitContainer3.Size = new System.Drawing.Size(778, 554);
            this.splitContainer3.SplitterDistance = 215;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblVehicleModelSearchResults);
            this.groupBox2.Controls.Add(this.btnSearchModel);
            this.groupBox2.Controls.Add(this.txtSearchVehicleModel);
            this.groupBox2.Controls.Add(this.btnLoadVehicleModelFullList);
            this.groupBox2.Controls.Add(this.btnRemoveVehicleModel);
            this.groupBox2.Controls.Add(this.btnUpdateVehicleModel);
            this.groupBox2.Controls.Add(this.btnInsertModel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbModelBrand);
            this.groupBox2.Controls.Add(this.txtModelName);
            this.groupBox2.Controls.Add(this.lblModelName);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 554);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Model form";
            // 
            // lblVehicleModelSearchResults
            // 
            this.lblVehicleModelSearchResults.AutoSize = true;
            this.lblVehicleModelSearchResults.Location = new System.Drawing.Point(18, 280);
            this.lblVehicleModelSearchResults.Name = "lblVehicleModelSearchResults";
            this.lblVehicleModelSearchResults.Size = new System.Drawing.Size(16, 13);
            this.lblVehicleModelSearchResults.TabIndex = 10;
            this.lblVehicleModelSearchResults.Text = "...";
            // 
            // btnSearchModel
            // 
            this.btnSearchModel.Location = new System.Drawing.Point(21, 237);
            this.btnSearchModel.Name = "btnSearchModel";
            this.btnSearchModel.Size = new System.Drawing.Size(170, 23);
            this.btnSearchModel.TabIndex = 9;
            this.btnSearchModel.Text = "Search";
            this.btnSearchModel.UseVisualStyleBackColor = true;
            this.btnSearchModel.Click += new System.EventHandler(this.btnSearchModel_Click);
            // 
            // txtSearchVehicleModel
            // 
            this.txtSearchVehicleModel.Location = new System.Drawing.Point(21, 196);
            this.txtSearchVehicleModel.Name = "txtSearchVehicleModel";
            this.txtSearchVehicleModel.Size = new System.Drawing.Size(170, 20);
            this.txtSearchVehicleModel.TabIndex = 8;
            // 
            // btnLoadVehicleModelFullList
            // 
            this.btnLoadVehicleModelFullList.Location = new System.Drawing.Point(112, 149);
            this.btnLoadVehicleModelFullList.Name = "btnLoadVehicleModelFullList";
            this.btnLoadVehicleModelFullList.Size = new System.Drawing.Size(79, 23);
            this.btnLoadVehicleModelFullList.TabIndex = 7;
            this.btnLoadVehicleModelFullList.Text = "Load full list";
            this.btnLoadVehicleModelFullList.UseVisualStyleBackColor = true;
            this.btnLoadVehicleModelFullList.Click += new System.EventHandler(this.btnLoadVehicleModelFullList_Click);
            // 
            // btnRemoveVehicleModel
            // 
            this.btnRemoveVehicleModel.Location = new System.Drawing.Point(21, 149);
            this.btnRemoveVehicleModel.Name = "btnRemoveVehicleModel";
            this.btnRemoveVehicleModel.Size = new System.Drawing.Size(77, 23);
            this.btnRemoveVehicleModel.TabIndex = 6;
            this.btnRemoveVehicleModel.Text = "Delete";
            this.btnRemoveVehicleModel.UseVisualStyleBackColor = true;
            this.btnRemoveVehicleModel.Click += new System.EventHandler(this.btnRemoveVehicleModel_Click);
            // 
            // btnUpdateVehicleModel
            // 
            this.btnUpdateVehicleModel.Location = new System.Drawing.Point(112, 110);
            this.btnUpdateVehicleModel.Name = "btnUpdateVehicleModel";
            this.btnUpdateVehicleModel.Size = new System.Drawing.Size(79, 23);
            this.btnUpdateVehicleModel.TabIndex = 5;
            this.btnUpdateVehicleModel.Text = "Update";
            this.btnUpdateVehicleModel.UseVisualStyleBackColor = true;
            this.btnUpdateVehicleModel.Click += new System.EventHandler(this.btnUpdateVehicleModel_Click);
            // 
            // btnInsertModel
            // 
            this.btnInsertModel.Location = new System.Drawing.Point(21, 110);
            this.btnInsertModel.Name = "btnInsertModel";
            this.btnInsertModel.Size = new System.Drawing.Size(77, 23);
            this.btnInsertModel.TabIndex = 4;
            this.btnInsertModel.Text = "Insert";
            this.btnInsertModel.UseVisualStyleBackColor = true;
            this.btnInsertModel.Click += new System.EventHandler(this.btnInsertModel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Brand";
            // 
            // cmbModelBrand
            // 
            this.cmbModelBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelBrand.FormattingEnabled = true;
            this.cmbModelBrand.Location = new System.Drawing.Point(70, 69);
            this.cmbModelBrand.Name = "cmbModelBrand";
            this.cmbModelBrand.Size = new System.Drawing.Size(121, 21);
            this.cmbModelBrand.TabIndex = 2;
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(72, 34);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(119, 20);
            this.txtModelName.TabIndex = 1;
            // 
            // lblModelName
            // 
            this.lblModelName.AutoSize = true;
            this.lblModelName.Location = new System.Drawing.Point(18, 34);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(35, 13);
            this.lblModelName.TabIndex = 0;
            this.lblModelName.Text = "Name";
            // 
            // tableVehicleModels
            // 
            this.tableVehicleModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableVehicleModels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableVehicleModels.Location = new System.Drawing.Point(0, 0);
            this.tableVehicleModels.Name = "tableVehicleModels";
            this.tableVehicleModels.ReadOnly = true;
            this.tableVehicleModels.Size = new System.Drawing.Size(559, 554);
            this.tableVehicleModels.TabIndex = 0;
            this.tableVehicleModels.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableVehicleModels_CellClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 560);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Brands";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableBrands);
            this.splitContainer2.Size = new System.Drawing.Size(778, 554);
            this.splitContainer2.SplitterDistance = 186;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.lblSearchResults);
            this.groupBox1.Controls.Add(this.btnReloadAllBrands);
            this.groupBox1.Controls.Add(this.txtSearchBrand);
            this.groupBox1.Controls.Add(this.btnSearchBrand);
            this.groupBox1.Controls.Add(this.btnRemoveBrand);
            this.groupBox1.Controls.Add(this.btnUpdateBrand);
            this.groupBox1.Controls.Add(this.txtBrandName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInsertBrand);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 554);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brand form";
            // 
            // lblSearchResults
            // 
            this.lblSearchResults.AutoSize = true;
            this.lblSearchResults.Location = new System.Drawing.Point(7, 231);
            this.lblSearchResults.Name = "lblSearchResults";
            this.lblSearchResults.Size = new System.Drawing.Size(16, 13);
            this.lblSearchResults.TabIndex = 8;
            this.lblSearchResults.Text = "...";
            // 
            // btnReloadAllBrands
            // 
            this.btnReloadAllBrands.Location = new System.Drawing.Point(87, 108);
            this.btnReloadAllBrands.Name = "btnReloadAllBrands";
            this.btnReloadAllBrands.Size = new System.Drawing.Size(78, 23);
            this.btnReloadAllBrands.TabIndex = 7;
            this.btnReloadAllBrands.Text = "Reload all";
            this.btnReloadAllBrands.UseVisualStyleBackColor = true;
            this.btnReloadAllBrands.Click += new System.EventHandler(this.btnReloadAllBrands_Click);
            // 
            // txtSearchBrand
            // 
            this.txtSearchBrand.Location = new System.Drawing.Point(10, 148);
            this.txtSearchBrand.Name = "txtSearchBrand";
            this.txtSearchBrand.Size = new System.Drawing.Size(155, 20);
            this.txtSearchBrand.TabIndex = 6;
            // 
            // btnSearchBrand
            // 
            this.btnSearchBrand.Location = new System.Drawing.Point(9, 186);
            this.btnSearchBrand.Name = "btnSearchBrand";
            this.btnSearchBrand.Size = new System.Drawing.Size(155, 23);
            this.btnSearchBrand.TabIndex = 5;
            this.btnSearchBrand.Text = "Search";
            this.btnSearchBrand.UseVisualStyleBackColor = true;
            this.btnSearchBrand.Click += new System.EventHandler(this.btnSearchBrand_Click);
            // 
            // btnRemoveBrand
            // 
            this.btnRemoveBrand.Location = new System.Drawing.Point(9, 108);
            this.btnRemoveBrand.Name = "btnRemoveBrand";
            this.btnRemoveBrand.Size = new System.Drawing.Size(71, 23);
            this.btnRemoveBrand.TabIndex = 4;
            this.btnRemoveBrand.Text = "Remove";
            this.btnRemoveBrand.UseVisualStyleBackColor = true;
            this.btnRemoveBrand.Click += new System.EventHandler(this.btnRemoveBrand_Click);
            // 
            // btnUpdateBrand
            // 
            this.btnUpdateBrand.Location = new System.Drawing.Point(86, 64);
            this.btnUpdateBrand.Name = "btnUpdateBrand";
            this.btnUpdateBrand.Size = new System.Drawing.Size(79, 23);
            this.btnUpdateBrand.TabIndex = 3;
            this.btnUpdateBrand.Text = "Update";
            this.btnUpdateBrand.UseVisualStyleBackColor = true;
            this.btnUpdateBrand.Click += new System.EventHandler(this.btnUpdateBrand_Click);
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(64, 27);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(100, 20);
            this.txtBrandName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // btnInsertBrand
            // 
            this.btnInsertBrand.Location = new System.Drawing.Point(9, 64);
            this.btnInsertBrand.Name = "btnInsertBrand";
            this.btnInsertBrand.Size = new System.Drawing.Size(71, 23);
            this.btnInsertBrand.TabIndex = 0;
            this.btnInsertBrand.Text = "Insert";
            this.btnInsertBrand.UseVisualStyleBackColor = true;
            this.btnInsertBrand.Click += new System.EventHandler(this.btnInsertBrand_Click);
            // 
            // tableBrands
            // 
            this.tableBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableBrands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBrands.Location = new System.Drawing.Point(0, 0);
            this.tableBrands.Name = "tableBrands";
            this.tableBrands.Size = new System.Drawing.Size(588, 554);
            this.tableBrands.TabIndex = 0;
            this.tableBrands.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableBrands_CellClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 586);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfractionManager";
            this.tabControl.ResumeLayout(false);
            this.tabInfractions.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinnerFine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableInfractions)).EndInit();
            this.tabModels.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableVehicleModels)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBrands)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInfractions;
        private System.Windows.Forms.TabPage tabModels;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView tableBrands;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReloadAllBrands;
        private System.Windows.Forms.TextBox txtSearchBrand;
        private System.Windows.Forms.Button btnSearchBrand;
        private System.Windows.Forms.Button btnRemoveBrand;
        private System.Windows.Forms.Button btnUpdateBrand;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertBrand;
        private System.Windows.Forms.Label lblSearchResults;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoadVehicleModelFullList;
        private System.Windows.Forms.Button btnRemoveVehicleModel;
        private System.Windows.Forms.Button btnUpdateVehicleModel;
        private System.Windows.Forms.Button btnInsertModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbModelBrand;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.DataGridView tableVehicleModels;
        private System.Windows.Forms.Label lblVehicleModelSearchResults;
        private System.Windows.Forms.Button btnSearchModel;
        private System.Windows.Forms.TextBox txtSearchVehicleModel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView tableInfractions;
        private System.Windows.Forms.TextBox txtPatent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInfractionSearch;
        private System.Windows.Forms.Button btnLoadFullList;
        private System.Windows.Forms.Button btnRemoveInfraction;
        private System.Windows.Forms.Button btnUpdateInfraction;
        private System.Windows.Forms.Button btnInsertInfraction;
        private System.Windows.Forms.TextBox txtSearchInfraction;
        private System.Windows.Forms.NumericUpDown spinnerFine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInfractionDetails;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.ComboBox cmbVehicleModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInfraxtionSearchResults;


    }
}

