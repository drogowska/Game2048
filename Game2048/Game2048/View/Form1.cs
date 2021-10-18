using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2048
{
    public partial class Game : Form
    {
        int points = 0;
        int[,] board = new int[4, 4];
        Game2048 game;
        public Game()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            score.Text = points.ToString();
            game = new Game2048(board);
            game.initBoard();
            showBoard();

        }
        private void showBoard()
        {
            for (int i=0; i<4; i++)
            {
                for (int j=0; j<4; j++)
                {
                    String name = "Field" + i.ToString() + j.ToString();
                    Label label = this.Controls.Find(name, true).FirstOrDefault() as Label;
                    if (board[i, j] == 0)
                    {
                        label.Text =" ";
                        label.BackColor = Color.Gray;
                    }
                    else 
                    {
                        label.Text = board[i, j].ToString();
                        if (board[i, j] == 2) {
                            label.BackColor = Color.LightSeaGreen; //.LightSteelBlue;
                        }
                        if (board[i, j] == 4)
                        {
                            label.BackColor = Color.LightSlateGray;
                        }
                        if (board[i, j] == 8)
                        {
                            label.BackColor = Color.Wheat;
                        }
                        if (board[i, j] == 16)
                        {
                            label.BackColor = Color.DarkCyan;
                        }
                        if (board[i, j] == 32)
                        {
                            label.BackColor = Color.Goldenrod;
                        }
                        if (board[i, j] == 64)
                        {
                            label.BackColor = Color.Tan;
                        }
                        if (board[i, j] == 128)
                        {
                            label.BackColor = Color.Cyan;
                        }
                        if (board[i, j] == 256)
                        {
                            label.BackColor = Color.AntiqueWhite;
                        }
                        if (board[i, j] == 512)
                        {
                            label.BackColor = Color.DodgerBlue;
                        }
                        if (board[i, j] == 1024)
                        {
                            label.BackColor = Color.Cornsilk;
                        }
                        if (board[i, j] == 2048)
                        {
                            label.BackColor = Color.Lavender;
                        }
                    }
                }
            }
            score.Text = game.getScore().ToString();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            int[,] tab = new int[4, 4];
            board = tab;
            game = new Game2048(board);
            game.initBoard();
            showBoard();
        }

        private void up_Click(object sender, EventArgs e)
        {
            game.moveLeft();
            game.addRandom();
            game.drawBoard();
            showBoard();
            check();

        }

        private void left_Click(object sender, EventArgs e)
        {
            game.moveUp();
            game.addRandom();
            check();
            game.drawBoard();
            showBoard();
        }

        private void right_Click(object sender, EventArgs e)
        {
            game.moveDown();
            game.addRandom();
            game.drawBoard();
            showBoard();
            check();

        }

        private void down_Click(object sender, EventArgs e)
        {
            game.moveRight();
            game.addRandom();
           //
            game.drawBoard();
            showBoard();
            check();

        }

        private void check()
        {
            if (game.gameEnded())
            {
                String s = "Game over";
                MessageBox.Show(s);
                return;
            }
            if (game.gameFinished())
            {
                String s = "You won!";
                MessageBox.Show(s);
            }

        }

    }
}
