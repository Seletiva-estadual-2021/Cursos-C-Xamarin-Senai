using FormsEntity.Properties;
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
    public partial class ComponentesGrid : Form
    {
        private testeEntities en = new testeEntities();
        private List<pessoa> pessoas = new List<pessoa>();

        public ComponentesGrid()
        {
            InitializeComponent();
            montarGrid();
        }

        private void montarGrid()
        {
            tblLayout.ColumnCount = 2;
            tblLayout.RowCount = 0;
            int t = 0;

            pessoas = en.pessoa.ToList();
            pessoas.ForEach(p => {

                TableLayoutPanel tblLayoutLabels = new TableLayoutPanel();
                tblLayoutLabels.ColumnCount = 1;
                tblLayoutLabels.RowCount = 3;
                tblLayoutLabels.Controls.Add(new Label() { Text = p.nome }, 0, tblLayout.RowCount);
                tblLayoutLabels.Controls.Add(new Label() { Text = p.idade.ToString() }, 1, tblLayout.RowCount);
                tblLayoutLabels.Dock = DockStyle.Fill;

                Button btnAcao = new Button();
                btnAcao.Text = "Clique aqui!";
                btnAcao.Click += (s, args) =>
                {
                    clicou(p.id);        
                };
                tblLayoutLabels.Controls.Add(btnAcao, 2, tblLayout.RowCount);


                tblLayout.Controls.Add(tblLayoutLabels, 0, tblLayout.RowCount);

                //outra forma de pegar a imagem da pessoa quando a descricao vem do banco
                var fotoTemp = p.foto != null ? p.foto.Trim() : "sem_foto";
                PictureBox img = new PictureBox();
                img.Image = (Image)Resources.ResourceManager.GetObject(fotoTemp);
                tblLayout.Controls.Add(img, 1, tblLayout.RowCount);

                tblLayout.RowCount++;
            });
        }
        
        private void clicou(int i)
        {
            MessageBox.Show("Clicou na pessoa " + i);
        }

        private void ComponentesGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
