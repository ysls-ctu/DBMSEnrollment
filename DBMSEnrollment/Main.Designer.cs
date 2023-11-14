namespace DBMSEnrollment
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.btnMain_EnrollForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMain_EnrollTracker = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbMain_AccSettings = new System.Windows.Forms.PictureBox();
            this.btnMain_Logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain_AccSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT ENROLLMENT \r\nSYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMain_EnrollForm
            // 
            this.btnMain_EnrollForm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMain_EnrollForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMain_EnrollForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMain_EnrollForm.Font = new System.Drawing.Font("Lucida Bright", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain_EnrollForm.Location = new System.Drawing.Point(26, 140);
            this.btnMain_EnrollForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnMain_EnrollForm.Name = "btnMain_EnrollForm";
            this.btnMain_EnrollForm.Size = new System.Drawing.Size(314, 125);
            this.btnMain_EnrollForm.TabIndex = 3;
            this.btnMain_EnrollForm.Text = "Enrollment Form";
            this.btnMain_EnrollForm.UseVisualStyleBackColor = false;
            this.btnMain_EnrollForm.Click += new System.EventHandler(this.btnMain_EnrollForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // btnMain_EnrollTracker
            // 
            this.btnMain_EnrollTracker.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMain_EnrollTracker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMain_EnrollTracker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMain_EnrollTracker.Font = new System.Drawing.Font("Lucida Bright", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain_EnrollTracker.Location = new System.Drawing.Point(26, 303);
            this.btnMain_EnrollTracker.Margin = new System.Windows.Forms.Padding(2);
            this.btnMain_EnrollTracker.Name = "btnMain_EnrollTracker";
            this.btnMain_EnrollTracker.Size = new System.Drawing.Size(314, 125);
            this.btnMain_EnrollTracker.TabIndex = 4;
            this.btnMain_EnrollTracker.Text = "Enrollment Process\r\nTracker\r\n";
            this.btnMain_EnrollTracker.UseVisualStyleBackColor = false;
            this.btnMain_EnrollTracker.Click += new System.EventHandler(this.btnMain_EnrollTracker_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(358, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pbMain_AccSettings
            // 
            this.pbMain_AccSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMain_AccSettings.Image = ((System.Drawing.Image)(resources.GetObject("pbMain_AccSettings.Image")));
            this.pbMain_AccSettings.Location = new System.Drawing.Point(718, 17);
            this.pbMain_AccSettings.Name = "pbMain_AccSettings";
            this.pbMain_AccSettings.Size = new System.Drawing.Size(36, 37);
            this.pbMain_AccSettings.TabIndex = 7;
            this.pbMain_AccSettings.TabStop = false;
            this.pbMain_AccSettings.Click += new System.EventHandler(this.pbMain_AccSettings_Click);
            // 
            // btnMain_Logout
            // 
            this.btnMain_Logout.BackColor = System.Drawing.Color.Red;
            this.btnMain_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMain_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMain_Logout.Font = new System.Drawing.Font("Lucida Bright", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain_Logout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMain_Logout.Location = new System.Drawing.Point(773, 17);
            this.btnMain_Logout.Margin = new System.Windows.Forms.Padding(2);
            this.btnMain_Logout.Name = "btnMain_Logout";
            this.btnMain_Logout.Size = new System.Drawing.Size(102, 32);
            this.btnMain_Logout.TabIndex = 8;
            this.btnMain_Logout.Text = "Logout";
            this.btnMain_Logout.UseVisualStyleBackColor = false;
            this.btnMain_Logout.Click += new System.EventHandler(this.btnMain_Logout_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(886, 537);
            this.Controls.Add(this.btnMain_Logout);
            this.Controls.Add(this.pbMain_AccSettings);
            this.Controls.Add(this.btnMain_EnrollTracker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMain_EnrollForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Enrollment System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain_AccSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMain_EnrollForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMain_EnrollTracker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbMain_AccSettings;
        private System.Windows.Forms.Button btnMain_Logout;
    }
}

