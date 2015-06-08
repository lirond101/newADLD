namespace CouponsSystems.Forms
{
    partial class PaymentWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt_MasterCard = new System.Windows.Forms.RadioButton();
            this.rbt_Visa = new System.Windows.Forms.RadioButton();
            this.rbt_PayPal = new System.Windows.Forms.RadioButton();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "How do you wish to pay?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt_MasterCard);
            this.groupBox1.Controls.Add(this.rbt_Visa);
            this.groupBox1.Controls.Add(this.rbt_PayPal);
            this.groupBox1.Location = new System.Drawing.Point(64, 191);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(405, 248);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment method";
            // 
            // rbt_MasterCard
            // 
            this.rbt_MasterCard.AutoSize = true;
            this.rbt_MasterCard.Location = new System.Drawing.Point(64, 179);
            this.rbt_MasterCard.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rbt_MasterCard.Name = "rbt_MasterCard";
            this.rbt_MasterCard.Size = new System.Drawing.Size(199, 36);
            this.rbt_MasterCard.TabIndex = 2;
            this.rbt_MasterCard.TabStop = true;
            this.rbt_MasterCard.Text = "MasterCard";
            this.rbt_MasterCard.UseVisualStyleBackColor = true;
            this.rbt_MasterCard.CheckedChanged += new System.EventHandler(this.rbt_MasterCard_CheckedChanged);
            // 
            // rbt_Visa
            // 
            this.rbt_Visa.AutoSize = true;
            this.rbt_Visa.Location = new System.Drawing.Point(64, 124);
            this.rbt_Visa.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rbt_Visa.Name = "rbt_Visa";
            this.rbt_Visa.Size = new System.Drawing.Size(108, 36);
            this.rbt_Visa.TabIndex = 1;
            this.rbt_Visa.TabStop = true;
            this.rbt_Visa.Text = "Visa";
            this.rbt_Visa.UseVisualStyleBackColor = true;
            this.rbt_Visa.CheckedChanged += new System.EventHandler(this.rbt_Visa_CheckedChanged);
            // 
            // rbt_PayPal
            // 
            this.rbt_PayPal.AutoSize = true;
            this.rbt_PayPal.Location = new System.Drawing.Point(64, 69);
            this.rbt_PayPal.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rbt_PayPal.Name = "rbt_PayPal";
            this.rbt_PayPal.Size = new System.Drawing.Size(143, 36);
            this.rbt_PayPal.TabIndex = 0;
            this.rbt_PayPal.TabStop = true;
            this.rbt_PayPal.Text = "PayPal";
            this.rbt_PayPal.UseVisualStyleBackColor = true;
            this.rbt_PayPal.CheckedChanged += new System.EventHandler(this.rbt_PayPal_CheckedChanged);
            // 
            // btn_Pay
            // 
            this.btn_Pay.Location = new System.Drawing.Point(73, 615);
            this.btn_Pay.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(266, 92);
            this.btn_Pay.TabIndex = 2;
            this.btn_Pay.Text = "Pay";
            this.btn_Pay.UseVisualStyleBackColor = true;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 530);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(605, 38);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 495);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Card Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 615);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 92);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pay Later";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaymentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 830);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Pay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "PaymentWindow";
            this.Text = "PaymentWindow";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt_MasterCard;
        private System.Windows.Forms.RadioButton rbt_Visa;
        private System.Windows.Forms.RadioButton rbt_PayPal;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}