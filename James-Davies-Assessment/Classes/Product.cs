using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace James_Davies_Assessment
{
    // Stores and modifies product details, including list of associated parts
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; private set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }

        // Constructor with all properties defined
        public Product(BindingList<Part> _associatedParts, int _productID, string _name,
            double _price, int _inStock, int _min, int _max)
        {
            AssociatedParts = _associatedParts;
            ProductID = _productID;
            Name = _name;
            Price = _price;
            InStock = _inStock;
            Max = _max;
            Min = _min;
        }

        // Parameterless constructor
        public Product()
        {
            AssociatedParts = new BindingList<Part>();
            ProductID = -1;
            Name = "New Product";
            Price = 0.0;
            InStock = 0;
            Max = 0;
            Min = 0;
        }

        // Adds part to list of parts associated with a product
        public void AddAssociatedPart(Part _part)
        {
            AssociatedParts.Add(_part);
        }

        // Removes part from list of parts associated with a product, returns success boolean.
        public bool RemoveAssociatedPart(int partID)
        {
            var foundParts =
                from part in AssociatedParts
                where part.PartID == partID
                select part;
            if (foundParts.Count() == 0)
                { return false; }
            else
            {
                AssociatedParts.Remove(foundParts.First());
                return true;
            }
        }

        // Returns the part from the associated parts list by part ID reference
        public Part LookupAssociatedPart(int partID)
        {
            var foundParts =
                from part in AssociatedParts
                where part.PartID == partID
                select part;
            if (foundParts.Count() == 0)
                { return null; }
            else
                { return foundParts.First(); }
        }
    }
}
