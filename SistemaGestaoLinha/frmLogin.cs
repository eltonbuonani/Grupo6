using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestaoLinha.Acessos;
using SistemaGestaoLinha.Conexao;


namespace SistemaGestaoLinha
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtUsuario.Text, txtSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string setor = controle.VerificaSetor(txtUsuario.Text, txtSenha.Text);

                    switch (setor)
                    {
                        case "Coordenador":
                            frmAcessoCoordenador f = new frmAcessoCoordenador();
                            f.ShowDialog();
                            f.Dispose();
                            break;
                        case "Eletrica":
                            frmAcessoManutencao f1 = new frmAcessoManutencao();
                            f1.ShowDialog();
                            f1.Dispose();
                            break;
                        case "Produção":
                            frmAcessoProducao f2 = new frmAcessoProducao();
                            f2.ShowDialog();
                            f2.Dispose();
                            break;
                        case "Mecânica":
                            frmAcessoManutencao f3 = new frmAcessoManutencao();
                            f3.ShowDialog();
                            f3.Dispose();
                            break;
                        case "Analista":
                            frmAcessoAnalista f4 = new frmAcessoAnalista();
                            f4.ShowDialog();
                            f4.Dispose();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }

}

               