namespace WindowsFormsApp7
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNovoIngredientes = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNovoModoDePreparo = new System.Windows.Forms.TextBox();
            this.txtNovoCategoria = new System.Windows.Forms.TextBox();
            this.txtNovoNomeDaReceita = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNovoTempo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.cbNovoDificuldade = new System.Windows.Forms.ComboBox();
            this.cbNovoPorcao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Porção para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tempo de Preparo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nome da Receita:";
            // 
            // txtNovoIngredientes
            // 
            this.txtNovoIngredientes.Location = new System.Drawing.Point(3, 206);
            this.txtNovoIngredientes.Margin = new System.Windows.Forms.Padding(2);
            this.txtNovoIngredientes.Multiline = true;
            this.txtNovoIngredientes.Name = "txtNovoIngredientes";
            this.txtNovoIngredientes.Size = new System.Drawing.Size(227, 79);
            this.txtNovoIngredientes.TabIndex = 37;
            this.txtNovoIngredientes.TextChanged += new System.EventHandler(this.txtIngredientes_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(3, 434);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(227, 27);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // txtNovoModoDePreparo
            // 
            this.txtNovoModoDePreparo.Location = new System.Drawing.Point(3, 317);
            this.txtNovoModoDePreparo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNovoModoDePreparo.Multiline = true;
            this.txtNovoModoDePreparo.Name = "txtNovoModoDePreparo";
            this.txtNovoModoDePreparo.Size = new System.Drawing.Size(227, 79);
            this.txtNovoModoDePreparo.TabIndex = 31;
            this.txtNovoModoDePreparo.TextChanged += new System.EventHandler(this.txtModoDePreparo_TextChanged);
            // 
            // txtNovoCategoria
            // 
            this.txtNovoCategoria.Location = new System.Drawing.Point(104, 153);
            this.txtNovoCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtNovoCategoria.Name = "txtNovoCategoria";
            this.txtNovoCategoria.Size = new System.Drawing.Size(126, 20);
            this.txtNovoCategoria.TabIndex = 30;
            this.txtNovoCategoria.TextChanged += new System.EventHandler(this.txtDificuldade_TextChanged);
            // 
            // txtNovoNomeDaReceita
            // 
            this.txtNovoNomeDaReceita.Location = new System.Drawing.Point(104, 58);
            this.txtNovoNomeDaReceita.Margin = new System.Windows.Forms.Padding(2);
            this.txtNovoNomeDaReceita.Name = "txtNovoNomeDaReceita";
            this.txtNovoNomeDaReceita.Size = new System.Drawing.Size(126, 20);
            this.txtNovoNomeDaReceita.TabIndex = 29;
            this.txtNovoNomeDaReceita.TextChanged += new System.EventHandler(this.txtNomeDaReceita_TextChanged);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(3, 400);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(227, 30);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNovoTempo
            // 
            this.txtNovoTempo.Location = new System.Drawing.Point(104, 81);
            this.txtNovoTempo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNovoTempo.Name = "txtNovoTempo";
            this.txtNovoTempo.Size = new System.Drawing.Size(126, 20);
            this.txtNovoTempo.TabIndex = 26;
            this.txtNovoTempo.TextChanged += new System.EventHandler(this.txtTempo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Grau de Dificuldade:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp7.Properties.Resources.INFO1;
            this.pictureBox2.Location = new System.Drawing.Point(-17, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 69);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp7.Properties.Resources.INGRE1;
            this.pictureBox3.Location = new System.Drawing.Point(-17, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(247, 69);
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp7.Properties.Resources.PREPARO1;
            this.pictureBox4.Location = new System.Drawing.Point(-17, 262);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(261, 69);
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // cbNovoDificuldade
            // 
            this.cbNovoDificuldade.FormattingEnabled = true;
            this.cbNovoDificuldade.Items.AddRange(new object[] {
            "Fácil",
            "Médio",
            "Díficil"});
            this.cbNovoDificuldade.Location = new System.Drawing.Point(104, 105);
            this.cbNovoDificuldade.Name = "cbNovoDificuldade";
            this.cbNovoDificuldade.Size = new System.Drawing.Size(126, 21);
            this.cbNovoDificuldade.TabIndex = 44;
            this.cbNovoDificuldade.SelectedIndexChanged += new System.EventHandler(this.cbDificuldade_SelectedIndexChanged);
            // 
            // cbNovoPorcao
            // 
            this.cbNovoPorcao.FormattingEnabled = true;
            this.cbNovoPorcao.Items.AddRange(new object[] {
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
            this.cbNovoPorcao.Location = new System.Drawing.Point(104, 129);
            this.cbNovoPorcao.Name = "cbNovoPorcao";
            this.cbNovoPorcao.Size = new System.Drawing.Size(126, 21);
            this.cbNovoPorcao.TabIndex = 45;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 463);
            this.Controls.Add(this.cbNovoPorcao);
            this.Controls.Add(this.cbNovoDificuldade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNovoIngredientes);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNovoModoDePreparo);
            this.Controls.Add(this.txtNovoCategoria);
            this.Controls.Add(this.txtNovoNomeDaReceita);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtNovoTempo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Gestão de Receitas Culinária";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtNovoNomeDaReceita;
        public System.Windows.Forms.TextBox txtNovoIngredientes;
        public System.Windows.Forms.TextBox txtNovoModoDePreparo;
        public System.Windows.Forms.TextBox txtNovoCategoria;
        public System.Windows.Forms.TextBox txtNovoTempo;
        public System.Windows.Forms.ComboBox cbNovoDificuldade;
        public System.Windows.Forms.ComboBox cbNovoPorcao;
    }
}