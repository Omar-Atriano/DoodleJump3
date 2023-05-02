using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoodleJump3
{
    public class Player
    {
        Sprite mainSprite;

        public float fPlayerPosX = 2.0f;
        public float fPlayerPosY = 120.0f;
        public bool go=false;

        private float fPlayerVelX = 0.0f;
        private float fPlayerVelY = 0.0f;

        public Sprite MainSprite
        {
            get { return mainSprite; }
        }

        public float FPlayerVelX
        {
            get { return fPlayerVelX; }
            set { fPlayerVelX = value; }
        }

        public float FPlayerVelY
        {
            get { return fPlayerVelY; }
            set { fPlayerVelY = value; }
        }

        public Player()
        {
            mainSprite = new Sprite(new Size(130, 130), new Size(35, 40), new Point(), Resource1.lik_right_2x, Resource1.lik_left_2x);
        }

        public void Right(float fElapsedTime)
        {
            if (FPlayerVelX<5f)
                FPlayerVelX += (bPlayerOnGround ? 25.0f : 15.0f) * fElapsedTime;
            if (bPlayerOnGround)
                mainSprite.MoveRight();
        }

        public void Left(float fElapsedTime)
        {
            if (FPlayerVelX > -5f)
                FPlayerVelX += (bPlayerOnGround ? -25.0f : -15.0f) * fElapsedTime;
            if (bPlayerOnGround)
                mainSprite.MoveLeft();
        }

        public void Frame(int x)
        {
            mainSprite.Frame(x);
        }
        public void Stop()
        {
            mainSprite.Frame(0);
        }

        public bool bPlayerOnGround = false;

        public void Update(float fElapsedTime, Map1 map)
        {
            //Gravity
            fPlayerVelY += 20.0f * fElapsedTime;//---------------

            // Drag
            if (bPlayerOnGround)
            {
                fPlayerVelX += -3.0f * fPlayerVelX * fElapsedTime;
                if (Math.Abs(fPlayerVelX) < 0.01f)
                    fPlayerVelX = 0.0f;
            }

            // Clamp velocities
            if (fPlayerVelX > 10.0f)
                fPlayerVelX = 10.0f;

            if (fPlayerVelX < -10.0f)
                fPlayerVelX = -10.0f;

            if (fPlayerVelY > 100.0f)
                fPlayerVelY = 100.0f;

            if (fPlayerVelY < -100.0f)
                fPlayerVelY = -100.0f;

            float fNewPlayerPosX = fPlayerPosX + fPlayerVelX * fElapsedTime;
            float fNewPlayerPosY = fPlayerPosY + fPlayerVelY * fElapsedTime;

            //Intercambia
            CheckPicks(map, fNewPlayerPosX, fNewPlayerPosY, 'o', '.');
            //
            CheckPicks(map, fNewPlayerPosX, fNewPlayerPosY, '*', 'a');


            // COLLISION
            if (fPlayerVelX <= 0)//left
            {
                //if ((map.GetTile((int)(fNewPlayerPosX + 0.0f), (int)(fPlayerPosY + 0.0f)) != '.') || (map.GetTile((int)(fNewPlayerPosX + 0.0f), (int)(fPlayerPosY + 0.9f)) != '.'))
                //{
                //    if (fPlayerVelX != 0)
                //        fNewPlayerPosX = (int)fNewPlayerPosX + 1;
                //    fPlayerVelX = 0;
                //}
            }
            else//right
            {
                //if ((map.GetTile((int)(fNewPlayerPosX + 1.0f), (int)(fPlayerPosY + 0.0f)) != '.') || (map.GetTile((int)(fNewPlayerPosX + 1.0f), (int)(fPlayerPosY + 0.9f)) != '.'))
                //{
                //    if (fPlayerVelX != 0)
                //        fNewPlayerPosX = (int)fNewPlayerPosX;

                //    fPlayerVelX = 0;
                //}
            }

            //bPlayerOnGround = false;
            if (fPlayerVelY <= 0)// up
            {
                if ((map.GetTile((int)(fNewPlayerPosX + 0.0f), (int)(fNewPlayerPosY + 0.0f)) == '6') || (map.GetTile((int)(fNewPlayerPosX + 0.9f), (int)(fNewPlayerPosY + 0.0f)) == '6'))
                {
                    fNewPlayerPosY = (int)fNewPlayerPosY + 1;
                    fPlayerVelY = 0;
                    go = true;
                    
                }
            }
            else
            {
                if ((map.GetTile((int)(fNewPlayerPosX + 0.0f), (int)(fNewPlayerPosY + 1.0f)) != '.') || (map.GetTile((int)(fNewPlayerPosX + 0.9f), (int)(fNewPlayerPosY + 1f)) != '.'))
                {
                    if ((map.GetTile((int)(fNewPlayerPosX + 0.0f), (int)(fNewPlayerPosY + 1.0f)) == '6') || (map.GetTile((int)(fNewPlayerPosX + 0.9f), (int)(fNewPlayerPosY + 1f)) == '6'))
                    {
                        map.SetTile((int)(fNewPlayerPosX + 0.0f), (int)(fNewPlayerPosY + 1.0f), '.');
                        map.SetTile((int)(fNewPlayerPosX + 0.9f), (int)(fNewPlayerPosY + 1f), '.');
                    }
                        fNewPlayerPosY = (int)fNewPlayerPosY;
                    fPlayerVelY = 0;
                    if (!bPlayerOnGround)
                        Frame(0);

                    bPlayerOnGround = true;
                }
            }

            fPlayerPosX = fNewPlayerPosX;
            fPlayerPosY = fNewPlayerPosY;

            mainSprite.Display(map.g);
        }

        private static void CheckPicks(Map1 map, float fNewPlayerPosX, float fNewPlayerPosY, char c, char c2)
        {
            // Check for pickups!
            if (map.GetTile(fNewPlayerPosX + 0.0f, fNewPlayerPosY + 0.0f) == c)
                map.SetTile(fNewPlayerPosX + 0.0f, fNewPlayerPosY + 0.0f, c2);

            if (map.GetTile(fNewPlayerPosX + 0.0f, fNewPlayerPosY + 1.0f) == c)
                map.SetTile(fNewPlayerPosX + 0.0f, fNewPlayerPosY + 1.0f, c2);

            if (map.GetTile(fNewPlayerPosX + 1.0f, fNewPlayerPosY + 0.0f) == c)
                map.SetTile(fNewPlayerPosX + 1.0f, fNewPlayerPosY + 0.0f, c2);

            if (map.GetTile(fNewPlayerPosX + 1.0f, fNewPlayerPosY + 1.0f) == c)
                map.SetTile(fNewPlayerPosX + 1.0f, fNewPlayerPosY + 1.0f, c2);
        }

    }

}
