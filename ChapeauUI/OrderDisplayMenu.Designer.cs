
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnID = new System.Windows.Forms.ColumnHeader();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnStock = new System.Windows.Forms.ColumnHeader();
            this.columnPrice = new System.Windows.Forms.ColumnHeader();
            this.columnVAT = new System.Windows.Forms.ColumnHeader();
            this.columnCategory = new System.Windows.Forms.ColumnHeader();
            this.labelMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnName,
            this.columnStock,
            this.columnPrice,
            this.columnVAT,
            this.columnCategory});
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(427, 403);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            this.ClientSize = new System.Drawing.Size(450, 454);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.listView1);
            this.Name = "OrderDisplayMenu";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnStock;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnVAT;
        private System.Windows.Forms.ColumnHeader columnCategory;
        private System.Windows.Forms.Label labelMenu;
    }
}