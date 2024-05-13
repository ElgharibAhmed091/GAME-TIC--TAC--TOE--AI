using System;
using System.Windows.Forms;

namespace GAME_AI_TIC_TAC_TOE
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Btnoneplayer_Click(object sender, EventArgs e)
        {
            Frm_OnePlayer frm = new Frm_OnePlayer();
            frm.Show();
            Hide();

        }

        private void Btntwoplayer_Click(object sender, EventArgs e)
        {
            Frm_TwoPlayer frm = new Frm_TwoPlayer();
            frm.Show();
            Hide();
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}































