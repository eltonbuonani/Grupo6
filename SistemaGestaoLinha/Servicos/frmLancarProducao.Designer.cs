namespace SistemaGestaoLinha.Servicos
{
    partial class frmLancarProducao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLancarProducao));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tblLancarProducaoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gestaoManutencaoDataSet10 = new SistemaGestaoLinha.gestaoManutencaoDataSet10();
            this.tblProdutoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tblProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblLancarProducaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.btnGravarLancaProd = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tbl_ProdutoTableAdapter = new SistemaGestaoLinha.gestaoManutencaoDataSet10TableAdapters.tbl_ProdutoTableAdapter();
            this.tbl_Lancar_ProducaoTableAdapter = new SistemaGestaoLinha.gestaoManutencaoDataSet10TableAdapters.tbl_Lancar_ProducaoTableAdapter();
            this.tblProdutoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblLancarProducaoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblProdutoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblProdutoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblLancarProducaoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLancarProducaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLancarProducaoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade produzida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Observações:";
            // 
            // tblLancarProducaoBindingSource2
            // 
            this.tblLancarProducaoBindingSource2.DataMember = "tbl_Lancar_Producao";
            this.tblLancarProducaoBindingSource2.DataSource = this.gestaoManutencaoDataSet10;
            // 
            // gestaoManutencaoDataSet10
            // 
            this.gestaoManutencaoDataSet10.DataSetName = "gestaoManutencaoDataSet10";
            this.gestaoManutencaoDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProdutoBindingSource4
            // 
            this.tblProdutoBindingSource4.DataMember = "tbl_Produto";
            this.tblProdutoBindingSource4.DataSource = this.gestaoManutencaoDataSet10;
            // 
            // tblProdutoBindingSource
            // 
            this.tblProdutoBindingSource.DataMember = "tbl_Produto";
            this.tblProdutoBindingSource.DataSource = this.gestaoManutencaoDataSet10;
            // 
            // tblLancarProducaoBindingSource
            // 
            this.tblLancarProducaoBindingSource.DataMember = "tbl_Lancar_Producao";
            this.tblLancarProducaoBindingSource.DataSource = this.gestaoManutencaoDataSet10;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(244, 60);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 22);
            this.txtData.TabIndex = 6;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(244, 90);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 22);
            this.txtHora.TabIndex = 7;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(244, 149);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 22);
            this.txtQuantidade.TabIndex = 8;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(76, 200);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(574, 86);
            this.txtObservacao.TabIndex = 9;
            // 
            // btnGravarLancaProd
            // 
            this.btnGravarLancaProd.Image = global::SistemaGestaoLinha.Properties.Resources.icons8_salvar_e_fechar_64;
            this.btnGravarLancaProd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGravarLancaProd.Location = new System.Drawing.Point(355, 330);
            this.btnGravarLancaProd.Name = "btnGravarLancaProd";
            this.btnGravarLancaProd.Size = new System.Drawing.Size(150, 120);
            this.btnGravarLancaProd.TabIndex = 10;
            this.btnGravarLancaProd.Text = "SALVAR";
            this.btnGravarLancaProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGravarLancaProd.UseVisualStyleBackColor = true;
            this.btnGravarLancaProd.Click += new System.EventHandler(this.btnGravarLancaProd_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = global::SistemaGestaoLinha.Properties.Resources.icons8_voltar_32;
            this.btnVoltar.Location = new System.Drawing.Point(166, 330);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(150, 120);
            this.btnVoltar.TabIndex = 22;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // tbl_ProdutoTableAdapter
            // 
            this.tbl_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_Lancar_ProducaoTableAdapter
            // 
            this.tbl_Lancar_ProducaoTableAdapter.ClearBeforeFill = true;
            // 
            // tblProdutoBindingSource1
            // 
            this.tblProdutoBindingSource1.DataMember = "tbl_Produto";
            this.tblProdutoBindingSource1.DataSource = this.gestaoManutencaoDataSet10;
            // 
            // tblLancarProducaoBindingSource1
            // 
            this.tblLancarProducaoBindingSource1.DataMember = "tbl_Lancar_Producao";
            this.tblLancarProducaoBindingSource1.DataSource = this.gestaoManutencaoDataSet10;
            // 
            // tblProdutoBindingSource2
            // 
            this.tblProdutoBindingSource2.DataMember = "tbl_Produto";
            this.tblProdutoBindingSource2.DataSource = this.gestaoManutencaoDataSet10;
            // 
            // tblProdutoBindingSource3
            // 
            this.tblProdutoBindingSource3.DataMember = "tbl_Produto";
            this.tblProdutoBindingSource3.DataSource = this.gestaoManutencaoDataSet10;
            // 
            // cbxProduto
            // 
            this.cbxProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblLancarProducaoBindingSource2, "ID_Produto", true));
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(244, 118);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(239, 24);
            this.cbxProduto.TabIndex = 5;
            // 
            // frmLancarProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnGravarLancaProd);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.cbxProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLancarProducao";
            this.Text = "Lancar produção diária";
            this.Load += new System.EventHandler(this.frmLancarProducao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblLancarProducaoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLancarProducaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLancarProducaoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button btnGravarLancaProd;
        private System.Windows.Forms.Button btnVoltar;
        private gestaoManutencaoDataSet10 gestaoManutencaoDataSet10;
        private System.Windows.Forms.BindingSource tblProdutoBindingSource;
        private gestaoManutencaoDataSet10TableAdapters.tbl_ProdutoTableAdapter tbl_ProdutoTableAdapter;
        private System.Windows.Forms.BindingSource tblLancarProducaoBindingSource;
        private gestaoManutencaoDataSet10TableAdapters.tbl_Lancar_ProducaoTableAdapter tbl_Lancar_ProducaoTableAdapter;
        private System.Windows.Forms.BindingSource tblProdutoBindingSource1;
        private System.Windows.Forms.BindingSource tblProdutoBindingSource2;
        private System.Windows.Forms.BindingSource tblLancarProducaoBindingSource1;
        private System.Windows.Forms.BindingSource tblLancarProducaoBindingSource2;
        private System.Windows.Forms.BindingSource tblProdutoBindingSource4;
        private System.Windows.Forms.BindingSource tblProdutoBindingSource3;
        private System.Windows.Forms.ComboBox cbxProduto;
    }
}