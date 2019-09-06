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
    public partial class CheckBoxes : Form
    {
        public CheckBoxes()
        {
            InitializeComponent();
            btnConfirma.Click += informaCores;
        }

        private void informaCores(object sender, EventArgs e)
        {
            MessageBox.Show("cores favoritas:");
            foreach (var item in chkListCores.CheckedItems)
            {
                MessageBox.Show(item.ToString());
            }

            new Radios().Show();
        }
    }
}
