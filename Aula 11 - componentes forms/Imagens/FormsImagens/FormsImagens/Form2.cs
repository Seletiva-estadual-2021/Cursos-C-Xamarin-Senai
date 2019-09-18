using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsImagens
{
    public partial class Form2 : Form
    {
        Form origem;
        List<Pessoa> pessoas;

        public Form2(string msg, Form origem)
        {
            InitializeComponent();
            this.origem = origem;
            button1.Click += voltar;
            if(MessageBox.Show($"mensagem importante: {msg}", "Tela de testes", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {

            }

            carregarGrid();
        }

        private void carregarGrid()
        {
            var path = @"C:\Users\william.chenta\Downloads\WindowsFormsApp3\WindowsFormsApp3\Resources";
            pessoas = new List<Pessoa>
            {
                new Pessoa
                {
                    nome = "william",
                    email = "aaa@aaa.com",
                    foto = Image.FromFile($"{path}\\user_17.jpg")
                },
                new Pessoa
                {
                    nome = "joao",
                    email = "bbb@bbb.com",
                    foto = Image.FromFile($"{path}\\user_35.jpg")
                }
            };

            dataGridView1.DataSource = pessoas;
            comboBox1.DataSource = pessoas;
        }

        private void voltar(object sender, EventArgs e)
        {
            this.origem.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"pessoa selecionada: {pessoas.ElementAt(comboBox1.SelectedIndex)}");
        }
    }

    public class Pessoa
    {
        public string nome { get; set; }
        public string email { get; set; }
        public Image foto { get; set; }

        public override string ToString()
        {
            return nome;
        }
    }
}
