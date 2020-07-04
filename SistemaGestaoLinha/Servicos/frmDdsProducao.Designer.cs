namespace SistemaGestaoLinha.Servicos
{
    partial class frmDdsProducao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDdsProducao));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDProducaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lancDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lancHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lancQuantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lancObservacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLancarProducaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestaoManutencaoDataSet10 = new SistemaGestaoLinha.gestaoManutencaoDataSet10();
            this.tbl_Lancar_ProducaoTableAdapter = new SistemaGestaoLinha.gestaoManutencaoDataSet10TableAdapters.tbl_Lancar_ProducaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLancarProducaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProducaoDataGridViewTextBoxColumn,
            this.lancDataDataGridViewTextBoxColumn,
            this.lancHoraDataGridViewTextBoxColumn,
            this.iDProdutoDataGridViewTextBoxColumn,
            this.lancQuantidadeDataGridViewTextBoxColumn,
            this.lancObservacaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblLancarProducaoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 388);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDProducaoDataGridViewTextBoxColumn
            // 
            this.iDProducaoDataGridViewTextBoxColumn.DataPropertyName = "ID_Producao";
            this.iDProducaoDataGridViewTextBoxColumn.HeaderText = "ID_Producao";
            this.iDProducaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDProducaoDataGridViewTextBoxColumn.Name = "iDProducaoDataGridViewTextBoxColumn";
            this.iDProducaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProducaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // lancDataDataGridViewTextBoxColumn
            // 
            this.lancDataDataGridViewTextBoxColumn.DataPropertyName = "lanc_Data";
            this.lancDataDataGridViewTextBoxColumn.HeaderText = "lanc_Data";
            this.lancDataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lancDataDataGridViewTextBoxColumn.Name = "lancDataDataGridViewTextBoxColumn";
            this.lancDataDataGridViewTextBoxColumn.Width = 125;
            // 
            // lancHoraDataGridViewTextBoxColumn
            // 
            this.lancHoraDataGridViewTextBoxColumn.DataPropertyName = "lanc_Hora";
            this.lancHoraDataGridViewTextBoxColumn.HeaderText = "lanc_Hora";
            this.lancHoraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lancHoraDataGridViewTextBoxColumn.Name = "lancHoraDataGridViewTextBoxColumn";
            this.lancHoraDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDProdutoDataGridViewTextBoxColumn
            // 
            this.iDProdutoDataGridViewTextBoxColumn.DataPropertyName = "ID_Produto";
            this.iDProdutoDataGridViewTextBoxColumn.HeaderText = "ID_Produto";
            this.iDProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDProdutoDataGridViewTextBoxColumn.Name = "iDProdutoDataGridViewTextBoxColumn";
            this.iDProdutoDataGridViewTextBoxColumn.Width = 125;
            // 
            // lancQuantidadeDataGridViewTextBoxColumn
            // 
            this.lancQuantidadeDataGridViewTextBoxColumn.DataPropertyName = "lanc_Quantidade";
            this.lancQuantidadeDataGridViewTextBoxColumn.HeaderText = "lanc_Quantidade";
            this.lancQuantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lancQuantidadeDataGridViewTextBoxColumn.Name = "lancQuantidadeDataGridViewTextBoxColumn";
            this.lancQuantidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // lancObservacaoDataGridViewTextBoxColumn
            // 
            this.lancObservacaoDataGridViewTextBoxColumn.DataPropertyName = "lanc_Observacao";
            this.lancObservacaoDataGridViewTextBoxColumn.HeaderText = "lanc_Observacao";
            this.lancObservacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lancObservacaoDataGridViewTextBoxColumn.Name = "lancObservacaoDataGridViewTextBoxColumn";
            this.lancObservacaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblLancarProducaoBindingSource
            // 
            this.tblLancarProducaoBindingSource.DataMember = "tbl_Lancar_Producao";
            this.tblLancarProducaoBindingSource.DataSource = this.gestaoManutencaoDataSet10;
            // 
            // gestaoManutencaoDataSet10
            // 
            this.gestaoManutencaoDataSet10.DataSetName = "gestaoManutencaoDataSet10";
            this.gestaoManutencaoDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Lancar_ProducaoTableAdapter
            // 
            this.tbl_Lancar_ProducaoTableAdapter.ClearBeforeFill = true;
            // 
            // frmDdsProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 629);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDdsProducao";
            this.Text = "Produção";
            this.Load += new System.EventHandler(this.frmDdsProducao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLancarProducaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestaoManutencaoDataSet10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private gestaoManutencaoDataSet10 gestaoManutencaoDataSet10;
        private System.Windows.Forms.BindingSource tblLancarProducaoBindingSource;
        private gestaoManutencaoDataSet10TableAdapters.tbl_Lancar_ProducaoTableAdapter tbl_Lancar_ProducaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProducaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lancDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lancHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lancQuantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lancObservacaoDataGridViewTextBoxColumn;
    }
}