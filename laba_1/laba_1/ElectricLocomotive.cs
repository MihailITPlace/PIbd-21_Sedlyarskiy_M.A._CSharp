using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    class ElectricLocomotive : Locomotive
    {
        protected const int monorailWidth = 100;

        protected const int monorailHeight = 60;

        public ElectricLocomotive(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
 
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            
            //корпус
            g.DrawLine(pen, _startPosX, _startPosY, _startPosX + 70, _startPosY);
            g.DrawLine(pen, _startPosX, _startPosY, _startPosX, _startPosY + 50);
            g.DrawLine(pen, _startPosX, _startPosY + 50, _startPosX + 90, _startPosY + 50);
            g.DrawLine(pen, _startPosX, _startPosY + 45, _startPosX + 90, _startPosY + 45);
            //лобовое стекло
            g.DrawArc(pen, _startPosX + 50, _startPosY, 40, 100, -90, 90);

            Brush brMain = new SolidBrush(MainColor);
            g.FillRectangle(brMain, _startPosX, _startPosY, 70, 45);

            //окна и лобовое стекло
            Brush brAqua = new SolidBrush(Color.Aqua);
            g.FillPie(brAqua, _startPosX + 50, _startPosY, 40, 90, -90, 90);
            g.FillRectangle(brAqua, _startPosX + 11, _startPosY + 20, 11, 10);
            g.FillRectangle(brAqua, _startPosX + 44, _startPosY + 20, 11, 10);
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - monorailWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - monorailHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
    }
}
