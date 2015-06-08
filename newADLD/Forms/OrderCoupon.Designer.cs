namespace CouponsSystems.Forms
{
    partial class OrderCoupon
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
            this.lst_Coupons = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Coupons
            // 
            this.lst_Coupons.Location = new System.Drawing.Point(17, 16);
            this.lst_Coupons.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lst_Coupons.MultiSelect = false;
            this.lst_Coupons.Name = "lst_Coupons";
            this.lst_Coupons.Size = new System.Drawing.Size(1337, 641);
            this.lst_Coupons.TabIndex = 0;
            this.lst_Coupons.UseCompatibleStateImageBehavior = false;
            this.lst_Coupons.SelectedIndexChanged += new System.EventHandler(this.lst_Coupons_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 681);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 773);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lst_Coupons);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "OrderCoupon";
            this.Text = "OrderCoupon";
            this.Load += new System.EventHandler(this.OrderCoupon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lst_Coupons;
        private System.Windows.Forms.Button button1;
    }
}