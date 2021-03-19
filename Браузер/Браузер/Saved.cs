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

namespace Браузер
{
    public partial class Saved : Form
    {
        public Saved()
        {
            InitializeComponent();
            listBox1.Items.AddRange(File.ReadAllLines("savedpages.txt"));
        }

        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(listBox1.SelectedIndex.ToString());
        }

        private void Saved_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(listBox1.SelectedIndex.ToString());
        }
    }
}
