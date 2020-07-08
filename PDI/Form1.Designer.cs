namespace PDI
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_MonthOfManufacture = new System.Windows.Forms.ComboBox();
            this.cmb_YearOfManufacture = new System.Windows.Forms.ComboBox();
            this.dtp_InspectionDate = new System.Windows.Forms.DateTimePicker();
            this.txt_CountryOfExport = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.txt_EngineNumber = new System.Windows.Forms.TextBox();
            this.txt_Specification = new System.Windows.Forms.TextBox();
            this.cmb_Color = new System.Windows.Forms.ComboBox();
            this.cmb_CarMaker = new System.Windows.Forms.ComboBox();
            this.cmb_VehicleType = new System.Windows.Forms.ComboBox();
            this.cmb_Importer = new System.Windows.Forms.ComboBox();
            this.txt_ChassisNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_MonthOfManufacture);
            this.groupBox1.Controls.Add(this.cmb_YearOfManufacture);
            this.groupBox1.Controls.Add(this.dtp_InspectionDate);
            this.groupBox1.Controls.Add(this.txt_CountryOfExport);
            this.groupBox1.Controls.Add(this.txt_Model);
            this.groupBox1.Controls.Add(this.txt_EngineNumber);
            this.groupBox1.Controls.Add(this.txt_Specification);
            this.groupBox1.Controls.Add(this.cmb_Color);
            this.groupBox1.Controls.Add(this.cmb_CarMaker);
            this.groupBox1.Controls.Add(this.cmb_VehicleType);
            this.groupBox1.Controls.Add(this.cmb_Importer);
            this.groupBox1.Controls.Add(this.txt_ChassisNo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 446);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Importer Details";
            // 
            // cmb_MonthOfManufacture
            // 
            this.cmb_MonthOfManufacture.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmb_MonthOfManufacture.FormattingEnabled = true;
            this.cmb_MonthOfManufacture.Location = new System.Drawing.Point(181, 387);
            this.cmb_MonthOfManufacture.Name = "cmb_MonthOfManufacture";
            this.cmb_MonthOfManufacture.Size = new System.Drawing.Size(291, 25);
            this.cmb_MonthOfManufacture.TabIndex = 10;
            // 
            // cmb_YearOfManufacture
            // 
            this.cmb_YearOfManufacture.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmb_YearOfManufacture.FormattingEnabled = true;
            this.cmb_YearOfManufacture.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008"});
            this.cmb_YearOfManufacture.Location = new System.Drawing.Point(181, 354);
            this.cmb_YearOfManufacture.Name = "cmb_YearOfManufacture";
            this.cmb_YearOfManufacture.Size = new System.Drawing.Size(291, 25);
            this.cmb_YearOfManufacture.TabIndex = 9;
            // 
            // dtp_InspectionDate
            // 
            this.dtp_InspectionDate.Location = new System.Drawing.Point(181, 322);
            this.dtp_InspectionDate.Name = "dtp_InspectionDate";
            this.dtp_InspectionDate.Size = new System.Drawing.Size(291, 24);
            this.dtp_InspectionDate.TabIndex = 8;
            // 
            // txt_CountryOfExport
            // 
            this.txt_CountryOfExport.Location = new System.Drawing.Point(181, 290);
            this.txt_CountryOfExport.Name = "txt_CountryOfExport";
            this.txt_CountryOfExport.Size = new System.Drawing.Size(291, 24);
            this.txt_CountryOfExport.TabIndex = 7;
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(181, 225);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(291, 24);
            this.txt_Model.TabIndex = 6;
            // 
            // txt_EngineNumber
            // 
            this.txt_EngineNumber.Location = new System.Drawing.Point(181, 193);
            this.txt_EngineNumber.Name = "txt_EngineNumber";
            this.txt_EngineNumber.Size = new System.Drawing.Size(291, 24);
            this.txt_EngineNumber.TabIndex = 6;
            // 
            // txt_Specification
            // 
            this.txt_Specification.Location = new System.Drawing.Point(181, 161);
            this.txt_Specification.Name = "txt_Specification";
            this.txt_Specification.Size = new System.Drawing.Size(291, 24);
            this.txt_Specification.TabIndex = 5;
            // 
            // cmb_Color
            // 
            this.cmb_Color.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmb_Color.FormattingEnabled = true;
            this.cmb_Color.Location = new System.Drawing.Point(181, 257);
            this.cmb_Color.Name = "cmb_Color";
            this.cmb_Color.Size = new System.Drawing.Size(291, 25);
            this.cmb_Color.TabIndex = 4;
            // 
            // cmb_CarMaker
            // 
            this.cmb_CarMaker.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmb_CarMaker.FormattingEnabled = true;
            this.cmb_CarMaker.Location = new System.Drawing.Point(181, 128);
            this.cmb_CarMaker.Name = "cmb_CarMaker";
            this.cmb_CarMaker.Size = new System.Drawing.Size(291, 25);
            this.cmb_CarMaker.TabIndex = 4;
            // 
            // cmb_VehicleType
            // 
            this.cmb_VehicleType.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmb_VehicleType.FormattingEnabled = true;
            this.cmb_VehicleType.Location = new System.Drawing.Point(181, 63);
            this.cmb_VehicleType.Name = "cmb_VehicleType";
            this.cmb_VehicleType.Size = new System.Drawing.Size(291, 25);
            this.cmb_VehicleType.TabIndex = 4;
            // 
            // cmb_Importer
            // 
            this.cmb_Importer.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmb_Importer.FormattingEnabled = true;
            this.cmb_Importer.Location = new System.Drawing.Point(181, 30);
            this.cmb_Importer.Name = "cmb_Importer";
            this.cmb_Importer.Size = new System.Drawing.Size(291, 25);
            this.cmb_Importer.TabIndex = 3;
            // 
            // txt_ChassisNo
            // 
            this.txt_ChassisNo.Location = new System.Drawing.Point(181, 96);
            this.txt_ChassisNo.Name = "txt_ChassisNo";
            this.txt_ChassisNo.Size = new System.Drawing.Size(291, 24);
            this.txt_ChassisNo.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(122, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Model";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Inspection date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Month of manufacture";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Year of manufacture";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Country of  export ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Color";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Specification";
            this.label9.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Engine Number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Car Maker";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chasis Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vehicle type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "PDI Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_CarMaker;
        private System.Windows.Forms.ComboBox cmb_VehicleType;
        private System.Windows.Forms.ComboBox cmb_Importer;
        private System.Windows.Forms.TextBox txt_ChassisNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_MonthOfManufacture;
        private System.Windows.Forms.ComboBox cmb_YearOfManufacture;
        private System.Windows.Forms.DateTimePicker dtp_InspectionDate;
        private System.Windows.Forms.TextBox txt_CountryOfExport;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.TextBox txt_EngineNumber;
        private System.Windows.Forms.TextBox txt_Specification;
        private System.Windows.Forms.ComboBox cmb_Color;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}

