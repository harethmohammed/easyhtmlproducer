using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTMLProducer
{
    public partial class Form1 : Form
    {
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
               "<!DOCTYPE html> \n <html> \n <head> \n <meta charset='UTF-8'> \n \n <title> Sample </title> \n </head> \n \n <body> \n </body> \n <style> body \n { font-family:" + textBox9.Text + ";background-color:" + textBox10.Text +";color:"+textBox11.Text+";margin:"+textBox13.Text+";padding:"+textBox14.Text+"} \n </style>\n </html>";

            
            if (checkBox1.Checked == false)
            {
                // Copy default code to clipboard
                defCode  = "<!DOCTYPE html> \n <html> \n <head> \n <meta charset='UTF-8'> \n \n <title> Sample </title> \n </head> \n \n <body> \n </body> \n <style> body \n { font-family:" + textBox9.Text + ";background-color:" + textBox10.Text + ";color:" + textBox11.Text + ";margin:" + textBox13.Text + ";padding:" + textBox14.Text + "} \n </style>\n </html>";
                fastColoredTextBox1.Text = defCode;
             

            } else if(checkBox1.Checked == true)
            {
                
                
               // Copy text from advanced seo textboxs
                string author, title, desc, keyword;
                author = textBox1.Text;
                title = textBox2.Text;
                desc = textBox3.Text;
                keyword = textBox4.Text;

                // Intiliaze them in the string
                seoCode = "<!DOCTYPE html> \n <html> \n <head> \n <title>" + title + "</title> \n <meta charset='UTF-8'> \n <meta name='description' content='" + desc + "'> \n <meta name='author' content='" + author + "'> \n <meta name='keywords' content='" + keyword + "'> \n   \n </head> \n \n <body> \n </body> \n  <style> body \n { font-family:" + textBox9.Text + ";background-color:" + textBox10.Text + ";color:" + textBox11.Text + ";margin:" + textBox13.Text + ";padding:" + textBox14.Text + "} \n </html>";
                
                fastColoredTextBox1.Text = seoCode;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox1.Checked)
            {

                groupBox1.Enabled = true;
            } else
            {
                // No SEO Ticked
                groupBox1.Enabled = false;
            }
        }
    }
}
