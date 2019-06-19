using FormsEntity.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsEntity
{
    public partial class Cadastrinho : Form
    {
        testeEntities en = new testeEntities();
        private List<pessoa> pessoas = new List<pessoa>();
        //private Image semFoto = Image.FromFile(@"D:\drive\construindo campeões\My Food App\sem foto.png");
        private Image semFoto = Properties.Resources.sem_foto;
        private string fotoTemp;

        public Cadastrinho()
        {
            InitializeComponent();
            carregaPessoas();
        }

        private void carregaPessoas()
        {
            pessoas = en.pessoa.ToList();
            pessoas.ForEach(p => {
                fotoTemp = p.foto != null ? p.foto.Trim() : "sem_foto";
                fotoPic.Image = (Image)Resources.ResourceManager.GetObject(fotoTemp);

                tblPessoas.Rows.Add(p.id, p.nome, p.idade, fotoPic.Image);
            });
            fotoPic.Image = FormsEntity.Properties.Resources.sem_foto;            
        }

        private void carregaPessoa(object sender, DataGridViewCellEventArgs e)
        {
            var id = tblPessoas.SelectedCells[0].RowIndex;
            var pessoaSel = pessoas.ElementAt(id);

            txtNome.Text = pessoaSel.nome;
            txtIdade.Text = pessoaSel.idade.ToString();

            //outra forma de pegar a imagem da pessoa quando a descricao vem do banco
            fotoTemp = pessoaSel.foto != null ? pessoaSel.foto.Trim() : "sem_foto";
            fotoPic.Image = (Image) Resources.ResourceManager.GetObject(fotoTemp);
        }

        private void abreArquivo(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Select a image file";
            openFileDialog1.Filter = "Image files (*.png)|*.png| Image files (*.jpg)|*.jpg | Image files (*.jpeg)|*.jpeg";
            openFileDialog1.Title = "Open image file";
            openFileDialog1.ShowDialog();
        }

        private void openProcess(object sender, EventArgs e)
        {
            Process.Start("Chrome.exe", "www.folha.uol.com.br");
        }

        private void pegouArquivo(object sender, CancelEventArgs e)
        {
            MessageBox.Show("pegou arquivo: " + openFileDialog1.FileName);

            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;


            MessageBox.Show(RunningPath);

            string resourcesPath = Path.GetFullPath(Path.Combine(RunningPath, @"..\..\Resources\teste.png"));

            byte[] content = File.ReadAllBytes(openFileDialog1.FileName);
            File.WriteAllBytes(resourcesPath, content); 
        }
    }
}
