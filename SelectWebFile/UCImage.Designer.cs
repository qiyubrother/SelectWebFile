namespace SelectWebFile
{
    partial class UCImage
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lbl.Location = new System.Drawing.Point(6, 167);
            this.lbl.Name = "lbl";
            this.lbl.Padding = new System.Windows.Forms.Padding(5);
            this.lbl.Size = new System.Drawing.Size(160, 40);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "二年级一班上午.bmp";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoading
            // 
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.Image = Properties.Resources.Loading;
            this.lblLoading.Location = new System.Drawing.Point(57, 56);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(53, 54);
            this.lblLoading.TabIndex = 4;
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(5, 5);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(160, 160);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // UCImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pic);
            this.Name = "UCImage";
            this.Size = new System.Drawing.Size(170, 210);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblLoading;
    }
}
