namespace CobrancaSimples
{
    partial class frmNovaCobranca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovaCobranca));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tbValorAtualizado = new DevExpress.XtraEditors.TextEdit();
            this.tbValorDaCausa = new DevExpress.XtraEditors.TextEdit();
            this.tbReu = new DevExpress.XtraEditors.TextEdit();
            this.tbAutor = new DevExpress.XtraEditors.TextEdit();
            this.tbNumero = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.tbId = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbValorAtualizado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValorDaCausa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAutor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tbValorAtualizado);
            this.groupControl1.Controls.Add(this.tbValorDaCausa);
            this.groupControl1.Controls.Add(this.tbReu);
            this.groupControl1.Controls.Add(this.tbAutor);
            this.groupControl1.Controls.Add(this.tbNumero);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(559, 156);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Informe os Dados";
            // 
            // tbValorAtualizado
            // 
            this.tbValorAtualizado.Location = new System.Drawing.Point(411, 115);
            this.tbValorAtualizado.Name = "tbValorAtualizado";
            this.tbValorAtualizado.Properties.Appearance.Options.UseTextOptions = true;
            this.tbValorAtualizado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbValorAtualizado.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.tbValorAtualizado.Properties.MaskSettings.Set("mask", "n");
            this.tbValorAtualizado.Properties.MaskSettings.Set("hideInsignificantZeros", false);
            this.tbValorAtualizado.Properties.MaskSettings.Set("autoHideDecimalSeparator", false);
            this.tbValorAtualizado.Properties.MaskSettings.Set("culture", "pt-BR");
            this.tbValorAtualizado.Properties.MaskSettings.Set("valueType", typeof(float));
            this.tbValorAtualizado.Properties.UseMaskAsDisplayFormat = true;
            this.tbValorAtualizado.Size = new System.Drawing.Size(133, 20);
            this.tbValorAtualizado.TabIndex = 10;
            // 
            // tbValorDaCausa
            // 
            this.tbValorDaCausa.Location = new System.Drawing.Point(126, 111);
            this.tbValorDaCausa.Name = "tbValorDaCausa";
            this.tbValorDaCausa.Properties.Appearance.Options.UseTextOptions = true;
            this.tbValorDaCausa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbValorDaCausa.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.tbValorDaCausa.Properties.MaskSettings.Set("mask", "n");
            this.tbValorDaCausa.Properties.MaskSettings.Set("culture", "pt-BR");
            this.tbValorDaCausa.Properties.MaskSettings.Set("autoHideDecimalSeparator", false);
            this.tbValorDaCausa.Properties.MaskSettings.Set("hideInsignificantZeros", false);
            this.tbValorDaCausa.Properties.MaskSettings.Set("valueType", typeof(float));
            this.tbValorDaCausa.Properties.UseMaskAsDisplayFormat = true;
            this.tbValorDaCausa.Size = new System.Drawing.Size(133, 20);
            this.tbValorDaCausa.TabIndex = 9;
            // 
            // tbReu
            // 
            this.tbReu.Location = new System.Drawing.Point(126, 85);
            this.tbReu.Name = "tbReu";
            this.tbReu.Size = new System.Drawing.Size(418, 20);
            this.tbReu.TabIndex = 8;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(126, 59);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(418, 20);
            this.tbAutor.TabIndex = 7;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(126, 33);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(278, 20);
            this.tbNumero.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(323, 122);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(81, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Valor Atualizado:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(43, 118);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Valor da Causa:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(96, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Réu:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(88, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Autor:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Número do Processo:";
            // 
            // btnOK
            // 
            this.btnOK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.ImageOptions.Image")));
            this.btnOK.Location = new System.Drawing.Point(415, 174);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(496, 174);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "&Fechar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(12, 177);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(52, 20);
            this.tbId.TabIndex = 10;
            this.tbId.Visible = false;
            // 
            // frmNovaCobranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 207);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmNovaCobranca.IconOptions.Image")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNovaCobranca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Negociação";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbValorAtualizado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValorDaCausa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAutor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbValorAtualizado;
        private DevExpress.XtraEditors.TextEdit tbValorDaCausa;
        private DevExpress.XtraEditors.TextEdit tbReu;
        private DevExpress.XtraEditors.TextEdit tbAutor;
        private DevExpress.XtraEditors.TextEdit tbNumero;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.TextEdit tbId;
    }
}