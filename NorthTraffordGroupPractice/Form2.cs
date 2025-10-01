using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NorthTraffordGroupPractice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.ClientSize = new Size(1920, 1080);

            //label 1 position
            label2.Location = new Point(80, 80);
            // Set the button background color to #005EB8
            button2.BackColor = ColorTranslator.FromHtml("#005EB8");
            button2.Height = 100;
            button2.Width = 200;
            button2.ForeColor = Color.White;
            button2.Location = new Point(600, 400);

            //back button
            button3.Height = 80;
            button3.Width = 120;
            button3.BackColor = ColorTranslator.FromHtml("#005EB8");
            button3.ForeColor = Color.White;
            button3.Location = new Point(80, 160);
            // Event handler for Back button
            button3.Click += button3_Click;
            // Set the comboBox background color to #005EB8
            comboBox2.BackColor = ColorTranslator.FromHtml("#005EB8");
            comboBox2.ForeColor = Color.White;
            comboBox2.Height = 100;
            comboBox2.Width = 300;
            comboBox2.Location = new Point(1000, 80);

            // Add items to the ComboBox
            comboBox2.Items.Add("English");
            comboBox2.Items.Add("Welsh");
            comboBox2.Size = new Size(450, 90);
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            // Show Form1 (the home page)
            Form1 form1 = new Form1();
            form1.Show();

            // Close Form2
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show Form1 (the home page)
            Form4 form4 = new Form4();
            form4.Show();

            // Close Form2
            this.Hide();
        }
    }
}
