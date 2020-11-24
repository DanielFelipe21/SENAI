using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form5 : Form
    {
        Form1 instanciaDoForm1;
        public Form5(Form1 frm1)
        {
            instanciaDoForm1 = frm1;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var validateError = string.Empty;
            if (txtNomeIngrediente.Text.Length == 0)
                validateError = "- O ingrediente necessita de um nome.";
            if (txtQuantidade.Text.Length == 0)
                validateError = "- O ingrediente necessita de uma quantidade.";
            if (txtPreco.Text.Length == 0)
                validateError = "- O ingrediente necessita de um preço únitario.";
            if (validateError != string.Empty)
            {
                MessageBox.Show(validateError.Replace('.', '\n'), @"A receita está incompleta", MessageBoxButtons.OK);
                return;
            }
            ListViewItem varItem = new ListViewItem(new string[] { txtNomeIngrediente.Text,
                                                                txtQuantidade.Text,
                                                                txtPreco.Text
                                                               });
            listaDeIngredientes.Items.Add(varItem);
            listaDeIngredientes.Items[listaDeIngredientes.Items.Count - 1].EnsureVisible(); //for autoscroll
            txtNomeIngrediente.Text = "";
            txtQuantidade.Text = "";
            txtPreco.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void txtPrecoTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (listaDeIngredientes.Items.Count >= 1)
            {
                var total = 0m;
                for (int i = 0; i < listaDeIngredientes.Items.Count; i++)
                {
                    var quant = decimal.Parse(listaDeIngredientes.Items[i].SubItems[1].Text);
                    var preco = decimal.Parse(listaDeIngredientes.Items[i].SubItems[2].Text);

                    total += (quant * preco);
                }
                txtPrecoTotal.Text = string.Format("Preço Total: R${0}", total.ToString("N2"));
            }
            else
            {
                MessageBox.Show("Adicione algum ingrediente para fazer a soma de valores.");
            }
        }
    }
}
