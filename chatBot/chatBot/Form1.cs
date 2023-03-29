using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using System.Net;

// MICHAL JE BLB JUST SAYIN'

namespace chatBot
{
    public partial class Form1 : Form
    {
        bool followup;
        public void question()
        {
            string text;
            text = txb_in.Text;
            text = text.ToLower();
            string date = Convert.ToString(DateTime.Now);
            string[] pole = date.Split(' ');
            txb_out.Text += "Ty: " + txb_in.Text + Environment.NewLine;
            /*if (followup == true)
            {
                if (text == "ano")
                    this.Close();
                else if (text == "ne")
                {
                    txb_out.Text += "Chad: Tak si nestěžuj" + Environment.NewLine;
                    followup = false;
                }
                else
                {
                    txb_out.Text += "Chad: Na něco jsem se ptal, ale dobře" + Environment.NewLine;
                    followup = false;
                }
            }*/
            for (int j = 0; j <= questions.Count; j++)
                {
                /*if (text == "už mě nebavíš")
                    {
                    txb_out.Text += "Chad: Chceš ukončit program?" + Environment.NewLine;
                    followup = true;
                    break;
                    }*/
                if (text == "datum")
                        {
                            txb_out.Text += "Chad: Dnes je " + pole[0] + Environment.NewLine;
                            break;
                        }
                    if (text == "čas")
                        {
                            txb_out.Text += "Chad: Teď je " + pole[1] + Environment.NewLine;
                            break;
                        }
                    if (j == questions.Count)
                        {
                            string input = Interaction.InputBox("Tuto otázku neznám: " + txb_in.Text, "Neznámá otázka", "odpověď na tuto otázku", 10, 10);
                            if (input == "" || input == "odpověď na tuto otázku")
                                break;
                            StreamWriter fwrite = new StreamWriter("src.csv", true);
                            fwrite.WriteLine(text + ";" + input);
                            fwrite.Close();
                            questions.Add(text);
                            answers.Add(input);
                            break;
                        }
                    if (text == questions[j])
                        {
                            txb_out.Text += "Chad: " + answers[j] + Environment.NewLine;
                            break;
                        }
                }
                txb_in.Clear();
                txb_in.Focus();
        }
        List<string> questions = new List<string>();
        List<string> answers = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            question();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txb_in.Focus(); // nefunguje ffs
            string line;
            StreamReader fload = new StreamReader("src.csv");
            while ((line = fload.ReadLine()) != null)
            {
                string[] pole = line.Split(';');
                questions.Add(pole[0]);
                answers.Add(pole[1]);
            }
            fload.Close();
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txb_out.Clear();
        }

        private void txb_in_KeyPress(object sender, KeyPressEventArgs e)
        {
            char guess = e.KeyChar;
            char.ToUpper(guess);
            if (guess == (char)Keys.Enter)
            {
                question();
            }
        }
    }
}
