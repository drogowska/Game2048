using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2048
{
    class Game2048
    {
        private int[,] board;// = new int[4,4];
        private int SIZE = 4;
        private int score;
        private Random rnd = new Random();

        public int getScore() 
        {
            return score;
        }

        public Game2048(int[,] arr) {
            board = arr;
            score = 0; 
            //boardInit();
        }
        private int findTarget(int[] array, int x, int stop)
        {
            int t;
            // if the position is already on the first, don't evaluate
            if (x == 0)
            {
                return x;
            }
            for (t = x - 1; ; t--)
            {
                if (array[t] != 0)
                {
                    if (array[t] != array[x])
                    {
                        // merge is not possible, take next position
                        return t + 1;
                    }
                    return t;
                }
                else
                {
                    // we should not slide further, return this one
                    if (t == stop)
                    {
                        return t;
                    }
                }
            }
            // we did not find a
            return x;
        }

        private void rotateBoard()
        {
            int i, j, n = SIZE;
            int tmp;
            for (i = 0; i < n / 2; i++)
            {
                for (j = i; j < n - i - 1; j++)
                {
                    tmp = board[i,j];
                    board[i,j] = board[j,(n - i - 1)];
                    board[j,(n - i - 1)] = board[(n - i - 1),(n - j - 1)];
                    board[(n - i - 1),(n - j - 1)] = board[(n - j - 1),i];
                    board[(n - j - 1),i] = tmp;
                }
            }
        }
        public void addRandom()
        {
            int x, y;
            int r, len = 0;
            int[] n = new int[] { 2, 4 };
            int[,] list = new int[16,2];

            for (x = 0; x < SIZE; x++)
            {
                for (y = 0; y < SIZE; y++)
                {
                    if (board[x,y] == 0)
                    {
                        list[len,0] = x;
                        list[len,1] = y;
                        len++;
                    }
                }
            }

            if (len > 0)
            {
                r = rnd.Next() % len;
                x = list[r,0];
                y = list[r,1];
                int i = rnd.Next();
                board[x,y] = n[i % 2];
            }
        }

        public bool gameFinished()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (board[i, j] == 2048) return true;
                }
            }
            return false;
        }
        public bool gameEnded()
        {
            bool ended = true;
            if (countEmpty() > 0) return false;
            if (findPairDown(board)) return false;
            rotateBoard();
            if (findPairDown(board)) ended = false;
            rotateBoard();
            rotateBoard();
            rotateBoard();
            return ended;
        }

        public int countEmpty()
        {
            int x, y;
            int count = 0;
            for (x = 0; x < SIZE; x++)
            {
                for (y = 0; y < SIZE; y++)
                {
                    if (board[x,y] == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        bool findPairDown(int[,] board)
        {
            bool success = false;
            int x, y;
            for (x = 0; x < SIZE; x++)
            {
                for (y = 0; y < SIZE - 1; y++)
                {
                    if (board[x,y] == board[x,y + 1]) return true;
                }
            }
            return success;
        }

        public void initBoard()
        {
            int x, y;
            for (x = 0; x < SIZE; x++)
            {
                for (y = 0; y < SIZE; y++)
                {
                    board[x,y] = 0;
                }
            }
            addRandom();
            addRandom();
            score = 0;
        }
        public void drawBoard()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(board[i, j]);

                }
                Console.WriteLine();
            }

        }

        void right()
        {
            int iter = 3;
            do
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 3; j > 0; j--)
                    {
                        if (board[j, i] == 0)
                        {
                            board[j, i] = board[j - 1, i];
                            board[j - 1, i] = 0;
                        }
                    }
                }
                iter--;
            } while (iter != 0);
        }

        public void moveRight()
        {
            right();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 3; j > 0; j--)
                {
                    if (board[j, i] == board[j - 1, i])
                    {
                        board[j, i] += board[j - 1, i];
                        board[j - 1, i] = 0;
                        score += board[j, i];
                    }
                }
            }
            right();
        }

        void left()
        {
            int iter = 3;
            do
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[j, i] == 0)
                        {
                            board[j, i] = board[j + 1, i];
                            board[j + 1, i] = 0;
                        }
                    }
                }
                iter--;
            } while (iter != 0);
        }

        public void moveLeft()
        {
            left();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[j, i] == board[j + 1, i])
                    {
                        board[j, i] += board[j + 1, i];
                        board[j + 1, i] = 0;
                        score += board[j, i];
                    }
                }
            }
            left();
        }

        void down()
        {
            int iter = 3;
            do
            {
                for (int i = 3; i > 0; i--)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (board[j, i] == 0)
                        {
                            board[j, i] = board[j, i - 1];
                            board[j, i - 1] = 0;

                        }
                    }
                }
                iter--;
            } while (iter != 0);
        }

        public void moveDown()
        {
            down();
            for (int i = 3; i > 0; i--)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (board[j, i] == board[j, i - 1])
                    {
                        board[j, i] += board[j, i - 1];
                        board[j, i - 1] = 0;
                        score += board[j, i];
                    }
                }
            }
            down();
        }

        void up()
        {
            int iter = 3;
            do
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (board[j, i] == 0)
                        {
                            board[j, i] = board[j, i + 1];
                            board[j, i + 1] = 0;
                        }
                    }
                }
                iter--;
            } while (iter != 0);
        }

        public void moveUp()
        {
            up();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (board[j, i] == board[j, i + 1])
                    {
                        board[j, i] += board[j, i + 1];
                        board[j, i + 1] = 0;
                        score += board[j, i];
                    }
                }
            }
            up();
        }



    }
}
