namespace TinyToolbox
{
    partial class MainForm
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Setting", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listView_softwarelist = new System.Windows.Forms.ListView();
            this.imageList_software = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip_list = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_softwarelist
            // 
            this.listView_softwarelist.ContextMenuStrip = this.contextMenuStrip_list;
            this.listView_softwarelist.HideSelection = false;
            this.listView_softwarelist.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView_softwarelist.LargeImageList = this.imageList_software;
            this.listView_softwarelist.Location = new System.Drawing.Point(7, 7);
            this.listView_softwarelist.Margin = new System.Windows.Forms.Padding(2);
            this.listView_softwarelist.Name = "listView_softwarelist";
            this.listView_softwarelist.Size = new System.Drawing.Size(425, 245);
            this.listView_softwarelist.TabIndex = 0;
            this.listView_softwarelist.UseCompatibleStateImageBehavior = false;
            // 
            // imageList_software
            // 
            this.imageList_software.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_software.ImageStream")));
            this.imageList_software.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_software.Images.SetKeyName(0, "setting.png");
            // 
            // contextMenuStrip_list
            // 
            this.contextMenuStrip_list.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.toolStripSeparator1,
            this.editToolStripMenuItem});
            this.contextMenuStrip_list.Name = "contextMenuStrip1";
            this.contextMenuStrip_list.Size = new System.Drawing.Size(114, 76);
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.添加ToolStripMenuItem.Text = "Add";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.删除ToolStripMenuItem.Text = "Delete";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 257);
            this.Controls.Add(this.listView_softwarelist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TinyToolbox";
            this.contextMenuStrip_list.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_softwarelist;
        private System.Windows.Forms.ImageList imageList_software;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_list;
        private System.Windows.Forms.ToolStripMenuItem 添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}

