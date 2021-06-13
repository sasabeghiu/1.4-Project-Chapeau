
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
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.labelOrder = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonOrderView = new System.Windows.Forms.Button();
            this.buttonBarKitchen = new System.Windows.Forms.Button();
            this.buttonTable = new System.Windows.Forms.Button();
            this.buttonComplete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.labelItem = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxItem = new System.Windows.Forms.TextBox();
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
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewOrder.FullRowSelect = true;
            this.listViewOrder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(559, 46);
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(506, 403);
            this.listViewOrder.TabIndex = 3;
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Order#";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MenuItem ID";
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Comment";
            this.columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Table#";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Order Time";
            this.columnHeader8.Width = 110;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(559, 28);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(37, 15);
            this.labelOrder.TabIndex = 4;
            this.labelOrder.Text = "Order";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(406, 138);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(147, 56);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add To Order";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(406, 200);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(147, 56);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Remove From Order";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(406, 262);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(147, 56);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.Text = "Refresh Order";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
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
            this.buttonComplete.Location = new System.Drawing.Point(406, 324);
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.Size = new System.Drawing.Size(147, 56);
            this.buttonComplete.TabIndex = 11;
            this.buttonComplete.Text = "Complete Order";
            this.buttonComplete.UseVisualStyleBackColor = true;
            this.buttonComplete.Click += new System.EventHandler(this.buttonComplete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(406, 386);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(147, 56);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel Order";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
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
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(460, 46);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(31, 15);
            this.labelItem.TabIndex = 14;
            this.labelItem.Text = "Item";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(449, 91);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(53, 15);
            this.labelQuantity.TabIndex = 15;
            this.labelQuantity.Text = "Quantity";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(429, 109);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 23);
            this.textBoxQuantity.TabIndex = 16;
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(429, 64);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(100, 23);
            this.textBoxItem.TabIndex = 17;
            // 
            // OrderMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 454);
            this.Controls.Add(this.textBoxItem);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonComplete);
            this.Controls.Add(this.buttonTable);
            this.Controls.Add(this.buttonBarKitchen);
            this.Controls.Add(this.buttonOrderView);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.listViewOrder);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.listViewMenus);
            this.Name = "OrderMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonOrderView;
        private System.Windows.Forms.Button buttonBarKitchen;
        private System.Windows.Forms.Button buttonTable;
        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxItem;
    }
}