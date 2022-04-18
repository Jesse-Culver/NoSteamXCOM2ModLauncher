using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XCOM2ModLauncherNoSteam
{
    public partial class MainForm : Form
    {
        DataTable modTable = new DataTable();
        public MainForm()
        {
            InitializeComponent();
            modTable.Columns.Add("Name", typeof(string));
            xcom2_install_loc_txtbx.Text = Properties.Settings.Default["XCOM2_INSTALL_LOCATION"].ToString();
        }

        private void refresh_mods_btn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(xcom2_install_loc_txtbx.Text + "\\Binaries\\Win64\\XCom2.exe"))
                return;
            
            //modTable.Columns.Add("FilePath", typeof(string));
            xcom2_mods_clb.Items.Clear();
            string[] modlist = Directory.GetFiles(xcom2_install_loc_txtbx.Text, "*.XComMod", SearchOption.AllDirectories);
            foreach (var mod in modlist)
            {
                string mod_path = mod.ToString();
                string mod_name = Path.GetFileName(mod_path).Substring(0, Path.GetFileName(mod_path).IndexOf("."));
                modTable.Rows.Add(mod_name);
            }
            xcom2_mods_clb.DataSource = modTable;
            xcom2_mods_clb.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(xcom2_install_loc_txtbx.Text + "\\Binaries\\Win64\\XCom2.exe"))
                return;
            string fileName = "DefaultModOptions.ini";
            string location = xcom2_install_loc_txtbx.Text + "\\XComGame\\Config\\";

            // Create list to store mods we are enabling, also add file header first
            List<string> EnabledMods = new List<string>();
            EnabledMods.Add("[Engine.XComModOptions]");

            for(int i = 0; i < xcom2_mods_clb.Items.Count; i++)
            {
                if (xcom2_mods_clb.GetItemChecked(i))
                {
                    EnabledMods.Add("ActiveMods=\"" + modTable.Rows[i].Field<string>("Name") + "\"");
                }
            }

            // Delete the file and rewrite
            if (File.Exists(location + fileName))
                File.Delete(location + fileName);

            using (StreamWriter outputFile = new StreamWriter(location + fileName))
            {
                foreach (string line in EnabledMods)
                    outputFile.WriteLine(line);
            }

            //Launch XCOM 2
            Process xcom = new Process();
            xcom.StartInfo.FileName = "cmd.exe";
            xcom.StartInfo.Arguments = @"/C " + xcom2_install_loc_txtbx.Text + "\\Binaries\\Win64\\XCom2.exe -review -noRedScreens -noStartUpMovies -autoDebug";
            xcom.Start();
        }

        private void open_modfldr_btn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(xcom2_install_loc_txtbx.Text + "\\Binaries\\Win64\\XCom2.exe"))
                return;
            Process.Start(xcom2_install_loc_txtbx.Text + "\\XComGame\\Mods");
        }

        private void xcom2_install_browse_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (!File.Exists(folderBrowserDialog1.SelectedPath.ToString() + "\\Binaries\\Win64\\XCom2.exe"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not find XCom2.exe in:\n"+ folderBrowserDialog1.SelectedPath.ToString() + "\\Binaries\\Win64\\\n"+"Please make sure you have selected XCOM 2 install folder.");
                    return;
                }
                xcom2_install_loc_txtbx.Text = folderBrowserDialog1.SelectedPath.ToString();
                Properties.Settings.Default["XCOM2_INSTALL_LOCATION"] = xcom2_install_loc_txtbx.Text;
                Properties.Settings.Default.Save();
            }
        }
    }
}
