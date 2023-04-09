using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KareHesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int back = 0;
        void karehesapla()
        {
            int kare = 0, hesapla;

            kare = Convert.ToInt16(textBox1.Text);

            hesapla = kare * kare;

            listBox1.Items.Add(hesapla.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            karehesapla();
            back++;

            if (back == 1)
            {
                this.BackColor = Color.AliceBlue;

            }
           else if (back == 2)
            {
                this.BackColor = Color.Red;
            }
            else if (back == 3)
            {
                this.BackColor = Color.SlateBlue;
            }
            else if (back == 4)
            {
                this.BackColor = Color.Pink;
            }
            else if (back == 5)
            {
                this.BackColor = Color.Purple;
            }
            else if (back == 6)
            {
                this.BackColor = Color.SeaGreen;
            }
            else if (back == 7)
            {
                this.BackColor = Color.Salmon;
            }
            else if (back == 8)
            {
                this.BackColor = Color.SeaGreen;
            }
            else if (back == 9)
            {
                this.BackColor = Color.SkyBlue;
                back = 0;
            }   
        }
    }
}
