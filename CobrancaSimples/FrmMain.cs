using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CobrancaSimples
{
    public partial class FrmMain : DevExpress.XtraBars.TabForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            FrmMain form = new FrmMain();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new frmNovaCobranca();
            f.ShowDialog(this);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new FrmNovaOcorrencia();
            f.ShowDialog(this);
        }
    }
}
