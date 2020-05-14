using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tech_CSGO_Injector__Open_Source_
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DLLPATH.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Inject.TInjectr(metroTextBox1.Text, "csgo");
            }
            catch
            {
                MessageBox.Show("Erro ao Injetar a DLL, tente novamente", "Tech CSGO Injector");
            }
        }

        private void DLLPATH_FileOk(object sender, CancelEventArgs e)
        {
            metroTextBox1.Text = DLLPATH.FileName;
        }
    }
}
