using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Net;
using System.IO;
using System.Web;
using System.Xml;


namespace Tech_CSGO_Injector__Open_Source_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest http = WebRequest.Create("http://www.scorpioncheats.com/forum/login/login/") as HttpWebRequest;
            http.KeepAlive = true;
            http.Method = "POST";
            http.AllowAutoRedirect = true;
            http.ContentType = "application/x-www-form-urlencoded";
            string postData = "login=Techprimedev&password=Alissom@123&remember=1&cookie_check=0&_xfToken=";
            byte[] dataBytes = UTF8Encoding.UTF8.GetBytes(postData);
            http.ContentLength = dataBytes.Length;
            using (Stream postStream = http.GetRequestStream())
            {
                postStream.Write(dataBytes, 0, dataBytes.Length);
            }
            HttpWebResponse httpResponse = http.GetResponse() as HttpWebResponse;
            int y = (int)httpResponse.StatusCode;
            textBox1.Text = textBox1.Text + "\n "+ (Convert.ToString(y), "Response Code Debug");
            foreach (Cookie c in httpResponse.Cookies)
            {
                textBox1.Text = textBox1.Text + "\n " + (c.Name + " = " + c.Value, "Cookie Debug");
            }
            http = WebRequest.Create("http://www.scorpioncheats.com/") as HttpWebRequest;
            http.CookieContainer = new CookieContainer();
            http.CookieContainer.Add(httpResponse.Cookies);
            http.AllowAutoRedirect = false;
            HttpWebResponse httpResponse2 = http.GetResponse() as HttpWebResponse;
        }
    }
}
