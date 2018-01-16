using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikiDesktopSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadPage();
        }

        private  void loadPage()
        {
            webBrowser1.Navigate("http://www.wikipedia.org/");
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            String HomeURL = "http://www.wikipedia.org";
            webBrowser1.Navigate(HomeURL);
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            String SearchTerm = toolStripTextBox1.Text;
            String SearchWiki = "http://www.wikipedia.org/wiki/" + SearchTerm +"";
            webBrowser1.Navigate(SearchWiki);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }
    }
}
