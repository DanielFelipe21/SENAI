namespace WindowsFormsApp7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.listaDeReceitas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAceitar = new System.Windows.Forms.Button();
            this.txtNomeDaReceita = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtModoDePreparo = new System.Windows.Forms.TextBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnInformativo = new System.Windows.Forms.Button();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDificuldade = new System.Windows.Forms.ComboBox();
            this.txtTodasReceitas = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbPorcao = new System.Windows.Forms.ComboBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnSimulador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(104, 65);
            this.txtTempo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(126, 20);
            this.txtTempo.TabIndex = 1;
            this.txtTempo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listaDeReceitas
            // 
            this.listaDeReceitas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listaDeReceitas.FullRowSelect = true;
            this.listaDeReceitas.GridLines = true;
            this.listaDeReceitas.HideSelection = false;
            this.listaDeReceitas.HoverSelection = true;
            this.listaDeReceitas.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listaDeReceitas.LabelEdit = true;
            this.listaDeReceitas.Location = new System.Drawing.Point(237, 42);
            this.listaDeReceitas.Name = "listaDeReceitas";
            this.listaDeReceitas.Size = new System.Drawing.Size(552, 370);
            this.listaDeReceitas.TabIndex = 6;
            this.listaDeReceitas.UseCompatibleStateImageBehavior = false;
            this.listaDeReceitas.View = System.Windows.Forms.View.Details;
            this.listaDeReceitas.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Categoria";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 154;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tempo";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Porção";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 78;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dificuldade";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ingredientes";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Modo De Preparo";
            // 
            // btnAceitar
            // 
            this.btnAceitar.Location = new System.Drawing.Point(3, 384);
            this.btnAceitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(227, 30);
            this.btnAceitar.TabIndex = 7;
            this.btnAceitar.Text = "Aceitar";
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtNomeDaReceita
            // 
            this.txtNomeDaReceita.Location = new System.Drawing.Point(104, 42);
            this.txtNomeDaReceita.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeDaReceita.Name = "txtNomeDaReceita";
            this.txtNomeDaReceita.Size = new System.Drawing.Size(126, 20);
            this.txtNomeDaReceita.TabIndex = 9;
            this.txtNomeDaReceita.TextChanged += new System.EventHandler(this.txtNomeDaReceita_TextChanged);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(104, 137);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(126, 20);
            this.txtCategoria.TabIndex = 10;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtDificuldade_TextChanged);
            // 
            // txtModoDePreparo
            // 
            this.txtModoDePreparo.Location = new System.Drawing.Point(3, 301);
            this.txtModoDePreparo.Margin = new System.Windows.Forms.Padding(2);
            this.txtModoDePreparo.Multiline = true;
            this.txtModoDePreparo.Name = "txtModoDePreparo";
            this.txtModoDePreparo.Size = new System.Drawing.Size(227, 79);
            this.txtModoDePreparo.TabIndex = 12;
            this.txtModoDePreparo.TextChanged += new System.EventHandler(this.txtModoDePreparo_TextChanged);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(3, 418);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(227, 27);
            this.btnVisualizar.TabIndex = 13;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(3, 449);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(227, 26);
            this.btnRemover.TabIndex = 14;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnInformativo
            // 
            this.btnInformativo.Location = new System.Drawing.Point(3, 479);
            this.btnInformativo.Margin = new System.Windows.Forms.Padding(2);
            this.btnInformativo.Name = "btnInformativo";
            this.btnInformativo.Size = new System.Drawing.Size(227, 29);
            this.btnInformativo.TabIndex = 15;
            this.btnInformativo.Text = "Informativo";
            this.btnInformativo.UseVisualStyleBackColor = true;
            this.btnInformativo.Click += new System.EventHandler(this.btnInformativo_Click);
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Location = new System.Drawing.Point(3, 190);
            this.txtIngredientes.Margin = new System.Windows.Forms.Padding(2);
            this.txtIngredientes.Multiline = true;
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(227, 51);
            this.txtIngredientes.TabIndex = 18;
            this.txtIngredientes.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome da Receita:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tempo de Preparo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Grau de Dificuldade:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Porção para:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Categoria:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbDificuldade
            // 
            this.cbDificuldade.FormattingEnabled = true;
            this.cbDificuldade.Items.AddRange(new object[] {
            "Fácil",
            "Médio",
            "Díficil"});
            this.cbDificuldade.Location = new System.Drawing.Point(104, 89);
            this.cbDificuldade.Name = "cbDificuldade";
            this.cbDificuldade.Size = new System.Drawing.Size(126, 21);
            this.cbDificuldade.TabIndex = 25;
            this.cbDificuldade.SelectedIndexChanged += new System.EventHandler(this.cbDificuldade_SelectedIndexChanged);
            // 
            // txtTodasReceitas
            // 
            this.txtTodasReceitas.AutoSize = true;
            this.txtTodasReceitas.Location = new System.Drawing.Point(686, 495);
            this.txtTodasReceitas.Name = "txtTodasReceitas";
            this.txtTodasReceitas.Size = new System.Drawing.Size(103, 13);
            this.txtTodasReceitas.TabIndex = 26;
            this.txtTodasReceitas.Text = "Total de Receitas: 0";
            this.txtTodasReceitas.Click += new System.EventHandler(this.txtTodasReceitas_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp7.Properties.Resources.INFO1;
            this.pictureBox2.Location = new System.Drawing.Point(-17, -18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 69);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp7.Properties.Resources.INGRE1;
            this.pictureBox3.Location = new System.Drawing.Point(-17, 135);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(247, 69);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp7.Properties.Resources.PREPARO1;
            this.pictureBox4.Location = new System.Drawing.Point(-17, 246);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(261, 69);
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(236, 418);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 101);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // cbPorcao
            // 
            this.cbPorcao.FormattingEnabled = true;
            this.cbPorcao.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10+"});
            this.cbPorcao.Location = new System.Drawing.Point(104, 113);
            this.cbPorcao.Name = "cbPorcao";
            this.cbPorcao.Size = new System.Drawing.Size(126, 21);
            this.cbPorcao.TabIndex = 27;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(689, 449);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(100, 26);
            this.btnExportar.TabIndex = 28;
            this.btnExportar.Text = "Exportar Tudo";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 418);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 29;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(689, 14);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 22);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(559, 15);
            this.txtBusca.Margin = new System.Windows.Forms.Padding(2);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(126, 20);
            this.txtBusca.TabIndex = 31;
            // 
            // btnSimulador
            // 
            this.btnSimulador.Location = new System.Drawing.Point(4, 245);
            this.btnSimulador.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimulador.Name = "btnSimulador";
            this.btnSimulador.Size = new System.Drawing.Size(226, 26);
            this.btnSimulador.TabIndex = 32;
            this.btnSimulador.Text = "Simulador";
            this.btnSimulador.UseVisualStyleBackColor = true;
            this.btnSimulador.Click += new System.EventHandler(this.btnSimulador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.btnSimulador);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.cbPorcao);
            this.Controls.Add(this.txtTodasReceitas);
            this.Controls.Add(this.cbDificuldade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIngredientes);
            this.Controls.Add(this.btnInformativo);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.txtModoDePreparo);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtNomeDaReceita);
            this.Controls.Add(this.btnAceitar);
            this.Controls.Add(this.listaDeReceitas);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gestão de Receitas Culinária";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAceitar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnInformativo;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNomeDaReceita;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        public System.Windows.Forms.TextBox txtTempo;
        public System.Windows.Forms.TextBox txtCategoria;
        public System.Windows.Forms.TextBox txtModoDePreparo;
        public System.Windows.Forms.TextBox txtIngredientes;
        public System.Windows.Forms.ComboBox cbDificuldade;
        public System.Windows.Forms.ComboBox cbPorcao;
        public System.Windows.Forms.Label txtTodasReceitas;
        public System.Windows.Forms.ListView listaDeReceitas;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnSimulador;
    }
}

