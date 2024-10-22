using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLoops
{
    public partial class frmExercício1 : Form
    {
        public frmExercício1()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int EspaçoBranco = 0;
            for (int i = 0; i <rchtxtFrase.TextLength; i++)
            {
                if (rchtxtFrase.Text[i] == ' ')
                { 
                    EspaçoBranco=EspaçoBranco + 1;
                }
                
            }
            MessageBox.Show("A frase tem " + EspaçoBranco + " Espaços Brancos");
        }

        private void rchtxtFrase_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int i = 0;
            int r = 0;

            while(i<rchtxtFrase.TextLength)
            {
                if (rchtxtFrase.Text[i] == 'R' || rchtxtFrase.Text[i] == 'r')
                {
                    r = r + 1;
                }
                i++;
                MessageBox.Show("A frase tem " + r + " letras R");
            }
        }
    }
}
