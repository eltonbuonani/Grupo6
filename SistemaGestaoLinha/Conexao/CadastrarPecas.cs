using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaGestaoLinha.Conexao
{
    class CadastrarPecas
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        //SqlDataReader dr;

        public String cadastrarPecas(String descricao, String tipo, String quantidade)
        {
            tem = false;
            cmd.CommandText = "insert into tbl_Pecas values (@descricao, @tipo, @quantidade);";
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);

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
                this.mensagem = "Erro com banco de dados";
            }
            return mensagem;
        }  




    }
}

 