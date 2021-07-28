using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace James_Davies_Assessment
{
    // Extended definition for parts sourced externally
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        // Constructor, optional params for creation of "unknown" objects
        public Outsourced(string _companyName = "", int _partID = -1, string _name = "New Part", double _price = 0.0,
            int _inStock = 0, int _min = 0, int _max = 0) : base(_partID, _name, _price, _inStock, _min, _max)
        {
            CompanyName = _companyName;
        }
    }
}
