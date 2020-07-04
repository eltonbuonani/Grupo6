using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaGestaoLinha.Conexao
{
    class LoginConexao
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin(String cracha, String senha)
        {
            // comandos sql para verificar se tem no banco
            cmd.CommandText = "select * from tbl_Usuario where user_Cracha = @cracha and user_Senha = @senha";
            cmd.Parameters.AddWithValue("@cracha", cracha);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com banco de dados!";
            }
            return tem;
        }

        //bia

        public String verificaSetor(String cracha, String senha)
        {
            cmd.CommandText = "select user_Setor from tbl_usuario where user_Cracha = @cracha and user_Senha = @senha";
            cmd.Parameters.AddWithValue("@cracha", cracha);
            cmd.Parameters.AddWithValue("@senha", senha);
            string setor = "";
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    setor = dr["user_Setor"].ToString();
                }

            }
            catch (SqlException)
            {
                setor = "Erro com banco de dados!";
            }
            return setor;
        }

        public String cadastrar(String nome, String sobrenome, String setor, String cracha, String senha, String confSenha)
        {
            tem = false;
            // comandos para inserir
            if (senha.Equals(confSenha))
            {

                //Verificar se existe usuário com o mesmo cracha

                String sql = "Select * From tbl_Usuario Where user_Cracha = '" + cracha.ToString() + "'";

                cmd = new SqlCommand(sql);

                cmd.Connection = con.conectar();
                cmd.CommandText = sql;
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    this.mensagem = "Crachá já existente";
                    return mensagem;
                }

                dr.Close();

                cmd.CommandText = "insert into tbl_Usuario values (@nome, @sobrenome, @setor, @cracha, @senha);";
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@sobrenome", sobrenome);
                cmd.Parameters.AddWithValue("@setor", setor);
                cmd.Parameters.AddWithValue("@cracha", cracha);
                cmd.Parameters.AddWithValue("@senha", senha);

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
            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }
            return mensagem;
        }

        public String recadastrar(String nome, String cracha, String senha, String confSenha)
        {
            tem = false;
            // comandos para inserir
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "update tbl_Usuario set user_nome = @nome, user_cracha = @cracha, user_senha = @senha where user_cracha = @cracha";
                cmd.Parameters.AddWithValue("@nome", nome);                
                cmd.Parameters.AddWithValue("@cracha", cracha);
                cmd.Parameters.AddWithValue("@senha", senha);

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
            }
            else
            {
                this.mensagem = "Senhas não correspondem!";
            }
            return mensagem;
        }
    }
}

