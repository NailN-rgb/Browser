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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private int kolPages = 0;
        private string textBox;
        public string[] temp = { "google.com" };
        public ListBox listBox2;
        public ListBox listBox1;

        

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            /*Form1 about = new Form1();
            about.Show();*/

            WebBrowser browser = new WebBrowser();
            //go back go forward navigate
            browser.Visible = true;
            browser.ScriptErrorsSuppressed = true;
            browser.Dock = DockStyle.Fill;
            browser.DocumentCompleted += browser_DocumentCompleted;



            tabControl1.TabPages.Add("новая");
            tabControl1.SelectTab(kolPages);
            tabControl1.SelectedTab.Controls.Add(browser);
            kolPages++;
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebBrowser browser = new WebBrowser();
            //go back go forward navigate
            browser.Visible = true;
            browser.ScriptErrorsSuppressed = true;
            browser.Dock = DockStyle.Fill;
            browser.DocumentCompleted += Browser_DocumentCompleted;



            tabControl1.TabPages.Add("новая");
            tabControl1.SelectTab(kolPages);
            tabControl1.SelectedTab.Controls.Add(browser);
            kolPages++;

            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("www.google.com");
        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
        }

        void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(toolStripTextBox1.Text))
            {
                textBox = toolStripTextBox1.Text;
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(textBox);
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if(tabControl1.TabPages.Count > 1)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                kolPages--;
            }
            else
            {
                Application.Exit();
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Saved about = new Saved();
            about.Show();

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripTextBox1.Text);
            }
        }

        private void toolStripButton7_Click_1(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("www.google.com");
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
           
        }

        private void сохранитьСайтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.AppendAllText("savedpages.txt", ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
