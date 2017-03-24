using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TankGame
{
    class Wall
    {
        public const int WALL_HEIGHT = 10;
        public const int WALL_WIDTH = 10;
        public int x, y;
        private Rectangle _shape;
        public Wall(int x, int y)
        {
            this.x = x;
            this.y = y;
            _shape = new Rectangle();
        }
        public void Draw(Canvas c)
        {
            _shape.Width = WALL_WIDTH;
            _shape.Height = WALL_HEIGHT;
            _shape.Fill = new SolidColorBrush(Colors.Black);
            c.Children.Add(_shape);
            Canvas.SetLeft(_shape, (double)x*10);
            Canvas.SetTop(_shape, (double)y*10);
        }
    }
    class Map
    {
        public const int MAP_HEIGHT = 60;
        public const int MAP_WIDTH = 80;
        private int[,] _maparray;
        public Map()
        {
            _maparray = new int[MAP_HEIGHT, MAP_WIDTH];
            Generator();
        }
        void Generator()
        {
            for (int i = 0; i < MAP_HEIGHT; i++)
            {
                for (int j = 0; j < MAP_WIDTH; j++)
                {
                    if (i == 0 || j == 0 || i == MAP_HEIGHT - 1 || j == MAP_WIDTH - 1)
                        _maparray[i, j] = 1;
                    else
                        _maparray[i, j] = 0;
                }
            }

        }
        public void Draw(Canvas c)
        {
            Wall TempWall;
            for (int i = 0; i < MAP_HEIGHT; i++)
            {
                for (int j = 0; j < MAP_WIDTH; j++)
                {
                    if (_maparray[i,j] == 1)
                    {
                        TempWall = new Wall(j, i);
                        TempWall.Draw(c);
                    }
                }
            }
        }
        

    }

}
