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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.ClientSize = new Size(1920, 1080);
            //label 1 position
            this.Controls.Add(label3);
            label3.AutoSize = false;
            this.Padding = new Padding(0);
            label3.BorderStyle = BorderStyle.None;
            label3.TextAlign = ContentAlignment.MiddleCenter;


            label3.Location = new Point(-200, 0);

            label3.Height = 80;
            label3.Width = 1920;
            label3.BackColor = ColorTranslator.FromHtml("#005EB8");
            label3.ForeColor = Color.White;


            label4.Location = new Point(390, 400);
            label4.Height = 500;
            label4.Width = 120;
            
            // Set the button background color to #005EB8
            //back button
            button6.Height = 80;
            button6.Width = 120;
            button6.BackColor = ColorTranslator.FromHtml("#005EB8");
            button6.ForeColor = Color.White;
            button6.Location = new Point(120, 120);
            
           
            //Enable cleaning mode button
            button5.Height = 80;
            button5.Width = 120;
            button5.BackColor = ColorTranslator.FromHtml("#41B6E6");
            button5.ForeColor = Color.White;
            button5.Location = new Point(120, 650);
            //Scan QR code button
            button4.Height = 80;
            button4.Width = 120;
            button4.BackColor = ColorTranslator.FromHtml("#005EB8");
            button4.ForeColor = Color.White;
            button4.Location = new Point(1320, 650);

            //TEXT BOX
            textBox1.Height = 80;
            textBox1.Width = 400;

            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(600, 120);
            // Set the placeholder text and style for textBox1


            // Add Enter and Leave events for the placeholder functionality

            // Set the placeholder text and style for textBox1
            textBox1.Text = "Chwilio adran ysbyty"; // Set placeholder text
            textBox1.ForeColor = Color.Gray; // Set placeholder text color

            // Attach the Enter and Leave events
            textBox1.Enter += TextBox1_Enter;
            textBox1.Leave += TextBox1_Leave;


            // Set the comboBox background color to #005EB8
            comboBox3.BackColor = ColorTranslator.FromHtml("#005EB8");
            comboBox3.ForeColor = Color.White;
            comboBox3.Height = 100;
            comboBox3.Width = 150;
            comboBox3.Location = new Point(1200, 120);
            comboBox3.Size = new Size(250, 90);
            label4.Text = "Cymhwysiad Meddalwedd ar gyfer GIG Practis Grŵp Gogledd Trafford\r\n" +
                "Dewch o hyd i wybodaeth a gwasanaethau i'ch helpu i reoli eich iechyd";

        }

        // Event handler for when the user enters the textBox1
        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Chwilio adran ysbyty")
            {
                textBox1.Text = ""; // Clear the placeholder text
                textBox1.ForeColor = Color.Black; // Set text color to normal
            }
        }

        // Event handler for when the user leaves textBox1
        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Chwilio adran ysbyty"; // Restore the placeholder text
                textBox1.ForeColor = Color.Gray; // Set text color to placeholder color
            }
        }
    


        private void button6_Click(object sender, EventArgs e)
        {
            // Show Form1 (the home page)
            Form1 form1 = new Form1();
            form1.Show();

            // Close Form2
            this.Close();
        }
    }
}
