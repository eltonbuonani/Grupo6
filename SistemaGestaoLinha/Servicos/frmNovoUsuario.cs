using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestaoLinha.Conexao;

namespace SistemaGestaoLinha.Servicos
{
    public partial class frmNovoUsuario : Form
    {
        public frmNovoUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrarNovoUsuario_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txtNome.Text, txtSobrenome.Text, cbxSetor.Text, txtCracha.Text, txtSenha.Text, txtConfirmarSenha.Text);
            if (controle.tem)//msg de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(controle.mensagem); //msg de erro             
            }
        }     

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

