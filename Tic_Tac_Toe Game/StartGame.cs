using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class StartGame : Form
    {
        public StartGame()
        {
            InitializeComponent();
        }

        private void btn_startGame_MouseEnter(object sender, EventArgs e)
        {
            btn_startGame.BackColor = Color.GreenYellow;
        }

        private void btn_startGame_MouseLeave(object sender, EventArgs e)
        {
            btn_startGame.BackColor = Color.Transparent;

        }

        private void btn_startGame_Click(object sender, EventArgs e)
        {
            ChoiceMode choiceMode = new ChoiceMode();
            this.Hide();
            choiceMode.Show();
        }
    }
}
