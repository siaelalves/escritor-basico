using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Writer
{
    public partial class ABT : Form
    {
        public ABT()
        {
            InitializeComponent();
        }

        private void ABT_Load(object sender, EventArgs e)
        {
            picCm.ImageLocation = @Environment.CurrentDirectory + "\\Contact_me.png";
            picIc.ImageLocation = @Environment.CurrentDirectory + "\\writer.ico";
            lblNm.Text = Application.ProductName;
            lblVr.Text = Application.ProductVersion;
            lblCm.Text = Application.CompanyName;
            lblCnt.Text = "Este aplicativo foi desenvolvido por Siael Alves de Carvalho" +
                " e não pode ser distribuído sem o seu consentimento." +
                " Em caso de dúvidas, contate siaelalves@outlook.com.";               
        }
    }
}
