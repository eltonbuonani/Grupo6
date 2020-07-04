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
    public partial class frmDdsProducao : Form
    {
        public frmDdsProducao()
        {
            InitializeComponent();
        }

        private void frmDdsProducao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gestaoManutencaoDataSet10.tbl_Lancar_Producao'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_Lancar_ProducaoTableAdapter.Fill(this.gestaoManutencaoDataSet10.tbl_Lancar_Producao);

            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Data";
            dataGridView1.Columns[2].HeaderText = "Hora";
            dataGridView1.Columns[3].HeaderText = "Produto";
            dataGridView1.Columns[4].HeaderText = "Quantidade";
            dataGridView1.Columns[5].HeaderText = "Observação";

            //formatar largura das colunas
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 200;
            

        }
    }
}
