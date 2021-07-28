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
    // If not passed a target part, class is setup to create a blank form. Otherwise, fields are populated with
    // the part data to be edited. If the part is saved, there is an accessible property with the "new" part object
    public partial class PartForm : Form
    {
        public Part TargetPart { get; set; }
        public Part ReturnPart { get; private set; }

        public PartForm()
        {
            InitializeComponent();
        }

        // On load sets form text, defines targetPart if undefined by parent,
        // calls method to check part source type
        private void PartForm_Load(object sender, EventArgs e)
        {
            if (TargetPart == null)
            {
                this.Text = "Add Part";
                TargetPart = new Inhouse();
            }
            else
            {
                this.Text = "Modify Part";
            }
            UpdateFields();
        }

        // Updates form fields with correct values
        private void UpdateFields()
        {
            var isInhousePart = TargetPart is Inhouse;
            inHouseRadioButton.Checked   = isInhousePart;
            outsourceRadioButton.Checked = !isInhousePart;
            companyNameLabel.Visible     = !isInhousePart;
            if (TargetPart.PartID > -1)
            {
                idTextBox.Text = TargetPart.PartID.ToString();
            }
            else
            {
                // Leave the ID box blank for new parts
            }
            nameTextBox.Text             = TargetPart.Name;
            inventoryTextBox.Text        = TargetPart.InStock.ToString();
            priceTextBox.Text            = TargetPart.Price.ToString();
            minTextBox.Text              = TargetPart.Min.ToString();
            maxTextBox.Text              = TargetPart.Max.ToString();
            if (isInhousePart)
            {
                var targetInhousePart = (Inhouse)TargetPart;
                sourceTextBox.Text = targetInhousePart.MachineID.ToString();
            }
            else // Outsourced part
            {
                var targetOutsourcedPart = (Outsourced)TargetPart;
                sourceTextBox.Text = targetOutsourcedPart.CompanyName;
            }
        }

        // Exits form without returning an object
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Validates data before returning an object and closing the form
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

            CreateReturnPart();
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
            // Checks that all applicable values can be parsed (side effect: all values are parsed!)
            double priceTestVal;
            int inventoryTestVal, minTestVal, maxTestVal, sourceTestVal;
            if (!int.TryParse(inventoryTextBox.Text, out inventoryTestVal)) 
                { throw new InvalidOperationException("Inventory is not a valid integer."); }
            if (!double.TryParse(priceTextBox.Text, out priceTestVal))
                { throw new InvalidOperationException("Price/Cost is not a valid amount."); }
            if (!int.TryParse(minTextBox.Text, out minTestVal))
                { throw new InvalidOperationException("Minimum is not a valid integer."); }
            if (!int.TryParse(maxTextBox.Text, out maxTestVal))
                { throw new InvalidOperationException("Maximum is not a valid integer."); }
            if (inHouseRadioButton.Checked & !int.TryParse(sourceTextBox.Text, out sourceTestVal))
                { throw new InvalidOperationException("Machine ID is not a valid integer"); }

            
            // For my next trick, all parsed values will be logic-checked
            if (priceTestVal <= 0 || inventoryTestVal < 0 || minTestVal < 0 || maxTestVal < 0 || (inHouseRadioButton.Checked && sourceTestVal < 0))
                { throw new InvalidOperationException("Values cannot be less than zero."); }
            if (maxTestVal < minTestVal)
                { throw new InvalidOperationException("Inventory range is invalid."); }
            if (inventoryTestVal < minTestVal || inventoryTestVal > maxTestVal)
                { throw new InvalidOperationException("Inventory value is outside of allowed range."); }
        }

        // Creates a part to be returned to the parent form
        private void CreateReturnPart()
        {
            Part savedPart;
            if (inHouseRadioButton.Checked)
                { savedPart = new Inhouse(int.Parse(sourceTextBox.Text)); }
            else
                { savedPart = new Outsourced(sourceTextBox.Text); }
            if (idTextBox.Text != "")
                { savedPart.PartID = int.Parse(idTextBox.Text); }
            savedPart.InStock = int.Parse(inventoryTextBox.Text);
            savedPart.Max = int.Parse(maxTextBox.Text);
            savedPart.Min = int.Parse(minTextBox.Text);
            savedPart.Name = nameTextBox.Text;
            savedPart.Price = double.Parse(priceTextBox.Text);

            ReturnPart = savedPart;
        }

        // Changes the label for the source text box when the part source is changed
        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            companyNameLabel.Visible = !inHouseRadioButton.Checked;
        }
    }
}
