using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaGestaoLinha.Conexao
{
    class LancarProducao
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        //SqlDataReader dr;

        public String lancarProducao(String data, String hora, String produto, String quantidade, String observacao)
        {
            tem = false;
            cmd.CommandText = "insert into tbl_Lancar_Producao values (@data, @hora, @produto, @quantidade, @observacao);";
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@hora", hora);
            cmd.Parameters.AddWithValue("@produto", produto);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@observacao", observacao);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                this.mensagem = "Cadastrado com sucesso!";
                tem = true;
            }
            catch (SqlException)
            {
                this.mensagem = "Erro";
            }
            return mensagem;
        }
    }
}

