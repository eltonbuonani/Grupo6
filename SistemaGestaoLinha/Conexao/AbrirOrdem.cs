using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaGestaoLinha.Conexao
{
    class AbrirOrdem
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        //SqlDataReader dr;

        public String abrirOrdem(String descricao, String tipo, String setor, String criticidade, String data, String descrServico, String pecasNecessarias, String equipamento)
        {
            tem = false;
            cmd.CommandText = "insert into tbl_Ordem values ( @data, @criticidade, @tipo, @pecas, @descricao, @setor, @descrServico, @equipamento);";
            
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@criticidade", criticidade);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@pecas", pecasNecessarias);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@setor", setor);
            cmd.Parameters.AddWithValue("@descrServico", descrServico);
            cmd.Parameters.AddWithValue("@equipamento", equipamento);            

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

            String SQL = "select top 1 cast(id_ordem as varchar(20)) from tbl_Ordem order by id_ordem desc ";
            cmd = new SqlCommand(SQL);
            
            SqlDataReader dr;
            cmd.Connection = con.conectar();
            cmd.CommandText = SQL;
            dr = cmd.ExecuteReader();


            if (dr.HasRows)
            {
                  while (dr.Read())
                {
                    this.mensagem = "Ordem ";
                    this.mensagem += dr.GetString(0);
                    this.mensagem += " cadastrada com sucesso";
                }
                
            }

            return mensagem;
        }

       
        
    }
}

  
