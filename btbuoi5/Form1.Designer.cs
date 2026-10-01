namespace btbuoi5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            toolStrip1 = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            openToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripComboBox2 = new ToolStripComboBox();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            menuStrip1 = new MenuStrip();
            tToolStripMenuItem = new ToolStripMenuItem();
            tạoVănBảnMớiToolStripMenuItem = new ToolStripMenuItem();
            mởTệpToolStripMenuItem = new ToolStripMenuItem();
            lưuNộiDungVănBảnCtrlSToolStripMenuItem = new ToolStripMenuItem();
            địnhDạngToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 59);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 252);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { newToolStripButton, openToolStripButton, saveToolStripButton, toolStripSeparator, toolStripSeparator1, toolStripComboBox1, toolStripComboBox2, toolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 28);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(29, 25);
            newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            openToolStripButton.Image = (Image)resources.GetObject("openToolStripButton.Image");
            openToolStripButton.ImageTransparentColor = Color.Magenta;
            openToolStripButton.Name = "openToolStripButton";
            openToolStripButton.Size = new Size(29, 25);
            openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(29, 25);
            saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 28);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            // 
            // toolStripComboBox2
            // 
            toolStripComboBox2.Name = "toolStripComboBox2";
            toolStripComboBox2.Size = new Size(121, 28);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 25);
            toolStripButton1.Text = "B";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 163);
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 25);
            toolStripButton2.Text = "I";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 163);
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 25);
            toolStripButton3.Text = "U";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tToolStripMenuItem, địnhDạngToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // tToolStripMenuItem
            // 
            tToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tạoVănBảnMớiToolStripMenuItem, mởTệpToolStripMenuItem, lưuNộiDungVănBảnCtrlSToolStripMenuItem });
            tToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            tToolStripMenuItem.Name = "tToolStripMenuItem";
            tToolStripMenuItem.Size = new Size(81, 24);
            tToolStripMenuItem.Text = "Hệ Thống";
            tToolStripMenuItem.Click += tToolStripMenuItem_Click;
            // 
            // tạoVănBảnMớiToolStripMenuItem
            // 
            tạoVănBảnMớiToolStripMenuItem.Name = "tạoVănBảnMớiToolStripMenuItem";
            tạoVănBảnMớiToolStripMenuItem.Size = new Size(252, 26);
            tạoVănBảnMớiToolStripMenuItem.Text = "Tạo văn bản mới Ctrl+N";
            tạoVănBảnMớiToolStripMenuItem.Click += tạoVănBảnMớiToolStripMenuItem_Click;
            // 
            // mởTệpToolStripMenuItem
            // 
            mởTệpToolStripMenuItem.Name = "mởTệpToolStripMenuItem";
            mởTệpToolStripMenuItem.Size = new Size(252, 26);
            mởTệpToolStripMenuItem.Text = "Mở tệp ";
            // 
            // lưuNộiDungVănBảnCtrlSToolStripMenuItem
            // 
            lưuNộiDungVănBảnCtrlSToolStripMenuItem.Name = "lưuNộiDungVănBảnCtrlSToolStripMenuItem";
            lưuNộiDungVănBảnCtrlSToolStripMenuItem.Size = new Size(252, 26);
            lưuNộiDungVănBảnCtrlSToolStripMenuItem.Text = "Lưu nội dung văn bản Ctrl+S";
            // 
            // địnhDạngToolStripMenuItem
            // 
            địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            địnhDạngToolStripMenuItem.Size = new Size(92, 24);
            địnhDạngToolStripMenuItem.Text = "Định dạng";
            địnhDạngToolStripMenuItem.Click += địnhDạngToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(richTextBox1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private ToolStrip toolStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tToolStripMenuItem;
        private ToolStripMenuItem tạoVănBảnMớiToolStripMenuItem;
        private ToolStripMenuItem mởTệpToolStripMenuItem;
        private ToolStripMenuItem lưuNộiDungVănBảnCtrlSToolStripMenuItem;
        private ToolStripMenuItem địnhDạngToolStripMenuItem;
        private ToolStripButton newToolStripButton;
        private ToolStripButton openToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripComboBox toolStripComboBox2;
    }
}
