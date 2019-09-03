using CadastroJson.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CadastroJson.util;

namespace CadastroJson
{
    public partial class Form1 : Form
    {
        ManipulaArquivos m = new ManipulaArquivos();
        List<Pessoa> pessoas = new List<Pessoa>();

        public Form1()
        {
            InitializeComponent();
            btnSalvar.Click += salvar;
            carregaGrid();
        }

        private void salvar(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa
            {
                nome = txtNome.Text,
                email = txtEmail.Text
            };
            m.escrever(p);
            MessageBox.Show("Salvo com sucesso!");
            carregaGrid();
        }

        public void carregaGrid()
        {
            tblPessoas.Rows.Clear();
            pessoas = m.ler();
            pessoas.ForEach(p => {
                tblPessoas.Rows.Add(p.id, p.nome, p.email);
            });
        }
    }
}
