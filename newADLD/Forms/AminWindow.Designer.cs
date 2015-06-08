namespace CouponsSystems
{
    partial class AdminWindow
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
            this.btn_addAdmin = new System.Windows.Forms.Button();
            this.btn_addStore = new System.Windows.Forms.Button();
            this.btn_addStoreOwner = new System.Windows.Forms.Button();
            this.btn_approve = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delStore = new System.Windows.Forms.Button();
            this.btn_delCoupon = new System.Windows.Forms.Button();
            this.btn_addCoupon = new System.Windows.Forms.Button();
            this.txt_storeID = new System.Windows.Forms.RichTextBox();
            this.txt_couponID = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_addAdmin
            // 
            this.btn_addAdmin.Location = new System.Drawing.Point(56, 44);
            this.btn_addAdmin.Name = "btn_addAdmin";
            this.btn_addAdmin.Size = new System.Drawing.Size(222, 83);
            this.btn_addAdmin.TabIndex = 0;
            this.btn_addAdmin.Text = "Add Administrator";
            this.btn_addAdmin.UseVisualStyleBackColor = true;
            this.btn_addAdmin.Click += new System.EventHandler(this.btn_addAdmin_Click);
            // 
            // btn_addStore
            // 
            this.btn_addStore.Location = new System.Drawing.Point(56, 157);
            this.btn_addStore.Name = "btn_addStore";
            this.btn_addStore.Size = new System.Drawing.Size(222, 83);
            this.btn_addStore.TabIndex = 1;
            this.btn_addStore.Text = "Add Store";
            this.btn_addStore.UseVisualStyleBackColor = true;
            this.btn_addStore.Click += new System.EventHandler(this.btn_addStore_Click);
            // 
            // btn_addStoreOwner
            // 
            this.btn_addStoreOwner.Location = new System.Drawing.Point(331, 157);
            this.btn_addStoreOwner.Name = "btn_addStoreOwner";
            this.btn_addStoreOwner.Size = new System.Drawing.Size(222, 83);
            this.btn_addStoreOwner.TabIndex = 2;
            this.btn_addStoreOwner.Text = "Add StoreOwner";
            this.btn_addStoreOwner.UseVisualStyleBackColor = true;
            this.btn_addStoreOwner.Click += new System.EventHandler(this.btn_addStoreOwner_Click);
            // 
            // btn_approve
            // 
            this.btn_approve.Location = new System.Drawing.Point(331, 44);
            this.btn_approve.Name = "btn_approve";
            this.btn_approve.Size = new System.Drawing.Size(222, 93);
            this.btn_approve.TabIndex = 3;
            this.btn_approve.Text = "Approve Coupons";
            this.btn_approve.UseVisualStyleBackColor = true;
            this.btn_approve.Click += new System.EventHandler(this.btn_approve_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(56, 280);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(222, 88);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Edit Coupon";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delStore
            // 
            this.btn_delStore.Location = new System.Drawing.Point(403, 464);
            this.btn_delStore.Name = "btn_delStore";
            this.btn_delStore.Size = new System.Drawing.Size(150, 86);
            this.btn_delStore.TabIndex = 6;
            this.btn_delStore.Text = "Delete Store";
            this.btn_delStore.UseVisualStyleBackColor = true;
            this.btn_delStore.Click += new System.EventHandler(this.btn_delStore_Click);
            // 
            // btn_delCoupon
            // 
            this.btn_delCoupon.Location = new System.Drawing.Point(403, 620);
            this.btn_delCoupon.Name = "btn_delCoupon";
            this.btn_delCoupon.Size = new System.Drawing.Size(150, 86);
            this.btn_delCoupon.TabIndex = 5;
            this.btn_delCoupon.Text = "Delete Coupon";
            this.btn_delCoupon.UseVisualStyleBackColor = true;
            this.btn_delCoupon.Click += new System.EventHandler(this.btn_delCoupon_Click);
            // 
            // btn_addCoupon
            // 
            this.btn_addCoupon.Location = new System.Drawing.Point(331, 280);
            this.btn_addCoupon.Name = "btn_addCoupon";
            this.btn_addCoupon.Size = new System.Drawing.Size(222, 88);
            this.btn_addCoupon.TabIndex = 7;
            this.btn_addCoupon.Text = "Add Coupon";
            this.btn_addCoupon.UseVisualStyleBackColor = true;
            this.btn_addCoupon.Click += new System.EventHandler(this.btn_addCoupon_Click);
            // 
            // txt_storeID
            // 
            this.txt_storeID.Location = new System.Drawing.Point(191, 464);
            this.txt_storeID.Name = "txt_storeID";
            this.txt_storeID.Size = new System.Drawing.Size(183, 86);
            this.txt_storeID.TabIndex = 8;
            this.txt_storeID.Text = "";
            // 
            // txt_couponID
            // 
            this.txt_couponID.Location = new System.Drawing.Point(191, 620);
            this.txt_couponID.Name = "txt_couponID";
            this.txt_couponID.Size = new System.Drawing.Size(183, 86);
            this.txt_couponID.TabIndex = 9;
            this.txt_couponID.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Store ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 648);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Coupon ID";
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_couponID);
            this.Controls.Add(this.txt_storeID);
            this.Controls.Add(this.btn_addCoupon);
            this.Controls.Add(this.btn_delStore);
            this.Controls.Add(this.btn_delCoupon);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_approve);
            this.Controls.Add(this.btn_addStoreOwner);
            this.Controls.Add(this.btn_addStore);
            this.Controls.Add(this.btn_addAdmin);
            this.Name = "AdminWindow";
            this.Text = "Coupons";
            this.Load += new System.EventHandler(this.AdminWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addAdmin;
        private System.Windows.Forms.Button btn_addStore;
        private System.Windows.Forms.Button btn_addStoreOwner;
        private System.Windows.Forms.Button btn_approve;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delStore;
        private System.Windows.Forms.Button btn_delCoupon;
        private System.Windows.Forms.Button btn_addCoupon;
        private System.Windows.Forms.RichTextBox txt_storeID;
        private System.Windows.Forms.RichTextBox txt_couponID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}