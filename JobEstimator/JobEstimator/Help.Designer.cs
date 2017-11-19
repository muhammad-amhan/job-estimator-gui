namespace JobEstimator
{
    partial class Help
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
            this.about = new System.Windows.Forms.LinkLabel();
            this.inputInfo = new System.Windows.Forms.LinkLabel();
            this.howItWorks = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExitHelp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Help and Support";
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Location = new System.Drawing.Point(37, 95);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(115, 13);
            this.about.TabIndex = 1;
            this.about.TabStop = true;
            this.about.Text = "What is Job Estimator?";
            this.about.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.about_LinkClicked);
            // 
            // inputInfo
            // 
            this.inputInfo.AutoSize = true;
            this.inputInfo.Location = new System.Drawing.Point(37, 122);
            this.inputInfo.Name = "inputInfo";
            this.inputInfo.Size = new System.Drawing.Size(176, 13);
            this.inputInfo.TabIndex = 2;
            this.inputInfo.TabStop = true;
            this.inputInfo.Text = "What infomration do I need to fill in?";
            this.inputInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.inputInfo_LinkClicked);
            // 
            // howItWorks
            // 
            this.howItWorks.AutoSize = true;
            this.howItWorks.Location = new System.Drawing.Point(37, 145);
            this.howItWorks.Name = "howItWorks";
            this.howItWorks.Size = new System.Drawing.Size(153, 13);
            this.howItWorks.TabIndex = 3;
            this.howItWorks.TabStop = true;
            this.howItWorks.Text = "How does Job Estimator work?";
            this.howItWorks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.howItWorks_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome to Job Estimator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "1.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "2.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "3.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = " what would you like help with?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(15, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "___________________________________________________";
            // 
            // btnExitHelp
            // 
            this.btnExitHelp.Location = new System.Drawing.Point(133, 197);
            this.btnExitHelp.Name = "btnExitHelp";
            this.btnExitHelp.Size = new System.Drawing.Size(80, 23);
            this.btnExitHelp.TabIndex = 9;
            this.btnExitHelp.Text = "Close";
            this.btnExitHelp.UseVisualStyleBackColor = true;
            this.btnExitHelp.Click += new System.EventHandler(this.btnExitHelp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JobEstimator.Properties.Resources.help_circle_blue;
            this.pictureBox1.Location = new System.Drawing.Point(232, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 232);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnExitHelp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.howItWorks);
            this.Controls.Add(this.inputInfo);
            this.Controls.Add(this.about);
            this.Controls.Add(this.label1);
            this.Name = "Help";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel about;
        private System.Windows.Forms.LinkLabel inputInfo;
        private System.Windows.Forms.LinkLabel howItWorks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExitHelp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}