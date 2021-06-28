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
    public partial class WRT : Form
    {
        public WRT()
        {
            InitializeComponent();
        }

        bool TextoFoiAlterado { get; set; }

        public void CarregarTexto(string texto)
        {
            txtEsc.Text = texto;
        }

        public void CarregarTexto(string nomeDoArquivo, Encoding codificação)
        {
            arquivo = nomeDoArquivo;
            texto = System.IO.File.ReadAllLines(nomeDoArquivo , codificação);
            txtEsc.Lines = texto;
            this.Text = "Escritor - " + arquivo;
        }

        public void SalvarTexto(string nomeDoArquivo, string[] texto,
            Encoding codificação)
        {
            System.IO.FileInfo inf = new System.IO.FileInfo(nomeDoArquivo);
            if (inf.Attributes == System.IO.FileAttributes.ReadOnly)
            {
                if (dlgSv.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    arquivo = dlgSv.FileName;
                }
            }
            System.IO.File.WriteAllLines(nomeDoArquivo, texto, codificação);
            MessageBox.Show("Texto salvo com sucesso!", "Editor de texto",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Text = "Escritor - " + arquivo;
        }

        private string[] texto;
        private string arquivo = "Arquivo";

        private void WRT_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarTexto(Environment.GetCommandLineArgs()[1], Encoding.Default);
            }
            catch
            {
            }

        }

        private void mnAA_Click(object sender, EventArgs e)
        {
            if (dlgAb.ShowDialog() == DialogResult.Cancel)
            {
                return;                
            }
            CarregarTexto(@dlgAb.FileName, Encoding.Default);            
        }

        private void mnAS_Click(object sender, EventArgs e)
        {
            SalvarTexto(@dlgSv.FileName, txtEsc.Lines, Encoding.Default);
        }

        private void mnAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnAC_Click(object sender, EventArgs e)
        {
            if (dlgSv.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            SalvarTexto(@dlgSv.FileName, txtEsc.Lines, Encoding.Default);
        }

        private void mnE_DropDownOpened(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText() == true)
            {
                mnEL.Enabled = true;
            }
            else
            {
                mnEL.Enabled = false;
            }
        }
        
        private void mnEC_Click(object sender, EventArgs e)
        {
            Segurança.Criptografia cript = new Segurança.Criptografia();
            try
            {
                txtEsc.Text = cript.Criptografar(txtEsc.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro de criptografia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            mnEC.Enabled = false;
            mnED.Enabled = true;
        }

        private void mnED_Click(object sender, EventArgs e)
        {
            Segurança.Criptografia cript = new Segurança.Criptografia();
            try
            {
                txtEsc.Text = cript.Descriptografar(txtEsc.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro de criptografia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            mnEC.Enabled = true;
            mnED.Enabled = false;
        }

        private void mnEL_Click(object sender, EventArgs e)
        {
            txtEsc.Paste();
        }

        private void mnEP_Click(object sender, EventArgs e)
        {
            txtEsc.Copy();
        }

        private void mnER_Click(object sender, EventArgs e)
        {
            txtEsc.Cut();
        }

        private void mnDS_Click(object sender, EventArgs e)
        {
            ABT sobre = new ABT();
            sobre.ShowDialog();
        }

        private void mnFF_Click(object sender, EventArgs e)
        {
            if (dlgFn.ShowDialog() == DialogResult.OK)
            {
                this.txtEsc.Font = dlgFn.Font;
                this.txtEsc.ForeColor = dlgFn.Color;
            }
        }

        private void mnFQ_CheckedChanged(object sender, EventArgs e)
        {
            this.txtEsc.WordWrap = mnFQ.Checked;
        }

        private void txtEsc_TextChanged(object sender, EventArgs e)
        {
            TextoFoiAlterado = true;
        }

        private void WRT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TextoFoiAlterado == true)
            {
                DialogResult resposta = MessageBox.Show("Deseja salvar as alterações no arquivo?",
                    "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    texto = txtEsc.Lines;
                    System.IO.File.WriteAllLines(@arquivo, texto, Encoding.Default);
                }
                else if (resposta == DialogResult.No)
                {
                    return;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void WRT_SizeChanged(object sender, EventArgs e)
        {
            this.txtEsc.Size = new Size(WRT.ActiveForm.Size.Width - 16,
                WRT.ActiveForm.Size.Height - 65);            
        }
    }
}
