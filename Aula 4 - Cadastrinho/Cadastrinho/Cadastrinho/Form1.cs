using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastrinho
{
    public partial class Form1 : Form
    {
        private List<pessoa> pessoas = new List<pessoa>();
        private testeEntities en = new testeEntities();
        private int pula = 0;

        public Form1()
        {
            InitializeComponent();
            pagina();
        }

        private void pagina()
        {
            /**
             * use skip e take para fazer paginação
             * https://stackoverflow.com/questions/10145815/c-sharp-entity-framework-pagination
             */

            pessoas = en.pessoa.ToList();

            pessoas.Skip(pula).Take(2).ToList().ForEach(p =>
            {
                tblPessoas.Rows.Add(p.id, p.nome, p.idade);
            });
        }

        private void proximo(object sender, EventArgs e)
        {
            tblPessoas.Rows.Clear();
            pula += pula + 2 >= pessoas.Count ? 0 : 2;
            pagina();
        }

        private void anterior(object sender, EventArgs e)
        {
            tblPessoas.Rows.Clear();
            pula -= pula <= 0 ? 0 : 2;
            pagina();
        }
    }
}
