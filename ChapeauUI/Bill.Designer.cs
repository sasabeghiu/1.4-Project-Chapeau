
namespace ChapeauUI
{
    partial class Bill
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
            this.btn_paidCard = new System.Windows.Forms.Button();
            this.btn_paidCash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_orderview = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_BillId = new System.Windows.Forms.Label();
            this.lbl_table = new System.Windows.Forms.Label();
            this.lbl_hostname = new System.Windows.Forms.Label();
            this.lbl_VAT = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_paidCard
            // 
            this.btn_paidCard.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_paidCard.Location = new System.Drawing.Point(788, 240);
            this.btn_paidCard.Name = "btn_paidCard";
            this.btn_paidCard.Size = new System.Drawing.Size(206, 101);
            this.btn_paidCard.TabIndex = 0;
            this.btn_paidCard.Text = "PAID WITH CARD";
            this.btn_paidCard.UseVisualStyleBackColor = true;
            this.btn_paidCard.Click += new System.EventHandler(this.btn_paidCard_Click);
            // 
            // btn_paidCash
            // 
            this.btn_paidCash.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_paidCash.Location = new System.Drawing.Point(788, 391);
            this.btn_paidCash.Name = "btn_paidCash";
            this.btn_paidCash.Size = new System.Drawing.Size(206, 101);
            this.btn_paidCash.TabIndex = 1;
            this.btn_paidCash.Text = "PAID WITH CASH";
            this.btn_paidCash.UseVisualStyleBackColor = true;
            this.btn_paidCash.Click += new System.EventHandler(this.btn_paidCash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bill ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Table:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(413, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Host:";
            // 
            // lbl_orderview
            // 
            this.lbl_orderview.AutoSize = true;
            this.lbl_orderview.Location = new System.Drawing.Point(12, 132);
            this.lbl_orderview.Name = "lbl_orderview";
            this.lbl_orderview.Size = new System.Drawing.Size(54, 20);
            this.lbl_orderview.TabIndex = 5;
            this.lbl_orderview.Text = "order...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(50, 657);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "VAT:  €";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(43, 697);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total:  €";
            // 
            // lbl_BillId
            // 
            this.lbl_BillId.AutoSize = true;
            this.lbl_BillId.Location = new System.Drawing.Point(86, 31);
            this.lbl_BillId.Name = "lbl_BillId";
            this.lbl_BillId.Size = new System.Drawing.Size(18, 20);
            this.lbl_BillId.TabIndex = 8;
            this.lbl_BillId.Text = "...";
            // 
            // lbl_table
            // 
            this.lbl_table.AutoSize = true;
            this.lbl_table.Location = new System.Drawing.Point(86, 63);
            this.lbl_table.Name = "lbl_table";
            this.lbl_table.Size = new System.Drawing.Size(18, 20);
            this.lbl_table.TabIndex = 9;
            this.lbl_table.Text = "...";
            // 
            // lbl_hostname
            // 
            this.lbl_hostname.AutoSize = true;
            this.lbl_hostname.Location = new System.Drawing.Point(472, 23);
            this.lbl_hostname.Name = "lbl_hostname";
            this.lbl_hostname.Size = new System.Drawing.Size(18, 20);
            this.lbl_hostname.TabIndex = 10;
            this.lbl_hostname.Text = "...";
            // 
            // lbl_VAT
            // 
            this.lbl_VAT.AutoSize = true;
            this.lbl_VAT.Location = new System.Drawing.Point(145, 657);
            this.lbl_VAT.Name = "lbl_VAT";
            this.lbl_VAT.Size = new System.Drawing.Size(18, 20);
            this.lbl_VAT.TabIndex = 11;
            this.lbl_VAT.Text = "...";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(145, 697);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(18, 20);
            this.lbl_total.TabIndex = 12;
            this.lbl_total.Text = "...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 87);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::ChapeauUI.Properties.Resources.Chapeau_no_bg;
            this.pictureBox2.Location = new System.Drawing.Point(772, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(278, 178);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 753);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_VAT);
            this.Controls.Add(this.lbl_hostname);
            this.Controls.Add(this.lbl_table);
            this.Controls.Add(this.lbl_BillId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_orderview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_paidCash);
            this.Controls.Add(this.btn_paidCard);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Bill";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_paidCard;
        private System.Windows.Forms.Button btn_paidCash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_orderview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_BillId;
        private System.Windows.Forms.Label lbl_table;
        private System.Windows.Forms.Label lbl_hostname;
        private System.Windows.Forms.Label lbl_VAT;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}