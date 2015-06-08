namespace CouponsSystems
{
    partial class StoreOwnerWindow
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
            this.cmb_AllStores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_storeID = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_catagory = new System.Windows.Forms.TextBox();
            this.txt_storeRank = new System.Windows.Forms.TextBox();
            this.txt_serialKey = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_AllStores
            // 
            this.cmb_AllStores.FormattingEnabled = true;
            this.cmb_AllStores.Location = new System.Drawing.Point(219, 37);
            this.cmb_AllStores.Name = "cmb_AllStores";
            this.cmb_AllStores.Size = new System.Drawing.Size(352, 39);
            this.cmb_AllStores.TabIndex = 0;
            this.cmb_AllStores.SelectedIndexChanged += new System.EventHandler(this.cmb_AllStores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Store";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "Edit Store";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 80);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add Coupon";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(624, 566);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 80);
            this.button3.TabIndex = 4;
            this.button3.Text = "Mark Coupon Used";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(624, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 80);
            this.button4.TabIndex = 5;
            this.button4.Text = "Watch All Coupons";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Store ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 409);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(130, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Catagory";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 466);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(156, 32);
            this.label8.TabIndex = 12;
            this.label8.Text = "Store Rank";
            // 
            // txt_storeID
            // 
            this.txt_storeID.Enabled = false;
            this.txt_storeID.Location = new System.Drawing.Point(219, 126);
            this.txt_storeID.Name = "txt_storeID";
            this.txt_storeID.Size = new System.Drawing.Size(352, 38);
            this.txt_storeID.TabIndex = 13;
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(219, 182);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(352, 38);
            this.txt_name.TabIndex = 14;
            // 
            // txt_desc
            // 
            this.txt_desc.Enabled = false;
            this.txt_desc.Location = new System.Drawing.Point(219, 237);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(352, 38);
            this.txt_desc.TabIndex = 15;
            // 
            // txt_address
            // 
            this.txt_address.Enabled = false;
            this.txt_address.Location = new System.Drawing.Point(219, 295);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(352, 38);
            this.txt_address.TabIndex = 16;
            // 
            // txt_city
            // 
            this.txt_city.Enabled = false;
            this.txt_city.Location = new System.Drawing.Point(219, 348);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(352, 38);
            this.txt_city.TabIndex = 17;
            // 
            // txt_catagory
            // 
            this.txt_catagory.Enabled = false;
            this.txt_catagory.Location = new System.Drawing.Point(219, 409);
            this.txt_catagory.Name = "txt_catagory";
            this.txt_catagory.Size = new System.Drawing.Size(352, 38);
            this.txt_catagory.TabIndex = 18;
            // 
            // txt_storeRank
            // 
            this.txt_storeRank.Enabled = false;
            this.txt_storeRank.Location = new System.Drawing.Point(219, 466);
            this.txt_storeRank.Name = "txt_storeRank";
            this.txt_storeRank.Size = new System.Drawing.Size(352, 38);
            this.txt_storeRank.TabIndex = 19;
            // 
            // txt_serialKey
            // 
            this.txt_serialKey.Location = new System.Drawing.Point(250, 588);
            this.txt_serialKey.Name = "txt_serialKey";
            this.txt_serialKey.Size = new System.Drawing.Size(352, 38);
            this.txt_serialKey.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 594);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(145, 32);
            this.label9.TabIndex = 21;
            this.label9.Text = "Serial Key";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(624, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(217, 80);
            this.button5.TabIndex = 22;
            this.button5.Text = "REFRESH";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // StoreOwnerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 797);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_serialKey);
            this.Controls.Add(this.txt_storeRank);
            this.Controls.Add(this.txt_catagory);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_storeID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_AllStores);
            this.Name = "StoreOwnerWindow";
            this.Text = "StoreOwner";
            this.Load += new System.EventHandler(this.StoreOwnerWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_AllStores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_storeID;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_catagory;
        private System.Windows.Forms.TextBox txt_storeRank;
        private System.Windows.Forms.TextBox txt_serialKey;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
    }
}