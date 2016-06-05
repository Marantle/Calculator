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
    public class Myclass
        {
        public static void nappi(TextBox Formula, string result, bool tuloscheck, object sender)
        {
            if (tarkistin(Formula.Text) || tuloscheck)
            {
            }
            if (!tuloscheck)
            {
                Button b = (Button)sender;
                result += b.Text;
                Formula.Text += b.Text;
            }

        }

        public static bool tarkistin(string Formula)
        {
            if (Formula == "")
                return true;

            string v = Formula[Formula.Length - 1].ToString();
            if (v == "*" || v == "/" || v == "+" || v == "-")
                return true;

            return false;
        }

        public static bool commacheck(string Formula, double ekaluku, bool ekacheck, char[] ops)
        {
            if (Myclass.tarkistin(Formula))
                return true;

            string v = Formula[Formula.Length - 1].ToString();
            int ekalength = ekaluku.ToString().Length;
            int kokolength = Formula.Length;
            int tokalength = kokolength - ekalength;
            char[] ekamerkit = Formula.Substring(0, kokolength).ToArray();
            char[] tokamerkit = Formula.Substring(ekalength, tokalength).ToArray();


            if (ekamerkit.Contains(',') && !ekacheck)
                return true;
            foreach (char c in ops)
                if (ekamerkit.Contains(c) && tokamerkit.Contains(','))
                    return true;


            return false;
        }


        public static object operaattorit(TextBox Formula, bool tuloscheck, object sender, double tulos, char op, bool ekacheck, double ekaluku)
        {

            Button b = (Button)sender;
            if (tarkistin(Formula.Text))
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

            object[] paluu = { tuloscheck, tulos, op, ekacheck, ekaluku };
            return paluu;
        }
    }
}
