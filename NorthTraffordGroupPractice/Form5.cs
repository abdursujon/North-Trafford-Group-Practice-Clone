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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.ClientSize = new Size(1920, 1080);
            button6.Height = 80;
            button6.Width = 120;
            button6.BackColor = ColorTranslator.FromHtml("#005EB8");
            button6.ForeColor = Color.White;
            button6.Location = new Point(120, 120);
            pictureBox1.Location = new Point(300, 120);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = 700;  // Example width
            pictureBox1.Height = 700; // Example height

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
