
namespace ChapeauUI
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.table = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Label();
            this.host = new System.Windows.Forms.Label();
            this.table_number = new System.Windows.Forms.Label();
            this.order_Id = new System.Windows.Forms.Label();
            this.employee_firstname = new System.Windows.Forms.Label();
            this.Chapeau_logo = new System.Windows.Forms.PictureBox();
            this.order_items = new System.Windows.Forms.Label();
            this.btn_pay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Chapeau_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AutoSize = true;
            this.table.BackColor = System.Drawing.Color.Pink;
            this.table.Location = new System.Drawing.Point(13, 13);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(65, 20);
            this.table.TabIndex = 0;
            this.table.Text = "Table N°";
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.BackColor = System.Drawing.Color.Pink;
            this.order.Location = new System.Drawing.Point(12, 48);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(60, 20);
            this.order.TabIndex = 1;
            this.order.Text = "Order #";
            // 
            // host
            // 
            this.host.AutoSize = true;
            this.host.BackColor = System.Drawing.Color.Pink;
            this.host.Location = new System.Drawing.Point(192, 13);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(43, 20);
            this.host.TabIndex = 2;
            this.host.Text = "Host:";
            this.host.Click += new System.EventHandler(this.label3_Click);
            // 
            // table_number
            // 
            this.table_number.AutoSize = true;
            this.table_number.Location = new System.Drawing.Point(105, 13);
            this.table_number.Name = "table_number";
            this.table_number.Size = new System.Drawing.Size(18, 20);
            this.table_number.TabIndex = 3;
            this.table_number.Text = "...";
            // 
            // order_Id
            // 
            this.order_Id.AutoSize = true;
            this.order_Id.Location = new System.Drawing.Point(105, 48);
            this.order_Id.Name = "order_Id";
            this.order_Id.Size = new System.Drawing.Size(18, 20);
            this.order_Id.TabIndex = 4;
            this.order_Id.Text = "...";
            // 
            // employee_firstname
            // 
            this.employee_firstname.AutoSize = true;
            this.employee_firstname.Location = new System.Drawing.Point(236, 13);
            this.employee_firstname.Name = "employee_firstname";
            this.employee_firstname.Size = new System.Drawing.Size(18, 20);
            this.employee_firstname.TabIndex = 5;
            this.employee_firstname.Text = "...";
            // 
            // Chapeau_logo
            // 
            this.Chapeau_logo.BackColor = System.Drawing.SystemColors.Window;
            this.Chapeau_logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Chapeau_logo.Image = ((System.Drawing.Image)(resources.GetObject("Chapeau_logo.Image")));
            this.Chapeau_logo.Location = new System.Drawing.Point(516, 24);
            this.Chapeau_logo.Name = "Chapeau_logo";
            this.Chapeau_logo.Size = new System.Drawing.Size(272, 152);
            this.Chapeau_logo.TabIndex = 6;
            this.Chapeau_logo.TabStop = false;
            // 
            // order_items
            // 
            this.order_items.AutoSize = true;
            this.order_items.Location = new System.Drawing.Point(27, 108);
            this.order_items.Name = "order_items";
            this.order_items.Size = new System.Drawing.Size(54, 20);
            this.order_items.TabIndex = 7;
            this.order_items.Text = "order...";
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(549, 275);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(162, 69);
            this.btn_pay.TabIndex = 8;
            this.btn_pay.Text = "Payment";
            this.btn_pay.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Pink;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 80);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(9, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(779, 351);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.order_items);
            this.Controls.Add(this.Chapeau_logo);
            this.Controls.Add(this.employee_firstname);
            this.Controls.Add(this.order_Id);
            this.Controls.Add(this.table_number);
            this.Controls.Add(this.host);
            this.Controls.Add(this.order);
            this.Controls.Add(this.table);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.Text = "Chapeau";
            ((System.ComponentModel.ISupportInitialize)(this.Chapeau_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label table;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Label host;
        private System.Windows.Forms.Label table_number;
        private System.Windows.Forms.Label order_Id;
        private System.Windows.Forms.Label employee_firstname;
        private System.Windows.Forms.PictureBox Chapeau_logo;
        private System.Windows.Forms.Label order_items;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}