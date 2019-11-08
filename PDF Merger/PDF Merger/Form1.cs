using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PDF_Merger;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.IO;
using PdfSharp.Drawing;
using MigraDoc.RtfRendering;
using System.Diagnostics;

namespace PDF_Merger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //add pdf
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //add selected PDF files to listbox
                foreach (var file in openFileDialog1.FileNames)
                {
                    pdfList.Items.Add(file);
                }
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            //remove pdf
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(pdfList);

            if (pdfList.SelectedIndex != -1)
            {
                //Removes item
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    pdfList.Items.Remove(selectedItems[i]);
            }
            else
            {

            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the list box?", "PDF Merger", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //clears listbox items
                pdfList.Items.Clear();
            }
        }

        private void MergeBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf";
            if (pdfList.Items.Count > 1)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var List = pdfList.Items.Cast<String>().ToList(); //creates list of items in listbox

                    PdfDocument outputDocument = new PdfDocument(); //creates output document

                    foreach (string file in List)
                    {
                        PdfDocument inputDocument = PdfReader.Open(file, PdfDocumentOpenMode.Import); //creates input document

                        int count = inputDocument.PageCount; //total page count

                        for (int idx = 0; idx < count; idx++) //for each page
                        {
                            PdfPage page = inputDocument.Pages[idx];
                            outputDocument.AddPage(page);
                        }
                    }

                    outputDocument.Save(saveFileDialog1.FileName); //saves document
                    System.Diagnostics.Process.Start(saveFileDialog1.FileName); //starts merged PDF
                }
            }
            else
            {
                //If less than 2 files are tring to be merged
                MessageBox.Show("You need to select 2 or more PDF files to merge them.", "PDF Merger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            //moves file up in listbox
            MoveItem(-1);
        }

        public void MoveItem(int direction)
        {
            if (pdfList.SelectedItem == null || pdfList.SelectedIndex < 0)
                return; //no selected item

            int newIndex = pdfList.SelectedIndex + direction;

            if (newIndex < 0 || newIndex >= pdfList.Items.Count)
                return;

            object selected = pdfList.SelectedItem; //selected item

            //removing removable element
            pdfList.Items.Remove(selected);
            //inserts in new location
            pdfList.Items.Insert(newIndex, selected);
            //restore selection
            pdfList.SetSelected(newIndex, true);
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            //moves file down in listbox
            MoveItem(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //sets file dialog filters when form loads
            openFileDialog1.Filter = "PDF Files (*.pdf)|*.pdf";
            openFileDialog2.Filter = "JPEG Files (*.jpg)|*.jpg";
            saveFileDialog2.Filter = "PDF Files (*.pdf)|*.pdf";
        }

        private void ImageToPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //image to pdf
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                var document = new PdfDocument(); //new document
                document.Pages.Add(new PdfPage()); //creates blank page
                XGraphics xgr = XGraphics.FromPdfPage(document.Pages[0]); //gets graphics in PDF
                XImage img = XImage.FromFile(openFileDialog2.FileName); //gets image
                xgr.DrawImage(img, 0, 0); //draws image in PDF
                if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    string filepath = saveFileDialog2.FileName;
                    document.Save(filepath);
                    System.Diagnostics.Process.Start(filepath); //starts file path
                }
                document.Close();
            }
        }

        private void SplitPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Split PDF by pages
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Creates folder browser dialog called folder
                FolderBrowserDialog folder = new FolderBrowserDialog();

                if (folder.ShowDialog() == DialogResult.OK)
                {
                    //creates new PDF document called inputDocument
                    PdfDocument inputDocument = PdfReader.Open(openFileDialog1.FileName, PdfDocumentOpenMode.Import);
                    //gets open file dialog file name without extension
                    string name = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                    //while current page isn't equivalent to total pages
                    for (int idx = 0; idx < inputDocument.PageCount; idx++)
                    {
                        PdfDocument outputDocument = new PdfDocument();
                        //sets pdf settings and information.
                        outputDocument.Version = inputDocument.Version;
                        outputDocument.Info.Title = String.Format("Page {0} of {1}", idx + 1, inputDocument.Info.Title);
                        outputDocument.Info.Creator = inputDocument.Info.Creator;
                        //add the page and save it
                        outputDocument.AddPage(inputDocument.Pages[idx]);
                        outputDocument.Save(String.Format(folder.SelectedPath + @"\" + "{0} - Page {1}.pdf", name, idx + 1));
                    }
                    //shows the folder in which you saved your split PDF
                    System.Diagnostics.Process.Start(folder.SelectedPath);
                }
            }
        }

        private void RichTextToPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create blank PDF.
            var document = new PdfDocument();
            document.Pages.Add(new PdfPage());

            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                //string filepath is equal to save file dialog 2 file name
                string filepath = saveFileDialog2.FileName;
                //saves and closes document
                document.Save(filepath);
                document.Close();
                //starts saved file
                System.Diagnostics.Process.Start(filepath);
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //About
            new AboutBox1().ShowDialog();
        }

        private void TectraWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hyperlink to the Tectra Website
            System.Diagnostics.Process.Start("https://tectrasystems.org");
        }

        private void TextToPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //converts text file to pdf file
            OpenFileDialog ofd = new OpenFileDialog(); //creates new open file dialog
            ofd.Title = "Open"; //sets title
            ofd.Filter = "Text File (*.txt)|*.txt"; //sets open file dialog filter

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TextReader readFile = new StreamReader(ofd.FileName); //creates text reader for open file dialog selected item
                PdfDocument pdf = new PdfDocument(); //creates PdfDocument called pdf
                PdfPage pdfPage = pdf.AddPage(); //creates blank page
                XGraphics graph = XGraphics.FromPdfPage(pdfPage); //creates page graphics
                FontDialog fd = new FontDialog(); //creates FontDialog called fd

                if (fd.ShowDialog() == DialogResult.OK)
                {
                    XFont font = new XFont(fd.Font.Name, fd.Font.Size, XFontStyle.Regular); //creates font
                    string line; //makes a string called line
                    int yPoint = 40; //creates integer called yPoint, set to 40

                    while (true)
                    { 
                        //read line until text file ends
                        line = readFile.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        else
                        {
                            //draw text on PDF and increase the Y value for each line
                            graph.DrawString(line, font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                            yPoint = yPoint + 40;
                        }
                    }

                    if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                    {
                        //if result is ok, save PDF file
                        pdf.Save(saveFileDialog2.FileName);
                    }
                }

                //closes readFile
                readFile.Close();
                readFile = null;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes program
            this.Close();
        }

        private void GitHubPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //github
            Process.Start("https://github.com/johnspahr/pdftoolbox");
        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            //When mouse is hovered
            if (pdfList.SelectedItem != null)
            {
                toolTip1.SetToolTip(pdfList, pdfList.GetItemText(pdfList.SelectedItem));
            }
        }
    }
}