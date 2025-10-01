namespace NorthTraffordGroupPractice
{
    partial class Form3
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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Emergency Departments(ED)",
            "",
            "Surgery Department",
            "",
            "Intensive Care Unit(ICU)",
            "",
            "Anesthesiology ",
            "",
            "Cardiology",
            "",
            "Neurology",
            "",
            "Oncology",
            "",
            "Orthopedics",
            "",
            "Pediatrics",
            "",
            "Obstetrics and Gynecology",
            "",
            "Urology",
            "",
            "Gastroenterology",
            "",
            "Pulmonology ",
            "",
            "Nephrology ",
            "",
            "Rheumatology",
            "",
            "Dermatology ",
            "",
            "Ophthalmology",
            "",
            "Otoloaryngology(ENT)",
            "",
            "Plastic Surgery",
            "",
            "Radiology/ Imaging x"});
            this.comboBox3.Location = new System.Drawing.Point(729, 47);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(282, 36);
            this.comboBox3.TabIndex = 0;
            this.comboBox3.Text = "Select Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(85, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = " North Trafford Group Practice";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 14F);
            this.textBox1.Location = new System.Drawing.Point(408, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 36);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(741, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(215, 82);
            this.button4.TabIndex = 3;
            this.button4.Text = "Scan QR Code";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Verdana", 14F);
            this.button5.Location = new System.Drawing.Point(90, 341);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(231, 73);
            this.button5.TabIndex = 4;
            this.button5.Text = "Enable Cleanig Mode";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(103, 92);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 73);
            this.button6.TabIndex = 5;
            this.button6.Text = "Back / Yn ol";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(342, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(354, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = " NHS website for England";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Click += new System.EventHandler(this.textBox1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox1;
    }
}