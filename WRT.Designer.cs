namespace Writer
{
    partial class WRT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WRT));
            this.txtEsc = new System.Windows.Forms.RichTextBox();
            this.mn = new System.Windows.Forms.MenuStrip();
            this.mnA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAA = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAR = new System.Windows.Forms.ToolStripMenuItem();
            this.mnE = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEP = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEL = new System.Windows.Forms.ToolStripMenuItem();
            this.mnER = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnEC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnED = new System.Windows.Forms.ToolStripMenuItem();
            this.mnF = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFF = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFQ = new System.Windows.Forms.ToolStripMenuItem();
            this.mnD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDS = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgAb = new System.Windows.Forms.OpenFileDialog();
            this.dlgSv = new System.Windows.Forms.SaveFileDialog();
            this.dlgFn = new System.Windows.Forms.FontDialog();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mn.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEsc
            // 
            this.txtEsc.AcceptsTab = true;
            this.txtEsc.AutoWordSelection = true;
            resources.ApplyResources(this.txtEsc, "txtEsc");
            this.txtEsc.ForeColor = System.Drawing.Color.Black;
            this.txtEsc.Name = "txtEsc";
            this.txtEsc.TextChanged += new System.EventHandler(this.txtEsc_TextChanged);
            // 
            // mn
            // 
            resources.ApplyResources(this.mn, "mn");
            this.mn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnA,
            this.mnE,
            this.mnF,
            this.mnD});
            this.mn.Name = "mn";
            this.mn.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // mnA
            // 
            this.mnA.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAA,
            this.mnAS,
            this.mnAC,
            this.toolStripSeparator2,
            this.mnAR});
            this.mnA.Name = "mnA";
            resources.ApplyResources(this.mnA, "mnA");
            // 
            // mnAA
            // 
            this.mnAA.Name = "mnAA";
            resources.ApplyResources(this.mnAA, "mnAA");
            this.mnAA.Click += new System.EventHandler(this.mnAA_Click);
            // 
            // mnAS
            // 
            this.mnAS.Name = "mnAS";
            resources.ApplyResources(this.mnAS, "mnAS");
            this.mnAS.Click += new System.EventHandler(this.mnAS_Click);
            // 
            // mnAC
            // 
            this.mnAC.Name = "mnAC";
            resources.ApplyResources(this.mnAC, "mnAC");
            this.mnAC.Click += new System.EventHandler(this.mnAC_Click);
            // 
            // mnAR
            // 
            this.mnAR.Name = "mnAR";
            resources.ApplyResources(this.mnAR, "mnAR");
            this.mnAR.Click += new System.EventHandler(this.mnAR_Click);
            // 
            // mnE
            // 
            this.mnE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnEP,
            this.mnEL,
            this.mnER,
            this.toolStripSeparator1,
            this.mnEC,
            this.mnED});
            this.mnE.Name = "mnE";
            resources.ApplyResources(this.mnE, "mnE");
            this.mnE.DropDownOpened += new System.EventHandler(this.mnE_DropDownOpened);
            // 
            // mnEP
            // 
            this.mnEP.Name = "mnEP";
            resources.ApplyResources(this.mnEP, "mnEP");
            this.mnEP.Click += new System.EventHandler(this.mnEP_Click);
            // 
            // mnEL
            // 
            this.mnEL.Name = "mnEL";
            resources.ApplyResources(this.mnEL, "mnEL");
            this.mnEL.Click += new System.EventHandler(this.mnEL_Click);
            // 
            // mnER
            // 
            this.mnER.Name = "mnER";
            resources.ApplyResources(this.mnER, "mnER");
            this.mnER.Click += new System.EventHandler(this.mnER_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // mnEC
            // 
            this.mnEC.Name = "mnEC";
            resources.ApplyResources(this.mnEC, "mnEC");
            this.mnEC.Click += new System.EventHandler(this.mnEC_Click);
            // 
            // mnED
            // 
            this.mnED.Name = "mnED";
            resources.ApplyResources(this.mnED, "mnED");
            this.mnED.Click += new System.EventHandler(this.mnED_Click);
            // 
            // mnF
            // 
            this.mnF.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFF,
            this.mnFQ});
            this.mnF.Name = "mnF";
            resources.ApplyResources(this.mnF, "mnF");
            // 
            // mnFF
            // 
            this.mnFF.Name = "mnFF";
            resources.ApplyResources(this.mnFF, "mnFF");
            this.mnFF.Click += new System.EventHandler(this.mnFF_Click);
            // 
            // mnFQ
            // 
            this.mnFQ.Checked = true;
            this.mnFQ.CheckOnClick = true;
            this.mnFQ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnFQ.Name = "mnFQ";
            resources.ApplyResources(this.mnFQ, "mnFQ");
            this.mnFQ.CheckedChanged += new System.EventHandler(this.mnFQ_CheckedChanged);
            // 
            // mnD
            // 
            this.mnD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDS});
            this.mnD.Name = "mnD";
            resources.ApplyResources(this.mnD, "mnD");
            // 
            // mnDS
            // 
            this.mnDS.Name = "mnDS";
            resources.ApplyResources(this.mnDS, "mnDS");
            this.mnDS.Click += new System.EventHandler(this.mnDS_Click);
            // 
            // dlgAb
            // 
            this.dlgAb.DefaultExt = "txt";
            resources.ApplyResources(this.dlgAb, "dlgAb");
            this.dlgAb.RestoreDirectory = true;
            // 
            // dlgSv
            // 
            this.dlgSv.DefaultExt = "txt";
            this.dlgSv.FileName = "Writer";
            resources.ApplyResources(this.dlgSv, "dlgSv");
            this.dlgSv.RestoreDirectory = true;
            // 
            // dlgFn
            // 
            this.dlgFn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlgFn.FontMustExist = true;
            this.dlgFn.ShowColor = true;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // WRT
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEsc);
            this.Controls.Add(this.mn);
            this.MainMenuStrip = this.mn;
            this.Name = "WRT";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WRT_FormClosing);
            this.Load += new System.EventHandler(this.WRT_Load);
            this.SizeChanged += new System.EventHandler(this.WRT_SizeChanged);
            this.mn.ResumeLayout(false);
            this.mn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtEsc;
        private System.Windows.Forms.MenuStrip mn;
        private System.Windows.Forms.ToolStripMenuItem mnA;
        private System.Windows.Forms.ToolStripMenuItem mnAS;
        private System.Windows.Forms.ToolStripMenuItem mnAR;
        private System.Windows.Forms.ToolStripMenuItem mnAA;
        private System.Windows.Forms.OpenFileDialog dlgAb;
        private System.Windows.Forms.SaveFileDialog dlgSv;
        private System.Windows.Forms.ToolStripMenuItem mnAC;
        private System.Windows.Forms.ToolStripMenuItem mnF;
        private System.Windows.Forms.ToolStripMenuItem mnFF;
        private System.Windows.Forms.FontDialog dlgFn;
        private System.Windows.Forms.ToolStripMenuItem mnFQ;
        private System.Windows.Forms.ToolStripMenuItem mnD;
        private System.Windows.Forms.ToolStripMenuItem mnDS;
        private System.Windows.Forms.ToolStripMenuItem mnE;
        private System.Windows.Forms.ToolStripMenuItem mnEC;
        private System.Windows.Forms.ToolStripMenuItem mnED;
        private System.Windows.Forms.ToolStripMenuItem mnEP;
        private System.Windows.Forms.ToolStripMenuItem mnEL;
        private System.Windows.Forms.ToolStripMenuItem mnER;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

