using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestaoLinha.Conexao
{
    class Controle
    {

        public bool tem;
        public String mensagem = "";

        public bool acessar(String cracha, String senha)
        {
            LoginConexao loginDal = new LoginConexao();
            tem = loginDal.verificarLogin(cracha, senha);
            if (!loginDal.mensagem.Equals(""))
            {
                this.mensagem = loginDal.mensagem;
            }
            return tem;
        }

        public String cadastrar(String nome, String sobrenome, String setor, String cracha, String senha, String confSenha)
        {
            LoginConexao loginDal = new LoginConexao();
            this.mensagem = loginDal.cadastrar(nome, sobrenome, setor, cracha, senha, confSenha);
            if (loginDal.tem)//msg de sucesso
            {
                this.tem = true;
            }
            return mensagem;
        }

        public String cadastrarPecas(String descricao, String tipo, String quantidade)
        {
            CadastrarPecas cadpecas = new CadastrarPecas();
            this.mensagem = cadpecas.cadastrarPecas(descricao, tipo, quantidade);
            if (cadpecas.tem) //msg de sucesso
            {
                this.tem = true;
            }
            return mensagem;
        }

        public String definirProd(String produto, String quantidade)
        {
            DefProducao defprod = new DefProducao();
            this.mensagem = defprod.definirProd(produto, quantidade);
            if (defprod.tem) //msg de sucesso
            {
                this.tem = true;
            }
            return mensagem;
        }

        public String abrirOrdem(String descricao, String tipo, String setor, String criticidade, String data, String descrServico, String pecasNecessarias, String equipamento)
        {
            AbrirOrdem abOrdem = new AbrirOrdem();
            this.mensagem = abOrdem.abrirOrdem(descricao, tipo, setor, criticidade, data, descrServico, pecasNecessarias, equipamento);
            if (abOrdem.tem) //msg de sucesso
            {
                this.tem = true;
            }
            return mensagem;
        }

        public String lancarProducao(String data, String hora, String produto, String quantidade, String observacao)
        {
            LancarProducao lanProd = new LancarProducao();
            this.mensagem = lanProd.lancarProducao(data, hora, produto, quantidade, observacao);
            if (lanProd.tem)  //msg de sucesso
            {
                this.tem = true;
            }
            return mensagem;
        }

        public String cadastrarProduto(String produto)
        {
            CadastrarProduto cadProd = new CadastrarProduto();
            this.mensagem = cadProd.cadastrarProduto(produto);
            if (cadProd.tem)  //msg de sucesso
            {
                this.tem = true;
            }
            return mensagem;
        }

        //bia
        public String VerificaSetor(String cracha, String senha)
        {
            LoginConexao setor = new LoginConexao();
            string UsuarioSetor = setor.verificaSetor(cracha, senha).ToString();

            return UsuarioSetor;
        }

        public String recadastrar(String nome, String cracha, String senha, String confSenha)
        {
            LoginConexao loginDal = new LoginConexao();
            this.mensagem = loginDal.recadastrar(nome, cracha, senha, confSenha);
            if (loginDal.tem)//msg de sucesso
            {
                this.tem = true;
            }
            return mensagem;
        }


    }

}
