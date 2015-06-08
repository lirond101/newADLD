namespace CouponsSystems.Forms
{
    partial class AddAdmin
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
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_un = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_un = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_eeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(301, 348);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(252, 38);
            this.txt_lname.TabIndex = 22;
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(301, 258);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(252, 38);
            this.txt_fname.TabIndex = 21;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(301, 178);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(252, 38);
            this.txt_pass.TabIndex = 20;
            // 
            // txt_un
            // 
            this.txt_un.Location = new System.Drawing.Point(301, 88);
            this.txt_un.Name = "txt_un";
            this.txt_un.Size = new System.Drawing.Size(252, 38);
            this.txt_un.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "first name";
            // 
            // lbl_un
            // 
            this.lbl_un.AutoSize = true;
            this.lbl_un.Location = new System.Drawing.Point(105, 178);
            this.lbl_un.Name = "lbl_un";
            this.lbl_un.Size = new System.Drawing.Size(136, 32);
            this.lbl_un.TabIndex = 16;
            this.lbl_un.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "user name";
            // 
            // txt_eeID
            // 
            this.txt_eeID.Location = new System.Drawing.Point(301, 438);
            this.txt_eeID.Name = "txt_eeID";
            this.txt_eeID.Size = new System.Drawing.Size(252, 38);
            this.txt_eeID.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "employee ID";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(229, 523);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(165, 59);
            this.btn_submit.TabIndex = 25;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 613);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_eeID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_un);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_un);
            this.Controls.Add(this.label1);
            this.Name = "AddAdmin";
            this.Text = "AddAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_un;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_un;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_eeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_submit;
    }
}