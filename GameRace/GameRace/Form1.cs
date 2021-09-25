using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
        }


        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (enemyA.Top >= 500)
            {
                x = r.Next(20, 100);
                enemyA.Location = new Point(x, y);
            }
            else { enemyA.Top += speed; }

            if (EnemyB.Top >= 500)
            {
                x = r.Next(100, 200);
                EnemyB.Location = new Point(x, y);
            }
            else { EnemyB.Top += speed; }

            if (EnemyC.Top >= 500)
            {
                x = r.Next(200, 300);
                EnemyC.Location = new Point(x, y);
            }
            else { EnemyC.Top += speed; }


        }

        void gameover()
        {
            if (car.Bounds.IntersectsWith(enemyA.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }

            if (car.Bounds.IntersectsWith(EnemyB.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }

            if (car.Bounds.IntersectsWith(EnemyC.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }





        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }

            if (pictureBox5.Top >= 500)
            { pictureBox5.Top = 0; }
            else { pictureBox5.Top += speed; }

        }

        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if(car.Left>20)
                car.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if(car.Left<323)
                car.Left += 8;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                { gamespeed++; } 
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                { gamespeed--; }
            }




        }
    }
}
