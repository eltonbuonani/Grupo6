namespace SistemaGestaoLinha.Servicos
{
    partial class frmDefinirProducaoM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDefinirProducaoM));
            this.btnGravarQuantidadeProducao = new System.Windows.Forms.Button();
            this.cbxProduto = new System.Windows.Forms.ComboBox();
            this.txtQuantidadeProduzida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGravarQuantidadeProducao
            // 
            this.btnGravarQuantidadeProducao.Image = global::SistemaGestaoLinha.Properties.Resources.icons8_salvar_e_fechar_64;
            this.btnGravarQuantidadeProducao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGravarQuantidadeProducao.Location = new System.Drawing.Point(280, 174);
            this.btnGravarQuantidadeProducao.Name = "btnGravarQuantidadeProducao";
            this.btnGravarQuantidadeProducao.Size = new System.Drawing.Size(150, 120);
            this.btnGravarQuantidadeProducao.TabIndex = 15;
            this.btnGravarQuantidadeProducao.Text = "SALVAR";
            this.btnGravarQuantidadeProducao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGravarQuantidadeProducao.UseVisualStyleBackColor = true;
            this.btnGravarQuantidadeProducao.Click += new System.EventHandler(this.btnGravarQuantidadeProducao_Click);
            // 
            // cbxProduto
            // 
            this.cbxProduto.FormattingEnabled = true;
            this.cbxProduto.Location = new System.Drawing.Point(298, 59);
            this.cbxProduto.Name = "cbxProduto";
            this.cbxProduto.Size = new System.Drawing.Size(200, 24);
            this.cbxProduto.TabIndex = 14;
            // 
            // txtQuantidadeProduzida
            // 
            this.txtQuantidadeProduzida.Location = new System.Drawing.Point(298, 100);
            this.txtQuantidadeProduzida.Name = "txtQuantidadeProduzida";
            this.txtQuantidadeProduzida.Size = new System.Drawing.Size(132, 22);
            this.txtQuantidadeProduzida.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Quantidade mensal a ser produzida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Produto:";
            // 
            // button1
            // 
            this.button1.Image = global::SistemaGestaoLinha.Properties.Resources.icons8_voltar_32;
            this.button1.Location = new System.Drawing.Point(117, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 120);
            this.button1.TabIndex = 22;
            this.button1.Text = "VOLTAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDefinirProducaoM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGravarQuantidadeProducao);
            this.Controls.Add(this.cbxProduto);
            this.Controls.Add(this.txtQuantidadeProduzida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDefinirProducaoM";
            this.Text = "Programar produção";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravarQuantidadeProducao;
        private System.Windows.Forms.ComboBox cbxProduto;
        private System.Windows.Forms.TextBox txtQuantidadeProduzida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}