using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += button15.Text;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += " "+button12.Text+" ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += " "+button13.Text+" ";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += " "+button10.Text+" ";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += " "+button11.Text+" ";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            double sonuc=0;
            for(int i = 0; i <= textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == '+')
                {
                    sonuc = Convert.ToDouble(textBox1.Text.Substring(0, i)) + Convert.ToDouble(textBox1.Text.Substring(i + 1, textBox1.Text.Length - i - 1));
                    break;
                }
                else if (textBox1.Text[i] == '-')
                {
                    sonuc = Convert.ToDouble(textBox1.Text.Substring(0, i)) - Convert.ToDouble(textBox1.Text.Substring(i + 1, textBox1.Text.Length - i - 1));
                    break;
                }
                else if (textBox1.Text[i] == '*')
                {
                    sonuc = Convert.ToDouble(textBox1.Text.Substring(0, i)) * Convert.ToDouble(textBox1.Text.Substring(i + 1, textBox1.Text.Length - i - 1));
                    break;
                }
                else if (textBox1.Text[i] == '/')
                {
                    sonuc = Convert.ToDouble(textBox1.Text.Substring(0, i)) / Convert.ToDouble(textBox1.Text.Substring(i + 1, textBox1.Text.Length - i - 1));
                    break;
                }
                else if (textBox1.Text[i]== '%')
                {
                    sonuc = Convert.ToDouble(textBox1.Text.Substring(0, i)) % Convert.ToDouble(textBox1.Text.Substring(i + 1, textBox1.Text.Length - i - 1));
                    break;
                }
            }

            textBox1.Text=Convert.ToString(sonuc);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += " "+btn.Text+" ";
        }
    }
    public class Eleman
    {
        public int deger;
        public Eleman sonraki;
        public Eleman(int deger)
        {
            this.deger = deger;
            sonraki = null;
        }

    }
    public class Stack
    {
        public Eleman ust;
        public Stack()
        {
            ust = null;
        }
        public Boolean bosmu()
        {
            return ust == null;
        }
        public void push(int  deger)
        {
            Eleman yeni = new Eleman(deger);

            if (bosmu())
            {
                ust = yeni;
            }
            else
            {
                yeni.sonraki = ust;
                ust = yeni;
            }
        }
        public int pop()
        {
            if (bosmu())
            {
                return -1;
            }
            else
            {
                int temp = ust.deger;
                ust = ust.sonraki;
                return temp;
            }
        }
    }
   
} 
