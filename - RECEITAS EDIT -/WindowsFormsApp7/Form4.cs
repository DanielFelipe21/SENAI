using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form4 : Form
    {
        Form1 instanciaDoForm1;
        public Form4(Form1 frm1)
        {
            instanciaDoForm1 = frm1;
            InitializeComponent();
            //Desabilitar botões
            txtNovoNomeDaReceita.Enabled = false;
            txtNovoTempo.Enabled = false;
            cbNovoDificuldade.Enabled = false;
            cbNovoPorcao.Enabled = false;
            txtNovoCategoria.Enabled = false;
            txtNovoIngredientes.Enabled = false;
            txtNovoModoDePreparo.Enabled = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void txtNomeDaReceita_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbDificuldade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPorcao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDificuldade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIngredientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModoDePreparo_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string message = "Voce deseja realmente editar esse item?";
            string capition = "Edição de Item";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, message, capition, buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
            MessageBoxOptions.RightAlign);
            if (result == DialogResult.Yes)
            {
                txtNovoNomeDaReceita.Enabled = true;
                txtNovoTempo.Enabled = true;
                cbNovoDificuldade.Enabled = true;
                cbNovoPorcao.Enabled = true;
                txtNovoCategoria.Enabled = true;
                txtNovoIngredientes.Enabled = true;
                txtNovoModoDePreparo.Enabled = true;
            }
        }

        private string _valor = null;

        //encapsulo a variavel valor para nao ser acessada diretamente
        public string Valor
        {
            get { return _valor = txtNovoNomeDaReceita.Text; }
        }

        public string retornarValor
        {
            get { return txtNovoNomeDaReceita.Text; }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            string message = "Voce deseja realmente salvar esta alteração?";
            string capition = "Edição de Item";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, message, capition, buttons,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
            MessageBoxOptions.RightAlign);
            if (result == DialogResult.Yes)
            {
                var validateError = string.Empty;
                if (txtNovoNomeDaReceita.Text.Length == 0)
                    validateError = "- A receita tem que conter um nome.";
                if (txtNovoTempo.Text.Length == 0)
                    validateError += "- A receita tem que conter um tempo de preparo.";
                if (txtNovoCategoria.Text.Length == 0)
                    validateError += "- A receita tem que conter uma dificuldade de preparo.";
                if (txtNovoIngredientes.Text.Length <= 5)
                    validateError += "- A receita tem que conter ingredientes.";
                if (txtNovoModoDePreparo.Text.Length <= 5)
                    validateError += "- A receita tem que conter uma preparação.";
                if (validateError != string.Empty)
                {
                    MessageBox.Show(validateError.Replace('.', '\n'), @"A receita está incompleta", MessageBoxButtons.OK);
                    return;
                }
                ListViewItem varItem = new ListViewItem(new string[] { txtNovoNomeDaReceita.Text,
                                                                txtNovoCategoria.Text,
                                                                txtNovoTempo.Text,
                                                                cbNovoPorcao.Text,
                                                                cbNovoDificuldade.Text,
                                                                txtNovoIngredientes.Text,
                                                                txtNovoModoDePreparo.Text
                                                               });
                instanciaDoForm1.listaDeReceitas.Items.Add(varItem);
                instanciaDoForm1.txtTodasReceitas.Text = string.Format("Total de Receitas: {0}", instanciaDoForm1.listaDeReceitas.Items.Count);
                ////////////////////////////////////Remover para readicioanr/////////////////////////////////////
                for (int i = instanciaDoForm1.listaDeReceitas.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem li = instanciaDoForm1.listaDeReceitas.SelectedItems[i];
                    instanciaDoForm1. listaDeReceitas.Items.Remove(li);
                }
                /////////////////////////////////////////////////////////////////////////////////////////////////
                Hide();
            }
        }
    }
}
