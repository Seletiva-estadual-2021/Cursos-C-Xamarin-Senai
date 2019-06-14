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
    public partial class Tabelas : Form
    {
        private testeEntities en = new testeEntities();
        private List<pessoa> pessoas = new List<pessoa>();

        public Tabelas()
        {
            InitializeComponent();
            getPessoas();
        }

        private void getPessoas()
        {
            pessoas = en.pessoa.ToList();
            tblPessoas.Columns.Add("foto", "Foto");

            //tblPessoas.DataSource = en.pessoa.ToList<pessoa>();
            tblPessoas.DataSource = pessoas;

            Image img1 = Image.FromFile(@"C:\Users\william.chenta\Downloads\3x4.jpeg");
            
            pessoas.ForEach(p => {
                tblPessoas2.Rows.Add(p.id, p.nome, p.idade, img1);
            });

            //tblPessoas2.Rows.Add("3", "William x", "99", "aqui");
            //tblPessoas.Rows[0].SetValues("3", "William x", "99", "aqui");
        }

        private void getPessoaSel(object sender, EventArgs e)
        {
            //Console.WriteLine(tblPessoas.SelectedRows[0].Cells[0].Value.ToString());
            //Console.WriteLine(tblPessoas.SelectedCells[0].Value.ToString());
            Console.WriteLine(tblPessoas.SelectedCells[0].RowIndex);
            var id = tblPessoas.SelectedCells[0].RowIndex;
            pessoa p = pessoas.ElementAt(id);
            MessageBox.Show(p.nome);
        }
    }
}
