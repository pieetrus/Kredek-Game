using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Funkcja inicjalizująca okno
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            GameOver.Visible = false;
            ShopLabel.Visible = false;
            ski1.Visible = false;
        }
        /// <summary>
        /// Funkcja timera odpowiadająca za czynności wykonywane cyklicznie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         int gamespeed = 20; //zmienna określająca prędkość gry
        private void timer1_Tick(object sender, EventArgs e)
        {
            gamespeedLabel.Text = "Prędkość: " + gamespeed.ToString();
            flague(gamespeed);
            gameover();
            crayon(gamespeed);
            crayoncollections();
        }
        /// <summary>
        /// Funkcja decydująca kiedy będzie koniec gry
        /// </summary>
        bool isItOver = false; // zmienna informująca czy gra jest w toku, czy nastąpiła porażka
        void gameover()
        {
            if (character == 0)
            {
                if (ski.Bounds.IntersectsWith(flague1.Bounds))
                {
                    timer1.Enabled = false;
                    GameOver.Visible = true;
                    ExitButton.Visible = true;
                    NewGameButton.Visible = true;
                    isItOver = true;
                }

                if (ski.Bounds.IntersectsWith(flague2.Bounds))
                {
                    timer1.Enabled = false;
                    GameOver.Visible = true;
                    ExitButton.Visible = true;
                    NewGameButton.Visible = true;
                    isItOver = true;
                }

                if (ski.Bounds.IntersectsWith(flague3.Bounds))
                {
                    timer1.Enabled = false;
                    GameOver.Visible = true;
                    ExitButton.Visible = true;
                    NewGameButton.Visible = true;
                    isItOver = true;
                }
            }

            if (character == 1)
            {
                if (ski1.Bounds.IntersectsWith(flague1.Bounds))
                {
                    timer1.Enabled = false;
                    GameOver.Visible = true;
                    ExitButton.Visible = true;
                    NewGameButton.Visible = true;
                    isItOver = true;
                }

                if (ski1.Bounds.IntersectsWith(flague2.Bounds))
                {
                    timer1.Enabled = false;
                    GameOver.Visible = true;
                    ExitButton.Visible = true;
                    NewGameButton.Visible = true;
                    isItOver = true;
                }

                if (ski1.Bounds.IntersectsWith(flague3.Bounds))
                {
                    timer1.Enabled = false;
                    GameOver.Visible = true;
                    ExitButton.Visible = true;
                    NewGameButton.Visible = true;
                    isItOver = true;
                }
            }

            if (character == 2)
            {
                if (ski2.Bounds.IntersectsWith(flague1.Bounds))
                {
                    timer1.Enabled = false;
                    GameOver.Visible = true;
                    ExitButton.Visible = true;
                    NewGameButton.Visible = true;
                    isItOver = true;
                }

                if (ski2.Bounds.IntersectsWith(flague2.Bounds))
                {
                    timer1.Enabled = false;
                    GameOver.Visible = true;
                    ExitButton.Visible = true;
                    NewGameButton.Visible = true;
                    isItOver = true;
                }

                if (ski2.Bounds.IntersectsWith(flague3.Bounds))
                {
                    timer1.Enabled = false;
                    GameOver.Visible = true;
                    ExitButton.Visible = true;
                    NewGameButton.Visible = true;
                    isItOver = true;
                }
            }

            if (character == 3)
            {
                if (ski3.Bounds.IntersectsWith(flague1.Bounds))
                {
                    timer1.Enabled = false;
                    GameOver.Visible = true;
                    ExitButton.Visible = true;
                    NewGameButton.Visible = true;
                    isItOver = true;
                }

                if (ski3.Bounds.IntersectsWith(flague2.Bounds))
                {
                    timer1.Enabled = false;
                    GameOver.Visible = true;
                    ExitButton.Visible = true;
                    NewGameButton.Visible = true;
                    isItOver = true;
                }

                if (ski3.Bounds.IntersectsWith(flague3.Bounds))
                {
                    timer1.Enabled = false;
                    GameOver.Visible = true;
                    ExitButton.Visible = true;
                    NewGameButton.Visible = true;
                    isItOver = true;
                }
            }
        }

        Random rand = new Random();//deklaracja generatora zmiennych losowych
        int x, y = 0; //współrzędne w oknie
        /// <summary>
        /// Funkcja generująca pojawiające się przeszkody, czyli w tym wypadku flagi
        /// </summary>
        /// <param name="speed"></param>
        void flague(int speed)
        {
            if(flague1.Top >= 500)
            {
                x = rand.Next(16, 120);
                flague1.Location = new Point(x, 0);
            }
            else
            {
                flague1.Top += speed;
            }

            if (flague2.Top >= 500)
            {
                x = rand.Next(150, 260);
                flague2.Location = new Point(x, 0);
            }
            else
            {
                flague2.Top += speed;
            }

            if (flague3.Top >= 500)
            {
                x = rand.Next(280, 330);
                flague3.Location = new Point(x, 0);
            }
            else
            {
                flague3.Top += speed;
            }
        }
        /// <summary>
        /// Funkcja generująca kredki na planszy
        /// </summary>
        /// <param name="speed"></param>
        int CrayonsCollected = 0; //budżet kredek
        void crayon(int speed)
        {
            if (crayon1.Top >= 500)
            {
                x = rand.Next(16, 120);
                crayon1.Location = new Point(x, 0);
            }
            else
            {
                crayon1.Top += speed;
            }

            if (crayon2.Top >= 500)
            {
                x = rand.Next(150, 250);
                crayon2.Location = new Point(x, 0);
            }
            else
            {
                crayon2.Top += speed;
            }

            if (crayon3.Top >= 500)
            {
                x = rand.Next(270, 320);
                crayon3.Location = new Point(x, 0);
            }
            else
            {
                crayon3.Top += speed;
            }
        }
        /// <summary>
        /// Funkcja odpowiadająca za reakcję na wjechanie postaci na kredkę i dodawanie jej do budżetu
        /// </summary>
        void crayoncollections()
        {
            if (character == 0)
            {
                if (ski.Bounds.IntersectsWith(crayon1.Bounds))
                {
                    CrayonsCollected++;
                    CrayonAmountDisplay.Text = CrayonsCollected.ToString();
                    x = rand.Next(16, 120);
                    crayon1.Location = new Point(x, 0);
                }

                if (ski.Bounds.IntersectsWith(crayon2.Bounds))
                {
                    CrayonsCollected++;
                    CrayonAmountDisplay.Text = CrayonsCollected.ToString();
                    x = rand.Next(150, 250);
                    crayon2.Location = new Point(x, 0);
                }

                if (ski.Bounds.IntersectsWith(crayon3.Bounds))
                {
                    CrayonsCollected++;
                    CrayonAmountDisplay.Text = CrayonsCollected.ToString();
                    x = rand.Next(270, 320);
                    crayon3.Location = new Point(x, 0);
                }
            }

            if (character == 1)
            {
                if (ski1.Bounds.IntersectsWith(crayon1.Bounds))
                {
                    CrayonsCollected++;
                    CrayonAmountDisplay.Text = CrayonsCollected.ToString();
                    x = rand.Next(16, 120);
                    crayon1.Location = new Point(x, 0);
                }

                if (ski1.Bounds.IntersectsWith(crayon2.Bounds))
                {
                    CrayonsCollected++;
                    CrayonAmountDisplay.Text = CrayonsCollected.ToString();
                    x = rand.Next(150, 250);
                    crayon2.Location = new Point(x, 0);
                }

                if (ski1.Bounds.IntersectsWith(crayon3.Bounds))
                {
                    CrayonsCollected++;
                    CrayonAmountDisplay.Text = CrayonsCollected.ToString();
                    x = rand.Next(270, 320);
                    crayon3.Location = new Point(x, 0);
                }
            }

            if (character == 2)
            {
                if (ski2.Bounds.IntersectsWith(crayon1.Bounds))
                {
                    CrayonsCollected++;
                    CrayonAmountDisplay.Text = CrayonsCollected.ToString();
                    x = rand.Next(16, 120);
                    crayon1.Location = new Point(x, 0);
                }

                if (ski2.Bounds.IntersectsWith(crayon2.Bounds))
                {
                    CrayonsCollected++;
                    CrayonAmountDisplay.Text = CrayonsCollected.ToString();
                    x = rand.Next(150, 250);
                    crayon2.Location = new Point(x, 0);
                }

                if (ski2.Bounds.IntersectsWith(crayon3.Bounds))
                {
                    CrayonsCollected++;
                    CrayonAmountDisplay.Text = CrayonsCollected.ToString();
                    x = rand.Next(270, 320);
                    crayon3.Location = new Point(x, 0);
                }
            }

            if (character == 3)
            {
                if (ski3.Bounds.IntersectsWith(crayon1.Bounds))
                {
                    CrayonsCollected++;
                    CrayonAmountDisplay.Text = CrayonsCollected.ToString();
                    x = rand.Next(16, 120);
                    crayon1.Location = new Point(x, 0);
                }

                if (ski3.Bounds.IntersectsWith(crayon2.Bounds))
                {
                    CrayonsCollected++;
                    CrayonAmountDisplay.Text = CrayonsCollected.ToString();
                    x = rand.Next(150, 250);
                    crayon2.Location = new Point(x, 0);
                }

                if (ski3.Bounds.IntersectsWith(crayon3.Bounds))
                {
                    CrayonsCollected++;
                    CrayonAmountDisplay.Text = CrayonsCollected.ToString();
                    x = rand.Next(270, 320);
                    crayon3.Location = new Point(x, 0);
                }
            }
        }

        /// <summary>
        /// Funkcja sterowania postacią w prawo, w lewo, oraz przyspieszanie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        int character = 0; // zmienna informująca którą postacią gra teraz gracz
        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (character == 0)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (ski.Left > 20)//zapobiega wyjściu poza plansze
                        ski.Left += -6;
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (ski.Left < 330) //zapobiega wyjściu poza plansze
                        ski.Left += 6;
                }

                if (e.KeyCode == Keys.Up)
                {
                    if (gamespeed < 60)
                    { gamespeed++; }
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (gamespeed > 0)
                    { gamespeed--; }
                }
            }

            if (character == 1)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (ski1.Left > 20)//zapobiega wyjściu poza plansze
                        ski1.Left += -6;
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (ski1.Left < 330) //zapobiega wyjściu poza plansze
                        ski1.Left += 6;
                }

                if (e.KeyCode == Keys.Up)
                {
                    if (gamespeed < 60)
                    { gamespeed++; }
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (gamespeed > 0)
                    { gamespeed--; }
                }
            }

            if (character == 2)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (ski2.Left > 20)//zapobiega wyjściu poza plansze
                        ski2.Left += -6;
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (ski2.Left < 330) //zapobiega wyjściu poza plansze
                        ski2.Left += 6;
                }

                if (e.KeyCode == Keys.Up)
                {
                    if (gamespeed < 60)
                    { gamespeed++; }
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (gamespeed > 0)
                    { gamespeed--; }
                }
            }

            if (character == 3)
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (ski3.Left > 20)//zapobiega wyjściu poza plansze
                        ski3.Left += -6;
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (ski3.Left < 330) //zapobiega wyjściu poza plansze
                        ski3.Left += 6;
                }

                if (e.KeyCode == Keys.Up)
                {
                    if (gamespeed < 60)
                    { gamespeed++; }
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (gamespeed > 0)
                    { gamespeed--; }
                }
            }



            if (isItOver == false)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    ExitButton.Visible = true;
                    ExitButton.Location = new Point(250, 380);
                    crayon1.Visible = false;
                    crayon2.Visible = false;
                    crayon3.Visible = false;
                    flague1.Visible = false;
                    flague2.Visible = false;
                    flague3.Visible = false;
                    timer1.Enabled = false;
                    shop(true);

                }


                if (e.KeyCode == Keys.Space)
                {
                    ExitButton.Location = new Point(220, 240);
                    ExitButton.Visible = false;
                    crayon1.Visible = true;
                    crayon2.Visible = true;
                    crayon3.Visible = true;
                    flague1.Visible = true;
                    flague2.Visible = true;
                    flague3.Visible = true;
                    timer1.Enabled = true;
                    shop(false);

                }
            }

        }

        /// <summary>
        /// Funkcja obsługi sklepu
        /// </summary>
        /// <param name="visibility"></param>
        void shop(bool visibility)
        {
            if (visibility == false)
            {
                ShopLabel.Visible = false;
                dialogLabel.Visible = false;
                shop1.Visible = false;
                shop2.Visible = false;
                shop3.Visible = false;
                skii1.Visible = false;
                skii2.Visible = false;
                skii3.Visible = false;
                if (character == 0)
                {
                    if (ski.Bounds.IntersectsWith(crayon1.Bounds))
                    {
                        CrayonsCollected++;
                        CrayonAmountDisplay.Text = CrayonsCollected.ToString();
                        x = rand.Next(16, 120);
                        crayon1.Location = new Point(x, 0);
                    }

                    if (ski.Bounds.IntersectsWith(crayon2.Bounds))
                    {
                        CrayonsCollected++;
                        CrayonAmountDisplay.Text = CrayonsCollected.ToString();
                        x = rand.Next(150, 250);
                        crayon2.Location = new Point(x, 0);
                    }

                    if (ski.Bounds.IntersectsWith(crayon3.Bounds))
                    {
                        CrayonsCollected++;
                        CrayonAmountDisplay.Text = CrayonsCollected.ToString();
                        x = rand.Next(270, 320);
                        crayon3.Location = new Point(x, 0);
                    }
                }
            }


            if (visibility == true)
            {
                ShopLabel.Visible = true;
                dialogLabel.Visible = true;
                shop1.Visible = true;
                shop2.Visible = true;
                shop3.Visible = true;
                skii1.Visible = true;
                skii2.Visible = true;
                skii3.Visible = true;
            }

        }
        /// <summary>
        /// Funkcja obsługująca zakup postaci nr 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ski1_Click(object sender, EventArgs e)
        {
            if(CrayonsCollected >= 10)
            {
                ski.Visible = false;
                ski2.Visible = false;
                ski3.Visible = false;
                ski1.Visible = true;
                character = 1;
                CrayonsCollected = CrayonsCollected - 10;
            }

            else
            {
                MessageBox.Show("Nie masz wystarczającej ilości kredek aby zakupić tą postać!");
            }
        }

        /// <summary>
        /// Funkcja obsługująca zakup postaci nr 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skii2_Click(object sender, EventArgs e)
        {
            if (CrayonsCollected >= 20)
            {
                character = 2;
                ski.Visible = false;
                ski1.Visible = false;
                ski2.Visible = true;
                ski3.Visible = false;
                CrayonsCollected = CrayonsCollected - 20;
            }

            else
            {
                MessageBox.Show("Nie masz wystarczającej ilości kredek aby zakupić tą postać!");
            }
        }
        /// <summary>
        /// Funkcja obsługująca zakup postaci nr 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skii3_Click(object sender, EventArgs e)
        {
            if (CrayonsCollected >= 40)
            {
                character = 3;
                ski.Visible = false;
                ski1.Visible = false;
                ski2.Visible = false;
                ski3.Visible = true;
                CrayonsCollected = CrayonsCollected - 40;
            }

            else
            {
                MessageBox.Show("Nie masz wystarczającej ilości kredek aby zakupić tą postać!");
            }
        }
        /// <summary>
        /// Funkcja obsługująca reakcję gry na naciśnięcie przycisku nowej gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            isItOver = false;
            timer1.Enabled = true;
            GameOver.Visible = false;
            ExitButton.Visible = false;
            NewGameButton.Visible = false;
            /////////nowa lokalizacja flag//////
            x = rand.Next(30, 170);
            flague1.Location = new Point(x, 218);
            x = rand.Next(130, 200);
            flague2.Location = new Point(x, 119);
            x = rand.Next(250, 410);
            flague3.Location = new Point(x, 259);
            /////////nowa lokalizacja kredek/////
            x = rand.Next(115, 250);
            crayon1.Location = new Point(x, 240);
            x = rand.Next(200, 250);
            crayon2.Location = new Point(x, 275);
            x = rand.Next(300, 390);
            crayon3.Location = new Point(x, 361);

        }
        /// <summary>
        /// Funkcja obsługująca reakcję gry na na wciśnięcie przycisku ExiT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
