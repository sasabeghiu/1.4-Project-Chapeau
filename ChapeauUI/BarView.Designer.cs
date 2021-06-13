
namespace ChapeauUI
{
    partial class BarView
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
            this.panelBarCurrent = new System.Windows.Forms.Panel();
            this.btnMarkAsPreparingB = new System.Windows.Forms.Button();
            this.listViewDetailsBC = new System.Windows.Forms.ListView();
            this.qty = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.state = new System.Windows.Forms.ColumnHeader();
            this.btnPreviousB = new System.Windows.Forms.Button();
            this.btnMarkAsReadyBC = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDetailsBC = new System.Windows.Forms.Label();
            this.listViewCurrentOrders = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.status = new System.Windows.Forms.ColumnHeader();
            this.time = new System.Windows.Forms.ColumnHeader();
            this.panelBarPrevious = new System.Windows.Forms.Panel();
            this.listViewDetailsBP = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.BtnCurrentB = new System.Windows.Forms.Button();
            this.btnMarkAsReadyBP = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDetailsBP = new System.Windows.Forms.Label();
            this.listViewPreviousOrders = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.panelBarCurrent.SuspendLayout();
            this.panelBarPrevious.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarCurrent
            // 
            this.panelBarCurrent.Controls.Add(this.btnMarkAsPreparingB);
            this.panelBarCurrent.Controls.Add(this.listViewDetailsBC);
            this.panelBarCurrent.Controls.Add(this.btnPreviousB);
            this.panelBarCurrent.Controls.Add(this.btnMarkAsReadyBC);
            this.panelBarCurrent.Controls.Add(this.btnLogOut);
            this.panelBarCurrent.Controls.Add(this.label1);
            this.panelBarCurrent.Controls.Add(this.lblDetailsBC);
            this.panelBarCurrent.Controls.Add(this.listViewCurrentOrders);
            this.panelBarCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBarCurrent.Location = new System.Drawing.Point(0, 0);
            this.panelBarCurrent.Name = "panelBarCurrent";
            this.panelBarCurrent.Size = new System.Drawing.Size(896, 481);
            this.panelBarCurrent.TabIndex = 8;
            // 
            // btnMarkAsPreparingB
            // 
            this.btnMarkAsPreparingB.Location = new System.Drawing.Point(719, 436);
            this.btnMarkAsPreparingB.Name = "btnMarkAsPreparingB";
            this.btnMarkAsPreparingB.Size = new System.Drawing.Size(148, 29);
            this.btnMarkAsPreparingB.TabIndex = 8;
            this.btnMarkAsPreparingB.Text = "Mark as preparing";
            this.btnMarkAsPreparingB.UseVisualStyleBackColor = true;
            this.btnMarkAsPreparingB.Click += new System.EventHandler(this.btnMarkAsPreparingB_Click);
            // 
            // listViewDetailsBC
            // 
            this.listViewDetailsBC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.qty,
            this.name,
            this.state});
            this.listViewDetailsBC.FullRowSelect = true;
            this.listViewDetailsBC.HideSelection = false;
            this.listViewDetailsBC.Location = new System.Drawing.Point(527, 107);
            this.listViewDetailsBC.Name = "listViewDetailsBC";
            this.listViewDetailsBC.Size = new System.Drawing.Size(340, 303);
            this.listViewDetailsBC.TabIndex = 6;
            this.listViewDetailsBC.UseCompatibleStateImageBehavior = false;
            // 
            // qty
            // 
            this.qty.Text = "Qty";
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 170;
            // 
            // state
            // 
            this.state.Text = "Status";
            this.state.Width = 80;
            // 
            // btnPreviousB
            // 
            this.btnPreviousB.Location = new System.Drawing.Point(11, 436);
            this.btnPreviousB.Name = "btnPreviousB";
            this.btnPreviousB.Size = new System.Drawing.Size(133, 35);
            this.btnPreviousB.TabIndex = 5;
            this.btnPreviousB.Text = "Previous Orders";
            this.btnPreviousB.UseVisualStyleBackColor = true;
            this.btnPreviousB.Click += new System.EventHandler(this.btnPreviousB_Click_1);
            // 
            // btnMarkAsReadyBC
            // 
            this.btnMarkAsReadyBC.Location = new System.Drawing.Point(319, 436);
            this.btnMarkAsReadyBC.Name = "btnMarkAsReadyBC";
            this.btnMarkAsReadyBC.Size = new System.Drawing.Size(133, 35);
            this.btnMarkAsReadyBC.TabIndex = 4;
            this.btnMarkAsReadyBC.Text = "Mark as ready";
            this.btnMarkAsReadyBC.UseVisualStyleBackColor = true;
            this.btnMarkAsReadyBC.Click += new System.EventHandler(this.btnMarkAsReadyBC_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(11, 19);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(94, 29);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(319, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bar Current View";
            // 
            // lblDetailsBC
            // 
            this.lblDetailsBC.AutoSize = true;
            this.lblDetailsBC.Location = new System.Drawing.Point(598, 63);
            this.lblDetailsBC.Name = "lblDetailsBC";
            this.lblDetailsBC.Size = new System.Drawing.Size(189, 20);
            this.lblDetailsBC.TabIndex = 7;
            this.lblDetailsBC.Text = "Order Details for Order  #()";
            // 
            // listViewCurrentOrders
            // 
            this.listViewCurrentOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.status,
            this.time});
            this.listViewCurrentOrders.FullRowSelect = true;
            this.listViewCurrentOrders.HideSelection = false;
            this.listViewCurrentOrders.Location = new System.Drawing.Point(11, 107);
            this.listViewCurrentOrders.Name = "listViewCurrentOrders";
            this.listViewCurrentOrders.Size = new System.Drawing.Size(441, 303);
            this.listViewCurrentOrders.TabIndex = 0;
            this.listViewCurrentOrders.UseCompatibleStateImageBehavior = false;
            this.listViewCurrentOrders.SelectedIndexChanged += new System.EventHandler(this.listViewCurrentOrders_SelectedIndexChanged_1);
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
            // panelBarPrevious
            // 
            this.panelBarPrevious.Controls.Add(this.listViewDetailsBP);
            this.panelBarPrevious.Controls.Add(this.BtnCurrentB);
            this.panelBarPrevious.Controls.Add(this.btnMarkAsReadyBP);
            this.panelBarPrevious.Controls.Add(this.button3);
            this.panelBarPrevious.Controls.Add(this.label2);
            this.panelBarPrevious.Controls.Add(this.lblDetailsBP);
            this.panelBarPrevious.Controls.Add(this.listViewPreviousOrders);
            this.panelBarPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBarPrevious.Location = new System.Drawing.Point(0, 0);
            this.panelBarPrevious.Name = "panelBarPrevious";
            this.panelBarPrevious.Size = new System.Drawing.Size(896, 481);
            this.panelBarPrevious.TabIndex = 8;
            // 
            // listViewDetailsBP
            // 
            this.listViewDetailsBP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewDetailsBP.FullRowSelect = true;
            this.listViewDetailsBP.HideSelection = false;
            this.listViewDetailsBP.Location = new System.Drawing.Point(527, 107);
            this.listViewDetailsBP.Name = "listViewDetailsBP";
            this.listViewDetailsBP.Size = new System.Drawing.Size(340, 358);
            this.listViewDetailsBP.TabIndex = 6;
            this.listViewDetailsBP.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Qty";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 80;
            // 
            // BtnCurrentB
            // 
            this.BtnCurrentB.Location = new System.Drawing.Point(11, 436);
            this.BtnCurrentB.Name = "BtnCurrentB";
            this.BtnCurrentB.Size = new System.Drawing.Size(133, 35);
            this.BtnCurrentB.TabIndex = 5;
            this.BtnCurrentB.Text = "Current Orders";
            this.BtnCurrentB.UseVisualStyleBackColor = true;
            this.BtnCurrentB.Click += new System.EventHandler(this.BtnCurrentB_Click);
            // 
            // btnMarkAsReadyBP
            // 
            this.btnMarkAsReadyBP.Location = new System.Drawing.Point(319, 436);
            this.btnMarkAsReadyBP.Name = "btnMarkAsReadyBP";
            this.btnMarkAsReadyBP.Size = new System.Drawing.Size(133, 35);
            this.btnMarkAsReadyBP.TabIndex = 4;
            this.btnMarkAsReadyBP.Text = "Mark as ready";
            this.btnMarkAsReadyBP.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 1;
            this.button3.Text = "Log Out";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(319, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bar Previous View";
            // 
            // lblDetailsBP
            // 
            this.lblDetailsBP.AutoSize = true;
            this.lblDetailsBP.Location = new System.Drawing.Point(598, 73);
            this.lblDetailsBP.Name = "lblDetailsBP";
            this.lblDetailsBP.Size = new System.Drawing.Size(189, 20);
            this.lblDetailsBP.TabIndex = 7;
            this.lblDetailsBP.Text = "Order Details for Order  #()";
            // 
            // listViewPreviousOrders
            // 
            this.listViewPreviousOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewPreviousOrders.FullRowSelect = true;
            this.listViewPreviousOrders.HideSelection = false;
            this.listViewPreviousOrders.Location = new System.Drawing.Point(11, 107);
            this.listViewPreviousOrders.Name = "listViewPreviousOrders";
            this.listViewPreviousOrders.Size = new System.Drawing.Size(441, 303);
            this.listViewPreviousOrders.TabIndex = 0;
            this.listViewPreviousOrders.UseCompatibleStateImageBehavior = false;
            this.listViewPreviousOrders.SelectedIndexChanged += new System.EventHandler(this.listViewPreviousOrders_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Order ID";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Order Status";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Time";
            this.columnHeader6.Width = 150;
            // 
            // BarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 481);
            this.Controls.Add(this.panelBarPrevious);
            this.Controls.Add(this.panelBarCurrent);
            this.Name = "BarView";
            this.Text = "BarView";
            this.panelBarCurrent.ResumeLayout(false);
            this.panelBarCurrent.PerformLayout();
            this.panelBarPrevious.ResumeLayout(false);
            this.panelBarPrevious.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarCurrent;
        private System.Windows.Forms.ListView listViewDetailsBC;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader state;
        private System.Windows.Forms.Button btnPreviousB;
        private System.Windows.Forms.Button btnMarkAsReadyBC;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDetailsBC;
        private System.Windows.Forms.ListView listViewCurrentOrders;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.Panel panelBarPrevious;
        private System.Windows.Forms.ListView listViewDetailsBP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button BtnCurrentB;
        private System.Windows.Forms.Button btnMarkAsReadyBP;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDetailsBP;
        private System.Windows.Forms.ListView listViewPreviousOrders;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnMarkAsPreparingB;
    }
}