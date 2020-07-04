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
    public partial class frmAbrirOrdem : Form
    {
        public frmAbrirOrdem()
        {
            InitializeComponent();
        }

        private void frmAbrirOrdem_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gestaoManutencaoDataSet10.tbl_Criticidade'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_CriticidadeTableAdapter3.Fill(this.gestaoManutencaoDataSet10.tbl_Criticidade);
            // TODO: esta linha de código carrega dados na tabela 'gestaoManutencaoDataSet10.tbl_Ordem'. Você pode movê-la ou removê-la conforme necessário.
            //this.tbl_OrdemTableAdapter1.Fill(this.gestaoManutencaoDataSet10.tbl_Ordem);

            txtDataEntrada.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
        }

        private void btnSalvarOrdem_Click(object sender, EventArgs e)
        {
            {
                Controle controle = new Controle();
                String mensagem = controle.abrirOrdem(txtDescricaoOrdem.Text, cbxTipoManutencao.Text, cbxSetor.Text, cbxTipoCriticidade.Text, txtDataEntrada.Text, txtDescricaoServico.Text, txtPecasNecessarias.Text, cbxEquipamento.Text);
                if (controle.tem) //msg de sucesso
                {
                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(controle.mensagem); //msg de erro
                }
            }
        }

        private void cbxCriticidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_OrdemTableAdapter.FillBy(this.gestaoManutencaoDataSet5.tbl_Ordem);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tbl_OrdemTableAdapter.FillBy(this.gestaoManutencaoDataSet5.tbl_Ordem);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
           

        }

        private void cbxTipoCriticidadeToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void txtDataEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxSetor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
