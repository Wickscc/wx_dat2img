
namespace wx_dat2img
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.访问主页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giteeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始转换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停转换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.重新选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_deldat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(844, 376);
            this.panel1.TabIndex = 12;
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.访问主页ToolStripMenuItem,
            this.githubToolStripMenuItem,
            this.giteeToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 访问主页ToolStripMenuItem
            // 
            this.访问主页ToolStripMenuItem.Name = "访问主页ToolStripMenuItem";
            this.访问主页ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.访问主页ToolStripMenuItem.Text = "访问主页";
            this.访问主页ToolStripMenuItem.Click += new System.EventHandler(this.访问主页ToolStripMenuItem_Click);
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.githubToolStripMenuItem.Text = "前往Github发布页面";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // giteeToolStripMenuItem
            // 
            this.giteeToolStripMenuItem.Name = "giteeToolStripMenuItem";
            this.giteeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.giteeToolStripMenuItem.Text = "前往Gitee发布页面";
            this.giteeToolStripMenuItem.Click += new System.EventHandler(this.giteeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.文件ToolStripMenuItem,
            this.选项OToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始转换ToolStripMenuItem,
            this.暂停转换ToolStripMenuItem,
            this.toolStripSeparator1,
            this.重新选择ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // 开始转换ToolStripMenuItem
            // 
            this.开始转换ToolStripMenuItem.Name = "开始转换ToolStripMenuItem";
            this.开始转换ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.开始转换ToolStripMenuItem.Text = "开始转换(&B)";
            this.开始转换ToolStripMenuItem.Click += new System.EventHandler(this.开始转换ToolStripMenuItem_Click);
            // 
            // 暂停转换ToolStripMenuItem
            // 
            this.暂停转换ToolStripMenuItem.Name = "暂停转换ToolStripMenuItem";
            this.暂停转换ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.暂停转换ToolStripMenuItem.Text = "暂停转换(&E)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // 重新选择ToolStripMenuItem
            // 
            this.重新选择ToolStripMenuItem.Name = "重新选择ToolStripMenuItem";
            this.重新选择ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.重新选择ToolStripMenuItem.Text = "重新选择(&R)";
            this.重新选择ToolStripMenuItem.Click += new System.EventHandler(this.重新选择ToolStripMenuItem_Click);
            // 
            // 选项OToolStripMenuItem
            // 
            this.选项OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_deldat});
            this.选项OToolStripMenuItem.Name = "选项OToolStripMenuItem";
            this.选项OToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.选项OToolStripMenuItem.Text = "选项(&O)";
            // 
            // btn_deldat
            // 
            this.btn_deldat.Name = "btn_deldat";
            this.btn_deldat.Size = new System.Drawing.Size(179, 22);
            this.btn_deldat.Text = "转换后删除dat文件";
            this.btn_deldat.Click += new System.EventHandler(this.btn_deldat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 401);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wx_dat2img";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 访问主页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giteeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始转换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停转换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 重新选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选项OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_deldat;
    }
}

