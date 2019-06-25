using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectWebFile
{
    public delegate void ClickUCImageItem(WebImageFile file);
    public partial class UCImageManager : UserControl
    {
        public event ClickUCImageItem ClickUCImage;
        public UCImageManager()
        {
            InitializeComponent();
        }

        public WebImageFile SelectFile { get; set; }

        public void Render()
        {
            if (WebFileList == null || WebFileList.Length == 0)
            {
                return;
            }
            var index = 0;
            foreach(var wif in WebFileList)
            {
                var f = new UCImage { WebImageFile = wif, Tag = index++, ClickCallback = (o)=> {
                    foreach (var item in flowLayoutPanel1.Controls.Cast<UCImage>())
                    {
                        if (item != o) item.CancelSelect();
                    }
                    SelectFile = o.WebImageFile;
                    ClickUCImage?.Invoke(o.WebImageFile);
                } };
                flowLayoutPanel1.Controls.Add(f);
                f.Render();
            }

        }

        public WebImageFile[] WebFileList { get; set; }
    }

    public class WebImageFile
    {
        public string URL { get; set; }
        public string FileName { get; set; }
    }
}
