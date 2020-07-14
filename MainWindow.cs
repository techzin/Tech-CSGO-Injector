using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tech_CSGO_Injector__Open_Source_
{
    public partial class MainWindow : MetroFramework.Forms.MetroForm
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Dll_Box.Text = Properties.Settings.Default.last_DLL_Path;
            pname_Box.Text = Properties.Settings.Default.last_pname;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.techprimedev.tech");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            DllPath.ShowDialog();
            Dll_Box.Text = DllPath.FileName;
        }

        private void DllPath_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Inject.TInjectr(Dll_Box.Text, int.Parse(pname_Box.Text));
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.last_DLL_Path = Dll_Box.Text;
            Properties.Settings.Default.last_pname = pname_Box.Text;
        }
    }
}
