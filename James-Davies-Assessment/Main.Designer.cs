
namespace James_Davies_Assessment
{
    partial class Main
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
            this.mainFormTabControl = new System.Windows.Forms.TabControl();
            this.productsTab = new System.Windows.Forms.TabPage();
            this.productAddButton = new System.Windows.Forms.Button();
            this.productModifyButton = new System.Windows.Forms.Button();
            this.productDeleteButton = new System.Windows.Forms.Button();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.productSearchButton = new System.Windows.Forms.Button();
            this.productSearchTextBox = new System.Windows.Forms.TextBox();
            this.partsTab = new System.Windows.Forms.TabPage();
            this.partAddButton = new System.Windows.Forms.Button();
            this.partModifyButton = new System.Windows.Forms.Button();
            this.partDeleteButton = new System.Windows.Forms.Button();
            this.partGridView = new System.Windows.Forms.DataGridView();
            this.partSearchButton = new System.Windows.Forms.Button();
            this.partSearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainFormTabControl.SuspendLayout();
            this.productsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.partsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFormTabControl
            // 
            this.mainFormTabControl.Controls.Add(this.productsTab);
            this.mainFormTabControl.Controls.Add(this.partsTab);
            this.mainFormTabControl.Location = new System.Drawing.Point(8, 7);
            this.mainFormTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.mainFormTabControl.Name = "mainFormTabControl";
            this.mainFormTabControl.SelectedIndex = 0;
            this.mainFormTabControl.Size = new System.Drawing.Size(1029, 598);
            this.mainFormTabControl.TabIndex = 0;
            // 
            // productsTab
            // 
            this.productsTab.Controls.Add(this.label2);
            this.productsTab.Controls.Add(this.productAddButton);
            this.productsTab.Controls.Add(this.productModifyButton);
            this.productsTab.Controls.Add(this.productDeleteButton);
            this.productsTab.Controls.Add(this.productGridView);
            this.productsTab.Controls.Add(this.productSearchButton);
            this.productsTab.Controls.Add(this.productSearchTextBox);
            this.productsTab.Location = new System.Drawing.Point(4, 25);
            this.productsTab.Margin = new System.Windows.Forms.Padding(4);
            this.productsTab.Name = "productsTab";
            this.productsTab.Padding = new System.Windows.Forms.Padding(4);
            this.productsTab.Size = new System.Drawing.Size(1021, 569);
            this.productsTab.TabIndex = 0;
            this.productsTab.Text = "Products";
            this.productsTab.UseVisualStyleBackColor = true;
            // 
            // productAddButton
            // 
            this.productAddButton.Location = new System.Drawing.Point(696, 516);
            this.productAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.productAddButton.Name = "productAddButton";
            this.productAddButton.Size = new System.Drawing.Size(100, 28);
            this.productAddButton.TabIndex = 11;
            this.productAddButton.Text = "Add";
            this.productAddButton.UseVisualStyleBackColor = true;
            this.productAddButton.Click += new System.EventHandler(this.productAddButton_Click);
            // 
            // productModifyButton
            // 
            this.productModifyButton.Location = new System.Drawing.Point(804, 516);
            this.productModifyButton.Margin = new System.Windows.Forms.Padding(4);
            this.productModifyButton.Name = "productModifyButton";
            this.productModifyButton.Size = new System.Drawing.Size(100, 28);
            this.productModifyButton.TabIndex = 10;
            this.productModifyButton.Text = "Modify";
            this.productModifyButton.UseVisualStyleBackColor = true;
            this.productModifyButton.Click += new System.EventHandler(this.productModifyButton_Click);
            // 
            // productDeleteButton
            // 
            this.productDeleteButton.Location = new System.Drawing.Point(912, 516);
            this.productDeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.productDeleteButton.Name = "productDeleteButton";
            this.productDeleteButton.Size = new System.Drawing.Size(100, 28);
            this.productDeleteButton.TabIndex = 9;
            this.productDeleteButton.Text = "Delete";
            this.productDeleteButton.UseVisualStyleBackColor = true;
            this.productDeleteButton.Click += new System.EventHandler(this.productDeleteButton_Click);
            // 
            // productGridView
            // 
            this.productGridView.AllowUserToAddRows = false;
            this.productGridView.AllowUserToDeleteRows = false;
            this.productGridView.AllowUserToResizeColumns = false;
            this.productGridView.AllowUserToResizeRows = false;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(9, 73);
            this.productGridView.Margin = new System.Windows.Forms.Padding(4);
            this.productGridView.Name = "productGridView";
            this.productGridView.ReadOnly = true;
            this.productGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGridView.ShowEditingIcon = false;
            this.productGridView.Size = new System.Drawing.Size(1003, 415);
            this.productGridView.TabIndex = 8;
            // 
            // productSearchButton
            // 
            this.productSearchButton.Location = new System.Drawing.Point(912, 24);
            this.productSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.productSearchButton.Name = "productSearchButton";
            this.productSearchButton.Size = new System.Drawing.Size(100, 28);
            this.productSearchButton.TabIndex = 7;
            this.productSearchButton.Text = "Search";
            this.productSearchButton.UseVisualStyleBackColor = true;
            this.productSearchButton.Click += new System.EventHandler(this.productSearchButton_Click);
            // 
            // productSearchTextBox
            // 
            this.productSearchTextBox.Location = new System.Drawing.Point(570, 26);
            this.productSearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.productSearchTextBox.Name = "productSearchTextBox";
            this.productSearchTextBox.Size = new System.Drawing.Size(332, 22);
            this.productSearchTextBox.TabIndex = 6;
            // 
            // partsTab
            // 
            this.partsTab.Controls.Add(this.label1);
            this.partsTab.Controls.Add(this.partAddButton);
            this.partsTab.Controls.Add(this.partModifyButton);
            this.partsTab.Controls.Add(this.partDeleteButton);
            this.partsTab.Controls.Add(this.partGridView);
            this.partsTab.Controls.Add(this.partSearchButton);
            this.partsTab.Controls.Add(this.partSearchTextBox);
            this.partsTab.Location = new System.Drawing.Point(4, 25);
            this.partsTab.Margin = new System.Windows.Forms.Padding(4);
            this.partsTab.Name = "partsTab";
            this.partsTab.Padding = new System.Windows.Forms.Padding(4);
            this.partsTab.Size = new System.Drawing.Size(1021, 569);
            this.partsTab.TabIndex = 1;
            this.partsTab.Text = "Parts";
            this.partsTab.UseVisualStyleBackColor = true;
            // 
            // partAddButton
            // 
            this.partAddButton.Location = new System.Drawing.Point(695, 513);
            this.partAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.partAddButton.Name = "partAddButton";
            this.partAddButton.Size = new System.Drawing.Size(100, 28);
            this.partAddButton.TabIndex = 5;
            this.partAddButton.Text = "Add";
            this.partAddButton.UseVisualStyleBackColor = true;
            this.partAddButton.Click += new System.EventHandler(this.partAddButton_Click);
            // 
            // partModifyButton
            // 
            this.partModifyButton.Location = new System.Drawing.Point(803, 513);
            this.partModifyButton.Margin = new System.Windows.Forms.Padding(4);
            this.partModifyButton.Name = "partModifyButton";
            this.partModifyButton.Size = new System.Drawing.Size(100, 28);
            this.partModifyButton.TabIndex = 4;
            this.partModifyButton.Text = "Modify";
            this.partModifyButton.UseVisualStyleBackColor = true;
            this.partModifyButton.Click += new System.EventHandler(this.partModifyButton_Click);
            // 
            // partDeleteButton
            // 
            this.partDeleteButton.Location = new System.Drawing.Point(911, 513);
            this.partDeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.partDeleteButton.Name = "partDeleteButton";
            this.partDeleteButton.Size = new System.Drawing.Size(100, 28);
            this.partDeleteButton.TabIndex = 3;
            this.partDeleteButton.Text = "Delete";
            this.partDeleteButton.UseVisualStyleBackColor = true;
            this.partDeleteButton.Click += new System.EventHandler(this.partDeleteButton_Click);
            // 
            // partGridView
            // 
            this.partGridView.AllowUserToAddRows = false;
            this.partGridView.AllowUserToDeleteRows = false;
            this.partGridView.AllowUserToResizeColumns = false;
            this.partGridView.AllowUserToResizeRows = false;
            this.partGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partGridView.Location = new System.Drawing.Point(8, 70);
            this.partGridView.Margin = new System.Windows.Forms.Padding(4);
            this.partGridView.Name = "partGridView";
            this.partGridView.ReadOnly = true;
            this.partGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partGridView.ShowEditingIcon = false;
            this.partGridView.Size = new System.Drawing.Size(1003, 415);
            this.partGridView.TabIndex = 2;
            // 
            // partSearchButton
            // 
            this.partSearchButton.Location = new System.Drawing.Point(911, 21);
            this.partSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.partSearchButton.Name = "partSearchButton";
            this.partSearchButton.Size = new System.Drawing.Size(100, 28);
            this.partSearchButton.TabIndex = 1;
            this.partSearchButton.Text = "Search";
            this.partSearchButton.UseVisualStyleBackColor = true;
            this.partSearchButton.Click += new System.EventHandler(this.partSearchButton_Click);
            // 
            // partSearchTextBox
            // 
            this.partSearchTextBox.Location = new System.Drawing.Point(569, 23);
            this.partSearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.partSearchTextBox.Name = "partSearchTextBox";
            this.partSearchTextBox.Size = new System.Drawing.Size(332, 22);
            this.partSearchTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Available Parts (All):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Available Products:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 613);
            this.Controls.Add(this.mainFormTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainFormTabControl.ResumeLayout(false);
            this.productsTab.ResumeLayout(false);
            this.productsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.partsTab.ResumeLayout(false);
            this.partsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainFormTabControl;
        private System.Windows.Forms.TabPage productsTab;
        private System.Windows.Forms.TabPage partsTab;
        private System.Windows.Forms.Button partSearchButton;
        private System.Windows.Forms.TextBox partSearchTextBox;
        private System.Windows.Forms.Button productAddButton;
        private System.Windows.Forms.Button productModifyButton;
        private System.Windows.Forms.Button productDeleteButton;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.Button productSearchButton;
        private System.Windows.Forms.TextBox productSearchTextBox;
        private System.Windows.Forms.Button partAddButton;
        private System.Windows.Forms.Button partModifyButton;
        private System.Windows.Forms.Button partDeleteButton;
        private System.Windows.Forms.DataGridView partGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

