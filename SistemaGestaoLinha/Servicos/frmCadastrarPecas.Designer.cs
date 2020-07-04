namespace SistemaGestaoLinha.Servicos
{
    partial class frmCadastrarPecas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarPecas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrarPecas = new System.Windows.Forms.Button();
            this.txtDescricaoPeca = new System.Windows.Forms.TextBox();
            this.txtQuantidadePeca = new System.Windows.Forms.TextBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição da peça:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo (unidade ou comprimento):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade:";
            // 
            // btnCadastrarPecas
            // 
            this.btnCadastrarPecas.Image = global::SistemaGestaoLinha.Properties.Resources.icons8_salvar_e_fechar_64;
            this.btnCadastrarPecas.Location = new System.Drawing.Point(287, 207);
            this.btnCadastrarPecas.Name = "btnCadastrarPecas";
            this.btnCadastrarPecas.Size = new System.Drawing.Size(150, 120);
            this.btnCadastrarPecas.TabIndex = 3;
            this.btnCadastrarPecas.Text = "SALVAR";
            this.btnCadastrarPecas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarPecas.UseVisualStyleBackColor = true;
            this.btnCadastrarPecas.Click += new System.EventHandler(this.btnCadastrarPecas_Click);
            // 
            // txtDescricaoPeca
            // 
            this.txtDescricaoPeca.Location = new System.Drawing.Point(314, 62);
            this.txtDescricaoPeca.Name = "txtDescricaoPeca";
            this.txtDescricaoPeca.Size = new System.Drawing.Size(231, 22);
            this.txtDescricaoPeca.TabIndex = 4;
            // 
            // txtQuantidadePeca
            // 
            this.txtQuantidadePeca.Location = new System.Drawing.Point(314, 135);
            this.txtQuantidadePeca.Name = "txtQuantidadePeca";
            this.txtQuantidadePeca.Size = new System.Drawing.Size(73, 22);
            this.txtQuantidadePeca.TabIndex = 5;
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "unidade",
            "comprimento ( em metros)"});
            this.cbxTipo.Location = new System.Drawing.Point(314, 96);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(157, 24);
            this.cbxTipo.TabIndex = 6;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = global::SistemaGestaoLinha.Properties.Resources.icons8_voltar_32;
            this.btnVoltar.Location = new System.Drawing.Point(92, 207);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(150, 120);
            this.btnVoltar.TabIndex = 22;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCadastrarPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 369);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.txtQuantidadePeca);
            this.Controls.Add(this.txtDescricaoPeca);
            this.Controls.Add(this.btnCadastrarPecas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadastrarPecas";
            this.Text = "Cadastrar peças";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrarPecas;
        private System.Windows.Forms.TextBox txtDescricaoPeca;
        private System.Windows.Forms.TextBox txtQuantidadePeca;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Button btnVoltar;
    }
}