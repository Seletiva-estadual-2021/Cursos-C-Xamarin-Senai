using Biblioteca1;
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

namespace FormsImagens
{
    public partial class Form1 : Form
    {
        List<Image> fotos = new List<Image>();

        public Form1()
        {
            InitializeComponent();
            imgFoto.Image = Image.FromFile(@"D:\drive\drive2\lixo\logo.png");
            button1.Click += carregaFoto;

            Saudacoes s = new Saudacoes();
            s.digaOi();
            dateTimePicker1.TextChanged += setaData;
            button2.Click += chamaForm2;
        }

        private void chamaForm2(object sender, EventArgs e)
        {
            new Form2("olá form", this).Show();
            Hide();
        }

        private void setaData(object sender, EventArgs e)
        {
            DateTime data = dateTimePicker1.Value;
            MessageBox.Show($"Faltam {365 - data.DayOfYear} dias para o fim do ano!");
        }

        private void carregaFoto(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Selecione uma imagem...";
            openFileDialog1.Filter = "png|*.png| jpg|*.jpg| jpeg|*.jpeg";
            openFileDialog1.Title = "Open image file";
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                desenhaImagem();
            }
        }

        private void desenhaImagem()
        {
            byte[] content = File.ReadAllBytes(openFileDialog1.FileName);
            MemoryStream ms = new MemoryStream(content);
            imgFoto.Image = Image.FromStream(ms);
            fotos.Add(imgFoto.Image);
            carregaTabela();
        }

        private void carregaTabela()
        {
            dataGridView1.Rows.Clear();
            fotos.ForEach(f => {
                dataGridView1.Rows.Add(f);
            });
        }
    }
}
