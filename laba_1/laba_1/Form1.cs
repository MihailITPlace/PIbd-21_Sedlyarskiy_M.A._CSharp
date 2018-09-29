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
    public partial class FormMonorail : Form
    {
        private ITransport locomotive;

        public FormMonorail()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxTransport.Width, pictureBoxTransport.Height);
            Graphics gr = Graphics.FromImage(bmp);
            locomotive.Draw(gr);
            pictureBoxTransport.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            locomotive = new Monorail(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.DarkBlue, true, true, true, 1000);
            locomotive.SetPosition(rnd.Next(70, 160), rnd.Next(70, 160), pictureBoxTransport.Width, pictureBoxTransport.Height);
            Draw();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            try
            {
                //получаем имя кнопки
                string name = (sender as Button).Name;
                switch (name)
                {
                    case "buttonUp":
                        locomotive.MoveTransport(Direction.Up);
                        break;
                    case "buttonDown":
                        locomotive.MoveTransport(Direction.Down);
                        break;
                    case "buttonLeft":
                        locomotive.MoveTransport(Direction.Left);
                        break;
                    case "buttonRight":
                        locomotive.MoveTransport(Direction.Right);
                        break;
                }
                Draw();
            }
            catch (Exception ex)
            {
                MessageBox.Show("транспорт не создан");
            }
        }

        private void buttonCreateBase_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            locomotive = new ElectricLocomotive(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
            locomotive.SetPosition(rnd.Next(70, 160), rnd.Next(70, 160), pictureBoxTransport.Width, pictureBoxTransport.Height);
            Draw();
        }
    }
}
