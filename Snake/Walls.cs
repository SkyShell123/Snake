using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> WallList;

        public Walls(int mapWidht, int mapHeight)
        {
            WallList = new List<Figure>();

            HorizontalLine Upline = new HorizontalLine(0, mapWidht - 2, 0, '+');
            HorizontalLine Downline = new HorizontalLine(0, mapWidht - 2, mapHeight - 1, '+');
            VerticalLine Leftline = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine Rightline = new VerticalLine(0, mapHeight - 1, mapWidht - 2, '+');

            WallList.Add(Upline);
            WallList.Add(Downline);
            WallList.Add(Leftline);
            WallList.Add(Rightline);

            Upline.Draw();
            Downline.Draw();
            Leftline.Draw();
            Rightline.Draw();
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in WallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in WallList)
            {
                wall.Draw();
            }
        }
    }
}
