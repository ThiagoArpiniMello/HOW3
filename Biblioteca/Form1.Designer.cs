
namespace Biblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNome = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.txAutor = new System.Windows.Forms.TextBox();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.txEditora = new System.Windows.Forms.TextBox();
            this.lbEditora = new System.Windows.Forms.Label();
            this.txVolume = new System.Windows.Forms.TextBox();
            this.lbVolume = new System.Windows.Forms.Label();
            this.txEdicao = new System.Windows.Forms.TextBox();
            this.lbEdicao = new System.Windows.Forms.Label();
            this.lbPaginas = new System.Windows.Forms.Label();
            this.txLocal = new System.Windows.Forms.TextBox();
            this.lbLocal = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.btsalvar = new System.Windows.Forms.Button();
            this.nuId = new System.Windows.Forms.NumericUpDown();
            this.nuPaginas = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtPublicacao = new System.Windows.Forms.DateTimePicker();
            this.btdeletar = new System.Windows.Forms.Button();
            this.dglivro = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btalterar = new System.Windows.Forms.Button();
            this.btnovo = new System.Windows.Forms.Button();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nuId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dglivro)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(18, 24);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(95, 17);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome do livro";
            this.lbNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(16, 44);
            this.txNome.Margin = new System.Windows.Forms.Padding(4);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(452, 22);
            this.txNome.TabIndex = 1;
            // 
            // txAutor
            // 
            this.txAutor.Location = new System.Drawing.Point(499, 44);
            this.txAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txAutor.Name = "txAutor";
            this.txAutor.Size = new System.Drawing.Size(351, 22);
            this.txAutor.TabIndex = 3;
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Location = new System.Drawing.Point(502, 23);
            this.lbAutor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(92, 17);
            this.lbAutor.TabIndex = 2;
            this.lbAutor.Text = "Autor do livro";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(859, 24);
            this.lbCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(92, 17);
            this.lbCodigo.TabIndex = 4;
            this.lbCodigo.Text = "Cod. do Livro";
            // 
            // txEditora
            // 
            this.txEditora.Location = new System.Drawing.Point(18, 140);
            this.txEditora.Margin = new System.Windows.Forms.Padding(4);
            this.txEditora.Name = "txEditora";
            this.txEditora.Size = new System.Drawing.Size(307, 22);
            this.txEditora.TabIndex = 9;
            // 
            // lbEditora
            // 
            this.lbEditora.AutoSize = true;
            this.lbEditora.Location = new System.Drawing.Point(19, 119);
            this.lbEditora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEditora.Name = "lbEditora";
            this.lbEditora.Size = new System.Drawing.Size(53, 17);
            this.lbEditora.TabIndex = 8;
            this.lbEditora.Text = "Editora";
            // 
            // txVolume
            // 
            this.txVolume.Location = new System.Drawing.Point(609, 140);
            this.txVolume.Margin = new System.Windows.Forms.Padding(4);
            this.txVolume.Name = "txVolume";
            this.txVolume.Size = new System.Drawing.Size(241, 22);
            this.txVolume.TabIndex = 11;
            // 
            // lbVolume
            // 
            this.lbVolume.AutoSize = true;
            this.lbVolume.Location = new System.Drawing.Point(606, 119);
            this.lbVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVolume.Name = "lbVolume";
            this.lbVolume.Size = new System.Drawing.Size(55, 17);
            this.lbVolume.TabIndex = 10;
            this.lbVolume.Text = "Volume";
            this.lbVolume.Click += new System.EventHandler(this.label6_Click);
            // 
            // txEdicao
            // 
            this.txEdicao.Location = new System.Drawing.Point(343, 141);
            this.txEdicao.Margin = new System.Windows.Forms.Padding(4);
            this.txEdicao.Name = "txEdicao";
            this.txEdicao.Size = new System.Drawing.Size(251, 22);
            this.txEdicao.TabIndex = 13;
            // 
            // lbEdicao
            // 
            this.lbEdicao.AutoSize = true;
            this.lbEdicao.Location = new System.Drawing.Point(345, 120);
            this.lbEdicao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEdicao.Name = "lbEdicao";
            this.lbEdicao.Size = new System.Drawing.Size(51, 17);
            this.lbEdicao.TabIndex = 12;
            this.lbEdicao.Text = "Edição";
            // 
            // lbPaginas
            // 
            this.lbPaginas.AutoSize = true;
            this.lbPaginas.Location = new System.Drawing.Point(859, 120);
            this.lbPaginas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPaginas.Name = "lbPaginas";
            this.lbPaginas.Size = new System.Drawing.Size(99, 17);
            this.lbPaginas.TabIndex = 14;
            this.lbPaginas.Text = "N° de Páginas";
            this.lbPaginas.Click += new System.EventHandler(this.label8_Click);
            // 
            // txLocal
            // 
            this.txLocal.Location = new System.Drawing.Point(348, 245);
            this.txLocal.Margin = new System.Windows.Forms.Padding(4);
            this.txLocal.Name = "txLocal";
            this.txLocal.Size = new System.Drawing.Size(502, 22);
            this.txLocal.TabIndex = 19;
            // 
            // lbLocal
            // 
            this.lbLocal.AutoSize = true;
            this.lbLocal.Location = new System.Drawing.Point(350, 224);
            this.lbLocal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLocal.Name = "lbLocal";
            this.lbLocal.Size = new System.Drawing.Size(46, 17);
            this.lbLocal.TabIndex = 18;
            this.lbLocal.Text = "Local ";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(859, 224);
            this.lbData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(131, 17);
            this.lbData.TabIndex = 22;
            this.lbData.Text = "Data da Publicação";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Location = new System.Drawing.Point(19, 224);
            this.lbGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(56, 17);
            this.lbGenero.TabIndex = 24;
            this.lbGenero.Text = "Gênero";
            // 
            // btsalvar
            // 
            this.btsalvar.Location = new System.Drawing.Point(1041, 38);
            this.btsalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(145, 28);
            this.btsalvar.TabIndex = 30;
            this.btsalvar.Text = "Salvar";
            this.btsalvar.UseVisualStyleBackColor = true;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // nuId
            // 
            this.nuId.Enabled = false;
            this.nuId.Location = new System.Drawing.Point(858, 45);
            this.nuId.Margin = new System.Windows.Forms.Padding(4);
            this.nuId.Name = "nuId";
            this.nuId.Size = new System.Drawing.Size(150, 22);
            this.nuId.TabIndex = 34;
            // 
            // nuPaginas
            // 
            this.nuPaginas.Location = new System.Drawing.Point(858, 141);
            this.nuPaginas.Margin = new System.Windows.Forms.Padding(4);
            this.nuPaginas.Name = "nuPaginas";
            this.nuPaginas.Size = new System.Drawing.Size(150, 22);
            this.nuPaginas.TabIndex = 35;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1041, 242);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 28);
            this.button4.TabIndex = 36;
            this.button4.Text = "Cadastrar usúario";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Biblioteca.Properties.Resources.imagem_1;
            this.pictureBox1.Location = new System.Drawing.Point(13, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 675);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // dtPublicacao
            // 
            this.dtPublicacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPublicacao.Location = new System.Drawing.Point(857, 245);
            this.dtPublicacao.Name = "dtPublicacao";
            this.dtPublicacao.Size = new System.Drawing.Size(150, 22);
            this.dtPublicacao.TabIndex = 37;
            // 
            // btdeletar
            // 
            this.btdeletar.Location = new System.Drawing.Point(1041, 141);
            this.btdeletar.Margin = new System.Windows.Forms.Padding(4);
            this.btdeletar.Name = "btdeletar";
            this.btdeletar.Size = new System.Drawing.Size(145, 28);
            this.btdeletar.TabIndex = 38;
            this.btdeletar.Text = "Deletar";
            this.btdeletar.UseVisualStyleBackColor = true;
            this.btdeletar.Click += new System.EventHandler(this.btdeletar_Click);
            // 
            // dglivro
            // 
            this.dglivro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dglivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.colNome,
            this.colAutor,
            this.colEditora,
            this.colEdicao,
            this.colVolume,
            this.colPaginas,
            this.colGenero,
            this.colLocal,
            this.colData,
            this.colAtivo});
            this.dglivro.Location = new System.Drawing.Point(16, 290);
            this.dglivro.MultiSelect = false;
            this.dglivro.Name = "dglivro";
            this.dglivro.ReadOnly = true;
            this.dglivro.RowHeadersWidth = 51;
            this.dglivro.RowTemplate.Height = 24;
            this.dglivro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dglivro.Size = new System.Drawing.Size(1170, 322);
            this.dglivro.TabIndex = 39;
            this.dglivro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome do livro";
            this.colNome.MinimumWidth = 6;
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colAutor
            // 
            this.colAutor.HeaderText = "Autor do Livro";
            this.colAutor.MinimumWidth = 6;
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            // 
            // colEditora
            // 
            this.colEditora.HeaderText = "Editora";
            this.colEditora.MinimumWidth = 6;
            this.colEditora.Name = "colEditora";
            this.colEditora.ReadOnly = true;
            // 
            // colEdicao
            // 
            this.colEdicao.HeaderText = "Edição";
            this.colEdicao.MinimumWidth = 6;
            this.colEdicao.Name = "colEdicao";
            this.colEdicao.ReadOnly = true;
            // 
            // colVolume
            // 
            this.colVolume.HeaderText = "Volume";
            this.colVolume.MinimumWidth = 6;
            this.colVolume.Name = "colVolume";
            this.colVolume.ReadOnly = true;
            // 
            // colPaginas
            // 
            this.colPaginas.HeaderText = "Número de Páginas";
            this.colPaginas.MinimumWidth = 6;
            this.colPaginas.Name = "colPaginas";
            this.colPaginas.ReadOnly = true;
            // 
            // colGenero
            // 
            this.colGenero.HeaderText = "Gênero";
            this.colGenero.MinimumWidth = 6;
            this.colGenero.Name = "colGenero";
            this.colGenero.ReadOnly = true;
            // 
            // colLocal
            // 
            this.colLocal.HeaderText = "Local";
            this.colLocal.MinimumWidth = 6;
            this.colLocal.Name = "colLocal";
            this.colLocal.ReadOnly = true;
            // 
            // colData
            // 
            this.colData.HeaderText = "Data de Publicação";
            this.colData.MinimumWidth = 6;
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            // 
            // colAtivo
            // 
            this.colAtivo.HeaderText = "Ativo";
            this.colAtivo.MinimumWidth = 6;
            this.colAtivo.Name = "colAtivo";
            this.colAtivo.ReadOnly = true;
            // 
            // btalterar
            // 
            this.btalterar.Location = new System.Drawing.Point(1041, 193);
            this.btalterar.Margin = new System.Windows.Forms.Padding(4);
            this.btalterar.Name = "btalterar";
            this.btalterar.Size = new System.Drawing.Size(145, 28);
            this.btalterar.TabIndex = 40;
            this.btalterar.Text = "Alterar";
            this.btalterar.UseVisualStyleBackColor = true;
            this.btalterar.Click += new System.EventHandler(this.btalterar_Click);
            // 
            // btnovo
            // 
            this.btnovo.Location = new System.Drawing.Point(1041, 88);
            this.btnovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnovo.Name = "btnovo";
            this.btnovo.Size = new System.Drawing.Size(145, 28);
            this.btnovo.TabIndex = 41;
            this.btnovo.Text = "Limpar";
            this.btnovo.UseVisualStyleBackColor = true;
            this.btnovo.Click += new System.EventHandler(this.btnovo_Click);
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Fantasia",
            "Ficção",
            "Aventura",
            "Drama",
            "Terror",
            "Suspense",
            "Policial",
            "Biografia",
            "Esporte",
            "Romance",
            "Culinária",
            "Auto-Ajuda"});
            this.cbGenero.Location = new System.Drawing.Point(16, 247);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(230, 24);
            this.cbGenero.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 624);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.btnovo);
            this.Controls.Add(this.btalterar);
            this.Controls.Add(this.dglivro);
            this.Controls.Add(this.btdeletar);
            this.Controls.Add(this.dtPublicacao);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.nuPaginas);
            this.Controls.Add(this.nuId);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.lbGenero);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.txLocal);
            this.Controls.Add(this.lbLocal);
            this.Controls.Add(this.lbPaginas);
            this.Controls.Add(this.txEdicao);
            this.Controls.Add(this.lbEdicao);
            this.Controls.Add(this.txVolume);
            this.Controls.Add(this.lbVolume);
            this.Controls.Add(this.txEditora);
            this.Controls.Add(this.lbEditora);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.txAutor);
            this.Controls.Add(this.lbAutor);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Cadastro de Livros";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dglivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.TextBox txAutor;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txEditora;
        private System.Windows.Forms.Label lbEditora;
        private System.Windows.Forms.TextBox txVolume;
        private System.Windows.Forms.Label lbVolume;
        private System.Windows.Forms.TextBox txEdicao;
        private System.Windows.Forms.Label lbEdicao;
        private System.Windows.Forms.Label lbPaginas;
        private System.Windows.Forms.TextBox txLocal;
        private System.Windows.Forms.Label lbLocal;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nuId;
        private System.Windows.Forms.NumericUpDown nuPaginas;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dtPublicacao;
        private System.Windows.Forms.Button btdeletar;
        private System.Windows.Forms.DataGridView dglivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEdicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAtivo;
        private System.Windows.Forms.Button btalterar;
        private System.Windows.Forms.Button btnovo;
        private System.Windows.Forms.ComboBox cbGenero;
    }

}

