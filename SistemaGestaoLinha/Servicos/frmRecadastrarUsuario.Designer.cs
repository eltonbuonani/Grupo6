namespace SistemaGestaoLinha.Servicos
{
    partial class frmRecadastrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecadastrarUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeRecadastro = new System.Windows.Forms.TextBox();
            this.txtCrachaRecadastro = new System.Windows.Forms.TextBox();
            this.txtSenhaRecadastro = new System.Windows.Forms.TextBox();
            this.txtConfirmarSenhaRecadastro = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnRecadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Crachá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirmar Senha:";
            // 
            // txtNomeRecadastro
            // 
            this.txtNomeRecadastro.Location = new System.Drawing.Point(399, 56);
            this.txtNomeRecadastro.Name = "txtNomeRecadastro";
            this.txtNomeRecadastro.Size = new System.Drawing.Size(100, 22);
            this.txtNomeRecadastro.TabIndex = 5;
            // 
            // txtCrachaRecadastro
            // 
            this.txtCrachaRecadastro.Location = new System.Drawing.Point(399, 94);
            this.txtCrachaRecadastro.Name = "txtCrachaRecadastro";
            this.txtCrachaRecadastro.Size = new System.Drawing.Size(100, 22);
            this.txtCrachaRecadastro.TabIndex = 6;
            // 
            // txtSenhaRecadastro
            // 
            this.txtSenhaRecadastro.Location = new System.Drawing.Point(399, 131);
            this.txtSenhaRecadastro.Name = "txtSenhaRecadastro";
            this.txtSenhaRecadastro.PasswordChar = '*';
            this.txtSenhaRecadastro.Size = new System.Drawing.Size(100, 22);
            this.txtSenhaRecadastro.TabIndex = 7;
            // 
            // txtConfirmarSenhaRecadastro
            // 
            this.txtConfirmarSenhaRecadastro.Location = new System.Drawing.Point(399, 167);
            this.txtConfirmarSenhaRecadastro.Name = "txtConfirmarSenhaRecadastro";
            this.txtConfirmarSenhaRecadastro.PasswordChar = '*';
            this.txtConfirmarSenhaRecadastro.Size = new System.Drawing.Size(100, 22);
            this.txtConfirmarSenhaRecadastro.TabIndex = 8;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = global::SistemaGestaoLinha.Properties.Resources.icons8_voltar_32;
            this.btnVoltar.Location = new System.Drawing.Point(227, 216);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(150, 120);
            this.btnVoltar.TabIndex = 22;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnRecadastrar
            // 
            this.btnRecadastrar.Image = global::SistemaGestaoLinha.Properties.Resources.icons8_salvar_e_fechar_64;
            this.btnRecadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecadastrar.Location = new System.Drawing.Point(399, 216);
            this.btnRecadastrar.Name = "btnRecadastrar";
            this.btnRecadastrar.Size = new System.Drawing.Size(150, 120);
            this.btnRecadastrar.TabIndex = 21;
            this.btnRecadastrar.Text = "RECADASTRAR";
            this.btnRecadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecadastrar.UseVisualStyleBackColor = true;
            this.btnRecadastrar.Click += new System.EventHandler(this.btnRecadastrar_Click_1);
            // 
            // frmRecadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnRecadastrar);
            this.Controls.Add(this.txtConfirmarSenhaRecadastro);
            this.Controls.Add(this.txtSenhaRecadastro);
            this.Controls.Add(this.txtCrachaRecadastro);
            this.Controls.Add(this.txtNomeRecadastro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecadastrarUsuario";
            this.Text = "Recadastrar Usuário";
            this.Load += new System.EventHandler(this.frmRecadastrarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeRecadastro;
        private System.Windows.Forms.TextBox txtCrachaRecadastro;
        private System.Windows.Forms.TextBox txtSenhaRecadastro;
        private System.Windows.Forms.TextBox txtConfirmarSenhaRecadastro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnRecadastrar;
    }
}