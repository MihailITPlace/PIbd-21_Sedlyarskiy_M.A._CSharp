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
        MultiLevelDepot depot;
        FormTrainConfig form;

        private const int countLevel = 5;

        public FormDepot()
        {
            InitializeComponent();
            depot = new MultiLevelDepot(countLevel, pictureBoxDepot.Width, pictureBoxDepot.Height); ;

            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxDepot.Width, pictureBoxDepot.Height);
                Graphics gr = Graphics.FromImage(bmp);
                depot[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxDepot.Image = bmp;
            }
        }

        private void buttonSetElectricLocomotive_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var locomotive = new ElectricLocomotive(100, 1000, dialog.Color);
                int place = depot[listBoxLevels.SelectedIndex] + locomotive;
                if (place == -1)
                {
                    MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }
        }

        private void buttonSetMonorail_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var monorail = new Monorail(100, 1000, dialog.Color, dialogDop.Color, true, true, true, 12);
                        int place = depot[listBoxLevels.SelectedIndex] + monorail;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }
        }

        private void buttonTakeTrain_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    var car = depot[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBox.Text);
                    if (car != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBoxTakeTrain.Width, pictureBoxTakeTrain.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        car.SetPosition(5, 5, pictureBoxTakeTrain.Width, pictureBoxTakeTrain.Height);
                        car.Draw(gr);
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

        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void buttonSetTrain_Click(object sender, EventArgs e)
        {
            form = new FormTrainConfig();
            form.AddEvent(AddTrain);
            form.Show();
        }

        private void AddTrain(ITransport train)
        {
            if (train != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = depot[listBoxLevels.SelectedIndex] + train;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Состав не удалось поставить");
                }
            }
        }
    }
}
