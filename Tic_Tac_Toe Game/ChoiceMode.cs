using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tic_Tac_Toe_Game
{
    public partial class ChoiceMode : Form
    {
        public ChoiceMode()
        {
            InitializeComponent();
        }

        private enum enMode
        {
            One_VS_One,One_VS_PC
        };

        private enMode mode;

        private void btn_OneVSOne_MouseEnter(object sender, EventArgs e)
        {
            btn_OneVSOne.BackColor = Color.GreenYellow;
        }

        private void btn_OneVSOne_MouseLeave(object sender, EventArgs e)
        {
            btn_OneVSOne.BackColor = Color.Transparent;

        }

        private void btn_OneVSPC_MouseEnter(object sender, EventArgs e)
        {
            btn_OneVSPC.BackColor = Color.GreenYellow;
        }

        private void btn_OneVSPC_MouseLeave(object sender, EventArgs e)
        {
            btn_OneVSPC.BackColor = Color.Transparent;

        }

        private void btn_Go_MouseEnter(object sender, EventArgs e)
        {
            btn_Go.BackColor = Color.GreenYellow;
        }

        private void btn_Go_MouseLeave(object sender, EventArgs e)
        {
            btn_Go.BackColor= Color.Transparent;
        }

        private void btn_Go_Click(object sender, EventArgs e)
        {

            for (int i = 1; i <= 10; i++)
            {
                if (progressBar1.Value < progressBar1.Maximum)
                {
                    Thread.Sleep(500);  //منشان يبطى البرنامج
                    progressBar1.Value += 15;
                    progressBar1.Refresh();
                }
            }

                if (mode == enMode.One_VS_One)
            {
                new Form1().Show();
            }
            else    
                new Form2().Show();
            
        }

        private void btn_OneVSOne_Click(object sender, EventArgs e)
        {
            mode=enMode.One_VS_One;

            if (btn_OneVSPC.FlatStyle == FlatStyle.System)
            {
                btn_OneVSOne.FlatStyle = FlatStyle.System;
                btn_OneVSPC.FlatStyle = FlatStyle.Flat;
            }
            else
            {

                btn_OneVSOne.FlatStyle = FlatStyle.System;
            }
        }

        private void btn_OneVSPC_Click(object sender, EventArgs e)
        {
            mode = enMode.One_VS_PC;

            if (btn_OneVSOne.FlatStyle == FlatStyle.System)
            {
                btn_OneVSPC.FlatStyle = FlatStyle.System;
                btn_OneVSOne.FlatStyle = FlatStyle.Flat;
            }
            else
            {

                btn_OneVSPC.FlatStyle = FlatStyle.System;
            }
        }

     
    }
}
