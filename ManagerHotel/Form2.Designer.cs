namespace ManagerHotel
{
    partial class Form_addTenant
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
            this.components = new System.ComponentModel.Container();
            this.wizardControl1 = new AeroWizard.WizardControl();
            this.wizardPage1 = new AeroWizard.WizardPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelW1_imgHouseholdRegPath = new System.Windows.Forms.Label();
            this.labelW1_ImgIdCardPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxW1_idCard = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBoxW1_houseHoldReg = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.comboBoxW1_roomId = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxW1_phone = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBoxW1_address = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBoxW1_firstName = new System.Windows.Forms.TextBox();
            this.textBoxW1_personId = new System.Windows.Forms.TextBox();
            this.textBoxW1_lastName = new System.Windows.Forms.TextBox();
            this.wizardPage2 = new AeroWizard.WizardPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelW2_contractImagePath = new System.Windows.Forms.Label();
            this.pictureBoxW2_pictureContract = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerW2_timeEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerW2_timeStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxW2_paymentOneMonth = new System.Windows.Forms.TextBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagerDataSet = new ManagerHotel.HotelManagerDataSet();
            this.roomsTableAdapter = new ManagerHotel.HotelManagerDataSetTableAdapters.RoomsTableAdapter();
            this.checkBoxW2_skipContract = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxW1_idCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxW1_houseHoldReg)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.wizardPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxW2_pictureContract)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.BackColor = System.Drawing.Color.White;
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.Add(this.wizardPage1);
            this.wizardControl1.Pages.Add(this.wizardPage2);
            this.wizardControl1.Size = new System.Drawing.Size(806, 538);
            this.wizardControl1.TabIndex = 0;
            this.wizardControl1.Text = "Add Tenant";
            this.wizardControl1.Finished += new System.EventHandler(this.wizardControl1_Finished);
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.groupBox4);
            this.wizardPage1.Controls.Add(this.groupBox11);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(759, 384);
            this.wizardPage1.TabIndex = 0;
            this.wizardPage1.Text = "Tenant Infomation";
            this.wizardPage1.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.wizardPage1_Commit);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelW1_imgHouseholdRegPath);
            this.groupBox4.Controls.Add(this.labelW1_ImgIdCardPath);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.pictureBoxW1_idCard);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.pictureBoxW1_houseHoldReg);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(436, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(311, 365);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            // 
            // labelW1_imgHouseholdRegPath
            // 
            this.labelW1_imgHouseholdRegPath.AutoSize = true;
            this.labelW1_imgHouseholdRegPath.Location = new System.Drawing.Point(220, 347);
            this.labelW1_imgHouseholdRegPath.Name = "labelW1_imgHouseholdRegPath";
            this.labelW1_imgHouseholdRegPath.Size = new System.Drawing.Size(20, 15);
            this.labelW1_imgHouseholdRegPath.TabIndex = 27;
            this.labelW1_imgHouseholdRegPath.Text = "na";
            // 
            // labelW1_ImgIdCardPath
            // 
            this.labelW1_ImgIdCardPath.AutoSize = true;
            this.labelW1_ImgIdCardPath.Location = new System.Drawing.Point(206, 164);
            this.labelW1_ImgIdCardPath.Name = "labelW1_ImgIdCardPath";
            this.labelW1_ImgIdCardPath.Size = new System.Drawing.Size(20, 15);
            this.labelW1_ImgIdCardPath.TabIndex = 26;
            this.labelW1_ImgIdCardPath.Text = "na";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Household Register";
            // 
            // pictureBoxW1_idCard
            // 
            this.pictureBoxW1_idCard.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxW1_idCard.Location = new System.Drawing.Point(20, 14);
            this.pictureBoxW1_idCard.Name = "pictureBoxW1_idCard";
            this.pictureBoxW1_idCard.Size = new System.Drawing.Size(270, 147);
            this.pictureBoxW1_idCard.TabIndex = 15;
            this.pictureBoxW1_idCard.TabStop = false;
            this.pictureBoxW1_idCard.Click += new System.EventHandler(this.pictureBoxW1_idCard_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Household Register";
            // 
            // pictureBoxW1_houseHoldReg
            // 
            this.pictureBoxW1_houseHoldReg.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxW1_houseHoldReg.Location = new System.Drawing.Point(20, 193);
            this.pictureBoxW1_houseHoldReg.Name = "pictureBoxW1_houseHoldReg";
            this.pictureBoxW1_houseHoldReg.Size = new System.Drawing.Size(270, 151);
            this.pictureBoxW1_houseHoldReg.TabIndex = 16;
            this.pictureBoxW1_houseHoldReg.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "ID Card";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.comboBoxW1_roomId);
            this.groupBox11.Controls.Add(this.label26);
            this.groupBox11.Controls.Add(this.label27);
            this.groupBox11.Controls.Add(this.label28);
            this.groupBox11.Controls.Add(this.label29);
            this.groupBox11.Controls.Add(this.textBoxW1_phone);
            this.groupBox11.Controls.Add(this.label30);
            this.groupBox11.Controls.Add(this.textBoxW1_address);
            this.groupBox11.Controls.Add(this.label31);
            this.groupBox11.Controls.Add(this.textBoxW1_firstName);
            this.groupBox11.Controls.Add(this.textBoxW1_personId);
            this.groupBox11.Controls.Add(this.textBoxW1_lastName);
            this.groupBox11.Location = new System.Drawing.Point(13, 17);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(274, 351);
            this.groupBox11.TabIndex = 24;
            this.groupBox11.TabStop = false;
            // 
            // comboBoxW1_roomId
            // 
            this.comboBoxW1_roomId.DataSource = this.roomBindingSource;
            this.comboBoxW1_roomId.DisplayMember = "RoomID";
            this.comboBoxW1_roomId.FormattingEnabled = true;
            this.comboBoxW1_roomId.Location = new System.Drawing.Point(94, 204);
            this.comboBoxW1_roomId.Name = "comboBoxW1_roomId";
            this.comboBoxW1_roomId.Size = new System.Drawing.Size(153, 23);
            this.comboBoxW1_roomId.TabIndex = 31;
            this.comboBoxW1_roomId.ValueMember = "RoomID";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(ManagerHotel.Room);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 19);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 15);
            this.label26.TabIndex = 1;
            this.label26.Text = "Personal ID";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 54);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(61, 15);
            this.label27.TabIndex = 2;
            this.label27.Text = "Last name";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 92);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(62, 15);
            this.label28.TabIndex = 3;
            this.label28.Text = "First name";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 132);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(49, 15);
            this.label29.TabIndex = 4;
            this.label29.Text = "Address";
            // 
            // textBoxW1_phone
            // 
            this.textBoxW1_phone.Location = new System.Drawing.Point(94, 167);
            this.textBoxW1_phone.Name = "textBoxW1_phone";
            this.textBoxW1_phone.Size = new System.Drawing.Size(153, 23);
            this.textBoxW1_phone.TabIndex = 12;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 170);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(41, 15);
            this.label30.TabIndex = 5;
            this.label30.Text = "Phone";
            // 
            // textBoxW1_address
            // 
            this.textBoxW1_address.Location = new System.Drawing.Point(94, 129);
            this.textBoxW1_address.Name = "textBoxW1_address";
            this.textBoxW1_address.Size = new System.Drawing.Size(153, 23);
            this.textBoxW1_address.TabIndex = 11;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(6, 212);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(39, 15);
            this.label31.TabIndex = 6;
            this.label31.Text = "Room";
            // 
            // textBoxW1_firstName
            // 
            this.textBoxW1_firstName.Location = new System.Drawing.Point(94, 89);
            this.textBoxW1_firstName.Name = "textBoxW1_firstName";
            this.textBoxW1_firstName.Size = new System.Drawing.Size(153, 23);
            this.textBoxW1_firstName.TabIndex = 10;
            // 
            // textBoxW1_personId
            // 
            this.textBoxW1_personId.Location = new System.Drawing.Point(94, 16);
            this.textBoxW1_personId.Name = "textBoxW1_personId";
            this.textBoxW1_personId.Size = new System.Drawing.Size(153, 23);
            this.textBoxW1_personId.TabIndex = 8;
            // 
            // textBoxW1_lastName
            // 
            this.textBoxW1_lastName.Location = new System.Drawing.Point(94, 51);
            this.textBoxW1_lastName.Name = "textBoxW1_lastName";
            this.textBoxW1_lastName.Size = new System.Drawing.Size(153, 23);
            this.textBoxW1_lastName.TabIndex = 9;
            // 
            // wizardPage2
            // 
            this.wizardPage2.Controls.Add(this.groupBox2);
            this.wizardPage2.Controls.Add(this.groupBox1);
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(759, 384);
            this.wizardPage2.TabIndex = 1;
            this.wizardPage2.Text = "Contract Infomation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelW2_contractImagePath);
            this.groupBox2.Controls.Add(this.pictureBoxW2_pictureContract);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(445, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 365);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // labelW2_contractImagePath
            // 
            this.labelW2_contractImagePath.AutoSize = true;
            this.labelW2_contractImagePath.Location = new System.Drawing.Point(258, 242);
            this.labelW2_contractImagePath.Name = "labelW2_contractImagePath";
            this.labelW2_contractImagePath.Size = new System.Drawing.Size(20, 15);
            this.labelW2_contractImagePath.TabIndex = 25;
            this.labelW2_contractImagePath.Text = "na";
            // 
            // pictureBoxW2_pictureContract
            // 
            this.pictureBoxW2_pictureContract.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxW2_pictureContract.Location = new System.Drawing.Point(6, 14);
            this.pictureBoxW2_pictureContract.Name = "pictureBoxW2_pictureContract";
            this.pictureBoxW2_pictureContract.Size = new System.Drawing.Size(299, 204);
            this.pictureBoxW2_pictureContract.TabIndex = 15;
            this.pictureBoxW2_pictureContract.TabStop = false;
            this.pictureBoxW2_pictureContract.Click += new System.EventHandler(this.pictureBoxW2_pictureContract_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Household Register";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(132, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Picture Of Contract";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxW2_skipContract);
            this.groupBox1.Controls.Add(this.dateTimePickerW2_timeEnd);
            this.groupBox1.Controls.Add(this.dateTimePickerW2_timeStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxW2_paymentOneMonth);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 351);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePickerW2_timeEnd
            // 
            this.dateTimePickerW2_timeEnd.Location = new System.Drawing.Point(107, 109);
            this.dateTimePickerW2_timeEnd.Name = "dateTimePickerW2_timeEnd";
            this.dateTimePickerW2_timeEnd.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerW2_timeEnd.TabIndex = 12;
            // 
            // dateTimePickerW2_timeStart
            // 
            this.dateTimePickerW2_timeStart.Location = new System.Drawing.Point(107, 60);
            this.dateTimePickerW2_timeStart.Name = "dateTimePickerW2_timeStart";
            this.dateTimePickerW2_timeStart.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerW2_timeStart.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time Start";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time End";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Payment/Month";
            // 
            // textBoxW2_paymentOneMonth
            // 
            this.textBoxW2_paymentOneMonth.Location = new System.Drawing.Point(107, 159);
            this.textBoxW2_paymentOneMonth.Name = "textBoxW2_paymentOneMonth";
            this.textBoxW2_paymentOneMonth.Size = new System.Drawing.Size(200, 23);
            this.textBoxW2_paymentOneMonth.TabIndex = 10;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.hotelManagerDataSet;
            // 
            // hotelManagerDataSet
            // 
            this.hotelManagerDataSet.DataSetName = "HotelManagerDataSet";
            this.hotelManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // checkBoxW2_skipContract
            // 
            this.checkBoxW2_skipContract.AutoSize = true;
            this.checkBoxW2_skipContract.Location = new System.Drawing.Point(9, 22);
            this.checkBoxW2_skipContract.Name = "checkBoxW2_skipContract";
            this.checkBoxW2_skipContract.Size = new System.Drawing.Size(238, 19);
            this.checkBoxW2_skipContract.TabIndex = 13;
            this.checkBoxW2_skipContract.Text = "Skip(This person doesn \'t need contract)";
            this.checkBoxW2_skipContract.UseVisualStyleBackColor = true;
            this.checkBoxW2_skipContract.CheckedChanged += new System.EventHandler(this.checkBoxW2_skipContract_CheckedChanged);
            // 
            // Form_addTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 538);
            this.Controls.Add(this.wizardControl1);
            this.Name = "Form_addTenant";
            this.Text = "Add New Tenant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_addTenant_FormClosed);
            this.Load += new System.EventHandler(this.Form_addTenant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxW1_idCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxW1_houseHoldReg)).EndInit();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.wizardPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxW2_pictureContract)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagerDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl wizardControl1;
        private AeroWizard.WizardPage wizardPage1;
        private AeroWizard.WizardPage wizardPage2;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBoxW1_phone;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBoxW1_address;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBoxW1_firstName;
        private System.Windows.Forms.TextBox textBoxW1_personId;
        private System.Windows.Forms.TextBox textBoxW1_lastName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxW1_idCard;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBoxW1_houseHoldReg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxW1_roomId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerW2_timeEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerW2_timeStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxW2_paymentOneMonth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxW2_pictureContract;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelW1_imgHouseholdRegPath;
        private System.Windows.Forms.Label labelW1_ImgIdCardPath;
        private HotelManagerDataSet hotelManagerDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private HotelManagerDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.Label labelW2_contractImagePath;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.CheckBox checkBoxW2_skipContract;
    }
}