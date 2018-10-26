using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    class MultiLevelDepot
    {
        List<Depot<ITransport>> depotStages;

        private const int countPlaces = 20;

        public MultiLevelDepot(int countStages, int pictureWidth, int pictureHeight)
        {
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
    }
}
