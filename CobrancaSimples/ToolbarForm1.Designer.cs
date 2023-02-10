namespace CobrancaSimples
{
    partial class ToolbarForm1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolbarForm1));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnNovaNegociacao = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnNovaOcorrência = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnAtualizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddOcorrencia = new DevExpress.XtraEditors.SimpleButton();
            this.tbId = new DevExpress.XtraEditors.TextEdit();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.tbValorAtualizado = new DevExpress.XtraEditors.TextEdit();
            this.tbValorDaCausa = new DevExpress.XtraEditors.TextEdit();
            this.tbReu = new DevExpress.XtraEditors.TextEdit();
            this.tbAutor = new DevExpress.XtraEditors.TextEdit();
            this.tbNumero = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnPorNumero = new DevExpress.XtraEditors.SimpleButton();
            this.btnPorNome = new DevExpress.XtraEditors.SimpleButton();
            this.tbBusca = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValorAtualizado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValorDaCausa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAutor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBusca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNovaNegociacao,
            this.barButtonItem2,
            this.btnNovaOcorrência});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNovaNegociacao)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnNovaNegociacao
            // 
            this.btnNovaNegociacao.Caption = "Nova Negociação";
            this.btnNovaNegociacao.Id = 0;
            this.btnNovaNegociacao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaNegociacao.ImageOptions.Image")));
            this.btnNovaNegociacao.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNovaNegociacao.ImageOptions.LargeImage")));
            this.btnNovaNegociacao.Name = "btnNovaNegociacao";
            this.btnNovaNegociacao.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnNovaNegociacao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovaNegociacao_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(873, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 430);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(873, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 406);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(873, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 406);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnNovaOcorrência
            // 
            this.btnNovaOcorrência.Caption = "Nova Ocorrência";
            this.btnNovaOcorrência.Id = 2;
            this.btnNovaOcorrência.Name = "btnNovaOcorrência";
            this.btnNovaOcorrência.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNovaOcorrência_ItemClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnAtualizar);
            this.groupControl1.Controls.Add(this.btnAddOcorrencia);
            this.groupControl1.Controls.Add(this.tbId);
            this.groupControl1.Controls.Add(this.btnEdit);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.tbValorAtualizado);
            this.groupControl1.Controls.Add(this.tbValorDaCausa);
            this.groupControl1.Controls.Add(this.tbReu);
            this.groupControl1.Controls.Add(this.tbAutor);
            this.groupControl1.Controls.Add(this.tbNumero);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.btnPorNumero);
            this.groupControl1.Controls.Add(this.btnPorNome);
            this.groupControl1.Controls.Add(this.tbBusca);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 24);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(873, 199);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Pesquisar";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.ImageOptions.Image")));
            this.btnAtualizar.Location = new System.Drawing.Point(482, 85);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(22, 23);
            this.btnAtualizar.TabIndex = 24;
            this.btnAtualizar.ToolTip = "Carregar Ocorrências";
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnAddOcorrencia
            // 
            this.btnAddOcorrencia.Enabled = false;
            this.btnAddOcorrencia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOcorrencia.ImageOptions.Image")));
            this.btnAddOcorrencia.Location = new System.Drawing.Point(454, 85);
            this.btnAddOcorrencia.Name = "btnAddOcorrencia";
            this.btnAddOcorrencia.Size = new System.Drawing.Size(22, 23);
            this.btnAddOcorrencia.TabIndex = 24;
            this.btnAddOcorrencia.ToolTip = "Registrar Ocorrência";
            this.btnAddOcorrencia.Click += new System.EventHandler(this.btnAddOcorrencia_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(543, 87);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(52, 20);
            this.tbId.TabIndex = 23;
            this.tbId.Visible = false;
            this.tbId.EditValueChanged += new System.EventHandler(this.tbId_EditValueChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.Location = new System.Drawing.Point(426, 85);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(22, 23);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.ToolTip = "Editar";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(118, 69);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 13);
            this.labelControl7.TabIndex = 21;
            this.labelControl7.Text = "Detalhes";
            // 
            // tbValorAtualizado
            // 
            this.tbValorAtualizado.Location = new System.Drawing.Point(403, 170);
            this.tbValorAtualizado.Name = "tbValorAtualizado";
            this.tbValorAtualizado.Properties.Appearance.Options.UseTextOptions = true;
            this.tbValorAtualizado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tbValorAtualizado.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.tbValorAtualizado.Properties.MaskSettings.Set("mask", "n");
            this.tbValorAtualizado.Properties.MaskSettings.Set("culture", "pt-BR");
            this.tbValorAtualizado.Properties.MaskSettings.Set("valueType", typeof(float));
            this.tbValorAtualizado.Properties.MaskSettings.Set("autoHideDecimalSeparator", false);
            this.tbValorAtualizado.Properties.MaskSettings.Set("hideInsignificantZeros", false);
            this.tbValorAtualizado.Properties.UseMaskAsDisplayFormat = true;
            this.tbValorAtualizado.Size = new System.Drawing.Size(133, 20);
            this.tbValorAtualizado.TabIndex = 20;
            // 
            // tbValorDaCausa
            // 
            this.tbValorDaCausa.Location = new System.Drawing.Point(118, 166);
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
            this.tbValorDaCausa.TabIndex = 19;
            // 
            // tbReu
            // 
            this.tbReu.Location = new System.Drawing.Point(118, 140);
            this.tbReu.Name = "tbReu";
            this.tbReu.Size = new System.Drawing.Size(418, 20);
            this.tbReu.TabIndex = 18;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(118, 114);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(418, 20);
            this.tbAutor.TabIndex = 17;
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(118, 88);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(302, 20);
            this.tbNumero.TabIndex = 16;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(315, 177);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(81, 13);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Valor Atualizado:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(35, 173);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Valor da Causa:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(88, 147);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Réu:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(80, 121);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Autor:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(9, 96);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(102, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Número do Processo:";
            // 
            // btnPorNumero
            // 
            this.btnPorNumero.Enabled = false;
            this.btnPorNumero.Location = new System.Drawing.Point(543, 32);
            this.btnPorNumero.Name = "btnPorNumero";
            this.btnPorNumero.Size = new System.Drawing.Size(122, 23);
            this.btnPorNumero.TabIndex = 3;
            this.btnPorNumero.Text = "Pesquisar por número";
            this.btnPorNumero.Click += new System.EventHandler(this.btnPorNumero_Click);
            // 
            // btnPorNome
            // 
            this.btnPorNome.Enabled = false;
            this.btnPorNome.Location = new System.Drawing.Point(426, 32);
            this.btnPorNome.Name = "btnPorNome";
            this.btnPorNome.Size = new System.Drawing.Size(111, 23);
            this.btnPorNome.TabIndex = 2;
            this.btnPorNome.Text = "Pesquisar por nome";
            this.btnPorNome.Click += new System.EventHandler(this.btnPorNome_Click);
            // 
            // tbBusca
            // 
            this.tbBusca.Location = new System.Drawing.Point(118, 34);
            this.tbBusca.MenuManager = this.barManager1;
            this.tbBusca.Name = "tbBusca";
            this.tbBusca.Size = new System.Drawing.Size(302, 20);
            this.tbBusca.TabIndex = 1;
            this.tbBusca.EditValueChanged += new System.EventHandler(this.tbBusca_EditValueChanged);
            this.tbBusca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBusca_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Expressão de Busca:";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 223);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(873, 207);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "IdCobranca";
            this.gridColumn2.FieldName = "IdCobranca";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Data";
            this.gridColumn3.FieldName = "Data";
            this.gridColumn3.MaxWidth = 120;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Evento";
            this.gridColumn4.FieldName = "Evento";
            this.gridColumn4.MaxWidth = 220;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Descrição";
            this.gridColumn5.FieldName = "Descricao";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // ToolbarForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("ToolbarForm1.IconOptions.Image")));
            this.Name = "ToolbarForm1";
            this.Text = "Sistema de Negociação";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ToolbarForm1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValorAtualizado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValorDaCausa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAutor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBusca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnNovaNegociacao;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnPorNumero;
        private DevExpress.XtraEditors.SimpleButton btnPorNome;
        private DevExpress.XtraEditors.TextEdit tbBusca;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem btnNovaOcorrência;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit tbValorAtualizado;
        private DevExpress.XtraEditors.TextEdit tbValorDaCausa;
        private DevExpress.XtraEditors.TextEdit tbReu;
        private DevExpress.XtraEditors.TextEdit tbAutor;
        private DevExpress.XtraEditors.TextEdit tbNumero;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.TextEdit tbId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton btnAddOcorrencia;
        private DevExpress.XtraEditors.SimpleButton btnAtualizar;
    }
}