
namespace ChapeauUI
{
    partial class OrderMain
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
            this.listViewOrder = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.labelOrder = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonOrderView = new System.Windows.Forms.Button();
            this.buttonBarKitchen = new System.Windows.Forms.Button();
            this.buttonTable = new System.Windows.Forms.Button();
            this.buttonComplete = new System.Windows.Forms.Button();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.labelTable = new System.Windows.Forms.Label();
            this.textBoxTableNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.listViewMenus.Location = new System.Drawing.Point(-1, 46);
            this.listViewMenus.Name = "listViewMenus";
            this.listViewMenus.Size = new System.Drawing.Size(401, 403);
            this.listViewMenus.TabIndex = 1;
            this.listViewMenus.UseCompatibleStateImageBehavior = false;
            this.listViewMenus.View = System.Windows.Forms.View.Details;
            this.listViewMenus.SelectedIndexChanged += new System.EventHandler(this.listViewMenus_SelectedIndexChanged);
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
            this.labelMenu.Location = new System.Drawing.Point(-1, 28);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(38, 15);
            this.labelMenu.TabIndex = 2;
            this.labelMenu.Text = "Menu";
            // 
            // listViewOrder
            // 
            this.listViewOrder.CheckBoxes = true;
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader5});
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(633, 46);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(432, 403);
            this.listViewOrder.TabIndex = 3;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Comment";
            this.columnHeader5.Width = 75;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(633, 28);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(37, 15);
            this.labelOrder.TabIndex = 4;
            this.labelOrder.Text = "Order";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(406, 269);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(221, 56);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add To Order";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(406, 331);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(221, 56);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Remove From Order";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonOrderView
            // 
            this.buttonOrderView.Location = new System.Drawing.Point(277, 2);
            this.buttonOrderView.Name = "buttonOrderView";
            this.buttonOrderView.Size = new System.Drawing.Size(123, 23);
            this.buttonOrderView.TabIndex = 8;
            this.buttonOrderView.Text = "Order View";
            this.buttonOrderView.UseVisualStyleBackColor = true;
            this.buttonOrderView.Click += new System.EventHandler(this.buttonOrderView_Click);
            // 
            // buttonBarKitchen
            // 
            this.buttonBarKitchen.Location = new System.Drawing.Point(137, 2);
            this.buttonBarKitchen.Name = "buttonBarKitchen";
            this.buttonBarKitchen.Size = new System.Drawing.Size(123, 23);
            this.buttonBarKitchen.TabIndex = 9;
            this.buttonBarKitchen.Text = "Bar+Kitchen View";
            this.buttonBarKitchen.UseVisualStyleBackColor = true;
            this.buttonBarKitchen.Click += new System.EventHandler(this.buttonBarKitchen_Click);
            // 
            // buttonTable
            // 
            this.buttonTable.Location = new System.Drawing.Point(-1, 2);
            this.buttonTable.Name = "buttonTable";
            this.buttonTable.Size = new System.Drawing.Size(123, 23);
            this.buttonTable.TabIndex = 10;
            this.buttonTable.Text = "Table View";
            this.buttonTable.UseVisualStyleBackColor = true;
            this.buttonTable.Click += new System.EventHandler(this.buttonTable_Click);
            // 
            // buttonComplete
            // 
            this.buttonComplete.Location = new System.Drawing.Point(406, 393);
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.Size = new System.Drawing.Size(221, 56);
            this.buttonComplete.TabIndex = 11;
            this.buttonComplete.Text = "Complete Order";
            this.buttonComplete.UseVisualStyleBackColor = true;
            this.buttonComplete.Click += new System.EventHandler(this.buttonComplete_Click);
            // 
            // buttonPayment
            // 
            this.buttonPayment.Location = new System.Drawing.Point(406, 2);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(123, 23);
            this.buttonPayment.TabIndex = 13;
            this.buttonPayment.Text = "Payment View";
            this.buttonPayment.UseVisualStyleBackColor = true;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Location = new System.Drawing.Point(472, 28);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(81, 15);
            this.labelTable.TabIndex = 15;
            this.labelTable.Text = "Table Number";
            this.labelTable.Click += new System.EventHandler(this.labelQuantity_Click);
            // 
            // textBoxTableNumber
            // 
            this.textBoxTableNumber.Location = new System.Drawing.Point(462, 47);
            this.textBoxTableNumber.Name = "textBoxTableNumber";
            this.textBoxTableNumber.Size = new System.Drawing.Size(100, 23);
            this.textBoxTableNumber.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 56);
            this.button1.TabIndex = 17;
            this.button1.Text = "Go To Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTableNumber);
            this.Controls.Add(this.labelTable);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.buttonComplete);
            this.Controls.Add(this.buttonTable);
            this.Controls.Add(this.buttonBarKitchen);
            this.Controls.Add(this.buttonOrderView);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.listViewMenus);
            this.Name = "OrderMain";
            this.Text = "OrderMain";
            this.Load += new System.EventHandler(this.OrderMain_Load);
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
        private System.Windows.Forms.ListView listViewOrder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonOrderView;
        private System.Windows.Forms.Button buttonBarKitchen;
        private System.Windows.Forms.Button buttonTable;
        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.TextBox textBoxTableNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}