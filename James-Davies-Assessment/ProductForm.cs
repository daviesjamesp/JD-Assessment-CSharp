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
    public partial class ProductForm : Form
    {
        public Product TargetProduct { get; set; }
        public Product ReturnProduct { get; private set; }
        public Inventory MainInventory { get; }

        public ProductForm(Inventory inventory)
        {
            InitializeComponent();
            MainInventory = inventory;
            partGridView.DataSource = MainInventory.AllParts;
        }

        // Onload sets form text, populates fields
        private void ProductForm_Load(object sender, EventArgs e)
        {
            if (TargetProduct == null)
            {
                this.Text = "Add Product";
                TargetProduct = new Product();
            }
            else
            {
                this.Text = "Modify Product";
            }
            
            UpdateFields();
        }

        // Sets all the fields to their initial values
        private void UpdateFields()
        {
            if (TargetProduct.ProductID > -1)
            {
                idTextBox.Text = TargetProduct.ProductID.ToString();
            }
            else
            {
                // Leave ID text box blank for new product
            }
            nameTextBox.Text      = TargetProduct.Name;
            inventoryTextBox.Text = TargetProduct.InStock.ToString();
            priceTextBox.Text     = TargetProduct.Price.ToString();
            minTextBox.Text       = TargetProduct.Min.ToString();
            maxTextBox.Text       = TargetProduct.Max.ToString();
            productPartsGridView.DataSource = TargetProduct.AssociatedParts;
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
                partSearchTextBox.Text = "";
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

        private void addPartButton_Click(object sender, EventArgs e)
        {
            if (partGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No part selected to add.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            TargetProduct.AddAssociatedPart(
                MainInventory.LookupPart(int.Parse(partGridView.SelectedRows[0].Cells[0].Value.ToString())));
        }

        private void partDeleteButton_Click(object sender, EventArgs e)
        {
            if (productPartsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No part selected to remove.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            TargetProduct.RemoveAssociatedPart(
                int.Parse(productPartsGridView.SelectedRows[0].Cells[0].Value.ToString()));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckForEmptyControls();
                ValidateControlData();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CreateReturnProduct();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Ensures that each textbox is not empty
        private void CheckForEmptyControls()
        {
            foreach (Control control in this.Controls)
            {
                // Skips non-textbox controls and the non-editable ID textbox
                if (control.GetType() != typeof(TextBox)) { continue; }
                if (control.Name == "idTextBox") { continue; }

                var textBox = (TextBox)control;
                if (textBox.Text.Trim() == "")
                {
                    throw new InvalidOperationException("Required fields are blank.");
                }
            }
        }

        // A rather long method for validating the data in the textboxes for accuracy
        private void ValidateControlData()
        {
            // Checks that all applicable values can be parsed
            double priceTestVal;
            int inventoryTestVal, minTestVal, maxTestVal;
            if (!int.TryParse(inventoryTextBox.Text, out inventoryTestVal))
                { throw new InvalidOperationException("Inventory is not a valid integer."); }
            if (!double.TryParse(priceTextBox.Text, out priceTestVal))
                { throw new InvalidOperationException("Price/Cost is not a valid amount."); }
            if (!int.TryParse(minTextBox.Text, out minTestVal))
                { throw new InvalidOperationException("Minimum is not a valid integer."); }
            if (!int.TryParse(maxTextBox.Text, out maxTestVal))
                { throw new InvalidOperationException("Maximum is not a valid integer."); }

            // All parsed values will be logic-checked
            if (priceTestVal <= 0 || inventoryTestVal < 0 || minTestVal < 0 || maxTestVal < 0)
                { throw new InvalidOperationException("Values cannot be less than zero."); }
            if (maxTestVal < minTestVal)
                { throw new InvalidOperationException("Inventory range is invalid."); }
            if (inventoryTestVal < minTestVal || inventoryTestVal > maxTestVal)
                { throw new InvalidOperationException("Inventory value is outside of allowed range."); }
        }

        // Creates a product to be returned to the parent form
        private void CreateReturnProduct()
        {
            Product savedProduct = new Product();
            if (idTextBox.Text != "")
                { savedProduct.ProductID = int.Parse(idTextBox.Text); }
            savedProduct.InStock = int.Parse(inventoryTextBox.Text);
            savedProduct.Max     = int.Parse(maxTextBox.Text);
            savedProduct.Min     = int.Parse(minTextBox.Text);
            savedProduct.Name    = nameTextBox.Text;
            savedProduct.Price   = double.Parse(priceTextBox.Text);

            ReturnProduct = savedProduct;
        }
    }
}
