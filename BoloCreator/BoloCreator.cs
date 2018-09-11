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
        private List<string[]> miscellaneous = new List<string[]>();
        private List<string[]> apprehensions = new List<string[]>();
        private List<string[]> pmrs = new List<string[]>();
        private List<string[]> ktrs = new List<string[]>();
        private const string VERSION_NUMBER = "0.0.2";
        private bool cancelNav = false;
        string path = "";
        Settings settings = new Settings();

        public BoloCreator()
        {
            InitializeComponent();
        }

        private void BoloCreator_Load(object sender, EventArgs e)
        {
            this.Text += " - " + VERSION_NUMBER; //show version number
            folderBrowserDialog1.SelectedPath = AppDomain.CurrentDomain.BaseDirectory; //set inital directory to current location
        }
        /// <summary>
        /// Goes through specified directory and all subdirectories recursively, sorting images into respective groups based on settings.
        /// </summary>
        /// <param name="path"></param>
        private void DirWork(string path)
        {
            try
            {
                foreach (string file in Directory.GetFiles(path))
                {
                    if (file.ToLower().EndsWith(".jpg") || file.ToLower().EndsWith(".jpeg") || file.ToLower().EndsWith(".png"))
                    {
                        string[] arr = { path, file };
                        if (settings.SortByType)
                        {
                            if (path.Contains("\\" + settings.ApprehensionFolderName + "\\") || path.Contains("\\" + settings.ApprehensionFolderName))
                                apprehensions.Add(arr);
                            else if (path.Contains("\\" + settings.PmrFolderName + "\\") || path.Contains("\\" + settings.PmrFolderName))
                                pmrs.Add(arr);
                            else if (path.Contains("\\" + settings.KtrFolderName + "\\") || path.Contains("\\" + settings.KtrFolderName))
                                ktrs.Add(arr);
                            else
                                miscellaneous.Add(arr);
                        }
                        else
                        {
                            miscellaneous.Add(arr);
                        }
                        //Console.WriteLine("\n------" + "PATH: " + arr[0] + "\nFILE: " + arr[1]);
                    }
                }
                foreach (string dir in Directory.GetDirectories(path))
                {
                    DirWork(dir);
                }
            }
            catch (Exception e) { Console.Write(e.Message); }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Console.WriteLine("DOCUMENT COMPLETED FIRING");

            //https://stackoverflow.com/questions/9804105/overriding-the-webbrowser-click-event
            for (int i = 0; i < webBrowser1.Document.Links.Count; i++)
            {
                webBrowser1.Document.Links[i].Click += new HtmlElementEventHandler(this.LinkClick);
            }
        }

        private void WriteDoc()
        {
            //preamble; anything before the images or any head data should go here
            string beginning = "<html><head></head><body>" +
                "<h1 style=\"color:red;\">The information in this document is sensitive may not be reproduced.</h1>" +
                "<h3>More recent images appear first.</h3>" +
                "<h3>Generated by BoloCreator V" + VERSION_NUMBER + "</h3>" +
                "<h2>Root folder for this document: " + path + "/<h2>";
            string content = "";//initialize content
            if (settings.SortByType)
            {
                if (settings.SortNewestFirst)
                {
                    if (settings.IncludeApprehensions)
                    {
                        content += "<div id=\"apprehensions\"><h2>Apprehensions:</h2>";
                        for (int i = apprehensions.Count - 1; i > -1; i--)
                        {
                            content += "<a href=\"" + apprehensions[i][0] + "\"><img width=\"20%\" src=\"" + apprehensions[i][1] + "\" title=\"" + apprehensions[i][1] + "\"></a>";
                        }
                        content += "</div>";
                    }
                    if (settings.IncludeKtrs)
                    {
                        content += "<div id=\"ktrs\"><h2>KTRs:</h2>";
                        for (int i = ktrs.Count - 1; i > -1; i--)
                        {
                            content += "<a href=\"" + ktrs[i][0] + "\"><img width=\"20%\" src=\"" + ktrs[i][1] + "\" title=\"" + ktrs[i][1] + "\"></a>";
                        }
                        content += "</div>";
                    }
                    if (settings.IncludePmrs)
                    {
                        content += "<div id=\"pmrs\"><h2>PMRs:</h2>";
                        for (int i = pmrs.Count - 1; i > -1; i--)
                        {
                            content += "<a href=\"" + pmrs[i][0] + "\"><img width=\"20%\" src=\"" + pmrs[i][1] + "\" title=\"" + pmrs[i][1] + "\"></a>";
                        }
                        content += "</div>";
                    }
                    if (settings.IncludeMisc)
                    {
                        content += "<div id=\"misc\"><h2>Miscellaneous:</h2>";
                        for (int i = miscellaneous.Count - 1; i > -1; i--)
                        {
                            content += "<a href=\"" + miscellaneous[i][0] + "\"><img width=\"20%\" src=\"" + miscellaneous[i][1] + "\" title=\"" + miscellaneous[i][1] + "\"></a>";
                        }
                        content += "</div>";
                    }
                }
                else
                {
                    if (settings.IncludeApprehensions)
                    {
                        content += "<div id=\"apprehensions\"><h2>Apprehensions:</h2>";
                        for (int i = 0; i < apprehensions.Count; i++)
                        {
                            content += "<a href=\"" + apprehensions[i][0] + "\"><img width=\"20%\" src=\"" + apprehensions[i][1] + "\" title=\"" + apprehensions[i][1] + "\"></a>";
                        }
                        content += "</div>";
                    }
                    if (settings.IncludeKtrs)
                    {
                        content += "<div id=\"ktrs\"><h2>KTRs:</h2>";
                        for (int i = 0; i < ktrs.Count; i++)
                        {
                            content += "<a href=\"" + ktrs[i][0] + "\"><img width=\"20%\" src=\"" + ktrs[i][1] + "\" title=\"" + ktrs[i][1] + "\"></a>";
                        }
                        content += "</div>";
                    }
                    if (settings.IncludePmrs)
                    {
                        content += "<div id=\"pmrs\"><h2>PMRs:</h2>";
                        for (int i = 0; i < pmrs.Count; i++)
                        {
                            content += "<a href=\"" + pmrs[i][0] + "\"><img width=\"20%\" src=\"" + pmrs[i][1] + "\" title=\"" + pmrs[i][1] + "\"></a>";
                        }
                        content += "</div>";
                    }
                    if (settings.IncludeMisc)
                    {
                        content += "<div id=\"misc\"><h2>Miscellaneous:</h2>";
                        for (int i = 0; i < miscellaneous.Count; i++)
                        {
                            content += "<a href=\"" + miscellaneous[i][0] + "\"><img src=\"" + miscellaneous[i][1] + "\" title=\"" + miscellaneous[i][1] + "\"></a>";
                        }
                        content += "</div>";
                    }
                }
            } else
            {
                if (settings.SortNewestFirst)
                {
                    for (int i = miscellaneous.Count - 1; i > -1; i--)
                    {
                        content += "<a href=\"" + miscellaneous[i][0] + "\"><img width=\"20%\" src=\"" + miscellaneous[i][1] + "\" title=\"" + miscellaneous[i][1] + "\"></a>";
                    }
                } else
                {
                    for (int i = 0; i < miscellaneous.Count; i++)
                    {
                        content += "<a href=\"" + miscellaneous[i][0] + "\"><img src=\"" + miscellaneous[i][1] + "\" title=\"" + miscellaneous[i][1] + "\"></a>";
                    }
                }
            }

            string style = "<style>" +
                "body {background-color:ghostwhite;}" +
                "img {padding:1%; margin:1%; border:1px solid black; width: 23%;}" +
                "</style>";
            string end = "<footer>" + style + "</footer></body></html>";
            doc.Write(beginning + content + end);

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

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
                miscellaneous.Clear();
                if (path.Length > 0)
                {
                    CreatePage();
                }
            }

        }

        private void CreatePage()
        {
            DirWork(path); // get all the images
            //http://geekswithblogs.net/paulwhitblog/archive/2005/12/12/62961.aspx
            webBrowser1.Navigate("about:blank");//navigate to blank page
            doc = webBrowser1.Document; // set global doc to this document
            doc.Write(string.Empty); //write an empty string so everything else will work
            WriteDoc();//call this function to build the actual page
            webBrowser1.Refresh();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To save this for use on a tablet:\n" +
                "1) Right click the document and select \"Print...\"\n" +
                "2) Instead of a printer, make sure \"Print to PDF\" is selected.\n" +
                "3) Continue through the dialog and when finished move the newly created .pdf onto your tablet.\n"
                , "Help");
        }
    }
}
