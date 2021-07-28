using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace James_Davies_Assessment
{
    // Stores and modifies lists of available products and parts
    public class Inventory
    {
        public BindingList<Product> Products { get; private set; }
        public BindingList<Part> AllParts { get; private set; }

        // Constructor with both lists predefined
        public Inventory(BindingList<Part> _allPartsList, BindingList<Product> _productsList)
        {
            Products = _productsList;
            AllParts = _allPartsList;
        }

        // Constructor with no lists predefined
        public Inventory()
        {
            Products = new BindingList<Product>();
            AllParts = new BindingList<Part>();
        }

        // Adds product to the inventory
        public void AddProduct(Product _product)
        {
            if (_product.ProductID == -1)
                { _product.ProductID = NextProductID(); }
            Products.Add(_product);
        }

        // Removes product from inventory via product ID reference, returns success boolean
        public bool RemoveProduct(int _productID)
        {
            var foundProducts =
                from product in Products
                where product.ProductID == _productID
                select product;
            if (foundProducts.Count() != 0 && foundProducts.First().AssociatedParts.Count == 0)
            { 
                Products.Remove(foundProducts.First());
                return true;
            }
            else
                { return false; }
        }

        // Returns a product from the inventory list via product ID reference
        public Product LookupProduct(int _productID)
        {
            var foundProducts =
                from product in Products
                where product.ProductID == _productID
                select product;
            if (foundProducts.Count() != 0)
                { return foundProducts.First(); }
            else
                { return null; }
        }

        // Replaces product at an index with an updated object
        public void UpdateProduct(int index, Product _product)
        {
            Products[index] = _product;
        }

        // Adds part to inventory list
        public void AddPart(Part _part)
        {
            if (_part.PartID == -1)
                { _part.PartID = NextPartID(); }
            AllParts.Add(_part);
        }

        // Removes part from inventory list, returns success boolean
        public bool DeletePart(int _partID)
        {
            var foundParts =
                from part in AllParts
                where part.PartID == _partID
                select part;
            if (foundParts.Count() != 0)
            {
                AllParts.Remove(foundParts.First());
                return true;
            }
            else
            { return false; }
        }

        // Returns a part from the parts list via part ID reference
        public Part LookupPart(int _partID)
        {
            var foundParts =
                from part in AllParts
                where part.PartID == _partID
                select part;
            if (foundParts.Count() != 0)
                { return foundParts.First(); }
            else
                { return null; }
        }

        // Replaces a part at an index with an updated object
        public void UpdatePart(int index, Part _part)
        {
            AllParts[index] = _part;
        }

        // Returns next available product ID
        private int NextProductID()
        {
            if (Products.Count == 0) { return 0; }
            var idList =
                from product in Products
                select product.ProductID;
            return idList.Max() + 1;
        }

        // Returns next available part ID
        private int NextPartID()
        {
            if (AllParts.Count == 0) { return 0; }
            var idList =
                from part in AllParts
                select part.PartID;
            return idList.Max() + 1;
        }
    }
}
