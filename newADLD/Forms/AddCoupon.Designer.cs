namespace CouponsSystems.Forms
{
    partial class AddCoupon
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_storeID = new System.Windows.Forms.TextBox();
            this.txt_Original = new System.Windows.Forms.TextBox();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.dtp_deadLine = new System.Windows.Forms.DateTimePicker();
            this.txt_daysValid = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_desc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(63, 104);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(90, 32);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Store ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Original Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Discount Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Deadline";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 560);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Days Valid";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(368, 89);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(282, 38);
            this.txt_name.TabIndex = 7;
            // 
            // txt_storeID
            // 
            this.txt_storeID.Location = new System.Drawing.Point(368, 283);
            this.txt_storeID.Name = "txt_storeID";
            this.txt_storeID.Size = new System.Drawing.Size(282, 38);
            this.txt_storeID.TabIndex = 9;
            // 
            // txt_Original
            // 
            this.txt_Original.Location = new System.Drawing.Point(368, 355);
            this.txt_Original.Name = "txt_Original";
            this.txt_Original.Size = new System.Drawing.Size(282, 38);
            this.txt_Original.TabIndex = 10;
            // 
            // txt_Discount
            // 
            this.txt_Discount.Location = new System.Drawing.Point(368, 424);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(282, 38);
            this.txt_Discount.TabIndex = 11;
            // 
            // dtp_deadLine
            // 
            this.dtp_deadLine.Location = new System.Drawing.Point(368, 488);
            this.dtp_deadLine.Name = "dtp_deadLine";
            this.dtp_deadLine.Size = new System.Drawing.Size(285, 38);
            this.dtp_deadLine.TabIndex = 12;
            // 
            // txt_daysValid
            // 
            this.txt_daysValid.Location = new System.Drawing.Point(371, 557);
            this.txt_daysValid.Name = "txt_daysValid";
            this.txt_daysValid.Size = new System.Drawing.Size(282, 38);
            this.txt_daysValid.TabIndex = 13;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(147, 639);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(419, 106);
            this.btn_submit.TabIndex = 14;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(368, 155);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(285, 96);
            this.txt_desc.TabIndex = 15;
            this.txt_desc.Text = "";
            // 
            // AddCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 793);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_daysValid);
            this.Controls.Add(this.dtp_deadLine);
            this.Controls.Add(this.txt_Discount);
            this.Controls.Add(this.txt_Original);
            this.Controls.Add(this.txt_storeID);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_name);
            this.Name = "AddCoupon";
            this.Text = "AddCoupon";
            this.Load += new System.EventHandler(this.AddCoupon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_storeID;
        private System.Windows.Forms.TextBox txt_Original;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.DateTimePicker dtp_deadLine;
        private System.Windows.Forms.TextBox txt_daysValid;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.RichTextBox txt_desc;
    }
}