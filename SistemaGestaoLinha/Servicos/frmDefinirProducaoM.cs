﻿using System;
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
    public partial class frmDefinirProducaoM : Form
    {
        public frmDefinirProducaoM()
        {
            InitializeComponent();
        }

        private void btnGravarQuantidadeProducao_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.definirProd(cbxProduto.Text, txtQuantidadeProduzida.Text);
            if (controle.tem)//msg de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(controle.mensagem); //msg de erro
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
