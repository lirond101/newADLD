﻿namespace CouponsSystems.Forms
{
    partial class ApproveCoupon
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstview_AllCoupons
            // 
            this.lstview_AllCoupons.Location = new System.Drawing.Point(10, 10);
            this.lstview_AllCoupons.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.lstview_AllCoupons.Name = "lstview_AllCoupons";
            this.lstview_AllCoupons.Size = new System.Drawing.Size(505, 272);
            this.lstview_AllCoupons.TabIndex = 0;
            this.lstview_AllCoupons.UseCompatibleStateImageBehavior = false;
            this.lstview_AllCoupons.SelectedIndexChanged += new System.EventHandler(this.lstview_AllCoupons_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 292);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Approve Selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ApproveCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstview_AllCoupons);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "ApproveCoupon";
            this.Text = "ApproveCoupon";
            this.Load += new System.EventHandler(this.ApproveCoupon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstview_AllCoupons;
        private System.Windows.Forms.Button button1;
    }
}