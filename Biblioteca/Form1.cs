using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biblioteca
{

    public partial class Form1 : Form

    {


        public Form1()
        {
            InitializeComponent();
        }
        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "biblioteca";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            conexaoBD.ConvertZeroDateTime = true;
            return conexaoBD;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 cadastrousuario = new Form2();
                cadastrousuario.ShowDialog();


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();

        }
        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaconexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaconexaoBD.Open();

               
                MySqlCommand comandoMySql = realizaconexaoBD.CreateCommand();
              
                comandoMySql.CommandText = "SELECT * FROM livro; ";
                
                MySqlDataReader reader = comandoMySql.ExecuteReader();
                
                dglivro.Rows.Clear();
                
                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dglivro.Rows[0].Clone();// Faz um cast e clona
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1); // NOME
                    row.Cells[2].Value = reader.GetString(2); // AUTOR
                    row.Cells[3].Value = reader.GetString(3); // 
                    row.Cells[4].Value = reader.GetString(4); // ANO
                    row.Cells[5].Value = reader.GetString(5);
                    row.Cells[6].Value = reader.GetString(6);
                    row.Cells[7].Value = reader.GetString(7);
                    row.Cells[8].Value = reader.GetString(8);
                    row.Cells[9].Value = reader.GetString(9);
                    row.Cells[10].Value = reader.GetString(10);

                    dglivro.Rows.Add(row); // ADICIONA A LINHA NA TABELA
                }
               
               realizaconexaoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection !");
                Console.WriteLine(ex.Message);

            }



        }

        private void btsalvar_Click(object sender, EventArgs e)
        {
            
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                
                //converte string para o formato que o banco aceita
                DateTime publicao = DateTime.Parse(dtPublicacao.Text);
                string s2 = publicao.ToString("yyyy-MM-dd HH:mm:ss");
                DateTime dtnew = Convert.ToDateTime(s2);


                realizaConexacoBD.Open();
                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                String mensagem = "";
                if (nuId.Value == 0)
                {
                    mensagem = "Inserido";
                    comandoMySql.CommandText = "INSERT INTO `livro`(`id`, `nome`, `autor`, `editora`, `edicao`, `volume`, `numero_paginas`, `genero`, `local`, `data_publicacao`, `ativo`) ";
                    comandoMySql.CommandText += "VALUES(null,'" + txNome.Text + "', '" + txAutor.Text + "', '" + txEditora.Text + "', '" + txEdicao.Text + "', '" + txVolume.Text + "', " + nuPaginas.Value + ", '" + cbGenero.Text + "', '" + txLocal.Text + "', '" + s2 + "', 1)";
                }
                else
                {
                    mensagem = "Alterado";
                    comandoMySql.CommandText = "UPDATE `livro` SET `nome`= '"+txNome.Text+"',`autor`= '"+txAutor.Text+"',`editora`= '"+txEdicao.Text+"',`edicao`= '"+txEdicao.Text+"',`volume`= '"+txVolume.Text+"',`numero_paginas`= "+nuPaginas.Value+",`genero`= '"+cbGenero.Text+"',`local`= '"+txLocal.Text+"',`data_publicacao`= '"+s2+"' WHERE id = "+nuId.Value+"";
                }
             
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show(mensagem+" com sucesso");
                atualizarGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            
        }

        private void btnovo_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        private void limparCampos()
        {

            txNome.Clear();
            txAutor.Clear();
            txEditora.Clear();
            txEdicao.Clear();
            txVolume.Clear();
            cbGenero.ResetText();
            txLocal.Clear();
            nuPaginas.ResetText();
            dtPublicacao.ResetText();
            nuId.ResetText();
            nuId.Value = 0;




        }

        private void btalterar_Click(object sender, EventArgs e)
        {
            nuId.Text = dglivro.CurrentRow.Cells[0].Value.ToString();
            txNome.Text = dglivro.CurrentRow.Cells[1].Value.ToString();
            txAutor.Text = dglivro.CurrentRow.Cells[2].Value.ToString();
            txEditora.Text = dglivro.CurrentRow.Cells[3].Value.ToString();
            txEdicao.Text = dglivro.CurrentRow.Cells[4].Value.ToString();
            txVolume.Text = dglivro.CurrentRow.Cells[5].Value.ToString();
            nuPaginas.Text = dglivro.CurrentRow.Cells[6].Value.ToString();
            cbGenero.Text = dglivro.CurrentRow.Cells[7].Value.ToString();
            txLocal.Text = dglivro.CurrentRow.Cells[8].Value.ToString();
            dtPublicacao.Text = dglivro.CurrentRow.Cells[9].Value.ToString();
            
           
        }

        private void btdeletar_Click(object sender, EventArgs e)
        {
          
            DialogResult dialogResult = MessageBox.Show("DESEJA REALMENTE DELETAR?", "AVISO", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {


               
                MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
                MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
                realizaConexacoBD.Open();
                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();


                string id = dglivro.CurrentRow.Cells[0].Value.ToString();
                comandoMySql.CommandText = "DELETE FROM `livro` WHERE id="+id+"";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Deletado Com Sucesso");
                atualizarGrid();
            }
           
        }
    }
}
