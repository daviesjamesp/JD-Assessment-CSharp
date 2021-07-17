using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace James_Davies_Assessment
{
    // Base definition of parts
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }

        // Base constructor, non-optional parameters are passed by inherited classes
        public Part(int _partID, string _name, double _price, int _inStock, int _min, int _max)
        {
            PartID = _partID;
            Name = _name;
            Price = _price;
            InStock = _inStock;
            Min = _min;
            Max = _max;
        }
    }
}
