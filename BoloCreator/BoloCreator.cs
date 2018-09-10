﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoloCreator
{
    public partial class BoloCreator : Form
    {
        private HtmlDocument doc;
        private List<string[]> items = new List<string[]>();
        private const string VERSION_NUMBER = "0.0.1";
        private bool cancelNav = false;

        public BoloCreator()
        {
            InitializeComponent();
        }

        private void BoloCreator_Load(object sender, EventArgs e)
        {
            this.Text += " - " + VERSION_NUMBER; //show version number
            folderBrowserDialog1.SelectedPath = AppDomain.CurrentDomain.BaseDirectory; //set inital directory to current location
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog1.SelectedPath;
                items.Clear();
            }
            if (txtPath.Text.Length > 0)
            {
                DirWork(txtPath.Text);
                //http://geekswithblogs.net/paulwhitblog/archive/2005/12/12/62961.aspx
                webBrowser1.Navigate("about:blank");
                doc = webBrowser1.Document;
                doc.Write(string.Empty);
                WriteDoc();
                webBrowser1.Refresh();
            }
        }

        private void DirWork(string path)
        {
            try
            {
                foreach (string dir in Directory.GetDirectories(path))
                {
                    foreach (string file in Directory.GetFiles(dir))
                    {
                        if (file.EndsWith(".jpg") || file.EndsWith(".jpeg") || file.EndsWith(".png"))
                        {
                            string[] arr = { dir, file };
                            items.Add(arr);
                            Console.WriteLine("\n------" + "PATH: " + arr[0] + "\nFILE: " + arr[1]);
                        }
                    }
                    DirWork(dir);
                }
            }
            catch (Exception e) { Console.Write(e.Message); }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Console.WriteLine("DOCUMENT COMPLETED FIRING");


        }
        private void WriteDoc()
        {
            string beginning = "<html><head></head><body>" +
                "<h1 style=\"color:red;\">The information in this document is sensitive may not be reproduced.</h1>" +
                "<h3>More recent images appear first.</h3>" +
                "<h3>Generated by BoloCreator V" + VERSION_NUMBER + "</h3>" +
                "<h2>Root folder for this document: " + txtPath.Text + "/<h2>";
            string content = "";
            for (int i = items.Count-1; i > -1; i--)
            {
                content += "<a href=\"file:\\\\\\" + items[i][0] + "\"><img width=\"20%\" src=\"" + items[i][1] + "\" title=\"" + items[i][0] + "\"></a>";
            }
            string style = "<style>" +
                "body {background-color:ghostwhite;}" +
                "img {padding:1.3%; margin:1.3%; border:1px solid black;}" +
                "</style>";
            string end = "<footer>" + style + "</footer></body></html>";
            doc.Write(beginning + content + end);

            //https://stackoverflow.com/questions/9804105/overriding-the-webbrowser-click-event
            for (int i = 0; i < webBrowser1.Document.Links.Count; i++)
            {
                webBrowser1.Document.Links[i].Click += new HtmlElementEventHandler(this.LinkClick);
            }
        }

        private void LinkClick(object sender, System.EventArgs e)
        {
            HtmlElement el = ((HtmlElement)sender);
            string location = el.GetAttribute("href");

            cancelNav = true;
            System.Diagnostics.Process.Start(location);
        }


        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (cancelNav == true)
            {
                e.Cancel = true;
                cancelNav = false;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To save this for use on a tablet:\n" +
                "1) Right click the document and select \"Print...\"\n" +
                "2) Instead of a printer, make sure \"Print to PDF\" is selected.\n" +
                "3) Continue through the dialog and when finished move the newly created .pdf onto your tablet.\n"
                ,"Help");
        }
    }
}
