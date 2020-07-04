using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestaoLinha.Servicos
{
    public partial class frmConsultaPecas : Form
    {
        public frmConsultaPecas()
        {
            InitializeComponent();
        }

        private void frmConsultaPecas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gestaoManutencaoDataSet8.tbl_Pecas'. 
            //Você pode movê-la ou removê-la conforme necessário.
            this.tbl_PecasTableAdapter.Fill(this.gestaoManutencaoDataSet8.tbl_Pecas);
            //formatar nome das colunas           
            dgvPecas.Columns[0].HeaderText = "Código";
            dgvPecas.Columns[1].HeaderText = "Descrição";
            dgvPecas.Columns[2].HeaderText = "Tipo";
            dgvPecas.Columns[3].HeaderText = "Quantidade";
            //formatar largura das colunas
            dgvPecas.Columns[0].Width = 60;
            dgvPecas.Columns[1].Width = 300;
            dgvPecas.Columns[2].Width = 100; 
            dgvPecas.Columns[3].Width = 80;


        }

        private void dgvPecas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }      

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void descricaoToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisarPecas_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_PecasTableAdapter.FillBy(this.gestaoManutencaoDataSet8.tbl_Pecas, txtPesDescr.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
