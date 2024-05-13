using System;
using System.Drawing;
using System.Windows.Forms;

namespace GAME_AI_TIC_TAC_TOE
{
    public partial class Frm_TwoPlayer : Form
    {
        public Frm_TwoPlayer()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private int xo = 0;
        private int player1 = 0;
        private int player2 = 0;
        private bool win = false;

        private void Getthewinner()
        {
            if (btn1.Text != "" && btn1.Text == btn2.Text && btn1.Text == btn3.Text)
            {
                Wineffect(btn1, btn2, btn3);
                win = true;
                _ = MessageBox.Show("Good Player...");
            }
            else if (btn4.Text != "" && btn4.Text == btn5.Text && btn4.Text == btn6.Text)
            {
                Wineffect(btn4, btn5, btn6);
                win = true;
                _ = MessageBox.Show("Good Player...");
            }
            else if (btn7.Text != "" && btn7.Text == btn8.Text && btn7.Text == btn9.Text)
            {
                Wineffect(btn7, btn8, btn9);
                win = true;
                _ = MessageBox.Show("Good Player...");
            }
            else if (btn1.Text != "" && btn1.Text == btn4.Text && btn1.Text == btn7.Text)
            {
                Wineffect(btn1, btn4, btn7);
                win = true;
                _ = MessageBox.Show("Good Player...");
            }
            else if (btn2.Text != "" && btn2.Text == btn5.Text && btn2.Text == btn8.Text)
            {
                Wineffect(btn2, btn5, btn8);
                win = true;
                _ = MessageBox.Show("Good Player...");
            }
            else if (btn3.Text != "" && btn3.Text == btn6.Text && btn3.Text == btn9.Text)
            {
                Wineffect(btn3, btn6, btn9);
                win = true;
                _ = MessageBox.Show("Good Player...");
            }
            else if (btn1.Text != "" && btn1.Text == btn5.Text && btn1.Text == btn9.Text)
            {
                Wineffect(btn1, btn5, btn9);
                win = true;
                _ = MessageBox.Show("Good Player...");
            }
            else if (btn3.Text != "" && btn3.Text == btn5.Text && btn3.Text == btn7.Text)
            {
                Wineffect(btn3, btn5, btn7);
                win = true;
                _ = MessageBox.Show("Good Player...");
            }
        }

        private void Wineffect(Guna.UI2.WinForms.Guna2Button b1, Guna.UI2.WinForms.Guna2Button b2, Guna.UI2.WinForms.Guna2Button b3)
        {
            b1.ForeColor = Color.FromArgb(115, 196, 232);
            b2.ForeColor = Color.FromArgb(115, 196, 232);
            b3.ForeColor = Color.FromArgb(115, 196, 232);
            if (b1.Text == "x")
            {
                player1++;
                lbl1.Text = player1.ToString();
            }
            else
            {
                player2++;
                lbl2.Text = player2.ToString();
            }
        }





        private void Frm_TwoPlayer_Load(object sender, EventArgs e)
        {
            foreach (Control c in panelofbuttons.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    c.Click += new EventHandler(Btn_click);
                }
            }

        }

        private void Btn_click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;
            if (btn.Text.Equals(""))
            {
                if (xo % 2 == 0)
                {
                    btn.Text = "x";
                    btn.ForeColor = Color.Yellow;
                    Getthewinner();
                }
                else
                {
                    btn.Text = "o";
                    btn.ForeColor = Color.Red;
                    Getthewinner();
                }
                xo++;
            }
        }

        private void Btnplayagain_Click(object sender, EventArgs e)
        {
            //xo = 0;
            //win = false;
            //foreach (Control c in panelofbuttons.Controls)
            //{
            //    if (c is Guna.UI2.WinForms.Guna2Button)
            //    {
            //        c.Text = "";
            //    }
            //}



        }

        private void Btnoneplayer_Click(object sender, EventArgs e)
        {
            xo = 0;
            win = false;
            foreach (Control c in panelofbuttons.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    c.Text = "";
                }
            }

        }

        private void Btnexit_Click(object sender, EventArgs e)
        {

            Close();
            FrmMain frm = new FrmMain();
            frm.Show();
        }

        private void Lbl1_Click(object sender, EventArgs e)
        {

        }

        public override bool Equals(object obj)
        {
            return obj is Frm_TwoPlayer player &&
                   win == player.win;
        }
    }
}

