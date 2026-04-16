using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3._CoreLayer;

namespace _4._DataLayer.FakeData
{
    internal class CollectorData
    {
        public List<Collector> Collectors()
        {
           Collector collector = new Collector(1, "John", "Doe", "johndoe", "password123", "johndoe@example.com");
           Collector collector2 = new Collector(2, "Jane", "Smith", "janesmith", "password456", "janesmith@example.com");
           Collector collector3 = new Collector(3, "Alice", "Johnson", "alicejohnson", "password789", "alicejohnson@example.com");
           return new List<Collector> { collector, collector2, collector3 };
        }

    }
}
