
namespace ChapeauUI
{
    partial class OrderDisplayMenu
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
            this.listViewMenus = new System.Windows.Forms.ListView();
            this.columnID = new System.Windows.Forms.ColumnHeader();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnStock = new System.Windows.Forms.ColumnHeader();
            this.columnPrice = new System.Windows.Forms.ColumnHeader();
            this.columnVAT = new System.Windows.Forms.ColumnHeader();
            this.columnCategory = new System.Windows.Forms.ColumnHeader();
            this.labelMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewMenus
            // 
            this.listViewMenus.CheckBoxes = true;
            this.listViewMenus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnName,
            this.columnStock,
            this.columnPrice,
            this.columnVAT,
            this.columnCategory});
            this.listViewMenus.FullRowSelect = true;
            this.listViewMenus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewMenus.HideSelection = false;
            this.listViewMenus.Location = new System.Drawing.Point(3, 51);
            this.listViewMenus.Name = "listViewMenus";
            this.listViewMenus.Size = new System.Drawing.Size(427, 403);
            this.listViewMenus.TabIndex = 0;
            this.listViewMenus.UseCompatibleStateImageBehavior = false;
            this.listViewMenus.View = System.Windows.Forms.View.Details;
            this.listViewMenus.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            // 
            // columnStock
            // 
            this.columnStock.Text = "Stock";
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            // 
            // columnVAT
            // 
            this.columnVAT.Text = "VAT";
            // 
            // columnCategory
            // 
            this.columnCategory.Text = "Category";
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Location = new System.Drawing.Point(3, 22);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(38, 15);
            this.labelMenu.TabIndex = 1;
            this.labelMenu.Text = "Menu";
            // 
            // OrderDisplayMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 454);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.listViewMenus);
            this.Name = "OrderDisplayMenu";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMenus;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnStock;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnVAT;
        private System.Windows.Forms.ColumnHeader columnCategory;
        private System.Windows.Forms.Label labelMenu;
    }
}