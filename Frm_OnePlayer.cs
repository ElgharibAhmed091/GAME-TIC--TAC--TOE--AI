using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GAME_AI_TIC_TAC_TOE
{
    public partial class Frm_OnePlayer : Form
    {
        public Frm_OnePlayer()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Guna2Panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            Close();
            FrmMain frm = new FrmMain();
            frm.Show();

        }

        private void Btn9_Click(object sender, EventArgs e)
        {

        }

        private List<Guna.UI2.WinForms.Guna2Button> buttons;
        private readonly Random rand = new Random();
        private int player1 = 0;
        private int player2 = 0;

        private void Loadbuttons()
        {
            buttons = new List<Guna.UI2.WinForms.Guna2Button> { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 }
            ;
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

        private void Frm_OnePlayer_Load(object sender, EventArgs e)
        {

            foreach (Control c in panelofbuttons.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    c.Click += new EventHandler(Btn_click);
                }
            }
            Loadbuttons();

        }
        public void Btn_click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button btn = (Guna.UI2.WinForms.Guna2Button)sender;
            if (btn.Text.Equals(""))
            {
                btn.Text = "x";
                btn.ForeColor = Color.Yellow;
                _ = buttons.Remove(btn);
                Getthewinner();
                move.Start();


            }
        }

        private void Move_Tick(object sender, EventArgs e)
        {
            if (buttons.Count > 0 && win == false)
            {
                int index = rand.Next(buttons.Count);
                if (buttons[index].Text == "")
                {
                    buttons[index].ForeColor = Color.Lime;
                    buttons[index].Text = "O";
                    buttons.RemoveAt(index);
                    Getthewinner();
                    move.Stop();
                }
            }

        }

        private void Btnplayagain_Click(object sender, EventArgs e)
        {
            Loadbuttons();
            win = false;
            foreach (Control c in panelofbuttons.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    c.Text = "";
                }
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}




