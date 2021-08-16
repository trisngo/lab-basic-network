using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab4
{
    public partial class Bai4_Lab4 : Form
    {
        public string presentUrl = "about:blank";
        public Bai4_Lab4()
        {
            InitializeComponent();
            webBrowser1.CanGoBackChanged +=
            new EventHandler(webBrowser1_CanGoBackChanged);
            webBrowser1.CanGoForwardChanged +=
                new EventHandler(webBrowser1_CanGoForwardChanged);
            webBrowser1.DocumentTitleChanged +=
                new EventHandler(webBrowser1_DocumentTitleChanged);

            webBrowser1.ScriptErrorsSuppressed = true;

            webBrowser1.Navigate("https://www.google.com/");//tự động lúc bắt đầu là ở trang google
            presentUrl = "https://www.google.com/";
        }
        //trở về
        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        //đi tới
        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnGoto_Click(object sender, EventArgs e)
        {
            //ấn nút go to là sẽ định hướng tới url đang có trong textbox Url
            NavigateWeb(txtUrl.Text);
        }


        private void btnUrl_KeyDown(object sender, KeyEventArgs e)
        {
            //ấn enter là sẽ định hướng tới url đang có trong textbox Url
            if (e.KeyCode == Keys.Enter)
            {
                NavigateWeb(txtUrl.Text);
            }
        }

        //hiện url đang ở nếu mình click trên browser chứ không phải nhập vào textbox
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtUrl.Text = webBrowser1.Url.ToString();
        }


        //Tắt nút trở về nếu đã đi đến trang chủ(trang đầu tiên)
        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            btnBack.Enabled = webBrowser1.CanGoBack;
        }

        //Tắt nút đi tới nếu không có trang nào phía trước trong lịch sử
        private void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            btnForward.Enabled = webBrowser1.CanGoForward;
        }

        // đi tới Url nếu url đó đúng
        private void NavigateWeb(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            //kiểm tra url
            if (address.Equals("about:blank")) return;

            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                webBrowser1.Navigate(new Uri(address));
                presentUrl = address;
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        // Updates the title bar with the current document title.
        private void webBrowser1_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.Text = webBrowser1.DocumentTitle;
        }

        private void btnDownSource_Click(object sender, EventArgs e)
        {
            //easy way
            //webBrowser1.ShowSaveAsDialog();


            HtmlWeb htmlWeb = new HtmlWeb();

            //Load trang web, nạp html vào document
            HtmlAgilityPack.HtmlDocument document = htmlWeb.Load(presentUrl);
            List<string> componentLinks = new List<string>();
            
            //lấy tiêu đề của trang web
            string webTitle = document.DocumentNode.SelectSingleNode("html/head/title").InnerText;
            
            //loại bỏ các kí tự đặc biệt trên tiêu đề để lưu file được cũng như tạo thư mục cho component
            char[] declineChar = { '<', '>', ':', '"', '/', '\\', '|', '?', '*' };
            foreach (char c in declineChar)
            {
                webTitle = webTitle.Replace(c, '_');
            }

            //tạo dialog save
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Trang web, toàn bộ files (*.html)|*.html";
            saveFileDialog1.FileName = webTitle;
            saveFileDialog1.DefaultExt = ".html";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //save file html
                document.Save(saveFileDialog1.FileName);
                int titleLen = webTitle.Length + 5;

                //tạo thư mục chứa component
                string dirComponent = Path.Combine(saveFileDialog1.FileName.Substring(0, saveFileDialog1.FileName.Length - titleLen), Path.GetFileName(webTitle));
                if (!Directory.Exists(dirComponent))
                {
                    Directory.CreateDirectory(dirComponent);
                }

                WebClient client = new WebClient();

                //lấy source code của web để kiểm tra xem có các tag cần để lấy file không
                string source = document.DocumentNode.OuterHtml;

                //kiểm tra tag img để tìm và lưu các hình ảnh
                bool checkHaveImg = source.Contains("img");
                if (checkHaveImg)
                {
                    foreach (HtmlNode node in document.DocumentNode.SelectNodes("//img"))
                    {
                        componentLinks.Add(node.GetAttributeValue("src", ""));
                    }

                    foreach (string link in componentLinks)
                    {
                        //split ra để lấy phần cuối của link là nơi có tên file cần tải
                        string[] comps = link.Split('/');

                        //loại bỏ từ không được phép lưu trên window khỏi tên của file
                        foreach (char c in declineChar)
                        {
                            comps[comps.Length - 1] = comps[comps.Length - 1].Replace(c, '_');
                        }
                        
                        //kiểm tra xem nguồn từ 1 link hay là sẵn trên thư mục của web
                        if (link.Contains("http"))
                        {
                            //download từ link và lưu tại thư mục cùng tên title
                            client.DownloadFile(link.ToString(), dirComponent + "\\" + comps[comps.Length - 1]);
                        }
                        else if(link.Contains("png") || link.Contains("jpg")) //từ thư mục nhưng phải là ảnh
                        {
                            client.DownloadFile(presentUrl + link.ToString(), dirComponent + "\\" + comps[comps.Length - 1]);
                        }
                    }
                }

                //cleat list link đã download
                componentLinks.Clear();

                //tương tự phần img nhưng là cho những javascript file embed
                bool checkHaveScript = source.Contains("script");
                if (checkHaveScript)
                {
                    foreach (HtmlNode node in document.DocumentNode.SelectNodes("//script"))
                    {
                        componentLinks.Add(node.GetAttributeValue("src", ""));
                    }


                    foreach (string link in componentLinks)
                    {
                        string[] comps = link.Split('/');
                        foreach (char c in declineChar)
                        {
                            comps[comps.Length - 1] = comps[comps.Length - 1].Replace(c, '_');
                        }
                        if (link.Contains("http"))
                        {
                            client.DownloadFile(link.ToString(), dirComponent + "\\" + comps[comps.Length - 1]);
                        }
                        else if (link.Contains("js"))
                        {
                            client.DownloadFile(presentUrl + link.ToString(), dirComponent + "\\" + comps[comps.Length - 1]);
                        }
                    }
                }


                //cleat list link đã download
                componentLinks.Clear();
                //tương tự img nhưng cho những tag embed link file như js, css, img, html
                bool checkHaveFile = source.Contains("link");
                if (checkHaveFile)
                {
                    foreach (HtmlNode node in document.DocumentNode.SelectNodes("//link"))
                    {
                        componentLinks.Add(node.GetAttributeValue("href", ""));
                    }


                    foreach (string link in componentLinks)
                    {
                        string[] comps = link.Split('/');
                        foreach (char c in declineChar)
                        {
                            comps[comps.Length - 1] = comps[comps.Length - 1].Replace(c, '_');
                        }
                        if (link.Contains("http") && (link.Contains(".css") || link.Contains(".js") || link.Contains(".html") || link.Contains("jpg") || link.Contains("png")))
                        {
                            client.DownloadFile(link.ToString(), dirComponent + "\\" + comps[comps.Length - 1]);
                        }
                    }
                }
            }
            MessageBox.Show("Đã download xong");
        }


        //view source sẽ cho ra cửa sổ mới
        private void btnViewSource_Click(object sender, EventArgs e)
        {
            viewSource source = new viewSource();
            source.ShowDialog();
        }
    }
}
