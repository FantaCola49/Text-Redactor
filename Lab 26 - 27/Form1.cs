using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_26___27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MenuFileOpen()
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                this.openFileDialog1.FileName.Length < 0)
            {
                try
                {
                    this.richTextBox1.LoadFile(this.openFileDialog1.FileName, RichTextBoxStreamType.PlainText);

                }
                catch
                {
                    this.richTextBox1.LoadFile(this.openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                this.Text = $"Файл {this.openFileDialog1.FileName}";
            }
        }

        private void MenuFileSaveAs()
        {

            if (this.saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                this.saveFileDialog1.FileName.Length > 0)
            {
                this.richTextBox1.SaveFile(this.saveFileDialog1.FileName);
                this.Text = "Файл [" + this.saveFileDialog1.FileName + "]";
            }
        }

        private void выделитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectAll();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void форматToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Формат");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuFile_Click(object sender, EventArgs e)
        {

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создать");
            this.richTextBox1.Clear();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Открыть");
            MenuFileOpen();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuFileSaveAs();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuFileSaveAs();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выход");
            this.Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Справки выдаются по субботам");
        }

        private void правкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правка");
        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Cut();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox1.SelectionFont = this.fontDialog1.Font;
            }
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox1.SelectionColor = this.colorDialog1.Color;
            }
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(Text);
        }

        private void открытьToolStripButton_Click(object sender, EventArgs e)
        {
            MenuFileOpen();
        }

        private void вырезатьToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void копироватьToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void справкаToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спайсы соли миксы роллы");
        }
    }
}
