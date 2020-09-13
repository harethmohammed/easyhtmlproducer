using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom.Compiler;

namespace HTMLProducer
{
    public partial class Form1 : Form
    {
        bool isSideOption = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* +SEO String */
            string seoCode =
                "<!DOCTYPE html> \n <html> \n <head> \n <title> Sample </title> \n <meta charset='UTF-8'> \n <meta name='description' content='seo_descrpition_Here'> \n <meta name='author' content='author_of_site'> \n <meta name='keywords' content='site_keywords seperated by , '> \n   \n </head> \n \n <body> \n </body> \n </html>";

            /* No options String */
            string defCode =
               "<!DOCTYPE html> \n <html> \n <head> \n <meta charset='UTF-8'> \n \n <title> Sample </title> \n </head> \n \n <body> \n </body> \n <style> body \n { font-family:" + fontInput.Text + ";background-color:" + bgColorInput.Text + ";color:" + forceColorInput.Text + ";margin:" + marginInput.Text + ";padding:" + paddingInput.Text + "} \n </style>\n </html>";


            if (enableSEOBtn.Checked == false)
            {
                // Copy default code to clipboard
                defCode = "<!DOCTYPE html> \n <html> \n <head> \n <meta charset='UTF-8'> \n \n <title> Sample </title> \n </head> \n \n <body> \n </body> \n <style> body \n { font-family:" + fontInput.Text + ";background-color:" + bgColorInput.Text + ";color:" + forceColorInput.Text + ";margin:" + marginInput.Text + ";padding:" + paddingInput.Text + "} \n </style>\n </html>";
                fastColoredTextBox1.Text = defCode;


            }
            else if (enableSEOBtn.Checked == true)
            {


                // Copy text from advanced seo textboxs
                string author, title, desc, keyword;
                author = authorInput.Text;
                title = titleInput.Text;
                desc = descInput.Text;
                keyword = keywordsInput.Text;

                // Intiliaze them in the string
                seoCode = "<!DOCTYPE html> \n <html> \n <head> \n <title>" + title + "</title> \n <meta charset='UTF-8'> \n <meta name='description' content='" + desc + "'> \n <meta name='author' content='" + author + "'> \n <meta name='keywords' content='" + keyword + "'> \n   \n </head> \n \n <body> \n </body> \n  <style> body \n { font-family:" + fontInput.Text + ";background-color:" + bgColorInput.Text + ";color:" + forceColorInput.Text + ";margin:" + marginInput.Text + ";padding:" + paddingInput.Text + "} \n </html>";

                fastColoredTextBox1.Text = seoCode;
                
            }
            toolStripStatusLabel1.Text = "Code Generate";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (enableSEOBtn.Checked)
            {

                groupBox1.Enabled = true;
            }
            else
            {
                // No SEO Ticked
                groupBox1.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            enableSEOBtn.Checked = false;
            cI(authorInput);
            cI(titleInput);
            cI(descInput);
            cI(keywordsInput);
            cI(fontInput);
            marginInput.Text = "0";
            bgColorInput.Text = "#ffffff";
            paddingInput.Text = "0";
            forceColorInput.Text = "#000000";

            fastColoredTextBox1.Text = "<!-- Generated code here --> \n";
            fastColoredTextBox1.Text += "<!-- CODE EXCUTED: RESET EVERYTHING -->";
            toolStripStatusLabel1.Text = "All Inputs cleared";

        }


        // Clear Inputs Function
        private void cI(TextBox fast)
        {
            fast.Text = "";
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            // Open Side Option   
            if (!isSideOption)
            {
                while (this.Width <= 809)
                {
                    this.Width = this.Width + 20;

                }

                isSideOption = true;
                timer1.Stop();
                timer1.Enabled = false;
                openSideBtn.Text = "Close Side";
                // Close-Side Option
            }
            else
            {
                if (this.Width >= 667)
                {
                    while (this.Width >= 667)
                    {
                        this.Width = this.Width - 20;

                    }
                    openSideBtn.Text = "Open Side";
                    isSideOption = false;
                    timer1.Stop();
                    timer1.Enabled = false;
                }

            }

        }

        // Side-Option BTTN
        private void button1_Click_2(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        // Instant browser preview
        private void button1_Click_3(object sender, EventArgs e)
        {
            string tempPath = Path.GetTempPath();
            File.WriteAllText(tempPath + @"inst.html", fastColoredTextBox1.Text);
            System.Diagnostics.Process.Start(tempPath + "inst.html");
            toolStripStatusLabel1.Text = "Preview in Browser";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string tempPath = Path.GetTempPath();
            File.Delete(tempPath + "inst.html");
        }
    }
 }
