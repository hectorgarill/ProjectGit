using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LetraDNI
{
    public partial class Form1 : Form
    {
        string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(textBoxDNI.Text);

            char[] letter = getletter(dni);

            textBoxletra.Text = letter[0].ToString();
        }

        private char[] getletter(int dni)
        {
            char[] letra=letras.ToCharArray(dni%23,1);

            return letra;

        }
    }
}
