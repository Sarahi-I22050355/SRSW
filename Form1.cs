using System.IO;
namespace SRSW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBloc.Clear();
            textBloc.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "archivo de texto|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader lector = new StreamReader(ofd.FileName);
                textBloc.Text = lector.ReadToEnd();
                lector.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "archivo de texto|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter escritor = new StreamWriter(sfd.FileName);
                escritor.Write(textBloc.Text);
                escritor.Close();
            }
            
        }
    }
}