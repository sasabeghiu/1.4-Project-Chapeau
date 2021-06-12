
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
            this.listViewCurrentOrders = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.status = new System.Windows.Forms.ColumnHeader();
            this.time = new System.Windows.Forms.ColumnHeader();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMarkAsReady = new System.Windows.Forms.Button();
            this.panelKitchenCurrent = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.panelKitchenPrevious = new System.Windows.Forms.Panel();
            this.btnCurrent = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewPreviousOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.panelKitchenCurrent.SuspendLayout();
            this.panelKitchenPrevious.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewCurrentOrders
            // 
            this.listViewCurrentOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.status,
            this.time});
            this.listViewCurrentOrders.HideSelection = false;
            this.listViewCurrentOrders.Location = new System.Drawing.Point(10, 80);
            this.listViewCurrentOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewCurrentOrders.Name = "listViewCurrentOrders";
            this.listViewCurrentOrders.Size = new System.Drawing.Size(386, 228);
            this.listViewCurrentOrders.TabIndex = 0;
            this.listViewCurrentOrders.UseCompatibleStateImageBehavior = false;
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
            this.btnLogOut.Location = new System.Drawing.Point(10, 14);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(82, 22);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // btnMarkAsReady
            // 
            this.btnMarkAsReady.Location = new System.Drawing.Point(280, 327);
            this.btnMarkAsReady.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMarkAsReady.Name = "btnMarkAsReady";
            this.btnMarkAsReady.Size = new System.Drawing.Size(116, 26);
            this.btnMarkAsReady.TabIndex = 4;
            this.btnMarkAsReady.Text = "Mark as ready";
            this.btnMarkAsReady.UseVisualStyleBackColor = true;
            // 
            // panelKitchenCurrent
            // 
            this.panelKitchenCurrent.Controls.Add(this.btnPrevious);
            this.panelKitchenCurrent.Controls.Add(this.btnMarkAsReady);
            this.panelKitchenCurrent.Controls.Add(this.btnLogOut);
            this.panelKitchenCurrent.Controls.Add(this.label1);
            this.panelKitchenCurrent.Controls.Add(this.label2);
            this.panelKitchenCurrent.Controls.Add(this.listViewCurrentOrders);
            this.panelKitchenCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKitchenCurrent.Location = new System.Drawing.Point(0, 0);
            this.panelKitchenCurrent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelKitchenCurrent.Name = "panelKitchenCurrent";
            this.panelKitchenCurrent.Size = new System.Drawing.Size(784, 361);
            this.panelKitchenCurrent.TabIndex = 5;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 327);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(116, 26);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Previous Orders";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // panelKitchenPrevious
            // 
            this.panelKitchenPrevious.Controls.Add(this.btnCurrent);
            this.panelKitchenPrevious.Controls.Add(this.button2);
            this.panelKitchenPrevious.Controls.Add(this.button3);
            this.panelKitchenPrevious.Controls.Add(this.label3);
            this.panelKitchenPrevious.Controls.Add(this.label4);
            this.panelKitchenPrevious.Controls.Add(this.listViewPreviousOrders);
            this.panelKitchenPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKitchenPrevious.Location = new System.Drawing.Point(0, 0);
            this.panelKitchenPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelKitchenPrevious.Name = "panelKitchenPrevious";
            this.panelKitchenPrevious.Size = new System.Drawing.Size(784, 361);
            this.panelKitchenPrevious.TabIndex = 6;
            // 
            // btnCurrent
            // 
            this.btnCurrent.Location = new System.Drawing.Point(12, 327);
            this.btnCurrent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.Size = new System.Drawing.Size(116, 26);
            this.btnCurrent.TabIndex = 5;
            this.btnCurrent.Text = "Current Orders";
            this.btnCurrent.UseVisualStyleBackColor = true;
            this.btnCurrent.Click += new System.EventHandler(this.btnCurrent_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 327);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 26);
            this.button2.TabIndex = 4;
            this.button2.Text = "Mark as ready";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 14);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 22);
            this.button3.TabIndex = 1;
            this.button3.Text = "Log Out";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // listViewPreviousOrders
            // 
            this.listViewPreviousOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewPreviousOrders.HideSelection = false;
            this.listViewPreviousOrders.Location = new System.Drawing.Point(10, 80);
            this.listViewPreviousOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewPreviousOrders.Name = "listViewPreviousOrders";
            this.listViewPreviousOrders.Size = new System.Drawing.Size(386, 228);
            this.listViewPreviousOrders.TabIndex = 0;
            this.listViewPreviousOrders.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Order Status";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time";
            this.columnHeader3.Width = 150;
            // 
            // KitchenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.panelKitchenCurrent);
            this.Controls.Add(this.panelKitchenPrevious);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KitchenView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitchenView";
            this.Load += new System.EventHandler(this.KitchenView_Load);
            this.panelKitchenCurrent.ResumeLayout(false);
            this.panelKitchenCurrent.PerformLayout();
            this.panelKitchenPrevious.ResumeLayout(false);
            this.panelKitchenPrevious.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCurrentOrders;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMarkAsReady;
        private System.Windows.Forms.Panel panelKitchenCurrent;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Panel panelKitchenPrevious;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewPreviousOrders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}