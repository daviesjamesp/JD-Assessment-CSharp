using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace James_Davies_Assessment
{
    public partial class Main : Form
    {
        public Inventory MainInventory { get; }

        public Main()
        {
            InitializeComponent();
            MainInventory = new Inventory();
        }

        // Currently set up to test the modularity of the PartForm, successful
        private void Main_Load(object sender, EventArgs e)
        {
            // FOR SAMPLE DATA INITIALIZATION, DO NOT REMOVE
            var initialPartsList = new BindingList<Part>()
            {
                new    Inhouse(10,        0, "Wheel", 12.11, 15, 5, 25),
                new    Inhouse(15,        1, "Pedal",  8.22, 11, 5, 25),
                new Outsourced("ChainCo", 2, "Chain",  8.33, 12, 5, 25),
                new    Inhouse(20,        3, "Seat",   4.55,  8, 2, 15)
            };
            var initialProductList = new BindingList<Product>()
            {
                new Product(new BindingList<Part>(), 0,    "Red Bicycle", 11.44, 15, 1, 25),
                new Product(new BindingList<Part>(), 1,   "Blue Bicycle",  9.66, 19, 1, 20),
                new Product(new BindingList<Part>(), 2, "Green Unicycle", 12.77,  5, 1, 25)
            };
            foreach (Part part in initialPartsList)
                { MainInventory.AddPart(part); }
            foreach (Product product in initialProductList)
                { MainInventory.AddProduct(product); }
            // FOR SAMPLE DATA INITIALIZATION, DO NOT REMOVE

            productGridView.DataSource = MainInventory.Products;
            partGridView.DataSource = MainInventory.AllParts;
        }

        // Prompts user for new product details and saves to the list
        private void productAddButton_Click(object sender, EventArgs e)
        {
            // Show product form to add product
            var newProductForm = new ProductForm(MainInventory);
            newProductForm.ShowDialog();

            // Check if valid object was returned, exit if not
            var returnedProduct = newProductForm.ReturnProduct;
            if (returnedProduct == null) { return; }

            // Add product to inventory
            MainInventory.AddProduct(returnedProduct);
        }

        // Sends selected product data to prompted form for user to modify.
        // Saves to inventory when returned.
        private void productModifyButton_Click(object sender, EventArgs e)
        {
            // Ensures an index is selected
            if (productGridView.SelectedRows.Count == 0)
            { 
                MessageBox.Show("No product selected to modify.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Shows dialog for user to modify product
            var index = productGridView.SelectedRows[0].Index;
            var modifyProductForm = new ProductForm(MainInventory);
            modifyProductForm.TargetProduct = MainInventory.Products[index];
            modifyProductForm.ShowDialog();

            // Null checks and updates inventory
            if (modifyProductForm.ReturnProduct != null)
                { MainInventory.UpdateProduct(index, modifyProductForm.ReturnProduct); }
        }

        // Removes product from list
        private void productDeleteButton_Click(object sender, EventArgs e)
        {
            // Ensures an index is selected
            if (productGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No product selected to delete.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirms delete
            var confirmation = MessageBox.Show(
                "Are you sure you want to delete?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation != DialogResult.Yes) { return; }

            var deleteOperation = MainInventory.RemoveProduct(productGridView.SelectedRows[0].Index);
            if (!deleteOperation)
            {
                MessageBox.Show("Product could not be removed. Check associated parts list.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Prompts user for new part details and saves to the list
        private void partAddButton_Click(object sender, EventArgs e)
        {
            // Show part form to add part
            var newPartForm = new PartForm();
            newPartForm.ShowDialog();

            // Check if valid object was returned, exit if not
            var returnedPart = newPartForm.ReturnPart;
            if (returnedPart == null) { return; }

            // Add part to inventory
            MainInventory.AddPart(returnedPart);
        }

        private void partModifyButton_Click(object sender, EventArgs e)
        {
            // Ensures an index is selected
            if (partGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No part selected to modify.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Shows dialog for user to modify part
            var index = partGridView.SelectedRows[0].Index;
            var modifyPartForm = new PartForm();
            modifyPartForm.TargetPart = MainInventory.AllParts[index];
            modifyPartForm.ShowDialog();

            // Null checks and updates inventory
            if (modifyPartForm.ReturnPart != null)
            { MainInventory.UpdatePart(index, modifyPartForm.ReturnPart); }
        }

        private void partDeleteButton_Click(object sender, EventArgs e)
        {
            // Ensures an index is selected
            if (partGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No part selected to delete.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirms delete
            var confirmation = MessageBox.Show(
                "Are you sure you want to delete?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation != DialogResult.Yes) { return; }

            var deleteOperation = MainInventory.DeletePart(partGridView.SelectedRows[0].Index);
            if (!deleteOperation)
            {
                MessageBox.Show("Part could not be removed.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void partSearchButton_Click(object sender, EventArgs e)
        {
            // Resets to full view if search box empty
            if (partSearchTextBox.Text == "")
            {
                partGridView.DataSource = MainInventory.AllParts;
                return;
            }

            int partID;
            if (!int.TryParse(partSearchTextBox.Text, out partID))
            {
                MessageBox.Show("Search term must be a valid integer.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                productSearchTextBox.Text = "";
                return;
            }

            var foundPart = MainInventory.LookupPart(partID);
            if (foundPart == null)
            {
                MessageBox.Show("No matching part found.", "Search",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var searchList = new BindingList<Part>() { foundPart };
                partGridView.DataSource = searchList;
            }

            partSearchTextBox.Text = "";
        }

        private void productSearchButton_Click(object sender, EventArgs e)
        {
            // Resets to full view if search box empty
            if (productSearchTextBox.Text == "")
            {
                productGridView.DataSource = MainInventory.AllParts;
                return;
            }

            int productID;
            if (!int.TryParse(productSearchTextBox.Text, out productID))
            {
                MessageBox.Show("Search term must be a valid integer.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                productSearchTextBox.Text = "";
                return;
            }

            var foundProduct = MainInventory.LookupProduct(productID);
            if (foundProduct == null)
            {
                MessageBox.Show("No matching product found.", "Search",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var searchList = new BindingList<Product>() { foundProduct };
                productGridView.DataSource = searchList;
            }

            productSearchTextBox.Text = "";
        }
    }
}
