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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sender == btnAceitar)
            {
                var validateError = string.Empty;
                if (txtNomeDaReceita.Text.Length == 0)
                    validateError = "- A receita tem que conter um nome.";
                if (txtTempo.Text.Length == 0)
                    validateError += "- A receita tem que conter um tempo de preparo.";
                if (txtCategoria.Text.Length == 0)
                    validateError += "- A receita tem que conter uma dificuldade de preparo.";
                if (txtIngredientes.Text.Length <= 5)
                    validateError += "- A receita tem que conter ingredientes.";
                if (txtModoDePreparo.Text.Length <= 5)
                    validateError += "- A receita tem que conter uma preparação.";
                if (validateError != string.Empty)
                {
                    MessageBox.Show(validateError.Replace('.', '\n'), @"A receita está incompleta", MessageBoxButtons.OK);
                    return;
                }
                ListViewItem varItem = new ListViewItem(new string[] { txtNomeDaReceita.Text,
                                                                txtCategoria.Text,
                                                                txtTempo.Text,                         
                                                                cbPorcao.Text,
                                                                cbDificuldade.Text,
                                                                txtIngredientes.Text,
                                                                txtModoDePreparo.Text
                                                               }) ;
                listaDeReceitas.Items.Add(varItem);
                listaDeReceitas.Items[listaDeReceitas.Items.Count - 1].EnsureVisible(); //for autoscroll
                txtTodasReceitas.Text = string.Format("Total de Receitas: {0}", listaDeReceitas.Items.Count);
                MessageBox.Show($"Nova receita adicionada.");
                txtNomeDaReceita.Text = "";
                txtTempo.Text = "";
                cbDificuldade.Text = "";
                cbPorcao.Text = "";
                txtCategoria.Text = "";
                txtIngredientes.Text = "";
                txtModoDePreparo.Text = "";
                return;
            }
        }

        private void txtModoDePreparo_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listaDeReceitas.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Selecione uma receita.");
            }
            else
            {
                string TEXT_Confirmacao = "Você realmente deseja excluir está receita?";
                if (MessageBox.Show(string.Format("Deseja remover a(s) {0} receitas selecionadas?", listaDeReceitas.SelectedIndices.Count), TEXT_Confirmacao, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                MessageBox.Show("A receita selecionada, foi apagada!");
                for (int i = listaDeReceitas.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem li = listaDeReceitas.SelectedItems[i];
                    listaDeReceitas.Items.Remove(li);
                    txtTodasReceitas.Text = string.Format("Total de Receitas: {0}", listaDeReceitas.Items.Count);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInformativo_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        public void criarView()
        {
            Form4 frm4 = new Form4(this);
            ListViewItem varItem = new ListViewItem(new string[] {"Olá"
        }) ;
                listaDeReceitas.Items.Add(varItem);
                listaDeReceitas.Items[listaDeReceitas.Items.Count - 1].EnsureVisible(); //for autoscroll
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (listaDeReceitas.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Selecione uma receita.");
            }
            else
            {
                Form4 frm4 = new Form4(this);
                if (listaDeReceitas.SelectedItems[0].Selected)
                {
                    frm4.txtNovoNomeDaReceita.Text = listaDeReceitas.FocusedItem.SubItems[0].Text;
                    frm4.txtNovoCategoria.Text = listaDeReceitas.FocusedItem.SubItems[6].Text;
                    frm4.txtNovoTempo.Text = listaDeReceitas.FocusedItem.SubItems[1].Text;
                    frm4.cbNovoPorcao.Text = listaDeReceitas.FocusedItem.SubItems[3].Text;
                    frm4.cbNovoDificuldade.Text = listaDeReceitas.FocusedItem.SubItems[2].Text;
                    frm4.txtNovoIngredientes.Text = listaDeReceitas.FocusedItem.SubItems[5].Text;
                    frm4.txtNovoModoDePreparo.Text = listaDeReceitas.FocusedItem.SubItems[6].Text;
                }
                frm4.ShowDialog(this);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtTodasReceitas_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbDificuldade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDificuldade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeDaReceita_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Texto |* .txt",
                InitialDirectory = @"c:\dados\txt",
                FileName = "receitas"  + ".txt",
                ValidateNames = true
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        foreach (ListViewItem item in listaDeReceitas.Items)
                        {
                            tw.WriteLineAsync("-----------------------------------------------");
                            tw.WriteLineAsync($"Informações:");
                            tw.WriteLineAsync($"Nome da Receita: {item.SubItems[0].Text}");
                            tw.WriteLineAsync($"Tempo de Preparo: {item.SubItems[1].Text}");
                            tw.WriteLineAsync($"Dificuldade de Preparo: {item.SubItems[2].Text}");
                            tw.WriteLineAsync($"Porção para: {item.SubItems[3].Text} pessoas");
                            tw.WriteLineAsync($"Categoria: {item.SubItems[4].Text}");
                            tw.WriteLineAsync($"");
                            tw.WriteLineAsync($"Ingredientes:");
                            tw.WriteLineAsync($"{item.SubItems[5].Text}");
                            tw.WriteLineAsync($"");
                            tw.WriteLineAsync($"Modo de preparo:");
                            tw.WriteLineAsync($"{item.SubItems[6].Text}");
                        }
                        MessageBox.Show("Seus dados foram exportados para o formato texto com sucesso");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listaDeReceitas.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Selecione uma receita.");
            }
            else
            {
                Form4 frm4 = new Form4(this);
                if (listaDeReceitas.SelectedItems[0].Selected)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog()
                    {
                        Filter = "Texto |* .txt",
                        InitialDirectory = @"c:\dados\txt",
                        FileName = "receita" + ".txt",
                        ValidateNames = true
                    })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                            {
                                foreach (ListViewItem item in listaDeReceitas.Items)
                                {
                                    tw.WriteLineAsync("-----------------------------------------------");
                                    tw.WriteLineAsync($"Informações:");
                                    tw.WriteLineAsync($"Nome da Receita: {listaDeReceitas.FocusedItem.SubItems[0].Text}");
                                    tw.WriteLineAsync($"Tempo de Preparo: {listaDeReceitas.FocusedItem.SubItems[1].Text}");
                                    tw.WriteLineAsync($"Dificuldade de Preparo: {listaDeReceitas.FocusedItem.SubItems[2].Text}");
                                    tw.WriteLineAsync($"Porção para: {listaDeReceitas.FocusedItem.SubItems[3].Text} pessoas");
                                    tw.WriteLineAsync($"Categoria: {listaDeReceitas.FocusedItem.SubItems[4].Text}");
                                    tw.WriteLineAsync($"");
                                    tw.WriteLineAsync($"Ingredientes:");
                                    tw.WriteLineAsync($"{listaDeReceitas.FocusedItem.SubItems[5].Text}");
                                    tw.WriteLineAsync($"");
                                    tw.WriteLineAsync($"Modo de preparo:");
                                    tw.WriteLineAsync($"{listaDeReceitas.FocusedItem.SubItems[6].Text}");
                                }
                                MessageBox.Show("Seus dados foram exportados para o formato texto com sucesso");
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listaDeReceitas.Items.Count > 0)
            {
                ListViewItem foundItem =
                listaDeReceitas.FindItemWithText(txtBusca.Text, true, 0, true);
                //verifica se o item foi encontrado
                if (foundItem != null)
                {
                    if (listaDeReceitas.Groups["Localizado"] == null)
                    listaDeReceitas.Groups.Add("Localizado", "Localizado");
                    if (listaDeReceitas.Groups["Localizado"].Items.Count > 0)
                    listaDeReceitas.Groups["Localizado"].Items[0].Group = null;
                    foundItem.Group = listaDeReceitas.Groups["Localizado"];
                }
            }
        }

        private void btnSimulador_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5(this);
            frm5.ShowDialog();
        }
    }
}
