using System.Windows.Forms;
namespace TP_Aula03
{
    public partial class TicTacToe : Form
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {

        }

        public string jogador1 = "X";
        public string jogador2 = "O";
        public int clicks = 0;
        public string[,] board = new string[3, 3];

        public string[] posicao = new string[3];
        public bool winner;




        public void btn1_Click(object sender, EventArgs e)
        {
            if (clicks % 2 == 0)
            {
                btn1.Text = jogador1;
                board[0, 0] = jogador1;
            }
            else
            {
                btn1.Text = jogador2;
                board[0, 0] = jogador2;
            }

            CheckWinDiag();
            CheckWinHorizVert();

            clicks++;
            CheckTie();

        }

        public void btn2_Click(object sender, EventArgs e)
        {
            if (clicks % 2 == 0)
            {
                btn2.Text = jogador1;
                board[0, 1] = jogador1;
            }
            else
            {
                btn2.Text = jogador2;
                board[0, 1] = jogador2;
            }

            CheckWinDiag();
            CheckWinHorizVert();

            clicks++;
            CheckTie();

        }

        public void btn3_Click(object sender, EventArgs e)
        {
            if (clicks % 2 == 0)
            {
                btn3.Text = jogador1;
                board[0, 2] = jogador1;

            }
            else
            {
                btn3.Text = jogador2;
                board[0, 2] = jogador2;
            }


            CheckWinDiag();
            CheckWinHorizVert();

            clicks++;
            CheckTie();

        }

        public void btn4_Click(object sender, EventArgs e)
        {
            if (clicks % 2 == 0)
            {
                btn4.Text = jogador1;
                board[1, 0] = jogador1;
            }
            else
            {
                btn4.Text = jogador2;
                board[1, 0] = jogador2;
            }


            CheckWinDiag();
            CheckWinHorizVert();

            clicks++;
            CheckTie();

        }

        public void btn5_Click(object sender, EventArgs e)
        {
            if (clicks % 2 == 0)
            {
                btn5.Text = jogador1;
                board[1, 1] = jogador1;
            }
            else
            {
                btn5.Text = jogador2;
                board[1, 1] = jogador2;
            }


            CheckWinDiag();
            CheckWinHorizVert();

            clicks++;
            CheckTie();

        }

        public void btn6_Click(object sender, EventArgs e)
        {
            if (clicks % 2 == 0)
            {
                btn6.Text = jogador1;
                board[1, 2] = jogador1;
            }
            else
            {
                btn6.Text = jogador2;
                board[1, 2] = jogador2;
            }

            CheckWinDiag();
            CheckWinHorizVert();

            clicks++;
            CheckTie();

        }

        public void btn7_Click(object sender, EventArgs e)
        {
            if (clicks % 2 == 0)
            {
                btn7.Text = jogador1;
                board[2, 0] = jogador1;
            }
            else
            {
                btn7.Text = jogador2;
                board[2, 0] = jogador2;
            }


            CheckWinDiag();
            CheckWinHorizVert();

            clicks++;
            CheckTie();

        }

        public void btn8_Click(object sender, EventArgs e)
        {
            if (clicks % 2 == 0)
            {
                btn8.Text = jogador1;
                board[2, 1] = jogador1;
            }
            else
            {
                btn8.Text = jogador2;
                board[2, 1] = jogador2;
            }


            CheckWinDiag();
            CheckWinHorizVert();

            clicks++;
            CheckTie();

        }

        public void btn9_Click(object sender, EventArgs e)
        {
            if (clicks % 2 == 0)
            {
                btn9.Text = jogador1;
                board[2, 2] = jogador1;
            }
            else
            {
                btn9.Text = jogador2;
                board[2, 2] = jogador2;
            }

            CheckWinDiag();
            CheckWinHorizVert();

            clicks++;
            CheckTie();

        }

        public void CheckWinHorizVert()
        {
            ClearPosicao();
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    posicao[coluna] = board[linha, coluna];
                }

                if (posicao[0] == posicao[1] && posicao[1] == posicao[2] && posicao[0] == "X")
                {
                    MessageBox.Show("Parabéns, jogador 1! Você venceu horizontalmente");
                    winner = true;
                    clicks = 0;
                    ClearBoard();
                    break;
                }
                else if (posicao[0] == posicao[1] && posicao[1] == posicao[2] && posicao[0] == "O")
                {
                    MessageBox.Show("Parabéns, jogador 2! Você venceu horizontalmente");
                    winner = true;
                    clicks = 0;
                    ClearBoard();
                    break;
                }
            }

            ClearPosicao();
            for (int coluna = 0; coluna < 3; coluna++)
            {
                for (int linha = 0; linha < 3; linha++)
                {
                    posicao[linha] = board[linha, coluna];
                }

                if (posicao[0] == posicao[1] && posicao[1] == posicao[2] && posicao[0] == "X")
                {
                    MessageBox.Show("Parabéns, jogador 1! Você venceu verticalmente");
                    winner = true;
                    clicks = 0;
                    ClearBoard();
                    break;
                }
                else if (posicao[0] == posicao[1] && posicao[1] == posicao[2] && posicao[0] == "O")
                {
                    MessageBox.Show("Parabéns, jogador 2! Você venceu verticalmente");
                    winner = true;
                    clicks = 0;
                    ClearBoard();
                    break;
                }
            }
        }

        public void CheckWinDiag()
        {
            ClearPosicao();
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    if (linha == coluna)
                    {
                        posicao[coluna] = board[linha, coluna];
                    }
                }

                if (posicao[0] == posicao[1] && posicao[1] == posicao[2] && posicao[0] == "X")
                {
                    MessageBox.Show("Parabéns, jogador 1! Você venceu pela diagonal principal");
                    winner = true;
                    clicks = 0;
                    ClearBoard();
                    break;
                }
                else if (posicao[0] == posicao[1] && posicao[1] == posicao[2] && posicao[0] == "O")
                {
                    MessageBox.Show("Parabéns, jogador 2! Você venceu pela diagonal principal");
                    winner = true;
                    clicks = 0;
                    ClearBoard();
                    break;
                }
            }

            ClearPosicao();
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    if (linha == 3 - coluna - 1)
                    {
                        posicao[coluna] = board[linha, coluna];
                    }
                }

                if (posicao[0] == posicao[1] && posicao[1] == posicao[2] && posicao[0] == "X"
                    && posicao[1] == "X" && posicao[2] == "X")
                {
                    MessageBox.Show("Parabéns, jogador 1! Você venceu pela diagonal secundária");
                    winner = true;
                    clicks = 0;
                    ClearBoard();
                    break;
                }
                else if (posicao[0] == posicao[1] && posicao[1] == posicao[2] && posicao[0] == "O"
                    && posicao[1] == "O" && posicao[2] == "O")
                {
                    MessageBox.Show("Parabéns, jogador 2! Você venceu pela diagonal secundária");
                    winner = true;
                    clicks = 0;
                    ClearBoard();
                    break;
                }
            }
        }

        public void CheckTie()
        {
            if (!winner && clicks == 9)
            {
                MessageBox.Show("Deu velha!");
                ClearBoard();
                ClearPosicao();
                clicks = 0;
            }
        }


        public void ClearBoard()
        {
            Array.Clear(board);
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
        }

        public void ClearPosicao()
        {
            Array.Clear(posicao);
        }


    }
}
