namespace SistemaGestaoLinha.Servicos
{
    partial class frmConsultaPecas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaPecas));
            this.dgvPecas = new System.Windows.Forms.DataGridView();
            this.iDPecasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pecDescricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pecTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pecQuantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPecasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestaoManutencaoDataSet8 = new SistemaGestaoLinha.gestaoManutencaoDataSet8();
            this.txtPesDescr = new System.Windows.Forms.TextBox();
            this.gestaoManutencaoDataSet1 = new SistemaGestaoLinha.gestaoManutencaoDataSet1();
            this.gestaoManutencaoDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestaoManutencaoDataSet = new SistemaGestaoLinha.gestaoManutencaoDataSet();
            this.gestaoManutencaoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisarPecas = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tbl_PecasTableAdapter = new SistemaGestaoLinha.gestaoManutencaoDataSet8TableAdapters.tbl_PecasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPecasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPecas
            // 
            this.dgvPecas.AutoGenerateColumns = false;
            this.dgvPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPecasDataGridViewTextBoxColumn,
            this.pecDescricaoDataGridViewTextBoxColumn,
            this.pecTipoDataGridViewTextBoxColumn,
            this.pecQuantidadeDataGridViewTextBoxColumn});
            this.dgvPecas.DataSource = this.tblPecasBindingSource;
            this.dgvPecas.Location = new System.Drawing.Point(53, 153);
            this.dgvPecas.Name = "dgvPecas";
            this.dgvPecas.RowHeadersWidth = 51;
            this.dgvPecas.RowTemplate.Height = 24;
            this.dgvPecas.Size = new System.Drawing.Size(812, 255);
            this.dgvPecas.TabIndex = 0;
            this.dgvPecas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPecas_CellContentClick);
            // 
            // iDPecasDataGridViewTextBoxColumn
            // 
            this.iDPecasDataGridViewTextBoxColumn.DataPropertyName = "ID_Pecas";
            this.iDPecasDataGridViewTextBoxColumn.HeaderText = "ID_Pecas";
            this.iDPecasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPecasDataGridViewTextBoxColumn.Name = "iDPecasDataGridViewTextBoxColumn";
            this.iDPecasDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPecasDataGridViewTextBoxColumn.Width = 125;
            // 
            // pecDescricaoDataGridViewTextBoxColumn
            // 
            this.pecDescricaoDataGridViewTextBoxColumn.DataPropertyName = "pec_Descricao";
            this.pecDescricaoDataGridViewTextBoxColumn.HeaderText = "pec_Descricao";
            this.pecDescricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pecDescricaoDataGridViewTextBoxColumn.Name = "pecDescricaoDataGridViewTextBoxColumn";
            this.pecDescricaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // pecTipoDataGridViewTextBoxColumn
            // 
            this.pecTipoDataGridViewTextBoxColumn.DataPropertyName = "pec_Tipo";
            this.pecTipoDataGridViewTextBoxColumn.HeaderText = "pec_Tipo";
            this.pecTipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pecTipoDataGridViewTextBoxColumn.Name = "pecTipoDataGridViewTextBoxColumn";
            this.pecTipoDataGridViewTextBoxColumn.Width = 125;
            // 
            // pecQuantidadeDataGridViewTextBoxColumn
            // 
            this.pecQuantidadeDataGridViewTextBoxColumn.DataPropertyName = "pec_Quantidade";
            this.pecQuantidadeDataGridViewTextBoxColumn.HeaderText = "pec_Quantidade";
            this.pecQuantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pecQuantidadeDataGridViewTextBoxColumn.Name = "pecQuantidadeDataGridViewTextBoxColumn";
            this.pecQuantidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblPecasBindingSource
            // 
            this.tblPecasBindingSource.DataMember = "tbl_Pecas";
            this.tblPecasBindingSource.DataSource = this.gestaoManutencaoDataSet8;
            // 
            // gestaoManutencaoDataSet8
            // 
            this.gestaoManutencaoDataSet8.DataSetName = "gestaoManutencaoDataSet8";
            this.gestaoManutencaoDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPesDescr
            // 
            this.txtPesDescr.Location = new System.Drawing.Point(56, 51);
            this.txtPesDescr.Name = "txtPesDescr";
            this.txtPesDescr.Size = new System.Drawing.Size(282, 22);
            this.txtPesDescr.TabIndex = 2;
            // 
            // gestaoManutencaoDataSet1
            // 
            this.gestaoManutencaoDataSet1.DataSetName = "gestaoManutencaoDataSet1";
            this.gestaoManutencaoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestaoManutencaoDataSet1BindingSource
            // 
            this.gestaoManutencaoDataSet1BindingSource.DataSource = this.gestaoManutencaoDataSet1;
            this.gestaoManutencaoDataSet1BindingSource.Position = 0;
            // 
            // gestaoManutencaoDataSet
            // 
            this.gestaoManutencaoDataSet.DataSetName = "gestaoManutencaoDataSet";
            this.gestaoManutencaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestaoManutencaoDataSetBindingSource
            // 
            this.gestaoManutencaoDataSetBindingSource.DataSource = this.gestaoManutencaoDataSet;
            this.gestaoManutencaoDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "DESCRIÇÃO DA PEÇA:";
            // 
            // btnPesquisarPecas
            // 
            this.btnPesquisarPecas.Image = global::SistemaGestaoLinha.Properties.Resources.icons8_pesquisar_32;
            this.btnPesquisarPecas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarPecas.Location = new System.Drawing.Point(368, 40);
            this.btnPesquisarPecas.Name = "btnPesquisarPecas";
            this.btnPesquisarPecas.Size = new System.Drawing.Size(140, 45);
            this.btnPesquisarPecas.TabIndex = 3;
            this.btnPesquisarPecas.Text = "PESQUISAR";
            this.btnPesquisarPecas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisarPecas.UseVisualStyleBackColor = true;
            this.btnPesquisarPecas.Click += new System.EventHandler(this.btnPesquisarPecas_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = global::SistemaGestaoLinha.Properties.Resources.icons8_voltar_32;
            this.btnVoltar.Location = new System.Drawing.Point(57, 438);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(150, 120);
            this.btnVoltar.TabIndex = 22;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // tbl_PecasTableAdapter
            // 
            this.tbl_PecasTableAdapter.ClearBeforeFill = true;
            // 
            // frmConsultaPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 584);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisarPecas);
            this.Controls.Add(this.txtPesDescr);
            this.Controls.Add(this.dgvPecas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsultaPecas";
            this.Text = "Consultar estoque de peças";
            this.Load += new System.EventHandler(this.frmConsultaPecas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPecasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPecas;
        private System.Windows.Forms.TextBox txtPesDescr;
        private System.Windows.Forms.BindingSource gestaoManutencaoDataSetBindingSource;
        private gestaoManutencaoDataSet gestaoManutencaoDataSet;
        private gestaoManutencaoDataSet1 gestaoManutencaoDataSet1;
        private System.Windows.Forms.BindingSource gestaoManutencaoDataSet1BindingSource;
        private gestaoManutencaoDataSet8 gestaoManutencaoDataSet8;
        private System.Windows.Forms.BindingSource tblPecasBindingSource;
        private gestaoManutencaoDataSet8TableAdapters.tbl_PecasTableAdapter tbl_PecasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPecasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pecDescricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pecTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pecQuantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPesquisarPecas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
    }
}