namespace Writer
{
    partial class ABT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABT));
            this.picIc = new System.Windows.Forms.PictureBox();
            this.lblNm = new System.Windows.Forms.Label();
            this.lblVr = new System.Windows.Forms.Label();
            this.lblCm = new System.Windows.Forms.Label();
            this.lblCnt = new System.Windows.Forms.Label();
            this.picCm = new System.Windows.Forms.PictureBox();
            this.lblOwn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCm)).BeginInit();
            this.SuspendLayout();
            // 
            // picIc
            // 
            this.picIc.InitialImage = null;
            this.picIc.Location = new System.Drawing.Point(2, 133);
            this.picIc.Name = "picIc";
            this.picIc.Size = new System.Drawing.Size(78, 76);
            this.picIc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIc.TabIndex = 0;
            this.picIc.TabStop = false;
            // 
            // lblNm
            // 
            this.lblNm.Location = new System.Drawing.Point(86, 133);
            this.lblNm.Name = "lblNm";
            this.lblNm.Size = new System.Drawing.Size(286, 28);
            this.lblNm.TabIndex = 1;
            this.lblNm.Text = "Product Name";
            this.lblNm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVr
            // 
            this.lblVr.AutoSize = true;
            this.lblVr.Location = new System.Drawing.Point(86, 161);
            this.lblVr.Name = "lblVr";
            this.lblVr.Size = new System.Drawing.Size(57, 19);
            this.lblVr.TabIndex = 2;
            this.lblVr.Text = "Version";
            // 
            // lblCm
            // 
            this.lblCm.AutoSize = true;
            this.lblCm.Location = new System.Drawing.Point(86, 190);
            this.lblCm.Name = "lblCm";
            this.lblCm.Size = new System.Drawing.Size(111, 19);
            this.lblCm.TabIndex = 3;
            this.lblCm.Text = "Company Name";
            // 
            // lblCnt
            // 
            this.lblCnt.Location = new System.Drawing.Point(-2, 224);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(374, 97);
            this.lblCnt.TabIndex = 4;
            this.lblCnt.Text = "Contact Information";
            // 
            // picCm
            // 
            this.picCm.InitialImage = null;
            this.picCm.Location = new System.Drawing.Point(2, 9);
            this.picCm.Name = "picCm";
            this.picCm.Size = new System.Drawing.Size(85, 85);
            this.picCm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCm.TabIndex = 5;
            this.picCm.TabStop = false;
            // 
            // lblOwn
            // 
            this.lblOwn.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwn.Location = new System.Drawing.Point(93, 9);
            this.lblOwn.Name = "lblOwn";
            this.lblOwn.Size = new System.Drawing.Size(279, 85);
            this.lblOwn.TabIndex = 6;
            this.lblOwn.Text = "Siael Access Keys System";
            this.lblOwn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ABT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 330);
            this.Controls.Add(this.lblOwn);
            this.Controls.Add(this.picCm);
            this.Controls.Add(this.lblCnt);
            this.Controls.Add(this.lblCm);
            this.Controls.Add(this.lblVr);
            this.Controls.Add(this.lblNm);
            this.Controls.Add(this.picIc);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ABT";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.Load += new System.EventHandler(this.ABT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIc;
        private System.Windows.Forms.Label lblNm;
        private System.Windows.Forms.Label lblVr;
        private System.Windows.Forms.Label lblCm;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.PictureBox picCm;
        private System.Windows.Forms.Label lblOwn;
    }
}