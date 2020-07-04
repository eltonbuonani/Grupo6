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
    public partial class frmRecadastrarUsuario : Form
    {
        public frmRecadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btnRecadastrar_Click(object sender, EventArgs e)
        {

        }

        private void frmRecadastrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecadastrar_Click_1(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.recadastrar(txtNomeRecadastro.Text, txtCrachaRecadastro.Text, txtSenhaRecadastro.Text, txtConfirmarSenhaRecadastro.Text);
            if (controle.tem)//msg de sucesso
            {
                MessageBox.Show(mensagem, "Recadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(controle.mensagem); //msg de erro             
            }
        }
    }
}
