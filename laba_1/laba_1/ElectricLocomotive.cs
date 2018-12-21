using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    class ElectricLocomotive : Locomotive, IComparable<ElectricLocomotive>, IEquatable<ElectricLocomotive>
    {
        protected const int monorailWidth = 100;

        protected const int monorailHeight = 60;

        public ElectricLocomotive(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        public ElectricLocomotive(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);                             

                MainColor = System.Drawing.ColorTranslator.FromHtml(strs[2]);
            }
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

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + '#' + MainColor.Name;
        }

        public int CompareTo(ElectricLocomotive other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }

        public bool Equals(ElectricLocomotive other)
        {
            if (other == null)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            ElectricLocomotive elecLocObj = obj as ElectricLocomotive;
            if (elecLocObj == null)
            {
                return false;
            }
            else
            {
                return Equals(elecLocObj);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
