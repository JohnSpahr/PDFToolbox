using System;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
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
using System.Diagnostics;
using MaterialSkin;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace PDF_Merger
{
    public partial class Form1 : MaterialForm
    {
        /**
         
        PDF Toolbox

        Written by John Spahr

        MIT License

        * */

        public Form1()
        {
            InitializeComponent();
            //Initializes MaterialSkin
            var manager = MaterialSkinManager.Instance;
            manager.Theme = MaterialSkinManager.Themes.DARK;
            manager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //add pdf
            pdfOpen.Multiselect = true;

            if (pdfOpen.ShowDialog() == DialogResult.OK)
            {
                //add selected PDF files to listbox
                foreach (var file in pdfOpen.FileNames)
                {
                    pdfList.Items.Add(file);
                }
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            //remove pdf
            System.Windows.Forms.ListBox.SelectedObjectCollection selectedItems = new System.Windows.Forms.ListBox.SelectedObjectCollection(pdfList);

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
            if (MessageBox.Show("Are you sure you want to clear the list box?", "PDF Toolbox", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //clears listbox items
                pdfList.Items.Clear();
            }
        }

        private void MergeBtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            //Merge
            if (pdfList.Items.Count > 1)
            {
                MergePDF();
            }
            else
            {
                //If less than 2 files are tring to be merged
                MessageBox.Show("You need to select 2 or more PDF files to merge them.", "PDF Toolbox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Cursor = Cursors.Default;
        }

        public void MergePDF()
        {
            //Merge PDF
            if (pdfSave.ShowDialog() == DialogResult.OK)
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

                outputDocument.Save(pdfSave.FileName); //saves document
                Process.Start(pdfSave.FileName); //starts merged PDF
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
            imageOpenDialog.Filter = "JPEG Files (*.jpg)|*.jpg";
            imageSaveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            //other setup stuff
            tabSelector.BaseTabControl = tabControl;
        }

        private void ImageToPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //image to pdf
            Cursor = Cursors.WaitCursor; //show loading cursor

            DialogResult result = MessageBox.Show("Do you want to automatically change the PDF page size to ensure that your image fits?", "PDF Toolbox", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //set page size to image size.
                if (imageOpenDialog.ShowDialog() == DialogResult.OK)
                {
                    var document = new PdfDocument(); //new document
                    PdfPage pdfPage = new PdfPage(); //new pdf page
                    Bitmap bmp = new Bitmap(imageOpenDialog.FileName); //make bitmap
                    pdfPage.Width = bmp.Width; //sets pdf page width
                    pdfPage.Height = bmp.Height; //sets pdf page height
                    document.Pages.Add(pdfPage); //adds resized page
                    XGraphics xgr = XGraphics.FromPdfPage(document.Pages[0]); //gets graphics in PDF
                    XImage img = XImage.FromFile(imageOpenDialog.FileName); //gets image
                    img.Interpolate = false; //turns of interpolation
                    xgr.DrawImage(img, 0, 0); //draws image in PDF
                    if (imageSaveDialog.ShowDialog() == DialogResult.OK)
                    {
                        document.Save(imageSaveDialog.FileName); //save
                        Process.Start(imageSaveDialog.FileName); //open
                    }
                    document.Close();
                }
            }
            else if (result == DialogResult.No)
            {
                //don't set page size to image size.
                if (imageOpenDialog.ShowDialog() == DialogResult.OK)
                {
                    var document = new PdfDocument(); //new document
                    Bitmap bmp = new Bitmap(imageOpenDialog.FileName);
                    document.Pages.Add(new PdfPage()); //creates blank page
                    XGraphics xgr = XGraphics.FromPdfPage(document.Pages[0]); //gets graphics in PDF
                    XImage img = XImage.FromFile(imageOpenDialog.FileName); //gets image
                    img.Interpolate = false; //turns of interpolation
                    xgr.DrawImage(img, 0, 0); //draws image in PDF
                    if (imageSaveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filepath = imageSaveDialog.FileName;
                        document.Save(filepath);
                        Process.Start(filepath); //starts file path
                        MessageBox.Show("Operation complete.", "PDF Toolbox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    document.Close();
                }
            }

            Cursor = Cursors.Default; //Back to default cursor
        }

        private void SplitPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Split PDF by pages
            Cursor = Cursors.WaitCursor;
            SplitPDF();
            Cursor = Cursors.Default;
        }

        public void SplitPDF()
        {
            //Split PDF
            try
            {
                //creates new PDF document called inputDocument
                PdfDocument inputDocument = PdfReader.Open(pdfOpen.FileName, PdfDocumentOpenMode.Import);
                //gets file to open's name without extension
                string name = Path.GetFileNameWithoutExtension(openPathSplitTxt.Text);
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
                    outputDocument.Save(String.Format(folderPathSplitTxt.Text + @"\" + "{0} - Page {1}.pdf", name, idx + 1));
                }
                //shows the folder in which you saved your split PDF
                Process.Start(folderPathSplitTxt.Text);
                //display message
                MessageBox.Show("Operation complete.", "PDF Toolbox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to split PDF file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BlankPDF(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor; //wait cursor
            BlankPDF();
            Cursor = Cursors.Default; //default cursor
        }

        public void BlankPDF()
        {
            //Create blank PDF.
            try
            {
                var document = new PdfDocument();
                int count = 1;
                document.Pages.Add(new PdfPage());

                //create selected number of pages
                while (count != pageNum.Value)
                {
                    document.Pages.Add(new PdfPage());
                    count++;
                }

                if (imageSaveDialog.ShowDialog() == DialogResult.OK)
                {
                    //string filepath is equal to save file dialog 2 file name
                    string filepath = imageSaveDialog.FileName;
                    //saves and closes document
                    document.Save(filepath);
                    document.Close();
                    //starts saved file
                    Process.Start(filepath);
                }
            }
            catch (Exception)
            {
                //If blank PDF can't be created.
                MessageBox.Show("Failed to create blank PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Process.Start("https://tectrasystems.org");
        }

        private void TextToPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //converts text file to pdf file
            Cursor = Cursors.WaitCursor; //wait cursor
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

                    if (imageSaveDialog.ShowDialog() == DialogResult.OK)
                    {
                        //if result is ok, save PDF file
                        pdf.Save(imageSaveDialog.FileName);
                    }
                }

                //closes readFile
                readFile.Close();

                //open completed PDF
                Process.Start(imageSaveDialog.FileName);
            }

            Cursor = Cursors.Default; //Default cursor
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Closes program
            this.Close();
        }

        private void GitHubPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GitHub page
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

        private void openPdfBtn_Click(object sender, EventArgs e)
        {
            pdfOpen.Multiselect = false;

            if (pdfOpen.ShowDialog() == DialogResult.OK)
            {
                openPathSplitTxt.Text = pdfOpen.FileName;
            }
        }

        private void openFolderClick(object sender, EventArgs e)
        {
            //open folder
            FolderBrowserDialog folder = new FolderBrowserDialog();

            if (folder.ShowDialog() == DialogResult.OK)
            {
                folderPathSplitTxt.Text = folder.SelectedPath;
            }
        }

        private void htmlBtn_Click(object sender, EventArgs e)
        {
            //HTML to PDF
            Cursor = Cursors.WaitCursor;

            try
            {
                //Set up open file dialog
                htmlPDFDialog.Filter = "HTML files (*.html)|*.html";
                htmlPDFDialog.Title = "Open HTML file";

                //Open HTML file
                if (htmlPDFDialog.ShowDialog() == DialogResult.OK)
                {
                    //create new PDF document
                    PdfDocument pdfDocument = new PdfDocument();

                    //convert html to pdf
                    string html = File.ReadAllText(htmlPDFDialog.FileName);
                    PdfDocument final = PdfGenerator.GeneratePdf(html, PageSize.A4);

                    //Save PDF
                    saveHtmlPDFDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveHtmlPDFDialog.Title = "Save PDF file";

                    //Show SaveFileDialog
                    if (saveHtmlPDFDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Save
                        final.Save(saveHtmlPDFDialog.FileName);
                        //Show PDF file and completion message
                        Process.Start(saveHtmlPDFDialog.FileName);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to convert this HTML file to a PDF.", "PDF Toolbox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor = Cursors.Default;
        }

        private void compressBtn_Click(object sender, EventArgs e)
        {
            //when compress button is clicked
            if (compressOpenTxt.Text.Trim() != "" && compressSaveTxt.Text.Trim() != "")
            {
                Cursor = Cursors.WaitCursor; //wait cursor
                CompressPDF(compressOpenTxt.Text, compressSaveTxt.Text);
                Cursor = Cursors.Default; //default cursor
            }
        }

        public static void CompressPDF(string filePath, string destinationPath)
        {
            try
            {
                using (var stream = new MemoryStream(File.ReadAllBytes(filePath)) { Position = 0 }) //get source file
                using (var source = PdfReader.Open(stream, PdfDocumentOpenMode.Import)) //read source file
                using (var document = new PdfDocument()) //create new PDF document
                {
                    //compression options
                    var options = document.Options;
                    options.FlateEncodeMode = PdfFlateEncodeMode.BestCompression;
                    options.UseFlateDecoderForJpegImages = PdfUseFlateDecoderForJpegImages.Automatic;
                    options.CompressContentStreams = true;
                    options.NoCompression = false;

                    //loop through pages
                    foreach (var page in source.Pages)
                    {
                        document.AddPage(page);
                    }

                    //save compressed document
                    document.Save(destinationPath);

                    //when complete show message and start PDF
                    MessageBox.Show("Successfully compressed PDF.\n\nOriginal Size: " + new FileInfo(filePath).Length / 1000 + " KB\nCompressed Size: " + new FileInfo(destinationPath).Length / 1000 + " KB", "PDF Toolbox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start(destinationPath);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to compress PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openPDFtoCompressBtn_Click(object sender, EventArgs e)
        {
            //open PDF to compress
            if (pdfOpen.ShowDialog() == DialogResult.OK)
            {
                compressOpenTxt.Text = pdfOpen.FileName;
            }
        }
        private void compressedPDFsavePathBtn_Click(object sender, EventArgs e)
        {
            //save path for compressed PDF
            if (pdfSave.ShowDialog() == DialogResult.OK)
            {
                compressSaveTxt.Text = pdfSave.FileName;
            }
        }

        private void removePageBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor; //loading cursor

            try
            {
                //remove page(s) from PDF...
                PdfDocument document = PdfReader.Open(openPathRemoveTxt.Text, PdfDocumentOpenMode.Import);

                int removedPageNum = 0;
                foreach (int i in pageList.CheckedIndices)
                {
                    //Remove page
                    document.Pages.RemoveAt(i - removedPageNum);
                    removedPageNum++;
                }

                //Save and start
                document.Save(savePathRemoveTxt.Text);
                Process.Start(savePathRemoveTxt.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Failed to remove page(s) from PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Cursor = Cursors.WaitCursor; //normal cursor
        }

        private void removeOpenButton_Click(object sender, EventArgs e)
        {
            //open PDF to remove page from
            if (pdfOpen.ShowDialog() == DialogResult.OK)
            {
                openPathRemoveTxt.Text = pdfOpen.FileName;
            }
        }

        private void removeSaveBtn_Click(object sender, EventArgs e)
        {
            //save path for PDF with removed page
            if (pdfSave.ShowDialog() == DialogResult.OK)
            {
                savePathRemoveTxt.Text = pdfSave.FileName;
            }
        }

        private void openPDFtoRemovePagesBtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor; //loading cursor

            try
            {
                PdfDocument document = PdfReader.Open(openPathRemoveTxt.Text, PdfDocumentOpenMode.Import);

                for (int idx = 0; idx < document.PageCount; idx++) //for each page
                {
                    pageList.Items.Add("Page " + (idx + 1));
                }

                //show remove pages stuff when open button pressed
                removeLbl.Visible = true;
                pageList.Visible = true;
                removeSaveLbl.Visible = true;
                savePathRemoveTxt.Visible = true;
                removePageBtn.Visible = true;
                removeSaveBtn.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to open PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Cursor = Cursors.Default; //default cursor
        }

        private void openPathRemoveTxt_TextChanged(object sender, EventArgs e)
        {
            //hide remove pages stuff when text changed in open file path textbox
            removeLbl.Visible = false;
            pageList.Visible = false;
            removeSaveLbl.Visible = false;
            savePathRemoveTxt.Visible = false;
            removePageBtn.Visible = false;
            removeSaveBtn.Visible = false;

            //uncheck all items
            while (pageList.CheckedIndices.Count > 0)
            {
                pageList.SetItemChecked(pageList.CheckedIndices[0], false);
            }
        }
    }
}