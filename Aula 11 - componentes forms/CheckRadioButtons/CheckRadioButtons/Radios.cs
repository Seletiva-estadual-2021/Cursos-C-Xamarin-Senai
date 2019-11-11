using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckRadioButtons
{
    public partial class Radios : Form
    {
        public Radios()
        {
            InitializeComponent();

            button1.Click += Testar;
        }

        private void Testar(object sender, EventArgs e)
        {
            if (rdMasculino.Checked)
            {
                MessageBox.Show("Sexo selecionado: Masculino");
            }
            else if (rdFeminino.Checked)
            {
                MessageBox.Show("Sexo selecionado: Feminino");
            } else
            {
                Console.WriteLine("Informe o sexo");
            }
        }
    }
}
