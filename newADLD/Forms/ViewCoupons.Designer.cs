namespace CouponsSystems
{
    partial class ViewCoupons
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
            this.lstview_AllCoupons = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstview_AllCoupons
            // 
            this.lstview_AllCoupons.Location = new System.Drawing.Point(22, 12);
            this.lstview_AllCoupons.Name = "lstview_AllCoupons";
            this.lstview_AllCoupons.Size = new System.Drawing.Size(1515, 686);
            this.lstview_AllCoupons.TabIndex = 0;
            this.lstview_AllCoupons.UseCompatibleStateImageBehavior = false;
            this.lstview_AllCoupons.SelectedIndexChanged += new System.EventHandler(this.lstview_AllCoupons_SelectedIndexChanged);
            // 
            // ViewCoupons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 710);
            this.Controls.Add(this.lstview_AllCoupons);
            this.Name = "ViewCoupons";
            this.Text = "ViewCoupons";
            this.Load += new System.EventHandler(this.ViewCoupons_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstview_AllCoupons;
    }
}