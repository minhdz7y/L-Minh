using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace btbuoi5
{
    public partial class Form1 : Form
    {
        // Biến lưu đường dẫn file hiện tại
        private string currentFilePath = string.Empty;

        // StatusStrip và label (được tạo động nếu designer chưa có)
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;

        public Form1()
        {
            InitializeComponent();

            // Đăng ký sự kiện Load
            this.Load += Form1_Load;
        }

        // Form Load: đổ font và kích thước vào ToolStripComboBox
        private void Form1_Load(object? sender, EventArgs e)
        {
            // Khởi tạo status strip nếu chưa có
            if (this.Controls.OfType<StatusStrip>().FirstOrDefault() is StatusStrip ss)
            {
                statusStrip1 = ss;
                toolStripStatusLabel1 = statusStrip1.Items.OfType<ToolStripStatusLabel>().FirstOrDefault() ?? new ToolStripStatusLabel();
                if (!statusStrip1.Items.Contains(toolStripStatusLabel1)) statusStrip1.Items.Add(toolStripStatusLabel1);
            }
            else
            {
                statusStrip1 = new StatusStrip();
                toolStripStatusLabel1 = new ToolStripStatusLabel();
                toolStripStatusLabel1.Text = "Tổng số từ: 0";
                statusStrip1.Items.Add(toolStripStatusLabel1);
                this.Controls.Add(statusStrip1);
                statusStrip1.BringToFront();
            }

            // Đổ danh sách font vào toolStripComboBox1
            try
            {
                foreach (FontFamily font in new InstalledFontCollection().Families)
                {
                    toolStripComboBox1.Items.Add(font.Name);
                }
            }
            catch
            {
                // ignore if fonts cannot be enumerated
            }

            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int s in sizes)
            {
                toolStripComboBox2.Items.Add(s.ToString());
            }

            // Thiết lập mặc định
            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";
            richTextBox1.Font = new Font("Tahoma", 14, FontStyle.Regular);

            // Gắn sự kiện cho các control nếu chưa gắn
            newToolStripButton.Click += (s, ea) => TaoVanBanMoi();
            openToolStripButton.Click += (s, ea) => MoTapTin();
            saveToolStripButton.Click += (s, ea) => LuuVanBan();

            toolStripComboBox1.SelectedIndexChanged += ToolStripComboBox1_SelectedIndexChanged;
            toolStripComboBox2.SelectedIndexChanged += ToolStripComboBox2_SelectedIndexChanged;

            toolStripButton1.Click += (s, ea) => ThayDoiKieuChu(FontStyle.Bold);
            toolStripButton2.Click += (s, ea) => ThayDoiKieuChu(FontStyle.Italic);
            toolStripButton3.Click += (s, ea) => ThayDoiKieuChu(FontStyle.Underline);

            // Gắn menu nếu designer chưa gắn
            tạoVănBảnMớiToolStripMenuItem.Click += (s, ea) => TaoVanBanMoi();
            mởTệpToolStripMenuItem.Click += (s, ea) => MoTapTin();
            lưuNộiDungVănBảnCtrlSToolStripMenuItem.Click += (s, ea) => LuuVanBan();
            địnhDạngToolStripMenuItem.Click += ĐịnhDạngToolStripMenuItem_Click;

            // Khởi tạo label trạng thái
            toolStripStatusLabel1.Text = "Tổng số từ: 0";
        }

        // Hàm gọi FontDialog theo yêu cầu
        private void ĐịnhDạngToolStripMenuItem_Click(object? sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;

            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.ForeColor = fontDlg.Color;
                richTextBox1.Font = fontDlg.Font;
            }
        }

        // Tạo văn bản mới
        private void TaoVanBanMoi()
        {
            richTextBox1.Clear();
            toolStripComboBox1.Text = "Tahoma";
            toolStripComboBox2.Text = "14";
            richTextBox1.Font = new Font("Tahoma", 14, FontStyle.Regular);
            currentFilePath = string.Empty;
            toolStripStatusLabel1.Text = "Tổng số từ: 0";
        }

        // Mở tập tin
        private void MoTapTin()
        {
            using OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Filter = "Text Files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf";
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string ext = Path.GetExtension(openDlg.FileName).ToLowerInvariant();
                    if (ext == ".rtf")
                        richTextBox1.LoadFile(openDlg.FileName, RichTextBoxStreamType.RichText);
                    else
                        richTextBox1.LoadFile(openDlg.FileName, RichTextBoxStreamType.PlainText);

                    currentFilePath = openDlg.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Lưu nội dung
        private void LuuVanBan()
        {
            try
            {
                if (string.IsNullOrEmpty(currentFilePath))
                {
                    using SaveFileDialog saveDlg = new SaveFileDialog();
                    saveDlg.Filter = "RTF Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";
                    if (saveDlg.ShowDialog() == DialogResult.OK)
                    {
                        string ext = Path.GetExtension(saveDlg.FileName).ToLowerInvariant();
                        if (ext == ".rtf")
                            richTextBox1.SaveFile(saveDlg.FileName, RichTextBoxStreamType.RichText);
                        else
                            richTextBox1.SaveFile(saveDlg.FileName, RichTextBoxStreamType.PlainText);

                        currentFilePath = saveDlg.FileName;
                        MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    string ext = Path.GetExtension(currentFilePath).ToLowerInvariant();
                    if (ext == ".rtf")
                        richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                    else
                        richTextBox1.SaveFile(currentFilePath, RichTextBoxStreamType.PlainText);

                    MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thay đổi kiểu chữ cho vùng chọn
        private void ThayDoiKieuChu(FontStyle style)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newStyle = currentFont.Style ^ style;
                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
        }

        // Thay đổi family từ combobox
        private void ToolStripComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string fam = toolStripComboBox1.Text;
            if (string.IsNullOrEmpty(fam)) return;
            float size = richTextBox1.SelectionFont?.Size ?? richTextBox1.Font.Size;
            FontStyle style = richTextBox1.SelectionFont?.Style ?? richTextBox1.Font.Style;
            try
            {
                richTextBox1.SelectionFont = new Font(fam, size, style);
            }
            catch { }
        }

        // Thay đổi size từ combobox
        private void ToolStripComboBox2_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (!float.TryParse(toolStripComboBox2.Text, out float size)) return;
            FontFamily fam = richTextBox1.SelectionFont?.FontFamily ?? richTextBox1.Font.FontFamily;
            FontStyle style = richTextBox1.SelectionFont?.Style ?? richTextBox1.Font.Style;
            try
            {
                richTextBox1.SelectionFont = new Font(fam, size, style);
            }
            catch { }
        }

        // Cập nhật đếm từ khi nội dung thay đổi
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string text = richTextBox1.Text.Trim();
            if (string.IsNullOrEmpty(text))
                toolStripStatusLabel1.Text = "Tổng số từ: 0";
            else
            {
                string[] words = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                toolStripStatusLabel1.Text = $"Tổng số từ: {words.Length}";
            }
        }

        // Giữ lại các sự kiện không dùng (tệp designer có thể gọi chúng)
        private void tToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }

        // Methods wired in designer - keep names exactly as designer expects
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ThayDoiKieuChu(FontStyle.Bold);
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoVanBanMoi();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Forward to implementation that matches spec
            ĐịnhDạngToolStripMenuItem_Click(sender, e);
        }
    }
}
