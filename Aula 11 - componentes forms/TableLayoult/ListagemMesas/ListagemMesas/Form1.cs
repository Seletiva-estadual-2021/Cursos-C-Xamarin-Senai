using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListagemMesas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            montaTela();
        }

        private void montaTela()
        {
            Random num = new Random();

            for (int i = 0; i < num.Next(1, 800); i++)
            {
                Panel p = new Panel();
                p.Width = 150;
                p.Height = 150;
                p.Name = $"p{i}";
                p.BackgroundImage = Properties.Resources.kiss;

                var disponivel = new Label();
                disponivel.Text = num.Next(1, 5) > 2 ? "Disponivel" : "Ocupado";
                disponivel.ForeColor = System.Drawing.Color.Black;

                p.Controls.Add(disponivel);

                p.BackgroundImageLayout = ImageLayout.Stretch;

                p.Click += clicou;
                flow.Controls.Add(p);
            }
        }

        private void clicou(object sender, EventArgs e)
        {
            var foto = (Panel)sender;
            MessageBox.Show(foto.Name);
        }
    }
}
