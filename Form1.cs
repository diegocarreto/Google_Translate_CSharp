using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traductor
{
    public partial class Form1 : Form
    {
        #region [Builder]

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Obtiene la traduccion del texto
        /// </summary>
        /// <param name="text">Texto a traducir</param>
        /// <param name="from">Idioma origen</param>
        /// <param name="to">Idioma destino</param>
        /// <returns>Texto traducido</returns>
        public static string Translate(string text, string from, string to)
        {
            var page = string.Empty;
            var url = string.Empty;
            var wc = new WebClient();

            try
            {

                wc.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0");
                wc.Headers.Add(HttpRequestHeader.AcceptCharset, "UTF-8");
                wc.Encoding = Encoding.UTF8;

                url = string.Format(@"http://translate.google.com.tr/m?hl=en&sl={0}&tl={1}&ie=UTF-8&prev=_m&q={2}", from, to, Uri.EscapeUriString(text));

                page = wc.DownloadString(url);
            }
            catch (Exception ex)
            {
                return "Error";
            }

            page = page.Remove(0, page.IndexOf("<div dir=\"ltr\" class=\"t0\">")).Replace("<div dir=\"ltr\" class=\"t0\">", "");

            var last = page.IndexOf("</div>");

            page = page.Remove(last, page.Length - last);

            return page;
        }

        /// <summary>
        /// Realiza la traduccion del texto
        /// </summary>
        private void Translation()
        {
            Cursor.Current = Cursors.WaitCursor;

            if (!string.IsNullOrEmpty(this.txtTranslator1.Text))
            {
                try
                {
                    var translation = String.Empty;

                    if (this.cmbLanguage.SelectedIndex.Equals(0))
                        translation = Translate(this.txtTranslator1.Text, "en", "es");
                    else
                        translation = Translate(this.txtTranslator1.Text, "es", "en");

                    this.txtTranslator2.Text = translation;

                    this.txtTranslator2.SelectAll();
                    this.txtTranslator2.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Cursor.Current = Cursors.Default;
        }

        #endregion

        #region [Events]

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbLanguage.SelectedIndex = 0;
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            this.Translation();
        } 

        #endregion
    }
}
