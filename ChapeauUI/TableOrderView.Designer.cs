
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableOrderView));
            this.btn_logout = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.btn_GoBack = new System.Windows.Forms.Button();
            this.btn_seatGuests = new System.Windows.Forms.Button();
            this.lbl_Reservation = new System.Windows.Forms.Label();
            this.pB_header = new System.Windows.Forms.PictureBox();
            this.lbl_OrderView = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pB_header)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_logout.Location = new System.Drawing.Point(35, 12);
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
            this.lbl_user.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_user.Location = new System.Drawing.Point(834, 55);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(45, 19);
            this.lbl_user.TabIndex = 2;
            this.lbl_user.Text = "User: ";
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_addOrder.Location = new System.Drawing.Point(834, 213);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(100, 40);
            this.btn_addOrder.TabIndex = 3;
            this.btn_addOrder.Text = "Add to order";
            this.btn_addOrder.UseVisualStyleBackColor = true;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click_1);
            // 
            // btn_pay
            // 
            this.btn_pay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_pay.Location = new System.Drawing.Point(834, 273);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(100, 40);
            this.btn_pay.TabIndex = 4;
            this.btn_pay.Text = "Pay";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // listViewOrders
            // 
            this.listViewOrders.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewOrders.FullRowSelect = true;
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(35, 213);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(593, 390);
            this.listViewOrders.TabIndex = 5;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            // 
            // btn_GoBack
            // 
            this.btn_GoBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_GoBack.Location = new System.Drawing.Point(35, 45);
            this.btn_GoBack.Name = "btn_GoBack";
            this.btn_GoBack.Size = new System.Drawing.Size(75, 27);
            this.btn_GoBack.TabIndex = 6;
            this.btn_GoBack.Text = "Back";
            this.btn_GoBack.UseVisualStyleBackColor = true;
            this.btn_GoBack.Click += new System.EventHandler(this.btn_GoBack_Click);
            // 
            // btn_seatGuests
            // 
            this.btn_seatGuests.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_seatGuests.Location = new System.Drawing.Point(834, 331);
            this.btn_seatGuests.Name = "btn_seatGuests";
            this.btn_seatGuests.Size = new System.Drawing.Size(100, 40);
            this.btn_seatGuests.TabIndex = 7;
            this.btn_seatGuests.Text = "Seat guests";
            this.btn_seatGuests.UseVisualStyleBackColor = true;
            this.btn_seatGuests.Click += new System.EventHandler(this.btn_seatGuests_Click);
            // 
            // lbl_Reservation
            // 
            this.lbl_Reservation.AutoSize = true;
            this.lbl_Reservation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Reservation.Location = new System.Drawing.Point(35, 182);
            this.lbl_Reservation.Name = "lbl_Reservation";
            this.lbl_Reservation.Size = new System.Drawing.Size(0, 19);
            this.lbl_Reservation.TabIndex = 8;
            // 
            // pB_header
            // 
            this.pB_header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pB_header.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pB_header.BackgroundImage")));
            this.pB_header.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pB_header.Location = new System.Drawing.Point(0, 0);
            this.pB_header.Name = "pB_header";
            this.pB_header.Size = new System.Drawing.Size(1064, 80);
            this.pB_header.TabIndex = 73;
            this.pB_header.TabStop = false;
            // 
            // lbl_OrderView
            // 
            this.lbl_OrderView.AutoSize = true;
            this.lbl_OrderView.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_OrderView.Location = new System.Drawing.Point(500, 100);
            this.lbl_OrderView.Name = "lbl_OrderView";
            this.lbl_OrderView.Size = new System.Drawing.Size(114, 25);
            this.lbl_OrderView.TabIndex = 74;
            this.lbl_OrderView.Text = "Order View";
            // 
            // TableOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 661);
            this.Controls.Add(this.lbl_OrderView);
            this.Controls.Add(this.lbl_Reservation);
            this.Controls.Add(this.btn_seatGuests);
            this.Controls.Add(this.btn_GoBack);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.btn_addOrder);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.pB_header);
            this.Name = "TableOrderView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order View";
            this.Load += new System.EventHandler(this.TableOrderView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB_header)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.Button btn_GoBack;
        private System.Windows.Forms.Button btn_seatGuests;
        private System.Windows.Forms.Label lbl_Reservation;
        private System.Windows.Forms.PictureBox pB_header;
        private System.Windows.Forms.Label lbl_OrderView;
    }
}