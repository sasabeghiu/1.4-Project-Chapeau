
namespace ChapeauUI
{
    partial class TableOrderView
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
            this.lbl_OrderView = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_seatGuests = new System.Windows.Forms.Button();
            this.lbl_Reservation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_OrderView
            // 
            this.lbl_OrderView.AutoSize = true;
            this.lbl_OrderView.Location = new System.Drawing.Point(344, 30);
            this.lbl_OrderView.Name = "lbl_OrderView";
            this.lbl_OrderView.Size = new System.Drawing.Size(65, 15);
            this.lbl_OrderView.TabIndex = 0;
            this.lbl_OrderView.Text = "Order View";
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(31, 24);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 27);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(628, 36);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(117, 15);
            this.lbl_user.TabIndex = 2;
            this.lbl_user.Text = "User: name/surname";
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.Location = new System.Drawing.Point(628, 130);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(92, 39);
            this.btn_addOrder.TabIndex = 3;
            this.btn_addOrder.Text = "Add to order";
            this.btn_addOrder.UseVisualStyleBackColor = true;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click_1);
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(628, 185);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(92, 33);
            this.btn_pay.TabIndex = 4;
            this.btn_pay.Text = "Pay";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // listViewOrders
            // 
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(31, 98);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(434, 239);
            this.listViewOrders.TabIndex = 5;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Location = new System.Drawing.Point(31, 57);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(75, 23);
            this.btn_GoBack.TabIndex = 6;
            this.btn_GoBack.Text = "Back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_seatGuests
            // 
            this.btn_seatGuests.Location = new System.Drawing.Point(628, 236);
            this.btn_seatGuests.Name = "btn_seatGuests";
            this.btn_seatGuests.Size = new System.Drawing.Size(92, 34);
            this.btn_seatGuests.TabIndex = 7;
            this.btn_seatGuests.Text = "Seat guests";
            this.btn_seatGuests.UseVisualStyleBackColor = true;
            this.btn_seatGuests.Click += new System.EventHandler(this.btn_seatGuests_Click);
            // 
            // lbl_Reservation
            // 
            this.lbl_Reservation.AutoSize = true;
            this.lbl_Reservation.Location = new System.Drawing.Point(195, 78);
            this.lbl_Reservation.Name = "lbl_Reservation";
            this.lbl_Reservation.Size = new System.Drawing.Size(0, 15);
            this.lbl_Reservation.TabIndex = 8;
            // 
            // TableOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.lbl_Reservation);
            this.Controls.Add(this.btn_seatGuests);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.btn_addOrder);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_OrderView);
            this.Name = "TableOrderView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableOrderView";
            this.Load += new System.EventHandler(this.TableOrderView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_OrderView;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_seatGuests;
        private System.Windows.Forms.Label lbl_Reservation;
    }
}