using CobrancaSimples.Code;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CobrancaSimples
{
    public partial class frmNovaCobranca : DevExpress.XtraEditors.XtraForm
    {
        int _id = 0;

        public frmNovaCobranca()
        {
            InitializeComponent();
        }

        public frmNovaCobranca(Cobranca c) : this()
        {
            _id = c.Id;

            tbId.Text = c.Id.ToString();
            tbNumero.Text = c.Numero;
            tbAutor.Text = c.Autor;
            tbReu.Text = c.Reu;
            tbValorDaCausa.Text = c.ValorDaCausa.ToString();
            tbValorAtualizado.Text = c.ValorAtualizado.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNumero.Text))
            {
                MessageBox.Show("Informe o número do processo.", "Alerta");
                tbNumero.Focus();
                return;
            }

            if (MessageBox.Show("Salvar os dados?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            try
            {
                float.TryParse(tbValorDaCausa.Text, out float valorDaCausa);
                float.TryParse(tbValorAtualizado.Text, out float valorAtualizado);

                Cobranca c = new Cobranca()
                {
                    Id = _id,
                    Numero = tbNumero.Text,
                    Autor = tbAutor.Text,
                    Reu = tbReu.Text,
                    ValorDaCausa = valorDaCausa,
                    ValorAtualizado = valorAtualizado
                };

                int ret = 0;

                if (_id == 0)
                {
                    ret = DBASE.SetCobranca(c);
                }
                else
                {
                    ret = DBASE.UpdateCobranca(c);
                }

                if (ret > 0)
                {
                    MessageBox.Show("Registro salvo com sucesso.", "Alerta");
                    LimparCampos();
                    tbNumero.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta");
            }

            this.Cursor = Cursors.Default;
        }

        private void LimparCampos()
        {
            tbNumero.Text = string.Empty;
            tbAutor.Text = string.Empty;
            tbReu.Text = string.Empty;
            tbValorAtualizado.Text = string.Empty;
            tbValorDaCausa.Text = string.Empty;
            tbId.Text = string.Empty;
        }
    }
}