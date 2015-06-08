namespace CouponsSystems.Forms
{
    partial class AddStore
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
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_storeID = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.cmb_pref = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_cities = new System.Windows.Forms.ComboBox();
            this.txt_OwnerID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store ID";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(90, 122);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(90, 32);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Catgory";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone";
            // 
            // txt_storeID
            // 
            this.txt_storeID.Enabled = false;
            this.txt_storeID.Location = new System.Drawing.Point(375, 43);
            this.txt_storeID.Name = "txt_storeID";
            this.txt_storeID.Size = new System.Drawing.Size(231, 38);
            this.txt_storeID.TabIndex = 7;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(375, 119);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(231, 38);
            this.txt_Name.TabIndex = 8;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(375, 196);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(231, 38);
            this.txt_desc.TabIndex = 9;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(375, 270);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(231, 38);
            this.txt_address.TabIndex = 10;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(375, 468);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(231, 38);
            this.txt_Phone.TabIndex = 12;
            // 
            // cmb_pref
            // 
            this.cmb_pref.FormattingEnabled = true;
            this.cmb_pref.Items.AddRange(new object[] {
            "Restaurat",
            "Fun",
            "Shopping",
            "Sports"});
            this.cmb_pref.Location = new System.Drawing.Point(375, 398);
            this.cmb_pref.Name = "cmb_pref";
            this.cmb_pref.Size = new System.Drawing.Size(231, 39);
            this.cmb_pref.TabIndex = 19;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(257, 593);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(248, 70);
            this.btn_submit.TabIndex = 20;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "City";
            // 
            // cmb_cities
            // 
            this.cmb_cities.FormattingEnabled = true;
            this.cmb_cities.Location = new System.Drawing.Point(375, 335);
            this.cmb_cities.Name = "cmb_cities";
            this.cmb_cities.Size = new System.Drawing.Size(231, 39);
            this.cmb_cities.TabIndex = 22;
            // 
            // txt_OwnerID
            // 
            this.txt_OwnerID.Location = new System.Drawing.Point(375, 532);
            this.txt_OwnerID.Name = "txt_OwnerID";
            this.txt_OwnerID.Size = new System.Drawing.Size(231, 38);
            this.txt_OwnerID.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 532);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(235, 32);
            this.label6.TabIndex = 23;
            this.label6.Text = "Owner Username";
            // 
            // AddStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 685);
            this.Controls.Add(this.txt_OwnerID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_cities);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.cmb_pref);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_storeID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            this.Text = "AddStore";
            this.Load += new System.EventHandler(this.AddStore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_storeID;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.ComboBox cmb_pref;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_cities;
        private System.Windows.Forms.TextBox txt_OwnerID;
        private System.Windows.Forms.Label label6;
    }
}