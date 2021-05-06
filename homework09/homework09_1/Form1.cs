using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework09_1
{
    public partial class Form1 : Form
    {
        BindingSource resultBindingSource = new BindingSource();
        SimpleCrawler crawler = new SimpleCrawler();
        
        
        public Form1()
        {
            InitializeComponent();
            resultGridView.DataSource = resultBindingSource;           
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            resultBindingSource.Clear();
            resultBindingSource.ResetBindings(false);
            crawler.StartURL = urlBox.Text;
            new System.Threading.Thread(crawler.Crawl).Start();
            foreach (KeyValuePair<string, string> kvp in crawler.results)
                {
                    var info = new { Index = resultBindingSource.Count + 1, URL = kvp.Key, Status = kvp.Value };
                    resultBindingSource.Add(info);
                }
                

        }                                                                                 
    }
}
