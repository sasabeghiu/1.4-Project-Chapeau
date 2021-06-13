
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
            this.btnPreviousB = new System.Windows.Forms.Button();
            this.btnMarkAsReady = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewCurrentOrders = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.status = new System.Windows.Forms.ColumnHeader();
            this.time = new System.Windows.Forms.ColumnHeader();
            this.panelBarPrevious = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCurrentB = new System.Windows.Forms.Button();
            this.btnMarkAsReadyBP = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewPreviousOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.panelBarCurrent.SuspendLayout();
            this.panelBarPrevious.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarCurrent
            // 
            this.panelBarCurrent.Controls.Add(this.btnPreviousB);
            this.panelBarCurrent.Controls.Add(this.btnMarkAsReady);
            this.panelBarCurrent.Controls.Add(this.btnLogOut);
            this.panelBarCurrent.Controls.Add(this.label1);
            this.panelBarCurrent.Controls.Add(this.label2);
            this.panelBarCurrent.Controls.Add(this.listViewCurrentOrders);
            this.panelBarCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBarCurrent.Location = new System.Drawing.Point(0, 0);
            this.panelBarCurrent.Name = "panelBarCurrent";
            this.panelBarCurrent.Size = new System.Drawing.Size(800, 450);
            this.panelBarCurrent.TabIndex = 6;
            // 
            // btnPreviousB
            // 
            this.btnPreviousB.Location = new System.Drawing.Point(14, 404);
            this.btnPreviousB.Name = "btnPreviousB";
            this.btnPreviousB.Size = new System.Drawing.Size(133, 35);
            this.btnPreviousB.TabIndex = 5;
            this.btnPreviousB.Text = "Previous Orders";
            this.btnPreviousB.UseVisualStyleBackColor = true;
            this.btnPreviousB.Click += new System.EventHandler(this.btnPreviousB_Click);
            // 
            // btnMarkAsReady
            // 
            this.btnMarkAsReady.Location = new System.Drawing.Point(322, 404);
            this.btnMarkAsReady.Name = "btnMarkAsReady";
            this.btnMarkAsReady.Size = new System.Drawing.Size(133, 35);
            this.btnMarkAsReady.TabIndex = 4;
            this.btnMarkAsReady.Text = "Mark as ready";
            this.btnMarkAsReady.UseVisualStyleBackColor = true;
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
            this.label1.Location = new System.Drawing.Point(290, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bar Current View";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // listViewCurrentOrders
            // 
            this.listViewCurrentOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.status,
            this.time});
            this.listViewCurrentOrders.HideSelection = false;
            this.listViewCurrentOrders.Location = new System.Drawing.Point(14, 80);
            this.listViewCurrentOrders.Name = "listViewCurrentOrders";
            this.listViewCurrentOrders.Size = new System.Drawing.Size(441, 303);
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
            // panelBarPrevious
            // 
            this.panelBarPrevious.Controls.Add(this.label5);
            this.panelBarPrevious.Controls.Add(this.BtnCurrentB);
            this.panelBarPrevious.Controls.Add(this.btnMarkAsReadyBP);
            this.panelBarPrevious.Controls.Add(this.logout);
            this.panelBarPrevious.Controls.Add(this.label3);
            this.panelBarPrevious.Controls.Add(this.label4);
            this.panelBarPrevious.Controls.Add(this.listViewPreviousOrders);
            this.panelBarPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBarPrevious.Location = new System.Drawing.Point(0, 0);
            this.panelBarPrevious.Name = "panelBarPrevious";
            this.panelBarPrevious.Size = new System.Drawing.Size(800, 450);
            this.panelBarPrevious.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bar Previous View";
            // 
            // BtnCurrentB
            // 
            this.BtnCurrentB.Location = new System.Drawing.Point(14, 404);
            this.BtnCurrentB.Name = "BtnCurrentB";
            this.BtnCurrentB.Size = new System.Drawing.Size(133, 35);
            this.BtnCurrentB.TabIndex = 5;
            this.BtnCurrentB.Text = "Current Orders";
            this.BtnCurrentB.UseVisualStyleBackColor = true;
            this.BtnCurrentB.Click += new System.EventHandler(this.BtnCurrentB_Click);
            // 
            // btnMarkAsReadyBP
            // 
            this.btnMarkAsReadyBP.Location = new System.Drawing.Point(322, 404);
            this.btnMarkAsReadyBP.Name = "btnMarkAsReadyBP";
            this.btnMarkAsReadyBP.Size = new System.Drawing.Size(133, 35);
            this.btnMarkAsReadyBP.TabIndex = 4;
            this.btnMarkAsReadyBP.Text = "Mark as ready";
            this.btnMarkAsReadyBP.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(11, 19);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(94, 29);
            this.logout.TabIndex = 1;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
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
            this.listViewPreviousOrders.Location = new System.Drawing.Point(14, 80);
            this.listViewPreviousOrders.Name = "listViewPreviousOrders";
            this.listViewPreviousOrders.Size = new System.Drawing.Size(441, 303);
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
            // BarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBarCurrent);
            this.Controls.Add(this.panelBarPrevious);
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
        private System.Windows.Forms.Button btnPreviousB;
        private System.Windows.Forms.Button btnMarkAsReady;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewCurrentOrders;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.Panel panelBarPrevious;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCurrentB;
        private System.Windows.Forms.Button btnMarkAsReadyBP;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewPreviousOrders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}