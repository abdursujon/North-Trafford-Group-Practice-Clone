using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthTraffordGroupPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set the form size to 1920x1080
            this.ClientSize = new Size(1920, 1080);

            //label 1 position
            label1.Location = new Point(80, 80);
            // Set the button background color to #005EB8
            button1.BackColor = ColorTranslator.FromHtml("#005EB8");
            button1.Height = 100;
            button1.Width = 200;
            button1.ForeColor = Color.White;
            button1.Location = new Point(600, 400);

            // Set the comboBox background color to #005EB8
            comboBox1.BackColor = ColorTranslator.FromHtml("#005EB8");
            comboBox1.ForeColor = Color.White;
            comboBox1.Height = 100;
            comboBox1.Width = 300;
            comboBox1.Location = new Point(1000, 80);

            // Add items to the ComboBox
            comboBox1.Items.Add("English");
            comboBox1.Items.Add("Cymraeg");
            comboBox1.Size = new Size(450, 90);
            // Subscribe to the SelectedIndexChanged event of the ComboBox
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            button1.Click += button1_Click;
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if the selected item is "Welsh"
            if (comboBox1.SelectedItem.ToString() == "Cymraeg")
            {
                // Open Form2 if "Welsh" is selected
                Form2 form2 = new Form2();
                form2.Show(); // Show Form2
                this.Hide();  // Optionally hide Form1
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show Form1 (the home page)
            Form3 form3 = new Form3();
            form3.Show();

            // Close Form2
            this.Hide();
        }
    }
}
