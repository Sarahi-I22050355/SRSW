using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SRSW
{
    public partial class Form2 : Form
    {
        string archivo = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBloc.Clear();
            textBloc.Focus();
            
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "archivo de texto|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                archivo = ofd.FileName;
                StreamReader lector = new StreamReader(archivo);
                textBloc.Text = lector.ReadToEnd();
                lector.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (archivo == "")
            {
                btnGuardarComo_Click(sender, e);
            }
            else
            {
                StreamWriter escritor = new StreamWriter(archivo);
                escritor.Write(textBloc.Text);
                escritor.Close();
            }
        }

        private void btnGuardarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "archivo de texto|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                archivo = sfd.FileName;
                StreamWriter escritor = new StreamWriter(sfd.FileName);
                escritor.Write(textBloc.Text);
                escritor.Close();
            }
        }
    }
}
