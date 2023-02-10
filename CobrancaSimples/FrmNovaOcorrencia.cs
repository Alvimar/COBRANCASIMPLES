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
    public partial class FrmNovaOcorrencia : DevExpress.XtraEditors.XtraForm
    {
        public FrmNovaOcorrencia()
        {
            InitializeComponent();
        }

        public FrmNovaOcorrencia(string idCobranca) : this()
        {
            tbIdCobranca.Text = idCobranca;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(deData.Text))
            {
                MessageBox.Show("Informe a data da ocorrência.", "Alerta");
                deData.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tbEvento.Text))
            {
                MessageBox.Show("Informe o tipo de evento.", "Alerta");
                tbEvento.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tbDescricao.Text))
            {
                MessageBox.Show("Informe a descrição da ocorrência.", "Alerta");
                tbDescricao.Focus();
                return;
            }

            if (MessageBox.Show("Salvar os dados?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            try
            {
                Historico h = new Historico()
                {
                    Data = deData.DateTime,
                    Evento = tbEvento.Text,
                    Descricao = tbDescricao.Text,
                    IdCobranca = int.Parse(tbIdCobranca.Text)
                };

                int ret = DBASE.SetHistorico(h);

                if (ret > 0)
                {
                    MessageBox.Show("Registro salvo com sucesso.", "Alerta");
                    LimparCampos();
                    deData.Focus();
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
            deData.Text = string.Empty;
            tbEvento.Text = string.Empty;
            tbDescricao.Text = string.Empty;
        }
    }
}