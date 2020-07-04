using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestaoLinha.Servicos;

namespace SistemaGestaoLinha.Acessos
{
    public partial class frmAcessoProducao : Form
    {
        public frmAcessoProducao()
        {
            InitializeComponent();
        }

        private void frmAcessoProducao_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrirOrdem_Click(object sender, EventArgs e)
        {
            frmAbrirOrdem f = new frmAbrirOrdem();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnCadastrarPecas_Click(object sender, EventArgs e)
        {
            frmCadastrarPecas f = new frmCadastrarPecas();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            frmCadastrarProduto f = new frmCadastrarProduto();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnConsultarPecas_Click(object sender, EventArgs e)
        {
            frmConsultaPecas f = new frmConsultaPecas();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnDadosProducao_Click(object sender, EventArgs e)
        {
            frmDdsProducao f = new frmDdsProducao();
            f.ShowDialog();
            f.Dispose();

        }

      

        private void btnConsultarOrdens_Click(object sender, EventArgs e)
        {
            frmOrdens f = new frmOrdens();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnRecadastrarSenha_Click(object sender, EventArgs e)
        {
            frmRecadastrarUsuario f = new frmRecadastrarUsuario();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
