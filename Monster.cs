using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoodleJump3
{
    public class Monster
    {
        Sprite monster;
        public float monsterPosX;
        public float monsterPosY;

        public Monster(float x, float y)
        {
            Sprite monster = new Sprite(new Size(155, 90), new Size(35, 40), new Point(), Resource1.lik_right_2x, Resource1.lik_left_2x);
            monsterPosX= x;
            monsterPosY= y;
        }


    }
}
