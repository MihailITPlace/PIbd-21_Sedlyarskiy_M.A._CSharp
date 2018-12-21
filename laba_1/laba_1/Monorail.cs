using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    class Monorail : ElectricLocomotive, IComparable<Monorail>, IEquatable<Monorail>
    {
        public Color AddColor { get; private set; }

        public bool BackSpoiler { get; private set; }

        public bool MagneticCushion { get; private set; }

        public bool TopStabilizer { get; private set; }

        public int MaxTonnage { get; private set; }

        public Monorail(int maxSpeed, float weight, Color mainColor, Color addColor,
            bool magneticCushion, bool backSpoiler, bool topStabilizer, int maxTonnage) : base (maxSpeed, weight, mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            AddColor = addColor;
            MagneticCushion = magneticCushion;            
            BackSpoiler = backSpoiler;
            TopStabilizer = topStabilizer;
            MaxTonnage = maxTonnage;
        }

        public Monorail(string info) : base(info)
        {
            string[] strs = info.Split(';');

            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                                
                MainColor = System.Drawing.ColorTranslator.FromHtml(strs[2]);
                AddColor = System.Drawing.ColorTranslator.FromHtml(strs[3]);

                MagneticCushion = Convert.ToBoolean(strs[4]);
                BackSpoiler = Convert.ToBoolean(strs[5]);
                TopStabilizer = Convert.ToBoolean(strs[6]);

                MaxTonnage = Convert.ToInt32(strs[7]);
            }
        }

        public void SetAddColor(Color color)
        {
            AddColor = color;
        }

        public override void Draw(Graphics g)
        {
            base.Draw(g);

            Pen pen = new Pen(Color.Black);
            if (TopStabilizer)
            {
                Brush top = new SolidBrush(Color.BlueViolet);
                g.FillRectangle(top, _startPosX, _startPosY, 69, 5);
                g.DrawRectangle(pen, _startPosX, _startPosY, 69, 5);
            }

            if (BackSpoiler)
            {
                Brush spoiler = new SolidBrush(AddColor);
                g.FillRectangle(spoiler, _startPosX, _startPosY, 5, 50);
                g.DrawRectangle(pen, _startPosX, _startPosY, 5, 50);
            }

            if (MagneticCushion)
            {
                Brush spoiler = new SolidBrush(Color.Coral);
                g.FillRectangle(spoiler, _startPosX + 70, _startPosY + 45, 20, 5);
                g.DrawRectangle(pen, _startPosX + 70, _startPosY + 45, 20, 5);
            }
        }

        public override string ToString()
        {
            return base.ToString() + ';' + '#' + AddColor.Name + ';' + MagneticCushion + ';' 
                + BackSpoiler + ';' + TopStabilizer + ';' + MaxTonnage;
        }

        public bool Equals(Monorail other)
        {
            var res = (this as ElectricLocomotive).Equals(other as ElectricLocomotive);
            if (!res)
            {
                return res;
            }
            if (AddColor != other.AddColor)
            {
                return false;
            }
            if (MagneticCushion != other.MagneticCushion)
            {
                return false;
            }
            if (TopStabilizer != other.TopStabilizer)
            {
                return false;
            }
            if (BackSpoiler != other.BackSpoiler)
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
            Monorail monorailObj = obj as Monorail;
            if (monorailObj == null)
            {
                return false;
            }
            else
            {
                return Equals(monorailObj);
            }
        }

        public int CompareTo(Monorail other)
        {
            var res = (this is ElectricLocomotive).CompareTo(other is ElectricLocomotive);
            if (res != 0)
            {
                return res;
            }
            if (AddColor != other.AddColor)
            {
                AddColor.Name.CompareTo(other.AddColor.Name);
            }
            if (MagneticCushion != other.MagneticCushion)
            {
                return MagneticCushion.CompareTo(other.MagneticCushion);
            }
            if (TopStabilizer != other.TopStabilizer)
            {
                return TopStabilizer.CompareTo(other.TopStabilizer);
            }
            if (BackSpoiler != other.BackSpoiler)
            {
                return BackSpoiler.CompareTo(other.BackSpoiler);
            }
            return 0;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}