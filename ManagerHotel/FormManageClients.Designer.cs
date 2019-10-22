namespace ManagerHotel
{
    partial class FormManageClients
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
            this.button_addClient = new System.Windows.Forms.Button();
            this.button_deleteClient = new System.Windows.Forms.Button();
            this.button_updateClient = new System.Windows.Forms.Button();
            this.button_searchClients = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView_viewClients = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.pictureBox_idCard = new System.Windows.Forms.PictureBox();
            this.pictureBox_household = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_viewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_idCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_household)).BeginInit();
            this.SuspendLayout();
            // 
            // button_addClient
            // 
            this.button_addClient.Location = new System.Drawing.Point(20, 432);
            this.button_addClient.Name = "button_addClient";
            this.button_addClient.Size = new System.Drawing.Size(75, 33);
            this.button_addClient.TabIndex = 0;
            this.button_addClient.Text = "Add";
            this.button_addClient.UseVisualStyleBackColor = true;
            // 
            // button_deleteClient
            // 
            this.button_deleteClient.Location = new System.Drawing.Point(152, 432);
            this.button_deleteClient.Name = "button_deleteClient";
            this.button_deleteClient.Size = new System.Drawing.Size(75, 33);
            this.button_deleteClient.TabIndex = 1;
            this.button_deleteClient.Text = "Delete";
            this.button_deleteClient.UseVisualStyleBackColor = true;
            // 
            // button_updateClient
            // 
            this.button_updateClient.Location = new System.Drawing.Point(20, 487);
            this.button_updateClient.Name = "button_updateClient";
            this.button_updateClient.Size = new System.Drawing.Size(75, 37);
            this.button_updateClient.TabIndex = 2;
            this.button_updateClient.Text = "Update Information";
            this.button_updateClient.UseVisualStyleBackColor = true;
            // 
            // button_searchClients
            // 
            this.button_searchClients.Location = new System.Drawing.Point(152, 487);
            this.button_searchClients.Name = "button_searchClients";
            this.button_searchClients.Size = new System.Drawing.Size(75, 37);
            this.button_searchClients.TabIndex = 3;
            this.button_searchClients.Text = "Search";
            this.button_searchClients.UseVisualStyleBackColor = true;
            this.button_searchClients.Click += new System.EventHandler(this.button_searchClients_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Person ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Room Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Contract Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Picture ID card";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(466, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = " Picture Household Register";
            // 
            // dataGridView_viewClients
            // 
            this.dataGridView_viewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_viewClients.Location = new System.Drawing.Point(707, 4);
            this.dataGridView_viewClients.Name = "dataGridView_viewClients";
            this.dataGridView_viewClients.Size = new System.Drawing.Size(559, 520);
            this.dataGridView_viewClients.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(322, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(563, 17);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(119, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(105, 59);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 20);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(319, 58);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(144, 20);
            this.textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(563, 58);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(119, 20);
            this.textBox6.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(105, 111);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(211, 20);
            this.textBox7.TabIndex = 20;
            // 
            // pictureBox_idCard
            // 
            this.pictureBox_idCard.Location = new System.Drawing.Point(12, 204);
            this.pictureBox_idCard.Name = "pictureBox_idCard";
            this.pictureBox_idCard.Size = new System.Drawing.Size(315, 211);
            this.pictureBox_idCard.TabIndex = 21;
            this.pictureBox_idCard.TabStop = false;
            // 
            // pictureBox_household
            // 
            this.pictureBox_household.Location = new System.Drawing.Point(375, 204);
            this.pictureBox_household.Name = "pictureBox_household";
            this.pictureBox_household.Size = new System.Drawing.Size(307, 211);
            this.pictureBox_household.TabIndex = 22;
            this.pictureBox_household.TabStop = false;
            // 
            // FormManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 536);
            this.Controls.Add(this.pictureBox_household);
            this.Controls.Add(this.pictureBox_idCard);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView_viewClients);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_searchClients);
            this.Controls.Add(this.button_updateClient);
            this.Controls.Add(this.button_deleteClient);
            this.Controls.Add(this.button_addClient);
            this.Name = "FormManageClients";
            this.Text = "FormManageClients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_viewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_idCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_household)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addClient;
        private System.Windows.Forms.Button button_deleteClient;
        private System.Windows.Forms.Button button_updateClient;
        private System.Windows.Forms.Button button_searchClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView_viewClients;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.PictureBox pictureBox_idCard;
        private System.Windows.Forms.PictureBox pictureBox_household;
    }
}