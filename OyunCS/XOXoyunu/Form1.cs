using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOXoyunu


{
    public partial class FrmOyunAlani : Form

    {
        public FrmOyunAlani()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void FrmOyunAlani_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control == true && e.KeyCode == Keys.Enter)
            {
                var cevap = MessageBox.Show("Çıkmak İstediğinizde Emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    this.Close();
                }
            }

        }
        bool birinciOyuncuMu = true;
        private void generic_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Text == string.Empty)
            {
                if (birinciOyuncuMu == true)
                {
                    button.BackColor = Color.Black;
                    button.ForeColor = Color.Red;
                    button.Text = "X";
                    button.Font = new Font("Consolas", 75, FontStyle.Bold);
                }
                else
                {
                    button.BackColor = Color.Red;
                    button.ForeColor = Color.Black;
                    button.Text = "O";
                    button.Font = new Font("Consolas", 75, FontStyle.Bold);

      

                }
           
            }
            KazandiMi();
        }

        private void KazandiMi()
        {
            if (
                 (btn1.Text == btn2.Text && btn2.Text == btn3.Text && btn3.Text != string.Empty) ||
                (btn4.Text == btn5.Text && btn5.Text == btn6.Text && btn6.Text != string.Empty) ||
                (btn7.Text == btn8.Text && btn8.Text == btn9.Text && btn9.Text != string.Empty) ||
                

                (btn1.Text == btn4.Text && btn4.Text == btn7.Text && btn7.Text != string.Empty) ||
                (btn2.Text == btn5.Text && btn5.Text == btn8.Text && btn8.Text != string.Empty) ||
                (btn3.Text == btn6.Text && btn6.Text == btn9.Text && btn9.Text != string.Empty) ||

                (btn1.Text == btn5.Text && btn5.Text == btn9.Text && btn9.Text != string.Empty) ||
                (btn3.Text == btn5.Text && btn5.Text == btn7.Text && btn7.Text != string.Empty) 
                )
               
            {
                if(birinciOyuncuMu)
                {
                    MessageBox.Show("1.Oyuncu Kazandı");
                }
                else
                {
                    MessageBox.Show("2.Oyuncu Kazandı");
                  
                }
                this.Close();

            }
             birinciOyuncuMu = !birinciOyuncuMu;
        }
    }
}

