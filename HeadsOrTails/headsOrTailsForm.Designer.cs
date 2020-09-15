namespace HeadsOrTails
{
    partial class headsOrTailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(headsOrTailsForm));
            this.btnHeads = new System.Windows.Forms.Button();
            this.btnTails = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.imgHeads = new System.Windows.Forms.PictureBox();
            this.imgTails = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHeads
            // 
            this.btnHeads.Location = new System.Drawing.Point(60, 309);
            this.btnHeads.Name = "btnHeads";
            this.btnHeads.Size = new System.Drawing.Size(167, 83);
            this.btnHeads.TabIndex = 0;
            this.btnHeads.Text = "&Show Heads";
            this.btnHeads.UseVisualStyleBackColor = true;
            this.btnHeads.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnTails
            // 
            this.btnTails.Location = new System.Drawing.Point(243, 310);
            this.btnTails.Name = "btnTails";
            this.btnTails.Size = new System.Drawing.Size(167, 82);
            this.btnTails.TabIndex = 1;
            this.btnTails.Text = "S&how Tails";
            this.btnTails.UseVisualStyleBackColor = true;
            this.btnTails.Click += new System.EventHandler(this.BtnTails_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(427, 310);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 82);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // imgHeads
            // 
            this.imgHeads.Image = ((System.Drawing.Image)(resources.GetObject("imgHeads.Image")));
            this.imgHeads.Location = new System.Drawing.Point(60, 31);
            this.imgHeads.Name = "imgHeads";
            this.imgHeads.Size = new System.Drawing.Size(265, 242);
            this.imgHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHeads.TabIndex = 3;
            this.imgHeads.TabStop = false;
            this.imgHeads.Click += new System.EventHandler(this.ImgHeads_Click);
            // 
            // imgTails
            // 
            this.imgTails.Image = ((System.Drawing.Image)(resources.GetObject("imgTails.Image")));
            this.imgTails.Location = new System.Drawing.Point(331, 31);
            this.imgTails.Name = "imgTails";
            this.imgTails.Size = new System.Drawing.Size(265, 242);
            this.imgTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTails.TabIndex = 4;
            this.imgTails.TabStop = false;
            this.imgTails.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // headsOrTailsForm
            // 
            this.AcceptButton = this.btnHeads;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(672, 430);
            this.Controls.Add(this.imgTails);
            this.Controls.Add(this.imgHeads);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTails);
            this.Controls.Add(this.btnHeads);
            this.Name = "headsOrTailsForm";
            this.Text = "headsOrTailsForm";
            this.Load += new System.EventHandler(this.HeadsOrTailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgHeads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHeads;
        private System.Windows.Forms.Button btnTails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox imgHeads;
        private System.Windows.Forms.PictureBox imgTails;
    }
}

