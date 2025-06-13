namespace ForterroAnasIdrissiCodeChallenge
{
    partial class MainForm
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
            this.productsListingDataGridView = new System.Windows.Forms.DataGridView();
            this.ProductsListingActionsGroupBox = new System.Windows.Forms.GroupBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsListingDataGridView)).BeginInit();
            this.ProductsListingActionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsListingDataGridView
            // 
            this.productsListingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsListingDataGridView.Location = new System.Drawing.Point(12, 146);
            this.productsListingDataGridView.Name = "productsListingDataGridView";
            this.productsListingDataGridView.RowHeadersWidth = 51;
            this.productsListingDataGridView.RowTemplate.Height = 24;
            this.productsListingDataGridView.Size = new System.Drawing.Size(1113, 371);
            this.productsListingDataGridView.TabIndex = 0;
            // 
            // ProductsListingActionsGroupBox
            // 
            this.ProductsListingActionsGroupBox.Controls.Add(this.deleteButton);
            this.ProductsListingActionsGroupBox.Controls.Add(this.updateButton);
            this.ProductsListingActionsGroupBox.Controls.Add(this.addProductButton);
            this.ProductsListingActionsGroupBox.Controls.Add(this.SearchLabel);
            this.ProductsListingActionsGroupBox.Controls.Add(this.searchTextBox);
            this.ProductsListingActionsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ProductsListingActionsGroupBox.Name = "ProductsListingActionsGroupBox";
            this.ProductsListingActionsGroupBox.Size = new System.Drawing.Size(1113, 71);
            this.ProductsListingActionsGroupBox.TabIndex = 1;
            this.ProductsListingActionsGroupBox.TabStop = false;
            this.ProductsListingActionsGroupBox.Text = "Product Actions";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(191, 34);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(292, 22);
            this.searchTextBox.TabIndex = 0;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(15, 37);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(165, 16);
            this.SearchLabel.TabIndex = 1;
            this.SearchLabel.Text = "Search product by name  : ";
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addProductButton.Location = new System.Drawing.Point(862, 31);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(88, 22);
            this.addProductButton.TabIndex = 2;
            this.addProductButton.Text = "+ Add";
            this.addProductButton.UseVisualStyleBackColor = false;
            // 
            // updateButton
            // 
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.updateButton.Location = new System.Drawing.Point(954, 31);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(68, 22);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkRed;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteButton.Location = new System.Drawing.Point(1028, 31);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(79, 22);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "- Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 529);
            this.Controls.Add(this.ProductsListingActionsGroupBox);
            this.Controls.Add(this.productsListingDataGridView);
            this.Name = "MainForm";
            this.Text = "Forterro Anas Idrissi Code Challenge";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsListingDataGridView)).EndInit();
            this.ProductsListingActionsGroupBox.ResumeLayout(false);
            this.ProductsListingActionsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productsListingDataGridView;
        private System.Windows.Forms.GroupBox ProductsListingActionsGroupBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
    }
}

