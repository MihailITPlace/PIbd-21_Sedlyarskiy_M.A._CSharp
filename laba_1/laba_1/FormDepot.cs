using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_1
{
    public partial class FormDepot : Form
    {
        Depot<ITransport> depot;

        public FormDepot()
        {
            InitializeComponent();
            depot = new Depot<ITransport>(20, pictureBoxDepot.Width, pictureBoxDepot.Height);            
                
            Draw();            
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxDepot.Width, pictureBoxDepot.Height);
            Graphics gr = Graphics.FromImage(bmp);
            depot.Draw(gr);
            pictureBoxDepot.Image = bmp;
        }

        private void buttonSetElectricLocomotive_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var electricLocomotive = new ElectricLocomotive(100, 1000, dialog.Color);                
                int place = depot + electricLocomotive;
                Draw();
            }
        }

        private void buttonSetMonorail_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var monorail = new Monorail(100, 1000, dialog.Color, dialogDop.Color, true, true, true, 50);                    
                    int place = depot + monorail;
                    Draw();
                }
            }
        }

        private void buttonTakeTrain_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var train = depot - Convert.ToInt32(maskedTextBox.Text);
                if (train != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeTrain.Width, pictureBoxTakeTrain.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    train.SetPosition(5, 5, pictureBoxTakeTrain.Width, pictureBoxTakeTrain.Height);
                    train.Draw(gr);
                    pictureBoxTakeTrain.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeTrain.Width, pictureBoxTakeTrain.Height);
                    pictureBoxTakeTrain.Image = bmp;
                }
                Draw();
            }
        }


    }
}
