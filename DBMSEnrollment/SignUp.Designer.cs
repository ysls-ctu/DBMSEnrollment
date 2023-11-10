namespace DBMSEnrollment
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSignUp_Pass = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSignUp_StudNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSignUp_EmailAd = new System.Windows.Forms.TextBox();
            this.dtpSignUp_Bday = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSignUp_Pass2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Birthdate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // tbSignUp_Pass
            // 
            this.tbSignUp_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSignUp_Pass.Location = new System.Drawing.Point(32, 415);
            this.tbSignUp_Pass.Name = "tbSignUp_Pass";
            this.tbSignUp_Pass.Size = new System.Drawing.Size(375, 32);
            this.tbSignUp_Pass.TabIndex = 4;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUp.Font = new System.Drawing.Font("Lucida Bright", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(159, 602);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(114, 46);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(478, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student No.";
            // 
            // tbSignUp_StudNo
            // 
            this.tbSignUp_StudNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSignUp_StudNo.Location = new System.Drawing.Point(32, 192);
            this.tbSignUp_StudNo.Name = "tbSignUp_StudNo";
            this.tbSignUp_StudNo.Size = new System.Drawing.Size(375, 32);
            this.tbSignUp_StudNo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email Address";
            // 
            // tbSignUp_EmailAd
            // 
            this.tbSignUp_EmailAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSignUp_EmailAd.Location = new System.Drawing.Point(32, 81);
            this.tbSignUp_EmailAd.Name = "tbSignUp_EmailAd";
            this.tbSignUp_EmailAd.Size = new System.Drawing.Size(375, 32);
            this.tbSignUp_EmailAd.TabIndex = 1;
            // 
            // dtpSignUp_Bday
            // 
            this.dtpSignUp_Bday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSignUp_Bday.Location = new System.Drawing.Point(32, 309);
            this.dtpSignUp_Bday.Name = "dtpSignUp_Bday";
            this.dtpSignUp_Bday.Size = new System.Drawing.Size(375, 30);
            this.dtpSignUp_Bday.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Confirm Password";
            // 
            // tbSignUp_Pass2
            // 
            this.tbSignUp_Pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSignUp_Pass2.Location = new System.Drawing.Point(32, 517);
            this.tbSignUp_Pass2.Name = "tbSignUp_Pass2";
            this.tbSignUp_Pass2.Size = new System.Drawing.Size(375, 32);
            this.tbSignUp_Pass2.TabIndex = 5;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 704);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSignUp_Pass2);
            this.Controls.Add(this.dtpSignUp_Bday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSignUp_StudNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSignUp_EmailAd);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSignUp_Pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.Text = "School Enrollment System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSignUp_Pass;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSignUp_StudNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSignUp_EmailAd;
        private System.Windows.Forms.DateTimePicker dtpSignUp_Bday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSignUp_Pass2;
    }
}

