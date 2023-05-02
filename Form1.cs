using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoodleJump3
{
    public partial class Form1 : Form
    {
        Map1 map1;
        private Bitmap img,wood;
        Graphics gImg;
        Player player;

        float fElapsedTime;

        SoundPlayer sPlayer;
        Thread thread, thread2;
        bool isP1 = true;

        // Camera properties
        float fCameraPosX = 0.0f;
        float fCameraPosY = 0.0f;
        bool left, right;

        public Form1()
        {
            InitializeComponent();
            init();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateEnv();
        }
        private void UpdateEnv()
        {
            if (left)
                player.Left(fElapsedTime);
            if (right)
                player.Right(fElapsedTime);

            fCameraPosX = player.fPlayerPosX;
            fCameraPosY = player.fPlayerPosY;

            map1.Draw(new PointF(fCameraPosX, fCameraPosY), player.fPlayerPosX.ToString(), player);
            player.Update(fElapsedTime, map1);
            pictureBox1.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    left = true;
                    //nDirModY = 1;
                    break;
                case Keys.Right:
                    right = true;
                    //nDirModY = 0;
                    break;
                case Keys.Up:
                    player.FPlayerVelY = -6.0f;
                    player.bPlayerOnGround = false;
                    break;
                case Keys.Down:
                    player.FPlayerVelY = 6.0f;
                    break;
            }

            UpdateEnv();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Space:
                    if (player.FPlayerVelY == 0)// sin brincar o cayendo
                    {
                        player.FPlayerVelY = -15;
                        player.Frame(2);
                        player.bPlayerOnGround = false;
                    }
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                return;

            left = false;
            right = false;

            player.Stop();
        }

        public void init()
        {

            map1 = new Map1(pictureBox1.Size);
            player = new Player();
            pictureBox1.Image = map1.bmp;
            fElapsedTime = 0.05f;
            left = false;
            right = false;
            //sPlayer = new SoundPlayer(Resource1.best);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GenerateIMG()
        {
            //// map properties
            //int w = 100;// width
            //int h = 500;// height
            //int u = 45;//unit
            //char v;

            //img = new Bitmap(w * u, h * u);
            //gImg = Graphics.FromImage(img);

            //this.Text = img.Width.ToString();

            //for (int y = 0; y < h; y++)
            //{
            //    for (int x = 0; x < w; x++)
            //    {
            //        v = map1.map[(y * w) + x];
            //        if (v == '5')
            //            gImg.FillRectangle(Brushes.Tomato, x * u, y * u, u, u);
            //        //if (v == '*')
            //        ////    gImg.DrawImage(wood02, x * u, y * u, u, u);
            //        //if (v == '5')
            //        //    gImg.DrawImage(wood, x * u, y * u, u, u);
            //    }
            //}


        }


    }
}
