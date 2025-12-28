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
    public partial class Form1 : Form
    {

        byte NumberTimes = 0;
        byte NumberPlayer = 0;

  

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color color=Color.White;
            Pen pen=new Pen(color);
            pen.Width=10;


            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            //horizontal
            e.Graphics.DrawLine(pen, 900, 200, 378, 200);
            e.Graphics.DrawLine(pen, 900, 330, 378, 330);

            // vertical
            e.Graphics.DrawLine(pen, 550, 100, 550, 450);

            e.Graphics.DrawLine(pen, 730, 100, 730, 450);


        }


        void UpdateTurnPlayer()
        {
            label_TurnPlayer.Tag = NumberPlayer;

        }
        byte GetCureentPlayer()
        {
            return Convert.ToByte( label_TurnPlayer.Tag);
        }

        void Change_Image(PictureBox pb)
        {
            if (pb.Tag=="?")
            {
                if (GetCureentPlayer() == 2)
                {
                    pb.Image = Tic_Tac_Toe_Game.Properties.Resources.O;
                    pb.Tag = "O";
                    label_TurnPlayer.Text = "Player " + Convert.ToString(label_TurnPlayer.Tag);
                    NumberPlayer = 1;
                }
                if (GetCureentPlayer() == 1)
                {
                    pb.Image = Tic_Tac_Toe_Game.Properties.Resources.X;
                    pb.Tag = "X";
                    label_TurnPlayer.Text = "Player " + Convert.ToString(label_TurnPlayer.Tag);
                    NumberPlayer = 2;

                }

            }
            else
            {
                MessageBox.Show("Wrong Choice","Wrong",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            NumberTimes++;


            if (NumberTimes > 4)
                CheckWinner();
        }

        bool CheckValues(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            if (pb1.Tag != "?" && pb1.Tag == pb2.Tag && pb1.Tag == pb3.Tag)
            {
                if (pb1.Tag=="X") {

                    label_TheWinner.Text = "Player 1 ";

                }
                else
                {
                    label_TheWinner.Text = "Player 2 ";

                }
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pb1.BackColor = Color.GreenYellow;
                pb2.BackColor = Color.GreenYellow;
                pb3.BackColor = Color.GreenYellow;
                return true;

            }
            return false;
        }

        void CheckWinner()
        {
            if (CheckValues(pictureBox1,pictureBox2,pictureBox3))
            {                
                    return;    
            }
            if (CheckValues(pictureBox4, pictureBox5, pictureBox6))
            {
                return;
            }
            if (CheckValues(pictureBox7, pictureBox8, pictureBox9))
            {
                return;
            }
            if (CheckValues(pictureBox1, pictureBox4, pictureBox7))
            {
                return;
            }
            if (CheckValues(pictureBox2, pictureBox5, pictureBox8))
            {
                return;
            }
            if (CheckValues(pictureBox3, pictureBox6, pictureBox9))
            {
                return;
            }
            if (CheckValues(pictureBox1, pictureBox5, pictureBox9))
            {
                return;
            }
            if (CheckValues(pictureBox5, pictureBox7, pictureBox3))
            {
                return;
            }


            if (NumberTimes == 9)
                EndGame();

        }

        void RestartGame(PictureBox pb)
        {

            if(pb.Tag != "?")
            {
                pb.Image = Properties.Resources.question_mark_96;
                pb.Tag = "?";
                pb.BackColor = Color.Black;
            }

        }

        void EndGame()
        {
            label_TheWinner.Text = "  Equal ";
            MessageBox.Show("The Result Equal","Equal",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

            Change_Image((PictureBox)sender);

            UpdateTurnPlayer();

        }
      

        private void btn_RestartGame_Click(object sender, EventArgs e)
        {

            label_TheWinner.Text = "In Progress";
            label_TurnPlayer.Text = "Player 1";

            RestartGame(pictureBox1);
            RestartGame(pictureBox2);
            RestartGame(pictureBox3);
            RestartGame(pictureBox4);
            RestartGame(pictureBox5);
            RestartGame(pictureBox6);
            RestartGame(pictureBox7);
            RestartGame(pictureBox8);
            RestartGame(pictureBox9);

            NumberPlayer = 0;
            NumberTimes = 0;

        }
    }
}
