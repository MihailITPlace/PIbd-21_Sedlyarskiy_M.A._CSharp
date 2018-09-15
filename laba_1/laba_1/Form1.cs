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
        private Monorail monorail;

        public FormMonorail()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxMonorails.Width, pictureBoxMonorails.Height);
            Graphics gr = Graphics.FromImage(bmp);
            monorail.DrawMonorail(gr);
            pictureBoxMonorails.Image = bmp;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            monorail = new Monorail(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.CadetBlue, Color.DarkBlue, true, true);
            monorail.SetPosition(rnd.Next(70, 160), rnd.Next(70, 160), pictureBoxMonorails.Width, pictureBoxMonorails.Height);
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
                        monorail.MoveMonorail(Direction.Up);
                        break;
                    case "buttonDown":
                        monorail.MoveMonorail(Direction.Down);
                        break;
                    case "buttonLeft":
                        monorail.MoveMonorail(Direction.Left);
                        break;
                    case "buttonRight":
                        monorail.MoveMonorail(Direction.Right);
                        break;
                }
                Draw();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Монорельс не создан");
            }
        }
    }
}
