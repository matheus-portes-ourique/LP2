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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercício1>().Count() > 0)
            {
                MessageBox.Show("form já existe");
                //da erro se forms nao tem nada
                //ou
                Application.OpenForms["frmexercicio2"].Activate();
            }
            else
            {
                frmExercício1 obj2 = new frmExercício1();
                obj2.MdiParent = this;
                obj2.WindowState = FormWindowState.Maximized;
                obj2.Show();
            }

        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercício2>().Count() > 0)
            {
                MessageBox.Show("form já existe");
                //da erro se forms nao tem nada
                //ou
                Application.OpenForms["frmexercicio2"].Activate();
            }
            else
            {
                frmExercício2 obj3 = new frmExercício2();
                obj3.MdiParent = this;
                obj3.WindowState = FormWindowState.Maximized;
                obj3.Show();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercício3>().Count() > 0)
            {
                MessageBox.Show("form já existe");
                //da erro se forms nao tem nada
                //ou
                Application.OpenForms["frmexercicio3"].Activate();
            }
            else
            {
                frmExercício3 obj3 = new frmExercício3();
                obj3.MdiParent = this;
                obj3.WindowState = FormWindowState.Maximized;
                obj3.Show();
            }
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmExercicio4>().Count() > 0)
            {
                MessageBox.Show("form já existe");
                //da erro se forms nao tem nada
                //ou
                Application.OpenForms["frmexercicio4"].Activate();
            }
            else
            {
                frmExercicio4 obj4 = new frmExercicio4();
                obj4.MdiParent = this;
                obj4.WindowState = FormWindowState.Maximized;
                obj4.Show();
            }
        }
    }
}
