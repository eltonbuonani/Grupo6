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
    public partial class frmLancarProducao : Form
    {
        public frmLancarProducao()
        {
            InitializeComponent();
        }

        private void btnGravarLancaProd_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.lancarProducao(txtData.Text, txtHora.Text, cbxProduto.Text, txtQuantidade.Text, txtObservacao.Text);
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

        private void frmLancarProducao_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            txtHora.Text = DateTime.Now.Date.ToString("00:00");
            // TODO: esta linha de código carrega dados na tabela 'gestaoManutencaoDataSet10.tbl_Lancar_Producao'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_Lancar_ProducaoTableAdapter.Fill(this.gestaoManutencaoDataSet10.tbl_Lancar_Producao);
            // TODO: esta linha de código carrega dados na tabela 'gestaoManutencaoDataSet10.tbl_Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_ProdutoTableAdapter.Fill(this.gestaoManutencaoDataSet10.tbl_Produto);

        }
    }
}
    