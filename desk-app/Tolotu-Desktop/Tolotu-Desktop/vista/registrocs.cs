using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tolotu_Desktop.vista
{
    public partial class registrocs : Form
    {
        public registrocs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "Pedro Perico Paredes";
            string[] words = s.Split(' ');
            string primero = words[0];
            string segundo = words[1];
            string tercero = words[2];
        }
    }
}
