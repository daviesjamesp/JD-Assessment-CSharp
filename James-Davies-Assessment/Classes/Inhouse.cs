using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace James_Davies_Assessment
{
    // Extended definition for parts produced internally
    public class Inhouse : Part
    {
        public int MachineID { get; set; }

        // Constructor, optional params for creation of "unknown" objects
        public Inhouse(int _machineID = -1, int _partID = -1, string _name = "New Part", double _price = 0.0,
            int _inStock = 0, int _min = 0, int _max = 0) : base(_partID, _name, _price, _inStock, _min, _max)
        {
            MachineID = _machineID;
        }
    }
}
