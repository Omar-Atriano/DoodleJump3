using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoodleJump3
{
    public class Map1
    {
        public string map;

        int divs =1;
        public int nTileWidth = 40;//Estaba en 20
        public int nTileHeight = 20;//Estaba en 20
        public int nMonsterWidth = 40;//Estaba en 20
        public int nMonsterHeight = 40;//Estaba en 20
        int nLevelWidth, nLevelHeight;
        private string sLevel;
        public Bitmap bmp;
        public Graphics g;
        Sprite monster;
        SoundPlayer soundPlayer;
        int score;
        bool isP1 = true;
        Thread thread, threadStop;
        public Map1(Size size)
        {
            sLevel = "";
            sLevel += ".5555555...";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "5..........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".5.........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "..5........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "........5..";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "..5........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "........5..";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...5.......";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "......5....";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...5.......";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "........5..";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "..5........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "......5....";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "..5........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".....5.....";
            sLevel += "...........";
            sLevel += "..........5";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "..........5";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "........5..";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "....5......";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "......5....";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".........5.";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "....5......";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "..5........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".........5.";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "....5......";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "..5........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".......5...";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...5.......";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "........5..";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".....5.....";
            sLevel += "...........";
            sLevel += "..........5";
            sLevel += "..5........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".5.........";
            sLevel += "...........";
            sLevel += "......5....";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "......5....";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "..........5";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".5.........";
            sLevel += ".........5.";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "........5..";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...5.......";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".........5.";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "..5........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".......5...";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...5.......";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "........5..";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".....5.....";
            sLevel += "...........";
            sLevel += "..........5";
            sLevel += "..5........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".5.........";
            sLevel += "...........";
            sLevel += "......5....";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "......5....";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "..........5";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".5.........";
            sLevel += ".........5.";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "........5..";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...5.......";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".........5.";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "..5........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".......5...";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...5.......";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "........5..";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".....5.....";
            sLevel += "...........";
            sLevel += "..........5";
            sLevel += "..5........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".5.........";
            sLevel += "...........";
            sLevel += "......5....";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "......5....";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "..........5";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".5.........";
            sLevel += ".........5.";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "........5..";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...5.......";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".........5.";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".5.........";
            sLevel += "...........";
            sLevel += "..5........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "......5....";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".5.........";
            sLevel += ".........5.";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "......5....";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "5..........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "....5....5.";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".......5...";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "..5........";
            sLevel += "........5..";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".5...5....5";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...5....5..";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".....5.....";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += ".5.........";
            sLevel += "........5..";
            sLevel += "...........";
            sLevel += "...5.......";
            sLevel += ".....5.....";
            sLevel += ".5......5..";
            sLevel += "...........";
            sLevel += "..5........";
            sLevel += "...........";
            sLevel += ".....5...5.";
            sLevel += "...........";
            sLevel += "..5........";
            sLevel += "......5.6..";
            sLevel += ".5.......5.";
            sLevel += "...........";
            sLevel += "...5..5....";
            sLevel += "...........";
            sLevel += ".....5.....";
            sLevel += "...........";
            sLevel += "..6.....5..";
            sLevel += ".....5.....";
            sLevel += "5..........";
            sLevel += "...5.......";
            sLevel += ".........5.";
            sLevel += "..5........";
            sLevel += "......5....";
            sLevel += "5........5.";
            sLevel += "...5.......";
            sLevel += "...........";
            sLevel += "........5..";
            sLevel += "5..........";
            sLevel += "........5..";
            sLevel += "......5....";
            sLevel += ".5.........";
            sLevel += "...........";
            sLevel += "55555555555";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";
            sLevel += "...........";



            nLevelWidth = 11;
            nLevelHeight = 346;

            bmp = new Bitmap(size.Width / divs, size.Height / divs);

            g = Graphics.FromImage(bmp);
            g.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            g.SmoothingMode = SmoothingMode.HighSpeed;
            
        }

        public void Draw(PointF cameraPos, string message, Player player)
        {
            // Draw Level based on the visible tiles on our picturebox (canvas)
            int nVisibleTilesX = bmp.Width / nTileWidth;
            int nVisibleTilesY = bmp.Height / nTileHeight;

            // Calculate Top-Leftmost visible tile
            float fOffsetX = cameraPos.X - (float)nVisibleTilesX / 2.0f;
            float fOffsetY = cameraPos.Y - (float)nVisibleTilesY / 2.0f;

            // Clamp camera to game boundaries
            if (fOffsetX < 0) fOffsetX = 0;
            if (fOffsetY < 0) fOffsetY = 0;
            if (fOffsetX > nLevelWidth - nVisibleTilesX) fOffsetX = nLevelWidth - nVisibleTilesX;
            if (fOffsetY > nLevelHeight - nVisibleTilesY) fOffsetY = nLevelHeight - nVisibleTilesY;

            float fTileOffsetX = (fOffsetX - (int)fOffsetX) * nTileWidth;
            float fTileOffsetY = (fOffsetY - (int)fOffsetY) * nTileHeight;
            GC.Collect();
            //Draw visible tile map//*--------------------DRAW------------------------------
            char c;
            float stepX, stepY;
            //g.DrawImage(Resource1.bck_2x,);
            for (int x = -1; x < nVisibleTilesX + 2; x++)
            {
                for (int y = -1; y < nVisibleTilesY + 2; y++)
                {
                    c = GetTile(x + (int)fOffsetX, y + (int)fOffsetY);
                    stepX = x * nTileWidth - fTileOffsetX;
                    stepY = y * nTileHeight - fTileOffsetY;
                    //g.FillRectangle(Brushes.White, stepX, stepY, nTileWidth, nTileHeight);
                    g.FillRectangle(Brushes.Red, stepX, stepY, nTileWidth, nTileHeight);
                    
                    g.FillRectangle(Brushes.White, stepX + 1, stepY + 1, (nTileWidth - 1)/2, nTileHeight - 1);
                    g.FillRectangle(Brushes.White, (stepX + 1 + (nTileWidth /2) ), stepY + 1, (nTileWidth - 1) / 2, nTileHeight - 1);

                    switch (c)
                    {
                        case '.':
                            //pictureBox1.Image = Resource1.bck_2x;
                            //g.FillRectangle(Brushes.Red, stepX, stepY, nTileWidth, nTileHeight);
                            //g.FillRectangle(Brushes.White, stepX + 1, stepY + 1, nTileWidth - 1, nTileHeight - 1);
                            break;
                        case '5':

                            g.DrawImage(Resource1.green,stepX, stepY + nTileHeight / 2, nTileWidth, (nTileHeight/2));
                            break;

                        case '6':


                            monster = new Sprite(new Size(230, 160), new Size(60, 40), new Point((int)stepX, (int)stepY), Resource1.monster, Resource1.monster);
                            monster.Display(g);
                            break;
                    }
                    //g.DrawRectangle(Pens.Gray, stepX, stepY, nTileWidth, nTileHeight);
                }
            }

            g.DrawString("SCORE:: " + score, new Font("Consolas", 10, FontStyle.Italic), Brushes.White, 5, 5);

            player.MainSprite.posX = (player.fPlayerPosX - fOffsetX) * nTileWidth;
            player.MainSprite.posY = (player.fPlayerPosY - fOffsetY) * nTileHeight;
        }
        public void SetTile(float x, float y, char c)//changes the tile
        {
            if (x >= 0 && x < nLevelWidth && y >= 0 && y < nLevelHeight)
            {
                int index = (int)y * nLevelWidth + (int)x;
                sLevel = sLevel.Remove(index, 1).Insert(index, c.ToString());
                //Play();
                score += 100;

            }
        }

        public char GetTile(float x, float y)
        {
            if (x >= 0 && x < nLevelWidth && y >= 0 && y < nLevelHeight)
                return sLevel[(int)y * nLevelWidth + (int)x];
            else
                return ' ';
        }

    }
}
