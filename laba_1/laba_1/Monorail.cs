using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    class Monorail : ElectricLocomotive
    {
        public Color AddColor { get; private set; }

        public bool BackSpoiler { get; private set; }

        public bool MagneticCushion { get; private set; }

        public bool TopStabilizer { get; private set; }

        public int MaxTonnage { get; private set; }

        public Monorail(int maxSpeed, float weight, Color mainColor, Color addColor, bool magneticCushion, bool backSpoiler, bool topStabilizer, int maxTonnage) : base (maxSpeed, weight, mainColor)
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

    }
}

