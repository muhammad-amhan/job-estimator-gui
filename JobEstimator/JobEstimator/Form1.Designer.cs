namespace JobEstimator
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.groupBoxPipes = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtChromePipes = new System.Windows.Forms.TextBox();
            this.txtCopperPipes = new System.Windows.Forms.TextBox();
            this.txtPlasticPipes = new System.Windows.Forms.TextBox();
            this.lblQuote = new System.Windows.Forms.Label();
            this.groupBoxMaterials = new System.Windows.Forms.GroupBox();
            this.lblTravel = new System.Windows.Forms.Label();
            this.lblLabour = new System.Windows.Forms.Label();
            this.txtTravel = new System.Windows.Forms.TextBox();
            this.txtLabour = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxPipes.SuspendLayout();
            this.groupBoxMaterials.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.ForeColor = System.Drawing.Color.Black;
            this.lblAppTitle.Location = new System.Drawing.Point(84, 39);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(468, 69);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "Pete Taylor\'s Plumbing Company";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxPipes
            // 
            this.groupBoxPipes.Controls.Add(this.checkBox3);
            this.groupBoxPipes.Controls.Add(this.checkBox2);
            this.groupBoxPipes.Controls.Add(this.checkBox1);
            this.groupBoxPipes.Controls.Add(this.txtChromePipes);
            this.groupBoxPipes.Controls.Add(this.txtCopperPipes);
            this.groupBoxPipes.Controls.Add(this.txtPlasticPipes);
            this.groupBoxPipes.ForeColor = System.Drawing.Color.Black;
            this.groupBoxPipes.Location = new System.Drawing.Point(12, 211);
            this.groupBoxPipes.Name = "groupBoxPipes";
            this.groupBoxPipes.Size = new System.Drawing.Size(193, 169);
            this.groupBoxPipes.TabIndex = 1;
            this.groupBoxPipes.TabStop = false;
            this.groupBoxPipes.Text = "Enter the materials used in the job:";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(9, 120);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(162, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "Chrome Pipes - £4 per metre:";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 71);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(160, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Copper Pipes - £3 per metre:";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(157, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Plastic Pipes - £2 per metre:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtChromePipes
            // 
            this.txtChromePipes.Location = new System.Drawing.Point(125, 143);
            this.txtChromePipes.Name = "txtChromePipes";
            this.txtChromePipes.Size = new System.Drawing.Size(62, 20);
            this.txtChromePipes.TabIndex = 3;
            this.txtChromePipes.Text = "0";
            this.toolTip1.SetToolTip(this.txtChromePipes, "Please check your material option first.");
            this.txtChromePipes.TextChanged += new System.EventHandler(this.txtChromePipes_TextChanged);
            this.txtChromePipes.Enter += new System.EventHandler(this.txtChromePipes_Enter);
            this.txtChromePipes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChromePipes_KeyPress);
            this.txtChromePipes.Leave += new System.EventHandler(this.txtChromePipes_Leave);
            // 
            // txtCopperPipes
            // 
            this.txtCopperPipes.Location = new System.Drawing.Point(125, 94);
            this.txtCopperPipes.Name = "txtCopperPipes";
            this.txtCopperPipes.Size = new System.Drawing.Size(62, 20);
            this.txtCopperPipes.TabIndex = 3;
            this.txtCopperPipes.Text = "0";
            this.toolTip1.SetToolTip(this.txtCopperPipes, "Please check your material option first.");
            this.txtCopperPipes.TextChanged += new System.EventHandler(this.txtCopperPipes_TextChanged);
            this.txtCopperPipes.Enter += new System.EventHandler(this.txtCopperPipes_Enter);
            this.txtCopperPipes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCopperPipes_KeyPress);
            this.txtCopperPipes.Leave += new System.EventHandler(this.txtCopperPipes_Leave);
            // 
            // txtPlasticPipes
            // 
            this.txtPlasticPipes.Location = new System.Drawing.Point(125, 43);
            this.txtPlasticPipes.Name = "txtPlasticPipes";
            this.txtPlasticPipes.Size = new System.Drawing.Size(62, 20);
            this.txtPlasticPipes.TabIndex = 3;
            this.txtPlasticPipes.Text = "0";
            this.toolTip1.SetToolTip(this.txtPlasticPipes, "Please check your material option first.");
            this.txtPlasticPipes.TextChanged += new System.EventHandler(this.txtPlasticPipes_TextChanged);
            this.txtPlasticPipes.Enter += new System.EventHandler(this.txtPlasticPipes_Enter);
            this.txtPlasticPipes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlasticPipes_KeyPress);
            this.txtPlasticPipes.Leave += new System.EventHandler(this.txtPlasticPipes_Leave);
            // 
            // lblQuote
            // 
            this.lblQuote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuote.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuote.Location = new System.Drawing.Point(218, 118);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(448, 225);
            this.lblQuote.TabIndex = 2;
            // 
            // groupBoxMaterials
            // 
            this.groupBoxMaterials.Controls.Add(this.lblTravel);
            this.groupBoxMaterials.Controls.Add(this.lblLabour);
            this.groupBoxMaterials.Controls.Add(this.txtTravel);
            this.groupBoxMaterials.Controls.Add(this.txtLabour);
            this.groupBoxMaterials.ForeColor = System.Drawing.Color.Black;
            this.groupBoxMaterials.Location = new System.Drawing.Point(12, 118);
            this.groupBoxMaterials.Name = "groupBoxMaterials";
            this.groupBoxMaterials.Size = new System.Drawing.Size(193, 76);
            this.groupBoxMaterials.TabIndex = 3;
            this.groupBoxMaterials.TabStop = false;
            this.groupBoxMaterials.Text = "1. Enter hours and miles:";
            // 
            // lblTravel
            // 
            this.lblTravel.AutoSize = true;
            this.lblTravel.Location = new System.Drawing.Point(13, 49);
            this.lblTravel.Name = "lblTravel";
            this.lblTravel.Size = new System.Drawing.Size(106, 13);
            this.lblTravel.TabIndex = 3;
            this.lblTravel.Text = "Travel at £1 per mile:";
            this.lblTravel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLabour
            // 
            this.lblLabour.AutoSize = true;
            this.lblLabour.Location = new System.Drawing.Point(6, 23);
            this.lblLabour.Name = "lblLabour";
            this.lblLabour.Size = new System.Drawing.Size(118, 13);
            this.lblLabour.TabIndex = 2;
            this.lblLabour.Text = "Labour at £40 per hour:";
            this.lblLabour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTravel
            // 
            this.txtTravel.Location = new System.Drawing.Point(125, 46);
            this.txtTravel.Name = "txtTravel";
            this.txtTravel.Size = new System.Drawing.Size(62, 20);
            this.txtTravel.TabIndex = 1;
            this.txtTravel.Text = "0";
            this.txtTravel.Enter += new System.EventHandler(this.txtTravel_Enter);
            this.txtTravel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTravel_KeyPress);
            this.txtTravel.Leave += new System.EventHandler(this.txtTravel_Leave);
            // 
            // txtLabour
            // 
            this.txtLabour.Location = new System.Drawing.Point(125, 20);
            this.txtLabour.Name = "txtLabour";
            this.txtLabour.Size = new System.Drawing.Size(62, 20);
            this.txtLabour.TabIndex = 0;
            this.txtLabour.Text = "0";
            this.txtLabour.Enter += new System.EventHandler(this.txtLabour_Enter);
            this.txtLabour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLabour_KeyPress);
            this.txtLabour.Leave += new System.EventHandler(this.txtLabour_Leave);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(591, 357);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate.Location = new System.Drawing.Point(218, 357);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(678, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.ForeColor = System.Drawing.Color.Black;
            this.btnSaveToFile.Location = new System.Drawing.Point(337, 357);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(73, 23);
            this.btnSaveToFile.TabIndex = 8;
            this.btnSaveToFile.Text = "Save";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.ForeColor = System.Drawing.Color.Black;
            this.btnCopyToClipboard.Location = new System.Drawing.Point(449, 357);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(116, 23);
            this.btnCopyToClipboard.TabIndex = 9;
            this.btnCopyToClipboard.Text = "Copy To Clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 1;
            this.toolTip1.ReshowDelay = 1;
            this.toolTip1.Tag = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Image = global::JobEstimator.Properties.Resources.Custom_Icon_Design_Flatastic_10_Open_file;
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openFileToolStripMenuItem.Text = "Open     Ctrl+N";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::JobEstimator.Properties.Resources.Aha_Soft_Hardware_Floppy;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveAsToolStripMenuItem.Text = "Save      Ctrl+S";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Image = global::JobEstimator.Properties.Resources.page_2_copy_icon;
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy to Clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // generalHelpToolStripMenuItem
            // 
            this.generalHelpToolStripMenuItem.Image = global::JobEstimator.Properties.Resources.help_circle_blue;
            this.generalHelpToolStripMenuItem.Name = "generalHelpToolStripMenuItem";
            this.generalHelpToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.generalHelpToolStripMenuItem.Text = "General Help";
            this.generalHelpToolStripMenuItem.Click += new System.EventHandler(this.generalHelpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::JobEstimator.Properties.Resources.Aha_Soft_People_User_info;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JobEstimator.Properties.Resources._2351821;
            this.pictureBox1.Location = new System.Drawing.Point(542, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.ImageIndex = 0;
            this.btnExit.Location = new System.Drawing.Point(12, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(678, 414);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBoxMaterials);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.groupBoxPipes);
            this.Controls.Add(this.lblAppTitle);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.RightToLeftLayout = true;
            this.Text = "Job Estimator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.groupBoxPipes.ResumeLayout(false);
            this.groupBoxPipes.PerformLayout();
            this.groupBoxMaterials.ResumeLayout(false);
            this.groupBoxMaterials.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.GroupBox groupBoxPipes;
        private System.Windows.Forms.TextBox txtChromePipes;
        private System.Windows.Forms.TextBox txtCopperPipes;
        private System.Windows.Forms.TextBox txtPlasticPipes;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.GroupBox groupBoxMaterials;
        private System.Windows.Forms.Label lblTravel;
        private System.Windows.Forms.Label lblLabour;
        private System.Windows.Forms.TextBox txtTravel;
        private System.Windows.Forms.TextBox txtLabour;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

