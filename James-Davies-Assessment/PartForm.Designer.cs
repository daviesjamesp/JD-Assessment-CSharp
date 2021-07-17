
namespace James_Davies_Assessment
{
    partial class PartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.acquisitionGroupBox = new System.Windows.Forms.GroupBox();
            this.outsourceRadioButton = new System.Windows.Forms.RadioButton();
            this.inHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.inHouseLabel = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.acquisitionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // acquisitionGroupBox
            // 
            this.acquisitionGroupBox.Controls.Add(this.outsourceRadioButton);
            this.acquisitionGroupBox.Controls.Add(this.inHouseRadioButton);
            this.acquisitionGroupBox.Location = new System.Drawing.Point(18, 12);
            this.acquisitionGroupBox.Name = "acquisitionGroupBox";
            this.acquisitionGroupBox.Size = new System.Drawing.Size(333, 57);
            this.acquisitionGroupBox.TabIndex = 0;
            this.acquisitionGroupBox.TabStop = false;
            this.acquisitionGroupBox.Text = "Acquisition";
            // 
            // outsourceRadioButton
            // 
            this.outsourceRadioButton.AutoSize = true;
            this.outsourceRadioButton.Location = new System.Drawing.Point(232, 21);
            this.outsourceRadioButton.Name = "outsourceRadioButton";
            this.outsourceRadioButton.Size = new System.Drawing.Size(95, 20);
            this.outsourceRadioButton.TabIndex = 1;
            this.outsourceRadioButton.Text = "Outsourced";
            this.outsourceRadioButton.UseVisualStyleBackColor = true;
            // 
            // inHouseRadioButton
            // 
            this.inHouseRadioButton.AutoSize = true;
            this.inHouseRadioButton.Checked = true;
            this.inHouseRadioButton.Location = new System.Drawing.Point(134, 21);
            this.inHouseRadioButton.Name = "inHouseRadioButton";
            this.inHouseRadioButton.Size = new System.Drawing.Size(80, 20);
            this.inHouseRadioButton.TabIndex = 0;
            this.inHouseRadioButton.TabStop = true;
            this.inHouseRadioButton.Text = "In-House";
            this.inHouseRadioButton.UseVisualStyleBackColor = true;
            this.inHouseRadioButton.CheckedChanged += new System.EventHandler(this.inHouseRadioButton_CheckedChanged);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(120, 96);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 16);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(152, 93);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(199, 22);
            this.idTextBox.TabIndex = 2;
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(152, 133);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(199, 22);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(96, 136);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 16);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(152, 213);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(199, 22);
            this.priceTextBox.TabIndex = 9;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(71, 216);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(70, 16);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "Price/Cost";
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(152, 173);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(199, 22);
            this.inventoryTextBox.TabIndex = 7;
            this.inventoryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Location = new System.Drawing.Point(79, 176);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(62, 16);
            this.inventoryLabel.TabIndex = 6;
            this.inventoryLabel.Text = "Inventory";
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(152, 293);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(199, 22);
            this.sourceTextBox.TabIndex = 13;
            this.sourceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inHouseLabel
            // 
            this.inHouseLabel.AutoSize = true;
            this.inHouseLabel.Location = new System.Drawing.Point(66, 296);
            this.inHouseLabel.Name = "inHouseLabel";
            this.inHouseLabel.Size = new System.Drawing.Size(75, 16);
            this.inHouseLabel.TabIndex = 12;
            this.inHouseLabel.Text = "Machine ID";
            this.inHouseLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(152, 253);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(65, 22);
            this.minTextBox.TabIndex = 11;
            this.minTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(112, 256);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(29, 16);
            this.minLabel.TabIndex = 10;
            this.minLabel.Text = "Min";
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(286, 253);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(65, 22);
            this.maxTextBox.TabIndex = 15;
            this.maxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(238, 256);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(33, 16);
            this.maxLabel.TabIndex = 14;
            this.maxLabel.Text = "Max";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(251, 356);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(18, 356);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(35, 296);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(106, 16);
            this.companyNameLabel.TabIndex = 18;
            this.companyNameLabel.Text = "Company Name";
            this.companyNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.companyNameLabel.Visible = false;
            // 
            // PartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 401);
            this.ControlBox = false;
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.inHouseLabel);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.acquisitionGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XXXX Part";
            this.Load += new System.EventHandler(this.PartForm_Load);
            this.acquisitionGroupBox.ResumeLayout(false);
            this.acquisitionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox acquisitionGroupBox;
        private System.Windows.Forms.RadioButton outsourceRadioButton;
        private System.Windows.Forms.RadioButton inHouseRadioButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Label inHouseLabel;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label companyNameLabel;
    }
}