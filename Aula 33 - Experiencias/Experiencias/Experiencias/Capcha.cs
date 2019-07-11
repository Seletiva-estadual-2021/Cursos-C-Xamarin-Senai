using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experiencias
{
    public partial class Capcha : Form
    {
        private List<string> _listFonts = new List<string>()
        {
            "Calibri",
            "Bauhaus 93",
            "Bernard MT Condensed",
            "Broadway",
            "Engravers MT",
            "Jokerman",
        };

        private List<Brush> _listBrushes = new List<Brush>
        {
            Brushes.Black,
            Brushes.Red,
            Brushes.Orange,
            Brushes.Green,
            Brushes.Blue
        };

        private static Random _random = new Random();
        private static string Alfabeto = "QWERTYUIOPASDFGHJKLZXCVBNM1234567890";
        private static string capcha = "";

        public Capcha()
        {
            InitializeComponent();
        }

        private void desenhar(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(picBox.Width, picBox.Height);
            capcha = "";

            for (int i = 0; i < 5; i++)
            {
                capcha += Alfabeto.Substring(_random.Next(1, Alfabeto.Length), 1);
            }

            var posX = 0;
            using (var graph = Graphics.FromImage(bitmap))
            {
                foreach(var item in capcha)
                {
                    graph.DrawString(item.ToString(),
                                        new Font(_listFonts[_random.Next(0, _listFonts.Count)],
                                        _random.Next(35, 40)),
                                        _listBrushes[_random.Next(0, _listBrushes.Count)],
                                        new Point(posX * 40, 5));
                    posX++;
                }
            }

            picBox.Image = bitmap;
        }
    }
}
