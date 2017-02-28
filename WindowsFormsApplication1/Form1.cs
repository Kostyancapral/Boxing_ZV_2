using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        string text;
        int vibor_p;
        class Kill
        {
            public
            int A, B;
            public
            void Vibor_zashit()
            {
                Random rand = new Random();
                A = rand.Next(1, 4);
            }
            public
            void Ydar(int vibor_p)
            {
                B = vibor_p;
            }
            public
            void Block(int vibor_p)
            {
                B = vibor_p;
            }
            public
            string Ataka()
            {
                if (B != A)
                {
                   return "Ты победил!";
                }
                else
                {
                   return "Проигрышь";
                }
            }
            public
            string Zashita()
            {
                if (A != B)
                {
                    return "Struck";
                }
                else
                {
                   return "Victory!";
                }
            }

        }
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button4_Click_1(object sender, EventArgs e)
        {
            Kill S = new Kill();
            S.Vibor_zashit();
            S.Ydar(vibor_p);
            richTextBox1.Text = S.Ataka();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Kill W = new Kill();
            W.Block(vibor_p);
            W.Vibor_zashit();
            richTextBox1.Text = W.Zashita();
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            vibor_p = 2;
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            vibor_p = 3;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            vibor_p = 1;
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
