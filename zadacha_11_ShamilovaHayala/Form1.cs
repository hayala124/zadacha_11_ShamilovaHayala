using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace zadacha_11_ShamilovaHayala
{
    public partial class Form1 : Form
    {
        const int n = 3;
        const int sizeButton = 50;
        public int[,] map = new int[n * n, n * n];
        public Button[,] buttons = new Button[n * n, n * n];
        public Form1()
        {
            InitializeComponent();
            GenerateMap();
        }
        public void GenerateMap()
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    map[i, j] = (i * n + i / n + j) % (n * n) + 1;
                    buttons[i, j] = new Button();
                }
            }
            CreateMap();
        }
        private string text;
        public void CreateMap()
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    Button button = new Button();
                    buttons[i, j] = button;
                    button.Size = new Size(sizeButton, sizeButton);
                    button.Text = map[i, j].ToString();
                    button.Location = new Point(j * sizeButton, i * sizeButton);
                    this.Controls.Add(button);
                    text += button.Text + " ";
                    if (j == 8)
                        text += "\n";
                }
            }
        }

        void PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(text, new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        // Вывод заполненного квадрата на печать.
        private void OutputPrintButton_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPage;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print();
        }
        // Вывод заполненного квадрата в текстовый файл.
        private void OutputToTextFileButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text files|*.txt" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        writer.WriteLine(text);
                    }
                }
            }
        }
    }
}