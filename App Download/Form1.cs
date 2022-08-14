using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace App_Download
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void download(string link, string name)
        {
            using (WebClient Client = new WebClient())
            {
                Client.DownloadFile(link, name);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try 
            {
                download(txtLink.Text, txtFilename.Text);
                MessageBox.Show("File Ok", "Downloaded");
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Erro", "Erro\n" + ex.ToString()); 
            }
            
        }
    }
}
