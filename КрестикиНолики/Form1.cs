using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace КрестикиНолики
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Button[,]  field;
        string player;
        public Form1()
        {
            InitializeComponent();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void isField()
        {
            player = "X";
            field = new System.Windows.Forms.Button[3, 3];


            field[0, 0] = button1;
            field[0, 1] = button2;
            field[0, 2] = button3;

            field[1, 0] = button4;
            field[1, 1] = button5;
            field[1, 2] = button6;

            field[2, 0] = button7;
            field[2, 1] = button8;
            field[2, 2] = button9;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    field[i, j].Text = " ";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Visible = false;
            isField();
        }

        private bool IsWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (field[i,0].Text == field[i, 1].Text && field[i, 1].Text == field[i, 2].Text && field[i, 0].Text != " ")
                {
                    return true;
                }
            }

            if (field[0, 0].Text == field[1, 1].Text && field[1, 1].Text == field[2, 2].Text && field[0, 0].Text != " ")
            {
                return true;
            }
            
            if (IsFree() == false)
            {
                MessageBox.Show("Ничья");
            }

            return false;
        }

        private bool IsFree()
        {
            int coun = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (field[i, j].Text == " ")
                    {
                        coun++;
                    }
                }
            }

            if (coun > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void FButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (((System.Windows.Forms.Button)sender).Equals(field[i, j]))
                    {

                        if (field[i, j].Text == " ")
                        {
                            field[i, j].Text = player;
                            if (IsWin())
                            {
                                MessageBox.Show($"Победил {player}");
                            }
                            if (player == "X")
                            {
                                player = "O";
                            }
                            else
                            {
                                player = "X";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Так НЕЛЬЗЯ!!!" +
                                "Клетка забронирована!");
                        }
                        return;
                    }
                }
            }
        }
        private void newPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
