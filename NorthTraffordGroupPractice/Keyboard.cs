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
    public partial class Keyboard : Form
    {
        TextBox tt;

        public Keyboard()
        {
            InitializeComponent();
            this.TopMost = true;  // make the keyboard always in front of the other forms
            clear.BackColor = ColorTranslator.FromHtml("#005EB8");
            buttonA.BackColor = ColorTranslator.FromHtml("#005EB8");
            buttonB.BackColor = ColorTranslator.FromHtml("#005EB8");
            buttonC.BackColor = ColorTranslator.FromHtml("#005EB8");
            button1.BackColor = ColorTranslator.FromHtml("#005EB8");
            button2.BackColor = ColorTranslator.FromHtml("#005EB8");
            button3.BackColor = ColorTranslator.FromHtml("#005EB8");
            button4.BackColor = ColorTranslator.FromHtml("#005EB8");
            button5.BackColor = ColorTranslator.FromHtml("#005EB8");
            button6.BackColor = ColorTranslator.FromHtml("#005EB8");
            button7.BackColor = ColorTranslator.FromHtml("#005EB8");
            button8.BackColor = ColorTranslator.FromHtml("#005EB8");
            button9.BackColor = ColorTranslator.FromHtml("#005EB8");
            button10.BackColor = ColorTranslator.FromHtml("#005EB8");
            button11.BackColor = ColorTranslator.FromHtml("#005EB8");
            button12.BackColor = ColorTranslator.FromHtml("#005EB8");
            button13.BackColor = ColorTranslator.FromHtml("#005EB8");
            button14.BackColor = ColorTranslator.FromHtml("#005EB8");
            button15.BackColor = ColorTranslator.FromHtml("#005EB8");
            button16.BackColor = ColorTranslator.FromHtml("#005EB8");
            button17.BackColor = ColorTranslator.FromHtml("#005EB8");
            button18.BackColor = ColorTranslator.FromHtml("#005EB8");
            button19.BackColor = ColorTranslator.FromHtml("#005EB8");
            button20.BackColor = ColorTranslator.FromHtml("#005EB8");
            button21.BackColor = ColorTranslator.FromHtml("#005EB8");
            button23.BackColor = ColorTranslator.FromHtml("#005EB8");
            button24.BackColor = ColorTranslator.FromHtml("#005EB8");
            button25.BackColor = ColorTranslator.FromHtml("#005EB8");
            button26.BackColor = ColorTranslator.FromHtml("#005EB8");
            button27.BackColor = ColorTranslator.FromHtml("#005EB8");
            button28.BackColor = ColorTranslator.FromHtml("#005EB8");

            //FORE COLOR 
            clear.ForeColor = Color.White;
            buttonA.ForeColor = Color.White;
            buttonB.ForeColor = Color.White;
            buttonC.ForeColor = Color.White;
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.White;
            button3.ForeColor = Color.White;
            button4.ForeColor = Color.White;
            button5.ForeColor = Color.White;
            button6.ForeColor = Color.White;
            button7.ForeColor = Color.White;
            button8.ForeColor = Color.White;
            button9.ForeColor = Color.White;
            button10.ForeColor = Color.White;
            button11.ForeColor = Color.White;
            button12.ForeColor = Color.White;
            button13.ForeColor = Color.White;
            button14.ForeColor = Color.White;
            button15.ForeColor = Color.White;
            button16.ForeColor = Color.White;
            button17.ForeColor = Color.White;
            button18.ForeColor = Color.White;
            button19.ForeColor = Color.White;
            button20.ForeColor = Color.White;
            button21.ForeColor = Color.White;
            button23.ForeColor = Color.White;
            button24.ForeColor = Color.White;
            button25.ForeColor = Color.White;
            button26.ForeColor = Color.White;
            button27.ForeColor = Color.White;
            button28.ForeColor = Color.White;


            //font family 
            buttonB.Font = new Font("Verdana", 14, FontStyle.Bold);
            buttonC.Font = new Font("Verdana", 14, FontStyle.Bold);
            button1.Font = new Font("Verdana", 14, FontStyle.Bold);
            button2.Font = new Font("Verdana", 14, FontStyle.Bold);
            button3.Font = new Font("Verdana", 14, FontStyle.Bold);
            button4.Font = new Font("Verdana", 14, FontStyle.Bold);
            button5.Font = new Font("Verdana", 14, FontStyle.Bold);
            button6.Font = new Font("Verdana", 14, FontStyle.Bold);
            button7.Font = new Font("Verdana", 14, FontStyle.Bold);
            button8.Font = new Font("Verdana", 14, FontStyle.Bold);
            button9.Font = new Font("Verdana", 14, FontStyle.Bold);
            button10.Font = new Font("Verdana", 14, FontStyle.Bold);
            button11.Font = new Font("Verdana", 14, FontStyle.Bold);
            button12.Font = new Font("Verdana", 14, FontStyle.Bold);
            button13.Font = new Font("Verdana", 14, FontStyle.Bold);
            button14.Font = new Font("Verdana", 14, FontStyle.Bold);
            button15.Font = new Font("Verdana", 14, FontStyle.Bold);
            button16.Font = new Font("Verdana", 14, FontStyle.Bold);
            button17.Font = new Font("Verdana", 14, FontStyle.Bold);
            button18.Font = new Font("Verdana", 14, FontStyle.Bold);
            button19.Font = new Font("Verdana", 14, FontStyle.Bold);
            button20.Font = new Font("Verdana", 14, FontStyle.Bold);
            button21.Font = new Font("Verdana", 14, FontStyle.Bold);
            button23.Font = new Font("Verdana", 14, FontStyle.Bold);
            button24.Font = new Font("Verdana", 14, FontStyle.Bold);
            button25.Font = new Font("Verdana", 14, FontStyle.Bold);
            button26.Font = new Font("Verdana", 14, FontStyle.Bold);
            button27.Font = new Font("Verdana", 14, FontStyle.Bold);
            button28.Font = new Font("Verdana", 14, FontStyle.Bold);
            clear.Font = new Font("Verdana", 14, FontStyle.Bold);


        }

        public void setTextBoxForOutput(TextBox t)
        {
            tt = t;  // 
        }
        private void button_Click(object sender, EventArgs e)
        {

            tt.Text += ((Button)sender).Text;
        }

        private void button_Click_Map(object sender, EventArgs e)
        {
            // Show Form1 (the home page)
            Form5 form5 = new Form5();
            form5.Show();

            // Close Form2
            this.Close();
        }
    }
}
