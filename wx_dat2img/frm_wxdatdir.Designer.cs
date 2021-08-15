
namespace wx_dat2img
{
    partial class frm_wxdatdir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.选择全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部取消ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.清空列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加目录ToolStripMenuItem,
            this.toolStripSeparator1,
            this.选择全部ToolStripMenuItem,
            this.全部取消ToolStripMenuItem,
            this.toolStripSeparator2,
            this.清空列表ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 104);
            // 
            // 添加目录ToolStripMenuItem
            // 
            this.添加目录ToolStripMenuItem.Name = "添加目录ToolStripMenuItem";
            this.添加目录ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加目录ToolStripMenuItem.Text = "添加目录";
            this.添加目录ToolStripMenuItem.Click += new System.EventHandler(this.添加目录ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 选择全部ToolStripMenuItem
            // 
            this.选择全部ToolStripMenuItem.Name = "选择全部ToolStripMenuItem";
            this.选择全部ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.选择全部ToolStripMenuItem.Text = "全部选择";
            this.选择全部ToolStripMenuItem.Click += new System.EventHandler(this.选择全部ToolStripMenuItem_Click);
            // 
            // 全部取消ToolStripMenuItem
            // 
            this.全部取消ToolStripMenuItem.Name = "全部取消ToolStripMenuItem";
            this.全部取消ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.全部取消ToolStripMenuItem.Text = "全部取消";
            this.全部取消ToolStripMenuItem.Click += new System.EventHandler(this.全部取消ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(121, 6);
            // 
            // 清空列表ToolStripMenuItem
            // 
            this.清空列表ToolStripMenuItem.Name = "清空列表ToolStripMenuItem";
            this.清空列表ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.清空列表ToolStripMenuItem.Text = "清空列表";
            this.清空列表ToolStripMenuItem.Click += new System.EventHandler(this.清空列表ToolStripMenuItem_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(564, 256);
            this.checkedListBox1.TabIndex = 19;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // frm_wxdatdir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 256);
            this.Controls.Add(this.checkedListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_wxdatdir";
            this.Text = "frm_DirList";
            this.Load += new System.EventHandler(this.frm_wxImgDir_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加目录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 选择全部ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部取消ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 清空列表ToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}