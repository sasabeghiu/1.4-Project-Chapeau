
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
            this.btnMarkAsReadyKC = new System.Windows.Forms.Button();
            this.panelKitchenCurrent = new System.Windows.Forms.Panel();
            this.btnMarkAsPreparingKC = new System.Windows.Forms.Button();
            this.listViewDetailsKC = new System.Windows.Forms.ListView();
            this.qty = new System.Windows.Forms.ColumnHeader();
            this.name = new System.Windows.Forms.ColumnHeader();
            this.comment = new System.Windows.Forms.ColumnHeader();
            this.state = new System.Windows.Forms.ColumnHeader();
            this.btnPreviousK = new System.Windows.Forms.Button();
            this.lblDetailsKC = new System.Windows.Forms.Label();
            this.panelKitchenPrevious = new System.Windows.Forms.Panel();
            this.listViewDetailsKP = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.btnCurrentK = new System.Windows.Forms.Button();
            this.btnMarkAsReadyKP = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDetailsKP = new System.Windows.Forms.Label();
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
            this.listViewCurrentOrders.FullRowSelect = true;
            this.listViewCurrentOrders.HideSelection = false;
            this.listViewCurrentOrders.Location = new System.Drawing.Point(11, 107);
            this.listViewCurrentOrders.Name = "listViewCurrentOrders";
            this.listViewCurrentOrders.Size = new System.Drawing.Size(441, 303);
            this.listViewCurrentOrders.TabIndex = 0;
            this.listViewCurrentOrders.UseCompatibleStateImageBehavior = false;
            this.listViewCurrentOrders.SelectedIndexChanged += new System.EventHandler(this.listViewCurrentOrders_SelectedIndexChanged);
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
            this.btnLogOut.Location = new System.Drawing.Point(11, 19);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(94, 29);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(320, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kitchen Current View";
            // 
            // btnMarkAsReadyKC
            // 
            this.btnMarkAsReadyKC.Location = new System.Drawing.Point(319, 436);
            this.btnMarkAsReadyKC.Name = "btnMarkAsReadyKC";
            this.btnMarkAsReadyKC.Size = new System.Drawing.Size(133, 35);
            this.btnMarkAsReadyKC.TabIndex = 4;
            this.btnMarkAsReadyKC.Text = "Mark as ready";
            this.btnMarkAsReadyKC.UseVisualStyleBackColor = true;
            this.btnMarkAsReadyKC.Click += new System.EventHandler(this.btnMarkAsReadyKC_Click);
            // 
            // panelKitchenCurrent
            // 
            this.panelKitchenCurrent.Controls.Add(this.btnMarkAsPreparingKC);
            this.panelKitchenCurrent.Controls.Add(this.btnPreviousK);
            this.panelKitchenCurrent.Controls.Add(this.btnMarkAsReadyKC);
            this.panelKitchenCurrent.Controls.Add(this.btnLogOut);
            this.panelKitchenCurrent.Controls.Add(this.label1);
            this.panelKitchenCurrent.Controls.Add(this.lblDetailsKC);
            this.panelKitchenCurrent.Controls.Add(this.listViewCurrentOrders);
            this.panelKitchenCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKitchenCurrent.Location = new System.Drawing.Point(0, 0);
            this.panelKitchenCurrent.Name = "panelKitchenCurrent";
            this.panelKitchenCurrent.Size = new System.Drawing.Size(896, 481);
            this.panelKitchenCurrent.TabIndex = 5;
            // 
            // btnMarkAsPreparingKC
            // 
            this.btnMarkAsPreparingKC.Location = new System.Drawing.Point(695, 436);
            this.btnMarkAsPreparingKC.Name = "btnMarkAsPreparingKC";
            this.btnMarkAsPreparingKC.Size = new System.Drawing.Size(172, 29);
            this.btnMarkAsPreparingKC.TabIndex = 8;
            this.btnMarkAsPreparingKC.Text = "Mark as preparing";
            this.btnMarkAsPreparingKC.UseVisualStyleBackColor = true;
            this.btnMarkAsPreparingKC.Click += new System.EventHandler(this.btnMarkAsPreparingKC_Click);
            // 
            // listViewDetailsKC
            // 
            this.listViewDetailsKC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.qty,
            this.name,
            this.comment,
            this.state});
            this.listViewDetailsKC.FullRowSelect = true;
            this.listViewDetailsKC.HideSelection = false;
            this.listViewDetailsKC.Location = new System.Drawing.Point(527, 107);
            this.listViewDetailsKC.Name = "listViewDetailsKC";
            this.listViewDetailsKC.Size = new System.Drawing.Size(340, 364);
            this.listViewDetailsKC.TabIndex = 6;
            this.listViewDetailsKC.UseCompatibleStateImageBehavior = false;
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
            // comment
            // 
            this.comment.DisplayIndex = 3;
            this.comment.Text = "Comment";
            // 
            // state
            // 
            this.state.DisplayIndex = 2;
            this.state.Text = "Status";
            this.state.Width = 80;
            // 
            // btnPreviousK
            // 
            this.btnPreviousK.Location = new System.Drawing.Point(11, 436);
            this.btnPreviousK.Name = "btnPreviousK";
            this.btnPreviousK.Size = new System.Drawing.Size(133, 35);
            this.btnPreviousK.TabIndex = 5;
            this.btnPreviousK.Text = "Previous Orders";
            this.btnPreviousK.UseVisualStyleBackColor = true;
            this.btnPreviousK.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblDetailsKC
            // 
            this.lblDetailsKC.AutoSize = true;
            this.lblDetailsKC.Location = new System.Drawing.Point(598, 72);
            this.lblDetailsKC.Name = "lblDetailsKC";
            this.lblDetailsKC.Size = new System.Drawing.Size(189, 20);
            this.lblDetailsKC.TabIndex = 7;
            this.lblDetailsKC.Text = "Order Details for Order  #()";
            // 
            // panelKitchenPrevious
            // 
            this.panelKitchenPrevious.Controls.Add(this.listViewDetailsKC);
            this.panelKitchenPrevious.Controls.Add(this.listViewDetailsKP);
            this.panelKitchenPrevious.Controls.Add(this.btnCurrentK);
            this.panelKitchenPrevious.Controls.Add(this.btnMarkAsReadyKP);
            this.panelKitchenPrevious.Controls.Add(this.button3);
            this.panelKitchenPrevious.Controls.Add(this.label3);
            this.panelKitchenPrevious.Controls.Add(this.lblDetailsKP);
            this.panelKitchenPrevious.Controls.Add(this.listViewPreviousOrders);
            this.panelKitchenPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKitchenPrevious.Location = new System.Drawing.Point(0, 0);
            this.panelKitchenPrevious.Name = "panelKitchenPrevious";
            this.panelKitchenPrevious.Size = new System.Drawing.Size(896, 481);
            this.panelKitchenPrevious.TabIndex = 6;
            // 
            // listViewDetailsKP
            // 
            this.listViewDetailsKP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewDetailsKP.HideSelection = false;
            this.listViewDetailsKP.Location = new System.Drawing.Point(527, 107);
            this.listViewDetailsKP.Name = "listViewDetailsKP";
            this.listViewDetailsKP.Size = new System.Drawing.Size(340, 303);
            this.listViewDetailsKP.TabIndex = 7;
            this.listViewDetailsKP.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Qty";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 170;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            this.columnHeader6.Width = 80;
            // 
            // btnCurrentK
            // 
            this.btnCurrentK.Location = new System.Drawing.Point(14, 436);
            this.btnCurrentK.Name = "btnCurrentK";
            this.btnCurrentK.Size = new System.Drawing.Size(133, 35);
            this.btnCurrentK.TabIndex = 5;
            this.btnCurrentK.Text = "Current Orders";
            this.btnCurrentK.UseVisualStyleBackColor = true;
            this.btnCurrentK.Click += new System.EventHandler(this.btnCurrent_Click);
            // 
            // btnMarkAsReadyKP
            // 
            this.btnMarkAsReadyKP.Location = new System.Drawing.Point(320, 436);
            this.btnMarkAsReadyKP.Name = "btnMarkAsReadyKP";
            this.btnMarkAsReadyKP.Size = new System.Drawing.Size(133, 35);
            this.btnMarkAsReadyKP.TabIndex = 4;
            this.btnMarkAsReadyKP.Text = "Mark as ready";
            this.btnMarkAsReadyKP.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitchen Previous View";
            // 
            // lblDetailsKP
            // 
            this.lblDetailsKP.AutoSize = true;
            this.lblDetailsKP.Location = new System.Drawing.Point(569, 72);
            this.lblDetailsKP.Name = "lblDetailsKP";
            this.lblDetailsKP.Size = new System.Drawing.Size(189, 20);
            this.lblDetailsKP.TabIndex = 3;
            this.lblDetailsKP.Text = "Order Details for Order  #()";
            // 
            // listViewPreviousOrders
            // 
            this.listViewPreviousOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewPreviousOrders.FullRowSelect = true;
            this.listViewPreviousOrders.HideSelection = false;
            this.listViewPreviousOrders.Location = new System.Drawing.Point(11, 107);
            this.listViewPreviousOrders.Name = "listViewPreviousOrders";
            this.listViewPreviousOrders.Size = new System.Drawing.Size(441, 303);
            this.listViewPreviousOrders.TabIndex = 0;
            this.listViewPreviousOrders.UseCompatibleStateImageBehavior = false;
            this.listViewPreviousOrders.SelectedIndexChanged += new System.EventHandler(this.listViewPreviousOrders_SelectedIndexChanged_1);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 481);
            this.Controls.Add(this.panelKitchenPrevious);
            this.Controls.Add(this.panelKitchenCurrent);
            this.Name = "KitchenView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitchenView";
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
        private System.Windows.Forms.Button btnMarkAsReadyKC;
        private System.Windows.Forms.Panel panelKitchenCurrent;
        private System.Windows.Forms.Button btnPreviousK;
        private System.Windows.Forms.Panel panelKitchenPrevious;
        private System.Windows.Forms.Button btnCurrentK;
        private System.Windows.Forms.Button btnMarkAsReadyKP;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDetailsKP;
        private System.Windows.Forms.ListView listViewPreviousOrders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listViewDetailsKC;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader state;
        private System.Windows.Forms.ListView listViewDetailsKP;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblDetailsKC;
        private System.Windows.Forms.Button btnMarkAsPreparingKC;
        private System.Windows.Forms.ColumnHeader comment;
    }
}