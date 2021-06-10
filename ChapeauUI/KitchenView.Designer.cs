
namespace ChapeauUI
{
    partial class KitchenView
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
            this.listViewKitchen = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.status = new System.Windows.Forms.ColumnHeader();
            this.time = new System.Windows.Forms.ColumnHeader();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.listViewOrderDetails = new System.Windows.Forms.ListView();
            this.quantity = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listViewKitchen
            // 
            this.listViewKitchen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.status,
            this.time});
            this.listViewKitchen.HideSelection = false;
            this.listViewKitchen.Location = new System.Drawing.Point(12, 126);
            this.listViewKitchen.Name = "listViewKitchen";
            this.listViewKitchen.Size = new System.Drawing.Size(440, 312);
            this.listViewKitchen.TabIndex = 0;
            this.listViewKitchen.UseCompatibleStateImageBehavior = false;
            // 
            // Id
            // 
            this.Id.Text = "Order ID";
            this.Id.Width = 80;
            // 
            // status
            // 
            this.status.Text = "Order Status";
            this.status.Width = 100;
            // 
            // time
            // 
            this.time.Text = "Time";
            this.time.Width = 150;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(12, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(94, 29);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // listViewOrderDetails
            // 
            this.listViewOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.quantity,
            this.name});
            this.listViewOrderDetails.HideSelection = false;
            this.listViewOrderDetails.Location = new System.Drawing.Point(487, 126);
            this.listViewOrderDetails.Name = "listViewOrderDetails";
            this.listViewOrderDetails.Size = new System.Drawing.Size(301, 312);
            this.listViewOrderDetails.TabIndex = 2;
            this.listViewOrderDetails.UseCompatibleStateImageBehavior = false;
            // 
            // quantity
            // 
            this.quantity.Text = "Qty";
            // 
            // name
            // 
            this.name.Text = "Name";
            // 
            // KitchenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewOrderDetails);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.listViewKitchen);
            this.Name = "KitchenView";
            this.Text = "KitchenViewcs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewKitchen;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ListView listViewOrderDetails;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader name;
    }
}