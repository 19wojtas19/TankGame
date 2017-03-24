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
    class Tank
    {
        public const int TANK_HEIGHT = 10;
        public const int TANK_WIDTH = 10;
        public int x, y;
        private Rectangle _tank;
        private Tank(int x, int y)
        {
            this.x = x;
            this.y = y;
            _tank = new Rectangle();
        }
        public void Draw(Canvas c)
        {
            _tank.Width = TANK_WIDTH;
            _tank.Height = TANK_HEIGHT;
            _tank.Fill = new SolidColorBrush(Colors.Blue);
            c.Children.Add(_tank);
            Canvas.SetLeft(_tank, (double)x);
            Canvas.SetTop(_tank, (double)x);
        }
        private void Move(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left) Canvas.SetLeft(_tank, Canvas.GetLeft(_tank) - 1);
            if (e.Key == Key.Up) Canvas.SetTop(_tank, Canvas.GetTop(_tank) - 1);
            if (e.Key == Key.Down) Canvas.SetTop(_tank, Canvas.GetTop(_tank) + 1);
            if (e.Key == Key.Right) Canvas.SetLeft(_tank, Canvas.GetLeft(_tank) + 1);
        }


    }
}
