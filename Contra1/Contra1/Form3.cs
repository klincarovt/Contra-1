using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contra1
{
    public partial class Form3 : Form
    {
        bool right;
        bool left;
        bool jump;
        bool goUP;
        int counter = 0;
        bool dead;

        int G = 25;
        int Force;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {



        }
        Random random = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Side Collision
            if (player.Right > block.Left && player.Left < block.Right - player.Width / 2 && player.Bottom > block.Top && player.Top < block.Bottom﻿)
            {
                right = false;
            }
            if (player.Left < block.Right && player.Right > block.Left + player.Width / 2 && player.Bottom > block.Top && player.Top < block.Bottom﻿)
            {
                left = false;
            }
            //SIDE BLOCK 1 block1
            if (player.Right > block1.Left && player.Left < block1.Right - player.Width / 2 && player.Bottom > block1.Top && player.Top < block1.Bottom﻿)
            {
                right = false;
            }
            if (player.Left < block1.Right && player.Right > block1.Left + player.Width / 2 && player.Bottom > block1.Top && player.Top < block1.Bottom﻿)
            {
                left = false;
            }

            if (player.Right > screen.Right)
            {
                right = false;
            }
            if (player.Left < screen.Left)
            {
                left = false;
            }

            if (right == true) { player.Left += 5; }
            if (left == true) { player.Left -= 5; }
            if (jump == true)
            {
                //Falling
                player.Top -= Force;
                Force -= 2;
            }
            if (player.Top + player.Height >= screen.Height)
            {
                player.Top = screen.Height - player.Height;//Stop falling at bottom
                jump = false;
            }
            else
            {
                player.Top += 3;//Falling
            }

            //Top Collision BLOCK
            if (player.Left + player.Width > block.Left && player.Left + player.Width < block.Left + block.Width + player.Width && player.Top + player.Height >= block.Top && player.Top < block.Top)
            {
                jump = false;
                Force = 0;
                player.Top = block.Location.Y - player.Height;

            }
            if (player.Left + player.Width > block.Left && player.Left + player.Width < block.Left + block.Width + player.Width && player.Top - block.Bottom <= 10 && player.Top - block.Top > -10)
            {
                Force = -1;
            }
            //Top Collision BLOCK1 block1

            if (player.Left + player.Width > block1.Left && player.Left + player.Width < block1.Left + block1.Width + player.Width && player.Top + player.Height >= block1.Top && player.Top < block1.Top)
            {
                jump = false;
                Force = 0;
                player.Top = block1.Location.Y - player.Height;

            }
            if (player.Left + player.Width > block1.Left && player.Left + player.Width < block1.Left + block1.Width + player.Width && player.Top - block1.Bottom <= 10 && player.Top - block1.Top > -10)
            {
                Force = -1;
            }
            //Simple Fall block 
            if (!(player.Left + player.Width > block.Left && player.Left + player.Width < block.Left + block.Width + player.Width) && player.Top + player.Height >= block.Top && player.Top < block.Top)
            {
                jump = true;
            }
            //Simple Fall block1
            if (!(player.Left + player.Width > block1.Left && player.Left + player.Width < block1.Left + block1.Width + player.Width) && player.Top + player.Height >= block1.Top && player.Top < block1.Top)
            {
                jump = true;
            }
            //1
            if (Missle1.Visible == true)
            {

                Missle1.Top -= 5;
                //if(Missle1.)

            }
            //2
            if (Missle2.Visible == true)
            {
                Missle2.Left += 2;
                Missle2.Top -= 5;

            }
            //3
            if (Missle3.Visible == true)
            {
                Missle3.Left -= 2;
                Missle3.Top -= 5;

            }
            //Block 
            //Missle 1 collision block
            if (Missle1.Left + Missle1.Width > block.Left && Missle1.Left + Missle1.Width < block.Left + block.Width + Missle1.Width && Missle1.Top + Missle1.Height >= block.Top && Missle1.Top < block.Top || Missle1.Left + Missle1.Width > block1.Left && Missle1.Left + Missle1.Width < block1.Left + block1.Width + Missle1.Width && Missle1.Top + Missle1.Height >= block1.Top && Missle1.Top < block1.Top)
            {
                Missle1.Visible = false;

            }
            //Missle 2 collision block
            if (Missle2.Left + Missle2.Width > block.Left && Missle2.Left + Missle2.Width < block.Left + block.Width + Missle2.Width && Missle2.Top + Missle2.Height >= block.Top && Missle2.Top < block.Top || Missle2.Left + Missle2.Width > block1.Left && Missle2.Left + Missle2.Width < block1.Left + block1.Width + Missle2.Width && Missle2.Top + Missle2.Height >= block1.Top && Missle2.Top < block1.Top)
            {
                Missle2.Visible = false;

            }
            //Missle 3 collision block
            if (Missle3.Left + Missle3.Width > block.Left && Missle3.Left + Missle3.Width < block.Left + block.Width + Missle3.Width && Missle3.Top + Missle3.Height >= block.Top && Missle3.Top < block.Top || Missle3.Left + Missle3.Width > block1.Left && Missle3.Left + Missle3.Width < block1.Left + block1.Width + Missle3.Width && Missle3.Top + Missle3.Height >= block1.Top && Missle3.Top < block1.Top)
            {
                Missle3.Visible = false;

            }

            //Missle Enemy1 Missle1 collision
            if (Missle1.Left + Missle1.Width > Enemy1.Left && Missle1.Left + Missle1.Width < Enemy1.Left + Enemy1.Width + Missle1.Width && Missle1.Top + Missle1.Height >= Enemy1.Top && Missle1.Top < Enemy1.Top)
            {
                Enemy1.Visible = false;
                Missle1.Visible = false;
                EnemyShoot4.Visible = false;
                EnemyShoot1.Visible = false;

                counter += 10;
            }
            //Missle Enemy1 MIssle 2 collision
            else if (Missle2.Left + Missle2.Width > Enemy1.Left && Missle2.Left + Missle2.Width < Enemy1.Left + Enemy1.Width + Missle2.Width && Missle2.Top + Missle2.Height >= Enemy1.Top && Missle2.Top < Enemy1.Top)
            {
                Enemy1.Visible = false;
                Missle2.Visible = false;
                EnemyShoot4.Visible = false;
                EnemyShoot1.Visible = false;


                counter += 1;
            }
            //Missle Enemy1 Missle 3 collision
            else if (Missle3.Left + Missle3.Width > Enemy1.Left && Missle3.Left + Missle3.Width < Enemy1.Left + Enemy1.Width + Missle3.Width && Missle3.Top + Missle3.Height >= Enemy1.Top && Missle3.Top < Enemy1.Top)
            {
                Enemy1.Visible = false;
                Missle3.Visible = false;
                EnemyShoot4.Visible = false;
                EnemyShoot1.Visible = false;

                counter += 1;
            }

            //Enemy2 2 Missle collision
            if (Missle1.Left + Missle1.Width > Enemy2.Left && Missle1.Left + Missle1.Width < Enemy2.Left + Enemy2.Width + Missle1.Width && Missle1.Top + Missle1.Height >= Enemy2.Top && Missle1.Top < Enemy2.Top)
            {
                Enemy2.Visible = false;
                Missle1.Visible = false;
                EnemyShoot2.Visible = false;
                EnemyShoot5.Visible = false;

                counter += 1;
            }
            //Missle Enemy2 MIssle 2 collision
            else if (Missle2.Left + Missle2.Width > Enemy2.Left && Missle2.Left + Missle2.Width < Enemy2.Left + Enemy2.Width + Missle2.Width && Missle2.Top + Missle2.Height >= Enemy2.Top && Missle2.Top < Enemy2.Top)
            {
                Enemy2.Visible = false;
                Missle2.Visible = false;
                EnemyShoot2.Visible = false;
                EnemyShoot5.Visible = false;

                counter += 1;
            }
            //Missle Enemy2 Missle 3 collision
            else if (Missle3.Left + Missle3.Width > Enemy2.Left && Missle3.Left + Missle3.Width < Enemy2.Left + Enemy2.Width + Missle3.Width && Missle3.Top + Missle3.Height >= Enemy2.Top && Missle3.Top < Enemy2.Top)
            {
                Enemy2.Visible = false;
                Missle3.Visible = false;
                EnemyShoot2.Visible = false;
                EnemyShoot5.Visible = false;

                counter += 1;
            }


            //Enemy3  Missle collision
            if (Missle1.Left + Missle1.Width > Enemy3.Left && Missle1.Left + Missle1.Width < Enemy3.Left + Enemy3.Width + Missle1.Width && Missle1.Top + Missle1.Height >= Enemy3.Top && Missle1.Top < Enemy3.Top)
            {
                Enemy3.Visible = false;
                Missle1.Visible = false;
                EnemyShoot3.Visible = false;
                EnemyShoot6.Visible = false;

                counter += 1;

            }
            //Missle Enemy2 MIssle 2 collision
            else if (Missle2.Left + Missle2.Width > Enemy3.Left && Missle2.Left + Missle2.Width < Enemy3.Left + Enemy3.Width + Missle2.Width && Missle2.Top + Missle2.Height >= Enemy3.Top && Missle2.Top < Enemy3.Top)
            {
                Enemy3.Visible = false;
                Missle2.Visible = false;
                EnemyShoot3.Visible = false;
                EnemyShoot6.Visible = false;


                counter += 1;

            }
            //Missle Enemy2 Missle 3 collision
            else if (Missle3.Left + Missle3.Width > Enemy3.Left && Missle3.Left + Missle3.Width < Enemy3.Left + Enemy3.Width + Missle3.Width && Missle3.Top + Missle3.Height >= Enemy3.Top && Missle3.Top < Enemy3.Top)
            {
                Enemy3.Visible = false;
                Missle3.Visible = false;
                EnemyShoot3.Visible = false;
                EnemyShoot6.Visible = false;

                counter += 1;
            }

            if (EnemyShoot1.Visible == true)
            {
                EnemyShoot1.Top += 4;
                EnemyShoot4.Top += 4;


            }
            if (EnemyShoot2.Visible == true)
            {
                EnemyShoot2.Top += 4;
                EnemyShoot5.Top += 4;

            }
            if (EnemyShoot3.Visible == true)
            {
                EnemyShoot3.Top += 4;
                EnemyShoot6.Top += 4;

            }
            
        




            //EnemyShootCollision
            if (EnemyShoot1.Left + EnemyShoot1.Width > block.Left && EnemyShoot1.Left + EnemyShoot1.Width < block.Left + block.Width + EnemyShoot1.Width && EnemyShoot1.Top + EnemyShoot1.Height >= block.Top && EnemyShoot1.Top < block.Top || EnemyShoot1.Left + EnemyShoot1.Width > block1.Left && EnemyShoot1.Left + EnemyShoot1.Width < block1.Left + block1.Width + EnemyShoot1.Width && EnemyShoot1.Top + EnemyShoot1.Height >= block1.Top && EnemyShoot1.Top < block1.Top)
            {
                EnemyShoot1.Visible = false;
                EnemyShoot1.Left = 1;



            }
            if (EnemyShoot2.Left + EnemyShoot2.Width > block.Left && EnemyShoot2.Left + EnemyShoot2.Width < block.Left + block.Width + EnemyShoot2.Width && EnemyShoot2.Top + EnemyShoot2.Height >= block.Top && EnemyShoot2.Top < block.Top || EnemyShoot2.Left + EnemyShoot2.Width > block1.Left && EnemyShoot2.Left + EnemyShoot2.Width < block1.Left + block1.Width + EnemyShoot2.Width && EnemyShoot2.Top + EnemyShoot2.Height >= block1.Top && EnemyShoot2.Top < block1.Top)
            {
                EnemyShoot2.Visible = false;
                EnemyShoot2.Left = 1;




            }
            if (EnemyShoot3.Left + EnemyShoot3.Width > block.Left && EnemyShoot3.Left + EnemyShoot3.Width < block.Left + block.Width + EnemyShoot3.Width && EnemyShoot3.Top + EnemyShoot3.Height >= block.Top && EnemyShoot3.Top < block.Top || EnemyShoot3.Left + EnemyShoot3.Width > block1.Left && EnemyShoot3.Left + EnemyShoot3.Width < block1.Left + block1.Width + EnemyShoot3.Width && EnemyShoot3.Top + EnemyShoot3.Height >= block1.Top && EnemyShoot3.Top < block1.Top)
            {
                EnemyShoot3.Visible = false;
                EnemyShoot3.Left = 1;



            }
            if (EnemyShoot4.Left + EnemyShoot4.Width > block.Left && EnemyShoot4.Left + EnemyShoot4.Width < block.Left + block.Width + EnemyShoot4.Width && EnemyShoot4.Top + EnemyShoot4.Height >= block.Top && EnemyShoot4.Top < block.Top || EnemyShoot4.Left + EnemyShoot4.Width > block1.Left && EnemyShoot4.Left + EnemyShoot4.Width < block1.Left + block1.Width + EnemyShoot4.Width && EnemyShoot4.Top + EnemyShoot4.Height >= block1.Top && EnemyShoot4.Top < block1.Top)
            {
                EnemyShoot4.Visible = false;
                EnemyShoot4.Left = 1;


            }
            if (EnemyShoot5.Left + EnemyShoot5.Width > block.Left && EnemyShoot5.Left + EnemyShoot5.Width < block.Left + block.Width + EnemyShoot5.Width && EnemyShoot5.Top + EnemyShoot5.Height >= block.Top && EnemyShoot5.Top < block.Top || EnemyShoot5.Left + EnemyShoot5.Width > block1.Left && EnemyShoot5.Left + EnemyShoot5.Width < block1.Left + block1.Width + EnemyShoot5.Width && EnemyShoot5.Top + EnemyShoot5.Height >= block1.Top && EnemyShoot5.Top < block1.Top)
            {
                EnemyShoot5.Visible = false;
                EnemyShoot5.Left = 1;

            }



            if (EnemyShoot6.Left + EnemyShoot6.Width > block.Left && EnemyShoot6.Left + EnemyShoot6.Width < block.Left + block.Width + EnemyShoot6.Width && EnemyShoot6.Top + EnemyShoot6.Height >= block.Top && EnemyShoot6.Top < block.Top || EnemyShoot6.Left + EnemyShoot6.Width > block1.Left && EnemyShoot6.Left + EnemyShoot6.Width < block1.Left + block1.Width + EnemyShoot6.Width && EnemyShoot6.Top + EnemyShoot6.Height >= block1.Top && EnemyShoot6.Top < block1.Top)
            {
                EnemyShoot6.Visible = false;
                EnemyShoot6.Left = 1;


            }


            //EnemyShoot Collision with player

            if (player.Left + player.Width > EnemyShoot1.Left && player.Left + player.Width < EnemyShoot1.Left + EnemyShoot1.Width + player.Width && player.Top + player.Height >= EnemyShoot1.Top && player.Top < EnemyShoot1.Top
                || player.Left + player.Width > EnemyShoot2.Left && player.Left + player.Width < EnemyShoot2.Left + EnemyShoot2.Width + player.Width && player.Top + player.Height >= EnemyShoot2.Top && player.Top < EnemyShoot2.Top
                || player.Left + player.Width > EnemyShoot3.Left && player.Left + player.Width < EnemyShoot3.Left + EnemyShoot3.Width + player.Width && player.Top + player.Height >= EnemyShoot3.Top && player.Top < EnemyShoot3.Top
                || player.Left + player.Width > EnemyShoot4.Left && player.Left + player.Width < EnemyShoot4.Left + EnemyShoot4.Width + player.Width && player.Top + player.Height >= EnemyShoot4.Top && player.Top < EnemyShoot4.Top
                || player.Left + player.Width > EnemyShoot5.Left && player.Left + player.Width < EnemyShoot5.Left + EnemyShoot5.Width + player.Width && player.Top + player.Height >= EnemyShoot5.Top && player.Top < EnemyShoot5.Top
                || player.Left + player.Width > EnemyShoot6.Left && player.Left + player.Width < EnemyShoot6.Left + EnemyShoot6.Width + player.Width && player.Top + player.Height >= EnemyShoot6.Top && player.Top < EnemyShoot6.Top
               )
            {
                dead = true;


            }


            scoreLabel.Text = counter.ToString();
        }





        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right)
            {
                right = true;
                player.Image = Image.FromFile("walk_right.png");
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
                player.Image = Image.FromFile("walk_left.png");

            }
            if (e.KeyCode == Keys.Escape) { this.Close(); } //Exit
            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    Force = G;
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                goUP = true;


                player.Image = Image.FromFile("re.png");

            }
            if (e.KeyCode == Keys.Z)
            {
                //1
                Missle1.Top = player.Top;
                Missle1.Left = player.Left + 7;
                Missle1.Visible = true;

                //2
                Missle2.Top = player.Top;
                Missle2.Left = player.Left + 7;
                Missle2.Visible = true;

                //3
                Missle3.Top = player.Top;
                Missle3.Left = player.Left + 7;
                Missle3.Visible = true;
                player.Image = Image.FromFile("re.png");


            }

        }

        private void ResetPicture(PictureBox pb)
        {
            if (pb.Left >= screen.Width - pb.Width)
            {
                pb.Left = 1;


            }
        }
        private void Form3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
                player.Image = Image.FromFile("stand_right.png");
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
                player.Image = Image.FromFile("stand_left.png");

            }

        }

        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            if (Enemy1.Visible)
            {
                if (timer == 1)//random.Next(1, 2))
                {
                    EnemyShoot1.Top = Enemy1.Top + 30;
                    EnemyShoot1.Left = Enemy1.Left + 50;
                    EnemyShoot1.Visible = true;
                    EnemyShoot4.Top = Enemy1.Top + 30;
                    EnemyShoot4.Left = Enemy1.Left + 60;
                    EnemyShoot4.Visible = true;


                }

                ResetPicture(Enemy1);
                Enemy1.Left += 1;



            }
            if (Enemy2.Visible)
            {
                if (timer == 2) //random.Next(3, 4))
                {
                    EnemyShoot2.Top = Enemy2.Top + 30;
                    EnemyShoot2.Left = Enemy2.Left + 50;
                    EnemyShoot2.Visible = true;
                    EnemyShoot5.Top = Enemy2.Top + 30;
                    EnemyShoot5.Left = Enemy2.Left + 60;
                    EnemyShoot5.Visible = true;

                }
                ResetPicture(Enemy2);
                Enemy2.Left += 1;


            }
            if (Enemy3.Visible)
            {
                if (timer == 3)// random.Next(5, 6))
                {
                    EnemyShoot3.Top = Enemy3.Top + 30;
                    EnemyShoot3.Left = Enemy3.Left + 50;
                    EnemyShoot3.Visible = true;
                    EnemyShoot6.Top = Enemy3.Top + 30;
                    EnemyShoot6.Left = Enemy3.Left + 60;
                    EnemyShoot6.Visible = true;

                }


                ResetPicture(Enemy3);
                Enemy3.Left += 1;

            }


        }

        int timer;

        private void EnemyShoot_Tick(object sender, EventArgs e)
        {



            timer++;
            if (timer == 3)
            {

                if (Enemy1.Visible == false)
                {
                    Enemy1.Visible = true;
                }
                if (Enemy2.Visible == false)
                {
                    Enemy2.Visible = true;
                }
                if (Enemy3.Visible == false)
                {
                    Enemy3.Visible = true;
                }
                timer = 1;
            }

        }




        private void scoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void deathTimer_Tick(object sender, EventArgs e)
        {
            if (dead == true)
            {
                if (Visible == true)
                {
                    Form4 openForm = new Form4();
                    openForm.Show();
                    Visible = false;
                }
            }

        }
    }
        
}