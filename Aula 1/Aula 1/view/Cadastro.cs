using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_1.view
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            btn1.Click += Clicou();
        }

        private EventHandler Clicou()
        {
            MessageBox.Show("clicou!!");
            return null;
        }
    }
}
