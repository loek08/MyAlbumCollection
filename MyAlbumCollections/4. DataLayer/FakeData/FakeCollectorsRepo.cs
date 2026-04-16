using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3._CoreLayer;

namespace _4._DataLayer.FakeData
{
    public class FakeCollectorsRepo
    {
        public Collector? GetSpecificCollector(int id)
        {
                       CollectorData collectorData = new CollectorData();
            return collectorData.Collectors().FirstOrDefault(c => c.Id == id);
        }
    }
}
