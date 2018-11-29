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
    public partial class FormTrainConfig : Form
    {

        ITransport train = null;

        private event trainDelegate eventAddTrain;

        public FormTrainConfig()
        {
            InitializeComponent();

            panelBlack.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelFlesh.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelPink.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown; 
            panelYellow.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        public void AddEvent(trainDelegate ev)
        {
            if (eventAddTrain == null)
            {
                eventAddTrain = new trainDelegate(ev);
            }
            else
            {
                eventAddTrain += ev;
            }
        }

        private void Draw()
        {
            if (train != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxTrain.Width, pictureBoxTrain.Height);
                Graphics gr = Graphics.FromImage(bmp);
                train.SetPosition(35, 25, pictureBoxTrain.Width, pictureBoxTrain.Height);
                train.Draw(gr);
                pictureBoxTrain.Image = bmp;
            }
        }

        private void labelElectricLocomotive_MouseDown(object sender, MouseEventArgs e)
        {
            labelElectricLocomotive.DoDragDrop(labelElectricLocomotive.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelMonorail_MouseDown(object sender, MouseEventArgs e)
        {
            labelMonorail.DoDragDrop(labelMonorail.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelTrain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelTrain_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Электричка":
                    train = new ElectricLocomotive(100, 500, Color.FromArgb(250,250,250));
                    break;
                case "Монорельс":
                    train = new Monorail(100, 500, Color.FromArgb(250, 250, 250), Color.FromArgb(10, 10, 10), true, true, true, 145);
                    break;
            }
            Draw();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (train != null)
            {
                train.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                Draw();
            }
        }

        private void labelAddColor_DragDrop(object sender, DragEventArgs e)
        {
            if (train != null)
            {
                if (train is Monorail)
                {
                    (train as Monorail).SetAddColor((Color)e.Data.GetData(typeof(Color)));
                    Draw();
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddTrain?.Invoke(train);
            Close();
        }
    }
}
