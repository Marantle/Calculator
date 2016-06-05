using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laskin
{
    public partial class Laskin : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Laskin()
        {
            InitializeComponent();
        }


        char op;
        char[] ops = {'+', '-', '/', '*'};
        string result = "";
        bool ekacheck = false;
        double ekaluku;
        bool tokacheck = false;
        double tokaluku;
        bool tuloscheck = false;
        double tulos;
        /// <summary>
        /// If Result contains operators, return true
        /// </summary>

        

        private void debug()
        {
            eka.Text = ekaluku.ToString();
            toka.Text = tokaluku.ToString();
            opsi.Text = op.ToString();
        }

        private void One_Click(object sender, EventArgs e)
        {
            Myclass.nappi(Formula, result, tuloscheck, sender);
            debug();
        }

        private void Two_Click(object sender, EventArgs e)
        {
            Myclass.nappi(Formula, result, tuloscheck, sender);
        }

        private void Three_Click(object sender, EventArgs e)
        {
            Myclass.nappi(Formula, result, tuloscheck, sender);
        }

        private void Four_Click(object sender, EventArgs e)
        {
            Myclass.nappi(Formula, result, tuloscheck, sender);
        }

        private void Five_Click(object sender, EventArgs e)
        {
            Myclass.nappi(Formula, result, tuloscheck, sender);
        }

        private void Six_Click(object sender, EventArgs e)
        {
            Myclass.nappi(Formula, result, tuloscheck, sender);
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            Myclass.nappi(Formula, result, tuloscheck, sender);
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            Myclass.nappi(Formula, result, tuloscheck, sender);
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            Myclass.nappi(Formula, result, tuloscheck, sender);
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            Myclass.nappi(Formula, result, tuloscheck, sender);
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (Myclass.tarkistin(Formula.Text))
            { }
            else if (tuloscheck)
            {
                Formula.Text = tulos.ToString();
                Formula.Text += b.Text;
                op = Char.Parse(b.Text);
                tuloscheck = false;
            }
            else if (!ekacheck)
            {
                ekaluku = Double.Parse(Formula.Text);
                ekacheck = true;
                Formula.Text += b.Text;
                op = Char.Parse(b.Text);
            }
            debug();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (Myclass.tarkistin(Formula.Text))
            { }
            else if (tuloscheck)
            {
                Formula.Text = tulos.ToString();
                Formula.Text += b.Text;
                op = Char.Parse(b.Text);
                tuloscheck = false;
            }
            else if (!ekacheck)
            {
                ekaluku = Double.Parse(Formula.Text);
                ekacheck = true;
                Formula.Text += b.Text;
                op = Char.Parse(b.Text);
            }
            debug();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (Myclass.tarkistin(Formula.Text))
            { }
            else if (tuloscheck)
            {
                Formula.Text = tulos.ToString();
                Formula.Text += b.Text;
                op = Char.Parse(b.Text);
                tuloscheck = false;
            }
            else if (!ekacheck)
            {
                ekaluku = Double.Parse(Formula.Text);
                ekacheck = true;
                Formula.Text += b.Text;
                op = Char.Parse(b.Text);
            }
            debug();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (Myclass.tarkistin(Formula.Text))
            { }
            else if (tuloscheck)
            {
                Formula.Text = tulos.ToString();
                Formula.Text += b.Text;
                op = Char.Parse(b.Text);
                tuloscheck = false;
            }
            else if (!ekacheck)
            {
                ekaluku = Double.Parse(Formula.Text);
                ekacheck = true;
                Formula.Text += b.Text;
                op = Char.Parse(b.Text);
            }
            debug();
        }

        private void Reset_Click(object sender, EventArgs e)
        {

            result = "";
            ekacheck = false;
            ekaluku = 0;
            tokacheck = false;
            tokaluku = 0;
            tuloscheck = false;
            tulos = 0;
            Formula.Text = "";
            Result.Text = "";
            debug();
        }

        private void Equal_Click_1(object sender, EventArgs e)
        {
            debug();
            if (Myclass.tarkistin(Formula.Text) || tuloscheck)
            {}
            else if (!tokacheck && ekacheck)
               {
                   if (!tuloscheck)
                   {
                       tokaluku = Double.Parse(Formula.Text.Substring(ekaluku.ToString().Length+1));
                   };
            if (op == '-')
                tulos = ekaluku - tokaluku;
            else if (op == '/')
                tulos = ekaluku / tokaluku;
            else if (op == '+')
                tulos = ekaluku + tokaluku;
            else if (op == '*')
                tulos = ekaluku * tokaluku;
            Result.Text = tulos.ToString("0.########");
            ekaluku = tulos;
            tokaluku = 0;
            tuloscheck = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            this.Height = 430;
            else
            this.Height = 305;
        }

        private void Comma_Click(object sender, EventArgs e)
        {

            if (Myclass.tarkistin(Formula.Text) || tuloscheck)
            { }
            else if (Myclass.commacheck(Formula.Text, ekaluku, ekacheck, ops))
            { }            
            else
            {
                result += ",";
                Formula.Text += ",";
            }
        }
    }
}