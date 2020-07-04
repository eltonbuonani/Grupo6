using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaGestaoLinha.Conexao;

namespace SistemaGestaoLinha.Servicos
{
    public partial class frmOrdens : Form
    {
        public frmOrdens()
        {
            InitializeComponent();
        }

        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        SistemaGestaoLinha.Conexao.Conexao con = new SistemaGestaoLinha.Conexao.Conexao();
        SqlDataReader dr;

        private void frmOrdens_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gestaoManutencaoDataSet11.tbl_Ordem'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_OrdemTableAdapter2.Fill(this.gestaoManutencaoDataSet11.tbl_Ordem);

            String SQL = "select o.ID_Ordem AS 'NÚMERO DA ORDEM', o.ord_Descricao AS 'DESCRIÇÃO DA ORDEM', o.ord_Tipo AS 'TIPO', c.crit_Tipo as CRITICIDADE, o.ord_Data AS 'DATA',";
            SQL += "  o.ord_Setor AS 'SETOR', u.user_Nome as USUÁRIO, o.ord_Pecas AS 'PEÇAS NECESSÁRIAS', o.ord_Descricao_Servico AS 'DESCRIÇÃO SERVIÇO', o.ord_Equipamento AS 'EQUIPAMENTOS'";
            SQL += " From tbl_Ordem o Inner Join tbl_Usuario u on u.ID_Usuario = o.ID_Usuario Inner Join tbl_Criticidade c on c.ID_Criticidade = o.ID_Criticidade";
            SQL += " Where Id_Ordem > 0";

            if (cbxTipoOrdem.SelectedIndex > 0) {
                SQL += " And o.ord_Tipo = " + cbxTipoOrdem.SelectedItem.ToString();
            }


            cmd = new SqlCommand(SQL);

            try
            {
                cmd.Connection = con.conectar();
                cmd.CommandText = SQL;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    // monta o array de valores...
                    object[] values = new object[dr.FieldCount];

                    // adiciona as colunas no grid...
                    if (dgvOrdens.Rows.Count == 0)
                        for (int i = 0; i < dr.FieldCount; i++)
                            dgvOrdens.Columns.Add(dr.GetName(i), dr.GetName(i));

                    // varre as colunas para preencher os valores...
                    for (int i = 0; i < dr.FieldCount; i++)
                        values[i] = dr.GetValue(i);

                    // adiciona no grid...
                    dgvOrdens.Rows.Add(values);

                 
                }

                dr.Close();

            }
            catch (SqlException)
            {

            }

            //formatar nome das colunas           
            //dgvOrdens.Columns[0].HeaderText = "Código";
            //dgvOrdens.Columns[1].HeaderText = "Pessoa responsável";
            //dgvOrdens.Columns[2].HeaderText = "Data";
            //dgvOrdens.Columns[3].HeaderText = "Criticidade";
            //dgvOrdens.Columns[4].HeaderText = "Tipo";
            //dgvOrdens.Columns[5].HeaderText = "Peças Necessárias";
            //dgvOrdens.Columns[6].HeaderText = "Anomalia encontrada";
            ///dgvOrdens.Columns[7].HeaderText = "Setor";
            //dgvOrdens.Columns[8].HeaderText = "Serviço a ser executado";
            //dgvOrdens.Columns[9].HeaderText = "Local";

            //formatar largura das colunas
            //dgvOrdens.Columns[0].Width = 50;
            //dgvOrdens.Columns[1].Width = 70;
            //dgvOrdens.Columns[2].Width = 70;
            //dgvOrdens.Columns[3].Width = 60;
            //dgvOrdens.Columns[4].Width = 100;
            //dgvOrdens.Columns[5].Width = 100;
            //dgvOrdens.Columns[6].Width = 150;
            //dgvOrdens.Columns[7].Width = 100;
            //dgvOrdens.Columns[8].Width = 100;

        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_OrdemTableAdapter.FillBy(this.gestaoManutencaoDataSet9.tbl_Ordem);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_UsuarioTableAdapter.FillBy(this.gestaoManutencaoDataSet7.tbl_Usuario);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dgvOrdens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPesquisarPecas_Click(object sender, EventArgs e)
        {

        }

        private void cbxTipoOrdem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxCriticidade_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tipo_de_ordemToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_OrdemTableAdapter.Tipo_de_ordem(this.gestaoManutencaoDataSet9.tbl_Ordem);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void tipoOrdemToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void cbxTipoOrdemToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

           

                // TODO: esta linha de código carrega dados na tabela 'gestaoManutencaoDataSet11.tbl_Ordem'. Você pode movê-la ou removê-la conforme necessário.
                this.tbl_OrdemTableAdapter2.Fill(this.gestaoManutencaoDataSet11.tbl_Ordem);

            dgvOrdens.Rows.Clear();


            String SQL = "IF EXISTS(SELECT * FROM Tempdb..SysObjects WHERE Name LIKE'%##tpStatus%') DROP TABLE ##tpStatus ";
            SQL += " Select o.ID_Ordem,  Case when o.ID_Criticidade = 1 and DATEADD(DD, 7, o.ord_Data) > getdate() then 'No Prazo' When o.ID_Criticidade = 2 and DATEADD(DD, 15, o.ord_Data) > getdate() then 'No Prazo' When o.ID_Criticidade = 3 and DATEADD(DD, 30, o.ord_Data) > getdate() then 'No Prazo' ";
            SQL += " when o.ID_Criticidade = 1 and DATEADD(DD, 7, o.ord_Data) < getdate() then 'Vencida' When o.ID_Criticidade = 2 and DATEADD(DD, 15, o.ord_Data) < getdate() then 'Vencida' When o.ID_Criticidade = 3 and DATEADD(DD, 30, o.ord_Data) < getdate() then 'Vencida' end  as status into ##tpStatus ";
            SQL += " From tbl_Ordem o ";

            SQL += " Select o.ID_Ordem, u.user_Nome as USUÁRIO, c.crit_Tipo as CRITICIDADE, o.*, Convert(varchar(10),o.ord_Data,103) as data, ##tpstatus.status as status From tbl_Ordem o";
            SQL += " Inner Join tbl_Usuario u on u.ID_Usuario = o.ID_Usuario Inner Join tbl_Criticidade c on c.ID_Criticidade = o.ID_Criticidade Inner Join ##tpStatus on ##tpStatus.ID_Ordem = o.ID_Ordem ";
            SQL += " Where o.Id_Ordem > 0 ";

            if (cbxTipoOrdem.SelectedIndex > 0)
            {
                SQL += " And o.ord_Tipo = '" + cbxTipoOrdem.SelectedItem.ToString() + "'";
            }

            if (cbxStatus.Text == "No Prazo") 
            {
                SQL += " And  ##tpStatus.status = 'No Prazo'";
            }

            if (cbxStatus.Text == "Vencida")
            {
                SQL += " And  ##tpStatus.status = 'Vencida'";
            }

            if (cbxStatus.Text == "Finalizada")
            {
                SQL += " And o.ord_status = 1";
            }

            cmd = new SqlCommand(SQL);

            try
            {

                cmd.Connection = con.conectar();
                cmd.CommandText = SQL;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    // monta o array de valores...
                    object[] values = new object[dr.FieldCount];

                    // adiciona as colunas no grid...
                    if (dgvOrdens.Rows.Count == 0)
                        for (int i = 0; i < dr.FieldCount; i++)
                            dgvOrdens.Columns.Add(dr.GetName(i), dr.GetName(i));

                    // varre as colunas para preencher os valores...
                    for (int i = 0; i < dr.FieldCount; i++)
                        values[i] = dr.GetValue(i);

                    // adiciona no grid...
                    dgvOrdens.Rows.Add(values);
                }


            }

           
            catch (SqlException)
            {

            }

            dr.Close();
        }

    

        private void dataToolStripTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gestaoManutencaoDataSet11.tbl_Ordem'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_OrdemTableAdapter2.Fill(this.gestaoManutencaoDataSet11.tbl_Ordem);

            dgvOrdens.Rows.Clear();

            String SQL = "Select  u.user_Nome as USUÁRIO, c.crit_Tipo as CRITICIDADE, o.*, Convert(varchar(10),o.ord_Data,103) as data From tbl_Ordem o";
            SQL += "  Inner Join tbl_Usuario u on u.ID_Usuario = o.ID_Usuario";
            SQL += " Inner Join tbl_Criticidade c on c.ID_Criticidade = o.ID_Criticidade";
            SQL += " Where Id_Ordem > 0";


            if (cbxTipoOrdem.SelectedIndex > 0)
            {
                SQL += " And o.ord_Tipo = '" + cbxTipoOrdem.SelectedItem.ToString() + "'";
            }

            cmd = new SqlCommand(SQL);

            try
            {

                cmd.Connection = con.conectar();
                cmd.CommandText = SQL;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    // monta o array de valores...
                    object[] values = new object[dr.FieldCount];

                    // adiciona as colunas no grid...
                    if (dgvOrdens.Rows.Count == 0)
                        for (int i = 0; i < dr.FieldCount; i++)
                            dgvOrdens.Columns.Add(dr.GetName(i), dr.GetName(i));

                    // varre as colunas para preencher os valores...
                    for (int i = 0; i < dr.FieldCount; i++)
                        values[i] = dr.GetValue(i);

                    // adiciona no grid...
                    dgvOrdens.Rows.Add(values);
                }


            }


            catch (SqlException)
            {

            }

            dr.Close();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvOrdens_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     
    }

}

