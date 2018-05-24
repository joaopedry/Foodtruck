using Foodtruck.Negocio;
using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodtruck.Grafico
{
    public partial class ManterLanche : Form
    {
        public Lanche LancheSelecionado { get; set; }

        public ManterLanche()
        {
            InitializeComponent();
        }

        private void btSalvarLanche_Click_1(object sender, EventArgs e)
        {
            Lanche lanche = new Lanche();
            /*if (Int64.TryParse(tbIdLanche.Text, out long value))
            {
                lanche.Id = value;
            }
            else
            {
                lanche.Id = -1;
                //passa indentificador com valor negativo se não conseguir converter
            }*/
            //lanche.Id = int.Parse(tbIdLanche.Text);
            lanche.Nome = tbNomeLanche.Text;
            lanche.Valor = decimal.Parse(tbValorLanche.Text);

            Validacao validacao;
            if (LancheSelecionado == null)
            {
                validacao = Program.Gerenciador.AdicionarLanche(lanche);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarLanche(lanche);
            }



            if (!validacao.Valido)
            {
                String mensagemValidacao = "";
                foreach (var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    mensagemValidacao += msg;
                    mensagemValidacao += Environment.NewLine;
                }
                MessageBox.Show(mensagemValidacao);
            }
            else
            {
                MessageBox.Show("Lanche salvo com sucesso");
            }

            this.Close();
        }

        private void btCancelarLanche_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManterLanche_Shown(object sender, EventArgs e)
        {
            if (LancheSelecionado != null)
            {
                //this.tbIdLanche.Text = LancheSelecionado.Id.ToString();
                this.tbNomeLanche.Text = LancheSelecionado.Nome;
                this.tbValorLanche.Text = LancheSelecionado.Valor.ToString();
            }
        }

        private void ManterLanche_Load(object sender, EventArgs e)
        {

        }

        private void tbIdLanche_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
