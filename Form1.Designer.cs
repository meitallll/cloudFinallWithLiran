namespace cloudFinal
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.richTextBox_Logger = new System.Windows.Forms.RichTextBox();
            this.button_refreshLoggerData = new System.Windows.Forms.Button();
            this.buttonResetLoggerData = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_envType = new System.Windows.Forms.TextBox();
            this.textBox_Uri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_primaryKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Ex38 = new System.Windows.Forms.DataGridView();
            this.btn_ShowAllObjects = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_CrateDataInCloud = new System.Windows.Forms.Button();
            this.textBox_DatabaseNameToCreate = new System.Windows.Forms.TextBox();
            this.textBox_containerNameToCreate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.radioButton_delete = new System.Windows.Forms.RadioButton();
            this.radioButton_replace = new System.Windows.Forms.RadioButton();
            this.radioButton_insert = new System.Windows.Forms.RadioButton();
            this.buttonPerformActivityInCloud = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.loadJsonFileBtn = new System.Windows.Forms.Button();
            this.jsonRichTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Search = new System.Windows.Forms.DataGridView();
            this.btn_presentHotels = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_EmployeeName = new System.Windows.Forms.TextBox();
            this.textBox_HotelName = new System.Windows.Forms.TextBox();
            this.textBox_NumOfStars = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_RoomType = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ex38)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(4, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1131, 719);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            this.tabControl2.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1123, 690);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tab1";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTextBox_Logger);
            this.groupBox5.Controls.Add(this.button_refreshLoggerData);
            this.groupBox5.Controls.Add(this.buttonResetLoggerData);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox5.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox5.Location = new System.Drawing.Point(7, 396);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(1109, 289);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Log data";
            // 
            // richTextBox_Logger
            // 
            this.richTextBox_Logger.Location = new System.Drawing.Point(24, 36);
            this.richTextBox_Logger.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox_Logger.Name = "richTextBox_Logger";
            this.richTextBox_Logger.Size = new System.Drawing.Size(1066, 201);
            this.richTextBox_Logger.TabIndex = 11;
            this.richTextBox_Logger.Text = "";
            // 
            // button_refreshLoggerData
            // 
            this.button_refreshLoggerData.Location = new System.Drawing.Point(24, 243);
            this.button_refreshLoggerData.Margin = new System.Windows.Forms.Padding(4);
            this.button_refreshLoggerData.Name = "button_refreshLoggerData";
            this.button_refreshLoggerData.Size = new System.Drawing.Size(308, 42);
            this.button_refreshLoggerData.TabIndex = 10;
            this.button_refreshLoggerData.Text = "refresh data";
            this.button_refreshLoggerData.UseVisualStyleBackColor = true;
            this.button_refreshLoggerData.Click += new System.EventHandler(this.button_refreshLoggerData_Click);
            // 
            // buttonResetLoggerData
            // 
            this.buttonResetLoggerData.Location = new System.Drawing.Point(781, 243);
            this.buttonResetLoggerData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonResetLoggerData.Name = "buttonResetLoggerData";
            this.buttonResetLoggerData.Size = new System.Drawing.Size(308, 42);
            this.buttonResetLoggerData.TabIndex = 2;
            this.buttonResetLoggerData.Text = "reset data";
            this.buttonResetLoggerData.UseVisualStyleBackColor = true;
            this.buttonResetLoggerData.Click += new System.EventHandler(this.buttonResetLoggerData_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_envType);
            this.groupBox3.Controls.Add(this.textBox_Uri);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox_primaryKey);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(7, 198);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(701, 190);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "env Data";
            // 
            // textBox_envType
            // 
            this.textBox_envType.Location = new System.Drawing.Point(264, 42);
            this.textBox_envType.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_envType.Name = "textBox_envType";
            this.textBox_envType.ReadOnly = true;
            this.textBox_envType.Size = new System.Drawing.Size(426, 34);
            this.textBox_envType.TabIndex = 1;
            // 
            // textBox_Uri
            // 
            this.textBox_Uri.Location = new System.Drawing.Point(264, 98);
            this.textBox_Uri.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Uri.Name = "textBox_Uri";
            this.textBox_Uri.ReadOnly = true;
            this.textBox_Uri.Size = new System.Drawing.Size(426, 34);
            this.textBox_Uri.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(135, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Env Type";
            // 
            // textBox_primaryKey
            // 
            this.textBox_primaryKey.Location = new System.Drawing.Point(264, 143);
            this.textBox_primaryKey.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_primaryKey.Name = "textBox_primaryKey";
            this.textBox_primaryKey.ReadOnly = true;
            this.textBox_primaryKey.Size = new System.Drawing.Size(426, 34);
            this.textBox_primaryKey.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(196, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "uri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(113, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Primary key";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_mail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(7, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(701, 177);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Developer Details";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(264, 41);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(426, 34);
            this.textBoxId.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(264, 81);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(426, 34);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(179, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(264, 122);
            this.textBox_mail.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.ReadOnly = true;
            this.textBox_mail.Size = new System.Drawing.Size(426, 34);
            this.textBox_mail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Developer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(141, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1123, 690);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Tab2";
            this.tabPage2.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_Ex38);
            this.groupBox4.Controls.Add(this.btn_ShowAllObjects);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox4.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox4.Location = new System.Drawing.Point(28, 218);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1016, 452);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tables With All Objects";
            // 
            // dataGridView_Ex38
            // 
            this.dataGridView_Ex38.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ex38.Location = new System.Drawing.Point(35, 120);
            this.dataGridView_Ex38.Name = "dataGridView_Ex38";
            this.dataGridView_Ex38.ReadOnly = true;
            this.dataGridView_Ex38.RowHeadersWidth = 51;
            this.dataGridView_Ex38.RowTemplate.Height = 24;
            this.dataGridView_Ex38.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Ex38.Size = new System.Drawing.Size(946, 305);
            this.dataGridView_Ex38.TabIndex = 7;
            this.dataGridView_Ex38.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Ex38_CellDoubleClick);
            // 
            // btn_ShowAllObjects
            // 
            this.btn_ShowAllObjects.Location = new System.Drawing.Point(0, 51);
            this.btn_ShowAllObjects.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ShowAllObjects.Name = "btn_ShowAllObjects";
            this.btn_ShowAllObjects.Size = new System.Drawing.Size(966, 42);
            this.btn_ShowAllObjects.TabIndex = 2;
            this.btn_ShowAllObjects.Text = "show all objects from Tables in cloud";
            this.btn_ShowAllObjects.UseVisualStyleBackColor = true;
            this.btn_ShowAllObjects.Click += new System.EventHandler(this.btn_ShowAllObjects_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_CrateDataInCloud);
            this.groupBox2.Controls.Add(this.textBox_DatabaseNameToCreate);
            this.groupBox2.Controls.Add(this.textBox_containerNameToCreate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(28, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1016, 185);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create DBs And Containers";
            // 
            // button_CrateDataInCloud
            // 
            this.button_CrateDataInCloud.Location = new System.Drawing.Point(323, 112);
            this.button_CrateDataInCloud.Margin = new System.Windows.Forms.Padding(4);
            this.button_CrateDataInCloud.Name = "button_CrateDataInCloud";
            this.button_CrateDataInCloud.Size = new System.Drawing.Size(303, 52);
            this.button_CrateDataInCloud.TabIndex = 2;
            this.button_CrateDataInCloud.Text = "create data in cloud";
            this.button_CrateDataInCloud.UseVisualStyleBackColor = true;
            this.button_CrateDataInCloud.Click += new System.EventHandler(this.button_CrateDataInCloud_Click);
            // 
            // textBox_DatabaseNameToCreate
            // 
            this.textBox_DatabaseNameToCreate.Location = new System.Drawing.Point(155, 42);
            this.textBox_DatabaseNameToCreate.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_DatabaseNameToCreate.Name = "textBox_DatabaseNameToCreate";
            this.textBox_DatabaseNameToCreate.Size = new System.Drawing.Size(215, 34);
            this.textBox_DatabaseNameToCreate.TabIndex = 1;
            // 
            // textBox_containerNameToCreate
            // 
            this.textBox_containerNameToCreate.Location = new System.Drawing.Point(676, 42);
            this.textBox_containerNameToCreate.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_containerNameToCreate.Name = "textBox_containerNameToCreate";
            this.textBox_containerNameToCreate.Size = new System.Drawing.Size(215, 34);
            this.textBox_containerNameToCreate.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(28, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "DataBase";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(532, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Container";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage3.Controls.Add(this.groupBox14);
            this.tabPage3.Controls.Add(this.groupBox13);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1123, 690);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Tab3";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.radioButton_delete);
            this.groupBox14.Controls.Add(this.radioButton_replace);
            this.groupBox14.Controls.Add(this.radioButton_insert);
            this.groupBox14.Controls.Add(this.buttonPerformActivityInCloud);
            this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox14.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox14.Location = new System.Drawing.Point(17, 321);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox14.Size = new System.Drawing.Size(1080, 126);
            this.groupBox14.TabIndex = 13;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Perform Activity";
            // 
            // radioButton_delete
            // 
            this.radioButton_delete.AutoSize = true;
            this.radioButton_delete.Location = new System.Drawing.Point(171, 45);
            this.radioButton_delete.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_delete.Name = "radioButton_delete";
            this.radioButton_delete.Size = new System.Drawing.Size(95, 29);
            this.radioButton_delete.TabIndex = 3;
            this.radioButton_delete.TabStop = true;
            this.radioButton_delete.Text = "Delete";
            this.radioButton_delete.UseVisualStyleBackColor = true;
            // 
            // radioButton_replace
            // 
            this.radioButton_replace.AutoSize = true;
            this.radioButton_replace.Location = new System.Drawing.Point(321, 45);
            this.radioButton_replace.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_replace.Name = "radioButton_replace";
            this.radioButton_replace.Size = new System.Drawing.Size(111, 29);
            this.radioButton_replace.TabIndex = 2;
            this.radioButton_replace.TabStop = true;
            this.radioButton_replace.Text = "Replace";
            this.radioButton_replace.UseVisualStyleBackColor = true;
            // 
            // radioButton_insert
            // 
            this.radioButton_insert.AutoSize = true;
            this.radioButton_insert.Location = new System.Drawing.Point(24, 45);
            this.radioButton_insert.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_insert.Name = "radioButton_insert";
            this.radioButton_insert.Size = new System.Drawing.Size(87, 29);
            this.radioButton_insert.TabIndex = 1;
            this.radioButton_insert.TabStop = true;
            this.radioButton_insert.Text = "Insert";
            this.radioButton_insert.UseVisualStyleBackColor = true;
            // 
            // buttonPerformActivityInCloud
            // 
            this.buttonPerformActivityInCloud.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPerformActivityInCloud.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonPerformActivityInCloud.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPerformActivityInCloud.ForeColor = System.Drawing.Color.Maroon;
            this.buttonPerformActivityInCloud.Location = new System.Drawing.Point(635, 31);
            this.buttonPerformActivityInCloud.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPerformActivityInCloud.Name = "buttonPerformActivityInCloud";
            this.buttonPerformActivityInCloud.Size = new System.Drawing.Size(437, 56);
            this.buttonPerformActivityInCloud.TabIndex = 0;
            this.buttonPerformActivityInCloud.Text = "Perform Activity In Cloud";
            this.buttonPerformActivityInCloud.UseVisualStyleBackColor = false;
            this.buttonPerformActivityInCloud.Click += new System.EventHandler(this.buttonPerformActivityInCloud_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.loadJsonFileBtn);
            this.groupBox13.Controls.Add(this.jsonRichTextBox);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox13.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox13.Location = new System.Drawing.Point(17, 7);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox13.Size = new System.Drawing.Size(1080, 312);
            this.groupBox13.TabIndex = 14;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Type Json Data Or Upload One";
            this.groupBox13.Leave += new System.EventHandler(this.groupBox13_Leave);
            // 
            // loadJsonFileBtn
            // 
            this.loadJsonFileBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.loadJsonFileBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.loadJsonFileBtn.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadJsonFileBtn.ForeColor = System.Drawing.Color.Maroon;
            this.loadJsonFileBtn.Location = new System.Drawing.Point(24, 269);
            this.loadJsonFileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loadJsonFileBtn.Name = "loadJsonFileBtn";
            this.loadJsonFileBtn.Size = new System.Drawing.Size(219, 37);
            this.loadJsonFileBtn.TabIndex = 8;
            this.loadJsonFileBtn.Text = "Load Json File";
            this.loadJsonFileBtn.UseVisualStyleBackColor = false;
            this.loadJsonFileBtn.Click += new System.EventHandler(this.loadJsonFileBtn_Click);
            // 
            // jsonRichTextBox
            // 
            this.jsonRichTextBox.Location = new System.Drawing.Point(24, 31);
            this.jsonRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.jsonRichTextBox.Name = "jsonRichTextBox";
            this.jsonRichTextBox.Size = new System.Drawing.Size(1027, 231);
            this.jsonRichTextBox.TabIndex = 0;
            this.jsonRichTextBox.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1123, 690);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Tab4";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView_Search);
            this.groupBox6.Controls.Add(this.btn_presentHotels);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.textBox_Id);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.textBox_Price);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.textBox_EmployeeName);
            this.groupBox6.Controls.Add(this.textBox_HotelName);
            this.groupBox6.Controls.Add(this.textBox_NumOfStars);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.textBox_RoomType);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox6.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox6.Location = new System.Drawing.Point(38, 30);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(1037, 511);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Developer Details";
            // 
            // dataGridView_Search
            // 
            this.dataGridView_Search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Search.Location = new System.Drawing.Point(472, 41);
            this.dataGridView_Search.Name = "dataGridView_Search";
            this.dataGridView_Search.ReadOnly = true;
            this.dataGridView_Search.RowHeadersWidth = 51;
            this.dataGridView_Search.RowTemplate.Height = 24;
            this.dataGridView_Search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Search.Size = new System.Drawing.Size(563, 357);
            this.dataGridView_Search.TabIndex = 17;
            this.dataGridView_Search.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Search_CellDoubleClick);
            // 
            // btn_presentHotels
            // 
            this.btn_presentHotels.Location = new System.Drawing.Point(162, 399);
            this.btn_presentHotels.Margin = new System.Windows.Forms.Padding(4);
            this.btn_presentHotels.Name = "btn_presentHotels";
            this.btn_presentHotels.Size = new System.Drawing.Size(303, 52);
            this.btn_presentHotels.TabIndex = 8;
            this.btn_presentHotels.Text = "present Hotels";
            this.btn_presentHotels.UseVisualStyleBackColor = true;
            this.btn_presentHotels.Click += new System.EventHandler(this.btn_presentHotels_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.Location = new System.Drawing.Point(142, 296);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 29);
            this.label14.TabIndex = 7;
            this.label14.Text = "ID";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(264, 296);
            this.textBox_Id.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(201, 34);
            this.textBox_Id.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(18, 244);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(176, 29);
            this.label13.TabIndex = 5;
            this.label13.Text = "Price Per Night";
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(264, 239);
            this.textBox_Price.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(201, 34);
            this.textBox_Price.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(-5, 185);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(246, 29);
            this.label12.TabIndex = 3;
            this.label12.Text = "Employee First Name";
            // 
            // textBox_EmployeeName
            // 
            this.textBox_EmployeeName.Location = new System.Drawing.Point(264, 180);
            this.textBox_EmployeeName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_EmployeeName.Name = "textBox_EmployeeName";
            this.textBox_EmployeeName.Size = new System.Drawing.Size(201, 34);
            this.textBox_EmployeeName.TabIndex = 2;
            // 
            // textBox_HotelName
            // 
            this.textBox_HotelName.Location = new System.Drawing.Point(264, 41);
            this.textBox_HotelName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_HotelName.Name = "textBox_HotelName";
            this.textBox_HotelName.Size = new System.Drawing.Size(201, 34);
            this.textBox_HotelName.TabIndex = 1;
            // 
            // textBox_NumOfStars
            // 
            this.textBox_NumOfStars.Location = new System.Drawing.Point(264, 81);
            this.textBox_NumOfStars.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_NumOfStars.Name = "textBox_NumOfStars";
            this.textBox_NumOfStars.Size = new System.Drawing.Size(201, 34);
            this.textBox_NumOfStars.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(27, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Hotel Name";
            // 
            // textBox_RoomType
            // 
            this.textBox_RoomType.Location = new System.Drawing.Point(264, 127);
            this.textBox_RoomType.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_RoomType.Name = "textBox_RoomType";
            this.textBox_RoomType.Size = new System.Drawing.Size(201, 34);
            this.textBox_RoomType.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(27, 81);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Num of Stars";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(39, 127);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = "Room Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 736);
            this.Controls.Add(this.tabControl2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ex38)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_envType;
        private System.Windows.Forms.TextBox textBox_Uri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_primaryKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_CrateDataInCloud;
        private System.Windows.Forms.TextBox textBox_DatabaseNameToCreate;
        private System.Windows.Forms.TextBox textBox_containerNameToCreate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView_Ex38;
        private System.Windows.Forms.Button btn_ShowAllObjects;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox richTextBox_Logger;
        private System.Windows.Forms.Button button_refreshLoggerData;
        private System.Windows.Forms.Button buttonResetLoggerData;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox_HotelName;
        private System.Windows.Forms.TextBox textBox_NumOfStars;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_RoomType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_EmployeeName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.DataGridView dataGridView_Search;
        private System.Windows.Forms.Button btn_presentHotels;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.RadioButton radioButton_delete;
        private System.Windows.Forms.RadioButton radioButton_replace;
        private System.Windows.Forms.RadioButton radioButton_insert;
        private System.Windows.Forms.Button buttonPerformActivityInCloud;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button loadJsonFileBtn;
        private System.Windows.Forms.RichTextBox jsonRichTextBox;
    }
}

