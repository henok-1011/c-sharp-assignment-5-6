namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.btn_Name = new System.Windows.Forms.Button();
            this.txt_IdNum = new System.Windows.Forms.TextBox();
            this.txt_InventoryNum = new System.Windows.Forms.TextBox();
            this.txt_objectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.laba = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.chk_isAvailable = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Name
            // 
            this.btn_Name.Location = new System.Drawing.Point(46, 355);
            this.btn_Name.Name = "btn_Name";
            this.btn_Name.Size = new System.Drawing.Size(130, 29);
            this.btn_Name.TabIndex = 0;
            this.btn_Name.Text = "Add";
            this.btn_Name.UseVisualStyleBackColor = true;
            this.btn_Name.Click += new System.EventHandler(this.btn_Name_Click);
            this.btn_Name.MouseHover += new System.EventHandler(this.btn_Name_MouseHover);
            // 
            // txt_IdNum
            // 
            this.txt_IdNum.Location = new System.Drawing.Point(29, 104);
            this.txt_IdNum.Name = "txt_IdNum";
            this.txt_IdNum.Size = new System.Drawing.Size(106, 20);
            this.txt_IdNum.TabIndex = 1;
            // 
            // txt_InventoryNum
            // 
            this.txt_InventoryNum.Location = new System.Drawing.Point(423, 104);
            this.txt_InventoryNum.Name = "txt_InventoryNum";
            this.txt_InventoryNum.Size = new System.Drawing.Size(160, 20);
            this.txt_InventoryNum.TabIndex = 2;
            this.txt_InventoryNum.TextChanged += new System.EventHandler(this.txt_InventoryNum_TextChanged);
            // 
            // txt_objectName
            // 
            this.txt_objectName.Location = new System.Drawing.Point(28, 181);
            this.txt_objectName.Multiline = true;
            this.txt_objectName.Name = "txt_objectName";
            this.txt_objectName.Size = new System.Drawing.Size(555, 42);
            this.txt_objectName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // laba
            // 
            this.laba.AutoSize = true;
            this.laba.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laba.Location = new System.Drawing.Point(26, 160);
            this.laba.Name = "laba";
            this.laba.Size = new System.Drawing.Size(95, 18);
            this.laba.TabIndex = 5;
            this.laba.Text = "Object Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inverntory Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(163, 104);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(211, 20);
            this.dtp_date.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Count";
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(29, 282);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(160, 20);
            this.txt_count.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(259, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(262, 282);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(160, 20);
            this.txt_price.TabIndex = 11;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(471, 355);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(130, 29);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(607, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 370);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // chk_isAvailable
            // 
            this.chk_isAvailable.AutoSize = true;
            this.chk_isAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_isAvailable.Location = new System.Drawing.Point(472, 265);
            this.chk_isAvailable.Name = "chk_isAvailable";
            this.chk_isAvailable.Size = new System.Drawing.Size(69, 17);
            this.chk_isAvailable.TabIndex = 17;
            this.chk_isAvailable.Text = "Available";
            this.chk_isAvailable.UseVisualStyleBackColor = true;
            this.chk_isAvailable.CheckedChanged += new System.EventHandler(this.chk_isAvailable_CheckedChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Delivery",
            "Water Resistant",
            "Fragile"});
            this.checkedListBox1.Location = new System.Drawing.Point(471, 282);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 60);
            this.checkedListBox1.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(249, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 41);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(23, 24);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(0, 25);
            this.lbl_username.TabIndex = 20;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(1021, 18);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(99, 31);
            this.btn_logout.TabIndex = 21;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 481);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.chk_isAvailable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.laba);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_objectName);
            this.Controls.Add(this.txt_InventoryNum);
            this.Controls.Add(this.txt_IdNum);
            this.Controls.Add(this.btn_Name);
            this.Name = "Form1";
            this.Text = "Add Invetory";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Name;
        private System.Windows.Forms.TextBox txt_IdNum;
        private System.Windows.Forms.TextBox txt_InventoryNum;
        private System.Windows.Forms.TextBox txt_objectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laba;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_count;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox chk_isAvailable;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_logout;
    }
}

