using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGETv6Beta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Button_choose_gtk_file_Click(object sender, EventArgs e)
        {

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "php files (*.php)|*.php";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    this.textBox_file.Text = filePath;

                }
            }


        }

        public void Button_choose_gtk_folder_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = folderBrowserDialog1.SelectedPath;
                    this.textBox_folder.Text = filePath;

                }
            }

        }

        public void Button_choose_icon_Click(object sender, EventArgs e)
        {

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "icon files (*.ico)|*.ico";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    this.textBox_icon.Text = filePath;
                }
            }

        }

        public void Button_choose_app_folder_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = folderBrowserDialog1.SelectedPath;
                    this.textBox_place.Text = filePath;

                }
            }

        }

        public void Encrypt_Click(object sender, EventArgs e)
        {

            var ins = new encrypt();

            if (this.check_admin.Checked)
            {

                if(this.check_console.Checked)
                {

                    ins.get_it(this.textBox_file.Text, this.textBox_folder.Text, this.textBox_icon.Text, this.textBox_place.Text, this.textBox_name.Text, true, true);

                } else
                {
                    ins.get_it(this.textBox_file.Text, this.textBox_folder.Text, this.textBox_icon.Text, this.textBox_place.Text, this.textBox_name.Text, true, false);


                }


            } else {

                if (this.check_console.Checked)
                {

                    ins.get_it(this.textBox_file.Text, this.textBox_folder.Text, this.textBox_icon.Text, this.textBox_place.Text, this.textBox_name.Text, false, true);

                }
                else
                {
                    ins.get_it(this.textBox_file.Text, this.textBox_folder.Text, this.textBox_icon.Text, this.textBox_place.Text, this.textBox_name.Text, false, false);


                }

            }

            ins.get_enc();

            ins.copy_it();

            ins.compi();

            ins.make_admin_rights();

            ins.set_icon();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/subabrain/RPGET/wiki");
        }
    }
}
