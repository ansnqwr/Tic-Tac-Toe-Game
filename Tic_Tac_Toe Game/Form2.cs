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


    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        byte Score_Me = 0;
        byte Score_Pc = 0;

        byte NumberTimes = 0;

        string myChoise;

        List<PictureBox> EnabledPictureBoxes=new List<PictureBox>();

        byte RandomNumber = 0;

        Random random=new Random();

        bool IsThereWinnering=false;

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.White;
            Pen pen = new Pen(color);
            pen.Width = 10;


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
            if (label_TurnPlayer.Text == "Me")
                label_TurnPlayer.Text = "Pc";

             else label_TurnPlayer.Text = "Me";


        }
        string GetCureentPlayer()
        {
            return label_TurnPlayer.Text;

        }

        void Change_Image(PictureBox pb)
        {
            if (pb.Tag == "?" && IsThereWinnering==false)
            {
                if (GetCureentPlayer() == "Pc")
                  {
                   
                    if (myChoise == "X")
                    {
                        pb.Image = Tic_Tac_Toe_Game.Properties.Resources.O;
                        pb.Tag = "O";
                    }
                    else
                    {
                        pb.Image = Tic_Tac_Toe_Game.Properties.Resources.X;
                        pb.Tag = "X";
                    }

               //     pb.Enabled=false;

                  }


                if (GetCureentPlayer() == "Me")
                {
                    if (myChoise == "X")
                    {
                        pb.Image = Tic_Tac_Toe_Game.Properties.Resources.X;
                        pb.Tag = "X";
                    }
                    else
                    {
                        pb.Image = Tic_Tac_Toe_Game.Properties.Resources.O;
                        pb.Tag = "O";
                    }

                }

            }
      
            NumberTimes++;

            if (NumberTimes > 4)
            {
                CheckWinner();             
                
            }

         

        }

        bool CheckValues(PictureBox pb1, PictureBox pb2, PictureBox pb3)
        {
            if (pb1.Tag != "?" && pb1.Tag == pb2.Tag && pb1.Tag == pb3.Tag )
            {
                if (pb1.Tag == "X")
                {
                    if (myChoise == "X")
                    {
                        label_TheWinner.Text = "Me ";
                        lb_MeScore.Text = "Me: " + Score_Me++;

                    }
                    else
                    {
                        label_TheWinner.Text = "Pc";
                      lb_PcScore.Text = "Pc: " +Score_Pc++;

                    }

                }
             

                /*   else
                 {
                        if (myChoise == "X")
                        {
                            label_TheWinner.Text = "Me ";
                        lb_MeScore.Text = "Me: " + Score_Me++;

                          }
                    else
                        {
                            label_TheWinner.Text = "Pc";
                        lb_PcScore.Text = "Pc: " + Score_Pc++;

                          }
                }*/


                if (IsThereWinnering == false)
                {
                    MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pb1.BackColor = Color.GreenYellow;
                    pb2.BackColor = Color.GreenYellow;
                    pb3.BackColor = Color.GreenYellow;
                }
               
               
                return true;

            }
            return false;
        }

        bool CheckWinner()
        {
            if (CheckValues(pictureBox1, pictureBox2, pictureBox3))
            {
                IsThereWinnering = true;
                return true;
            }
            if (CheckValues(pictureBox4, pictureBox5, pictureBox6))
            {
               IsThereWinnering = true;
                return true;
            }
            if (CheckValues(pictureBox7, pictureBox8, pictureBox9))
            {
                IsThereWinnering = true;
                return true;
            }
            if (CheckValues(pictureBox1, pictureBox4, pictureBox7))
            {
                IsThereWinnering = true;
                return true;
            }
            if (CheckValues(pictureBox2, pictureBox5, pictureBox8))
            {
                IsThereWinnering = true;
                return true;
            }
            if (CheckValues(pictureBox3, pictureBox6, pictureBox9))
            {
               IsThereWinnering = true;
                return true;
            }
            if (CheckValues(pictureBox1, pictureBox5, pictureBox9))
            {
               IsThereWinnering = true;
                return true;
            }
            if (CheckValues(pictureBox5, pictureBox7, pictureBox3))
            {
                IsThereWinnering = true;
                return true;
            }


            if (NumberTimes == 9)
                EndGame();

            return false;

        }

        void RestartGame(PictureBox pb)
        {

            if (pb.Tag != "?")
            {
                pb.Image = Properties.Resources.question_mark_96;
                pb.Tag = "?";
                pb.BackColor = Color.Black;
               // pb.Enabled = true;
            }

        }

        void EndGame()
        {
            label_TheWinner.Text = "  Equal ";
            MessageBox.Show("The Result Equal", "Equal", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void CheckValuesForPc()
        {
            if (pictureBox1.Tag=="?")
            {
                EnabledPictureBoxes.Add(pictureBox1);
            }
            if (pictureBox2.Tag == "?")
            {
                EnabledPictureBoxes.Add(pictureBox2);

            }
            if (pictureBox3.Tag == "?")
            {
                EnabledPictureBoxes.Add(pictureBox3);

            }
            if (pictureBox4.Tag == "?")
            {
                EnabledPictureBoxes.Add(pictureBox4);

            }
            if (pictureBox5.Tag == "?")
            {
                EnabledPictureBoxes.Add(pictureBox5);

            }
            if (pictureBox6.Tag == "?")
            {
                EnabledPictureBoxes.Add(pictureBox6);

            }
            if (pictureBox7.Tag == "?")
            {
                EnabledPictureBoxes.Add(pictureBox7);

            }
            if (pictureBox8.Tag == "?")
            {
                EnabledPictureBoxes.Add(pictureBox8);

            }
            if (pictureBox9.Tag == "?")
            {
                EnabledPictureBoxes.Add(pictureBox9);

            }


        }

        async void Role_Of_Pc()
        {

            CheckValuesForPc();

            RandomNumber =Convert.ToByte(random.Next(0, EnabledPictureBoxes.Count));
            try
            {
                 await Task.Delay(600);
                Change_Image(EnabledPictureBoxes[RandomNumber]);

            }
            catch (Exception e) {  }


            EnabledPictureBoxes.Clear();

            UpdateTurnPlayer();


        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

            Change_Image((PictureBox)sender);

            UpdateTurnPlayer();     

            Role_Of_Pc();           
            
        }


        private void btn_RestartGame_Click_1(object sender, EventArgs e)
        {
            label_TheWinner.Text = "In Progress";
            label_TurnPlayer.Text = "Me";

            RestartGame(pictureBox1);
            RestartGame(pictureBox2);
            RestartGame(pictureBox3);
            RestartGame(pictureBox4);
            RestartGame(pictureBox5);
            RestartGame(pictureBox6);
            RestartGame(pictureBox7);
            RestartGame(pictureBox8);
            RestartGame(pictureBox9);

            EnabledPictureBoxes.Clear();

           IsThereWinnering = false;
            NumberTimes = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {     

            myChoise = comboBox1.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lb_MeScore.Text = "Me:" + Score_Me;
            lb_PcScore.Text = "Pc:" + Score_Pc;

            comboBox1.SelectedIndex = 0;
            myChoise=comboBox1.Text;
        }

      
    }
}
