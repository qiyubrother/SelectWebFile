using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace SelectWebFile
{
    public partial class UCImage : UserControl
    {
        public UCImage()
        {
            InitializeComponent();
        }
        public bool IsSelected = false;
        public Action<UCImage> ClickCallback = null;
        private float borderWidth = 1.0f;
        private Color borderColor = Color.DarkGray;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            lblLoading.Click += UserSelect;
            pic.Click += UserSelect;
            lbl.Click += UserSelect;
            Click += UserSelect;
            Render();
        }

        private void UserSelect(object sender, EventArgs e) { UserSelect(); }

        public void UserSelect()
        {
            IsSelected = true;
            //BackColor = Color.WhiteSmoke;
            borderWidth = 5.0f;
            borderColor = Color.DarkGreen;
            ClickCallback?.Invoke(this);
            Invalidate();
        }

        public void CancelSelect()
        {
            IsSelected = false;
            borderWidth = 1.0f;
            borderColor = Color.DarkGray;
            Invalidate();
            //BackColor = Color.White;
        }

        public void Render()
        {
            if (WebImageFile != null)
            {
                lbl.Text = WebImageFile.FileName;
                Task.Run(() => {
                    var img = Image.FromStream(WebRequest.Create(WebImageFile.URL).GetResponse().GetResponseStream());
                    Invoke(new Action(() => {
                        lblLoading.Visible = false;
                        pic.Image = img;
                    }));
                });
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Pen pen = new Pen(Color.Red, 1);
            //pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            //pen.DashPattern = new float[] { 5, 5 };
            Graphics gh = CreateGraphics();
            gh.DrawRectangle(new Pen(borderColor, borderWidth), 0, 0, Width - 1, Height - 1);
        }

        public WebImageFile WebImageFile { get; set; }
    }
}
