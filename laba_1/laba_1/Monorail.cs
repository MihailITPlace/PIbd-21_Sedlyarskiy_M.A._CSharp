using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    class Monorail
    {
        private float _startPosX;
        private float _startPosY;

        private int _pictureWidth;        
        private int _pictureHeight;

        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        private const int carWidth = 100;

        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        private const int carHeight = 60;

        public int MaxSpeed { get; private set; }

        public float Weight { get; private set; }

        public Color MainColor { get; private set; }

        public Color AddColor { get; private set; }

        public bool FrontSpoiler { get; private set; }

        /// <summary>
        /// Признак наличия заднего спойлера
        /// </summary>
        public bool BackSpoiler { get; private set; }

        public Monorail(int maxSpeed, float weight, Color mainColor, Color addColor, bool frontSpoiler, bool backSpoiler)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            AddColor = addColor;
            FrontSpoiler = frontSpoiler;            
            BackSpoiler = backSpoiler;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public void MoveMonorail(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
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
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public void DrawMonorail(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            // отрисуем сперва передний спойлер автомобиля (чтобы потом отрисовка автомобиля на него "легла")
           
            //корпус
            g.DrawLine(pen, _startPosX, _startPosY, _startPosX + 70, _startPosY);
            g.DrawLine(pen, _startPosX, _startPosY, _startPosX, _startPosY + 50);
            g.DrawLine(pen, _startPosX, _startPosY + 50, _startPosX + 90, _startPosY + 50);
            g.DrawLine(pen, _startPosX, _startPosY + 45, _startPosX + 90, _startPosY + 45);
            //лобовое стекло
            g.DrawArc(pen, _startPosX + 50, _startPosY, 40, 100, -90, 90);
                       
            Brush brMain = new SolidBrush(MainColor);
            g.FillRectangle(brMain, _startPosX, _startPosY, 70, 45);

            Brush brAdd = new SolidBrush(AddColor);
            g.FillRectangle(brAdd, _startPosX, _startPosY + 45, 90, 5);


            //окна и лобовое стекло
            Brush brAqua = new SolidBrush(Color.Aqua);
            g.FillPie(brAqua, _startPosX + 50, _startPosY, 40, 90, -90, 90);
            g.FillRectangle(brAqua, _startPosX + 11, _startPosY + 20, 11, 10);
            g.FillRectangle(brAqua, _startPosX + 44, _startPosY + 20, 11, 10);
            
            if (BackSpoiler)
            {
                Brush spoiler = new SolidBrush(Color.Black);
                g.FillRectangle(spoiler, _startPosX, _startPosY, 5, 50);
                g.DrawRectangle(pen, _startPosX, _startPosY, 5, 50);
            }

            if (FrontSpoiler)
            {
                Brush spoiler = new SolidBrush(Color.Coral);
                g.FillRectangle(spoiler, _startPosX + 70, _startPosY + 45, 20, 5);
                g.DrawRectangle(pen, _startPosX + 70, _startPosY + 45, 20, 5);
            }
        }


    }
}

