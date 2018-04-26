using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;

namespace WindowsFormsTruyxuatweb
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            HtmlWeb htmlWeb = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị tiếng Việt
            };

            //Load trang web, nạp html vào document
            HtmlAgilityPack.HtmlDocument document = htmlWeb.Load("https://demov2.azurewebsites.net");


            // <ul class="somename" id ="threads">
            //   var threadItems = document.DocumentNode.QuerySelectorAll("ul#threads > li").ToList();
            var threadItems = document.DocumentNode.QuerySelectorAll("div.cbox").ToList(); 
            foreach (var item in threadItems)
            {
                //<a class="title" href="http://"> </a>
                //  var linkNode = item.QuerySelector("a.title");
                //  var link = linkNode.Attributes["href"].Value;


                //<div class="folTypPost">
                //<ul>
                //<li> 
                //<b>   </b>
                //</li>
                //</ul>
                //var readCount = item.QuerySelector("div.folTypPost > ul > li > b").InnerText;
                // var readCount = "rong";// item.QuerySelector("font > b").InnerText;
                var readCount1 = item.QuerySelector("div.ctitle > a").InnerText.Trim(); 
                //  var readCount2 = item.QuerySelector("div.ccaption").InnerText.Trim();
                    // var readCount3 = item.QuerySelector("div.cvalue").InnerText.Trim();
                var readCount2 = item.QuerySelector("div").InnerText.Trim() +"   "; 
                listBox2.Items.Add(readCount2);
            }
        }
    }
}
