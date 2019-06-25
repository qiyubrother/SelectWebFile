using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectWebFile
{
    public partial class FrmSelectWebImage : Form
    {
        public FrmSelectWebImage()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            btnOpen.Click += (o, ex) =>
            {
                if (ucImageManager1.SelectFile != null)
                {
                    MessageBox.Show(ucImageManager1.SelectFile.FileName);
                }
            };
            ucImageManager1.ClickUCImage += (f) => { lblFileName.Text = f.FileName; };

            Text = "选择文件";
            Icon = Icon.FromHandle(Properties.Resources.opened_folder.GetHicon());
            ucImageManager1.WebFileList = new WebImageFile[]
            {
                //new WebImageFile{ FileName = "2019-06-20-122543.jpg", URL = @"file:///d|/2019-05-28-15-16-06-37.jpg"},
                //new WebImageFile{ FileName = "2019-06-20-124172.jpg", URL = @"file:///d|/2019-06-18-11-31-41-72.jpg"},
                //new WebImageFile{ FileName = "2019-06-20-124243.jpg", URL = @"file:///d|/2019-06-18-17-35-42-43.jpg"},
                //new WebImageFile{ FileName = "2019-06-20-122006.jpg", URL = @"file:///d|/2019-06-19-09-58-20-06.jpg"},
            };
            ucImageManager1.Render();


        }
    }
}
