using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    class MultiLevelDepot
    {
        List<Depot<ITransport>> depotStages;

        private const int countPlaces = 20;

        private int pictureWidth;

        private int pictureHeight;

        public MultiLevelDepot(int countStages, int pictureWidth, int pictureHeight)
        {
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;

            depotStages = new List<Depot<ITransport>>();
            for (int i = 0; i < countStages; ++i)
            {
                depotStages.Add(new Depot<ITransport>(countPlaces, pictureWidth, pictureHeight));
            }
        }

        public Depot<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < depotStages.Count)
                {
                    return depotStages[ind];
                }
                return null;
            }
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    //Записываем количество уровней
                    WriteToFile("CountLeveles:" + depotStages.Count + Environment.NewLine, fs);
                    foreach (var level in depotStages)
                    {
                        //Начинаем уровень
                        WriteToFile("Level" + Environment.NewLine, fs);
                        for (int i = 0; i < countPlaces; i++)
                        {
                            var car = level[i];
                            if (car != null)
                            {
                                //если место не пустое
                                //Записываем тип поезда
                                if (car.GetType().Name == "ElectricLocomotive")
                                {
                                    WriteToFile(i + ":ElectricLocomotive:", fs);
                                }
                                if (car.GetType().Name == "Monorail")
                                {
                                    WriteToFile(i + ":Monorail:", fs);
                                }
                                //Записываемые параметры
                                WriteToFile(car + Environment.NewLine, fs);
                            }
                        }
                    }
                }
            }
            return true;
        }

        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        bufferTextFromFile += temp.GetString(b);
                    }
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("CountLeveles"))
            {
                //считываем количество уровней
                int count = Convert.ToInt32(strs[0].Split(':')[1]);
                if (depotStages != null)
                {
                    depotStages.Clear();
                }
                depotStages = new List<Depot<ITransport>>(count);
            }
            else
            {
                //если нет такой записи, то это не те данные
                return false;
            }

            int counter = -1;
            ITransport train = null;
            for (int i = 1; i < strs.Length; ++i)
            {
                //идем по считанным записям
                if (strs[i] == "Level")
                {
                    //начинаем новый уровень
                    counter++;
                    depotStages.Add(new Depot<ITransport>(countPlaces, pictureWidth, pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(':')[1] == "ElectricLocomotive")
                {
                    train = new ElectricLocomotive(strs[i].Split(':')[2]);
                }
                else if (strs[i].Split(':')[1] == "Monorail")
                {
                    train = new Monorail(strs[i].Split(':')[2]);
                }
                depotStages[counter][Convert.ToInt32(strs[i].Split(':')[0])] = train;
            }
            return true;
        }
    }
}
