using CobrancaSimples.Code;
using DevExpress.XtraBars;
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
    public partial class ToolbarForm1 : DevExpress.XtraEditors.XtraForm
    {
        public ToolbarForm1()
        {
            InitializeComponent();
        }

        private void btnNovaNegociacao_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNovaCobranca f = new frmNovaCobranca();
            f.ShowDialog(this);
        }

        private void btnNovaOcorrência_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmNovaOcorrencia f = new FrmNovaOcorrencia();
            f.ShowDialog(this);
        }

        private void ToolbarForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPorNome_Click(object sender, EventArgs e)
        {
            LimparCampos();

            if (string.IsNullOrEmpty(tbBusca.Text))
            {
                MessageBox.Show("Digite o nome da parte", "Alerta");
                tbBusca.Focus();
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            try
            {
                var cobranca = DBASE.GetCobrancaByNome(tbBusca.Text);
                if (cobranca != null)
                {
                    tbId.Text = cobranca.Id.ToString();
                    tbNumero.Text = cobranca.Numero;
                    tbAutor.Text = cobranca.Autor;
                    tbReu.Text = cobranca.Reu;
                    tbValorDaCausa.Text = cobranca.ValorDaCausa.ToString();
                    tbValorAtualizado.Text = cobranca.ValorAtualizado.ToString();

                    var historico = DBASE.GetHistoricoList(cobranca.Id);

                    gridControl1.DataSource = historico;
                    gridControl1.Refresh();
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado", "Alerta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta");
            }

            this.Cursor = Cursors.Default;
        }

        private void btnPorNumero_Click(object sender, EventArgs e)
        {
            LimparCampos();

            if (string.IsNullOrEmpty(tbBusca.Text))
            {
                MessageBox.Show("Digite o número do processo", "Alerta");
                tbBusca.Focus();
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            try
            {
                var cobranca = DBASE.GetCobrancaByNumero(tbBusca.Text);
                if (cobranca != null)
                {
                    tbId.Text = cobranca.Id.ToString();
                    tbNumero.Text = cobranca.Numero;
                    tbAutor.Text = cobranca.Autor;
                    tbReu.Text = cobranca.Reu;
                    tbValorDaCausa.Text = cobranca.ValorDaCausa.ToString();
                    tbValorAtualizado.Text = cobranca.ValorAtualizado.ToString();

                    var historico = DBASE.GetHistoricoList(cobranca.Id);

                    gridControl1.DataSource = historico;
                    gridControl1.Refresh();
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado", "Alerta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta");
            }

            this.Cursor = Cursors.Default;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Cobranca c = new Cobranca()
            {
                Id = int.Parse(tbId.Text),
                Numero = tbNumero.Text,
                Autor = tbAutor.Text,
                Reu = tbReu.Text,
                ValorDaCausa = float.Parse(tbValorDaCausa.Text),
                ValorAtualizado = float.Parse(tbValorAtualizado.Text)
            };

            frmNovaCobranca f = new frmNovaCobranca(c);
            f.ShowDialog(this);
        }

        private void btnAddOcorrencia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text))
            {
                MessageBox.Show("Para adicionar uma ocorrência é preciso pesquisar uma negociação.", "Alerta");
                tbNumero.Focus();
                return;
            }

            FrmNovaOcorrencia f = new FrmNovaOcorrencia(tbId.Text);
            f.ShowDialog(this);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            int idCobranca = int.Parse(tbId.Text);

            var historico = DBASE.GetHistoricoList(idCobranca);
            gridControl1.DataSource = historico;
            gridControl1.Refresh();

            this.Cursor = Cursors.Default;
        }

        private void tbId_EditValueChanged(object sender, EventArgs e)
        {
            var txt = sender as TextEdit;

            bool isDisable = string.IsNullOrEmpty(txt.Text);
            btnAddOcorrencia.Enabled = !isDisable;
            btnEdit.Enabled = !isDisable;
            btnAtualizar.Enabled = !isDisable;
        }

        private void tbBusca_EditValueChanged(object sender, EventArgs e)
        {
            var txt = sender as TextEdit;

            bool isDisable = string.IsNullOrEmpty(txt.Text);
            btnPorNome.Enabled = !isDisable;
            btnPorNumero.Enabled = !isDisable;

            LimparCampos();
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

        private void tbBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Enter )
            {
                btnPorNumero_Click(null, null);
            }
        }
    }
}