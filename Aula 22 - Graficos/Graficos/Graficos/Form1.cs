using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graficos
{
    public partial class Form1 : Form
    {
        //https://blogs.msdn.microsoft.com/alexgor/2009/02/20/data-binding-microsoft-chart-control/
        AtividadeLinqEntities bd = new AtividadeLinqEntities();

        public Form1()
        {
            InitializeComponent();
            desenhaGrafico();
        }

        private void desenhaGrafico()
        {
            chart1.DataSource = bd.Aluno.ToList();
            chart1.Series["Series1"].XValueMember = "nome";
            chart1.Series["Series1"].YValueMembers = "nota";

            chart1.DataBind();
        }
    }
}
