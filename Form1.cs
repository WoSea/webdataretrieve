using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTruyxuatweb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HtmlWeb htmlWeb = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị tiếng Việt
            };

            //Load trang web, nạp html vào document
            HtmlAgilityPack.HtmlDocument document = htmlWeb.Load("https://demov1.azurewebsites.net");


            // <ul class="somename" id ="threads">
            //   var threadItems = document.DocumentNode.QuerySelectorAll("ul#threads > li").ToList();
            var threadItems = document.DocumentNode.QuerySelectorAll("table#TB1 > tbody").ToList();
            foreach (var item in threadItems)
            {
                //<a class="title" href="http://"> </a>
                //  var linkNode = item.QuerySelector("a.title");
                //  var link = linkNode.Attributes["href"].Value;
                var linkNode = item.QuerySelector("td#TD4");
                var text = linkNode.InnerText;

                //<div class="folTypPost">
                //<ul>
                //<li> 
                //<b>   </b>
                //</li>
                //</ul>
                //var readCount = item.QuerySelector("div.folTypPost > ul > li > b").InnerText; 

                listBox1.Items.Add(new {text});
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fsdfs = new Form2();
            fsdfs.Show();
        }
    }
}
