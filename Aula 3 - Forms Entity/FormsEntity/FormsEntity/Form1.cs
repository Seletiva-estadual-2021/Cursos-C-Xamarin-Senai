using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsEntity
{
    public partial class Form1 : Form
    {
        private testeEntities en = new testeEntities();
        private List<pessoa> pessoas = new List<pessoa>();
        
        public Form1()
        {
            InitializeComponent();
            getPessoas();
        }

        private void getPessoas()
        {
            pessoas = en.pessoa.ToList();
            pessoas.ForEach(p => {
                cmbPessoas.Items.Add(p.nome);
            });
        }

        private void getPessoaSel(object sender, EventArgs e)
        {
            int pesSel = Int32.Parse(cmbPessoas.GetItemText(cmbPessoas.SelectedIndex));
            pessoa pessoaSel = pessoas.ElementAt(pesSel);
            txtNome.Text = pessoaSel.nome;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Tabelas().Show();
        }

        private void abreCadastro(object sender, EventArgs e)
        {
            new Cadastrinho().Show();
        }
    }
}
