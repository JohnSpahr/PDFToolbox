namespace PDF_Merger
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pdfList = new System.Windows.Forms.ListBox();
            this.pdfOpen = new System.Windows.Forms.OpenFileDialog();
            this.pdfSave = new System.Windows.Forms.SaveFileDialog();
            this.upBtn = new System.Windows.Forms.Button();
            this.downBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tectraWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.imageOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.mergePage = new System.Windows.Forms.TabPage();
            this.mergeBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.clearBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.removeBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.addBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.splitPage = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.openPdfBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.openFolderBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.folderPathSplitTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.openPathSplitTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.splitBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.convertPage = new System.Windows.Forms.TabPage();
            this.htmlBtn = new System.Windows.Forms.Button();
            this.textFileToPDFBtn = new System.Windows.Forms.Button();
            this.imageToPDFBtn = new System.Windows.Forms.Button();
            this.createPage = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.createBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.label14 = new System.Windows.Forms.Label();
            this.pageNum = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.compressPage = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.compressBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.openPDFtoCompressBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.compressedPDFsavePathBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.label18 = new System.Windows.Forms.Label();
            this.compressSaveTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.compressOpenTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.removePage = new System.Windows.Forms.TabPage();
            this.openPDFtoRemovePagesBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.pageList = new System.Windows.Forms.CheckedListBox();
            this.removeOpenButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.removeSaveBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.removeLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.removeSaveLbl = new System.Windows.Forms.Label();
            this.removePageBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.savePathRemoveTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.openPathRemoveTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.removeOpenLbl = new System.Windows.Forms.Label();
            this.tabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.htmlPDFDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveHtmlPDFDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.mergePage.SuspendLayout();
            this.splitPage.SuspendLayout();
            this.convertPage.SuspendLayout();
            this.createPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNum)).BeginInit();
            this.compressPage.SuspendLayout();
            this.removePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdfList
            // 
            this.pdfList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pdfList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pdfList.Font = new System.Drawing.Font("Verdana", 12F);
            this.pdfList.ForeColor = System.Drawing.Color.White;
            this.pdfList.FormattingEnabled = true;
            this.pdfList.HorizontalScrollbar = true;
            this.pdfList.ItemHeight = 25;
            this.pdfList.Location = new System.Drawing.Point(17, 54);
            this.pdfList.Margin = new System.Windows.Forms.Padding(2);
            this.pdfList.Name = "pdfList";
            this.pdfList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.pdfList.Size = new System.Drawing.Size(431, 227);
            this.pdfList.TabIndex = 0;
            this.pdfList.MouseHover += new System.EventHandler(this.listBox1_MouseHover);
            // 
            // pdfOpen
            // 
            this.pdfOpen.DefaultExt = "PDF";
            this.pdfOpen.Filter = "PDF Files (*.pdf)|*.pdf";
            this.pdfOpen.Title = "Select PDF file";
            // 
            // pdfSave
            // 
            this.pdfSave.Filter = "PDF Files (*.pdf)|*.pdf";
            this.pdfSave.Title = "Save merged PDF";
            // 
            // upBtn
            // 
            this.upBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.upBtn.FlatAppearance.BorderSize = 0;
            this.upBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upBtn.ForeColor = System.Drawing.Color.White;
            this.upBtn.Image = ((System.Drawing.Image)(resources.GetObject("upBtn.Image")));
            this.upBtn.Location = new System.Drawing.Point(467, 37);
            this.upBtn.Margin = new System.Windows.Forms.Padding(2);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(42, 31);
            this.upBtn.TabIndex = 5;
            this.upBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.upBtn.UseVisualStyleBackColor = true;
            this.upBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // downBtn
            // 
            this.downBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.downBtn.FlatAppearance.BorderSize = 0;
            this.downBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downBtn.ForeColor = System.Drawing.Color.White;
            this.downBtn.Image = ((System.Drawing.Image)(resources.GetObject("downBtn.Image")));
            this.downBtn.Location = new System.Drawing.Point(467, 72);
            this.downBtn.Margin = new System.Windows.Forms.Padding(2);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(42, 31);
            this.downBtn.TabIndex = 6;
            this.downBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.downBtn.UseVisualStyleBackColor = true;
            this.downBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 19.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Merge PDFs";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 506);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(653, 26);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F);
            this.programToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tectraWebsiteToolStripMenuItem,
            this.gitHubPageToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F);
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tectraWebsiteToolStripMenuItem
            // 
            this.tectraWebsiteToolStripMenuItem.Name = "tectraWebsiteToolStripMenuItem";
            this.tectraWebsiteToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.tectraWebsiteToolStripMenuItem.Text = "Tectra Website";
            this.tectraWebsiteToolStripMenuItem.Click += new System.EventHandler(this.TectraWebsiteToolStripMenuItem_Click);
            // 
            // gitHubPageToolStripMenuItem
            // 
            this.gitHubPageToolStripMenuItem.Name = "gitHubPageToolStripMenuItem";
            this.gitHubPageToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.gitHubPageToolStripMenuItem.Text = "GitHub Page";
            this.gitHubPageToolStripMenuItem.Click += new System.EventHandler(this.GitHubPageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.mergePage);
            this.tabControl.Controls.Add(this.splitPage);
            this.tabControl.Controls.Add(this.convertPage);
            this.tabControl.Controls.Add(this.createPage);
            this.tabControl.Controls.Add(this.compressPage);
            this.tabControl.Controls.Add(this.removePage);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(14, 76);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(625, 381);
            this.tabControl.TabIndex = 11;
            // 
            // mergePage
            // 
            this.mergePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mergePage.Controls.Add(this.mergeBtn);
            this.mergePage.Controls.Add(this.clearBtn);
            this.mergePage.Controls.Add(this.removeBtn);
            this.mergePage.Controls.Add(this.addBtn);
            this.mergePage.Controls.Add(this.label2);
            this.mergePage.Controls.Add(this.pdfList);
            this.mergePage.Controls.Add(this.downBtn);
            this.mergePage.Controls.Add(this.upBtn);
            this.mergePage.Location = new System.Drawing.Point(4, 22);
            this.mergePage.Margin = new System.Windows.Forms.Padding(2);
            this.mergePage.Name = "mergePage";
            this.mergePage.Padding = new System.Windows.Forms.Padding(2);
            this.mergePage.Size = new System.Drawing.Size(617, 355);
            this.mergePage.TabIndex = 0;
            this.mergePage.Text = "Merge";
            // 
            // mergeBtn
            // 
            this.mergeBtn.AutoSize = true;
            this.mergeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mergeBtn.Depth = 0;
            this.mergeBtn.Icon = null;
            this.mergeBtn.Location = new System.Drawing.Point(467, 137);
            this.mergeBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mergeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.mergeBtn.Name = "mergeBtn";
            this.mergeBtn.Primary = false;
            this.mergeBtn.Size = new System.Drawing.Size(163, 36);
            this.mergeBtn.TabIndex = 16;
            this.mergeBtn.Text = "Merge PDF Files";
            this.mergeBtn.UseVisualStyleBackColor = true;
            this.mergeBtn.Click += new System.EventHandler(this.MergeBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.AutoSize = true;
            this.clearBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearBtn.Depth = 0;
            this.clearBtn.Icon = null;
            this.clearBtn.Location = new System.Drawing.Point(159, 310);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.clearBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Primary = false;
            this.clearBtn.Size = new System.Drawing.Size(74, 36);
            this.clearBtn.TabIndex = 15;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.AutoSize = true;
            this.removeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeBtn.Depth = 0;
            this.removeBtn.Icon = null;
            this.removeBtn.Location = new System.Drawing.Point(73, 310);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.removeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Primary = false;
            this.removeBtn.Size = new System.Drawing.Size(90, 36);
            this.removeBtn.TabIndex = 14;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.AutoSize = true;
            this.addBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBtn.Depth = 0;
            this.addBtn.Icon = null;
            this.addBtn.Location = new System.Drawing.Point(17, 310);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.addBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addBtn.Name = "addBtn";
            this.addBtn.Primary = false;
            this.addBtn.Size = new System.Drawing.Size(56, 36);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // splitPage
            // 
            this.splitPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.splitPage.Controls.Add(this.label9);
            this.splitPage.Controls.Add(this.openPdfBtn);
            this.splitPage.Controls.Add(this.openFolderBtn);
            this.splitPage.Controls.Add(this.label4);
            this.splitPage.Controls.Add(this.folderPathSplitTxt);
            this.splitPage.Controls.Add(this.label3);
            this.splitPage.Controls.Add(this.openPathSplitTxt);
            this.splitPage.Controls.Add(this.label1);
            this.splitPage.Controls.Add(this.splitBtn);
            this.splitPage.Location = new System.Drawing.Point(4, 22);
            this.splitPage.Margin = new System.Windows.Forms.Padding(2);
            this.splitPage.Name = "splitPage";
            this.splitPage.Padding = new System.Windows.Forms.Padding(2);
            this.splitPage.Size = new System.Drawing.Size(617, 355);
            this.splitPage.TabIndex = 1;
            this.splitPage.Text = "Split";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(20, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(287, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "*Splits pages in PDF into separate files.";
            // 
            // openPdfBtn
            // 
            this.openPdfBtn.AutoSize = true;
            this.openPdfBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openPdfBtn.Depth = 0;
            this.openPdfBtn.Icon = null;
            this.openPdfBtn.Location = new System.Drawing.Point(519, 59);
            this.openPdfBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.openPdfBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.openPdfBtn.Name = "openPdfBtn";
            this.openPdfBtn.Primary = false;
            this.openPdfBtn.Size = new System.Drawing.Size(36, 36);
            this.openPdfBtn.TabIndex = 19;
            this.openPdfBtn.Text = "...";
            this.openPdfBtn.UseVisualStyleBackColor = true;
            this.openPdfBtn.Click += new System.EventHandler(this.openPdfBtn_Click);
            // 
            // openFolderBtn
            // 
            this.openFolderBtn.AutoSize = true;
            this.openFolderBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openFolderBtn.Depth = 0;
            this.openFolderBtn.Icon = null;
            this.openFolderBtn.Location = new System.Drawing.Point(519, 116);
            this.openFolderBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.openFolderBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.openFolderBtn.Name = "openFolderBtn";
            this.openFolderBtn.Primary = false;
            this.openFolderBtn.Size = new System.Drawing.Size(36, 36);
            this.openFolderBtn.TabIndex = 18;
            this.openFolderBtn.Text = "...";
            this.openFolderBtn.UseVisualStyleBackColor = true;
            this.openFolderBtn.Click += new System.EventHandler(this.openFolderClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "save:";
            // 
            // folderPathSplitTxt
            // 
            this.folderPathSplitTxt.Depth = 0;
            this.folderPathSplitTxt.Font = new System.Drawing.Font("Verdana", 9F);
            this.folderPathSplitTxt.Hint = "Select a folder to save the output file in...";
            this.folderPathSplitTxt.Location = new System.Drawing.Point(75, 123);
            this.folderPathSplitTxt.Margin = new System.Windows.Forms.Padding(2);
            this.folderPathSplitTxt.MaxLength = 32767;
            this.folderPathSplitTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.folderPathSplitTxt.Name = "folderPathSplitTxt";
            this.folderPathSplitTxt.PasswordChar = '\0';
            this.folderPathSplitTxt.SelectedText = "";
            this.folderPathSplitTxt.SelectionLength = 0;
            this.folderPathSplitTxt.SelectionStart = 0;
            this.folderPathSplitTxt.Size = new System.Drawing.Size(437, 28);
            this.folderPathSplitTxt.TabIndex = 16;
            this.folderPathSplitTxt.TabStop = false;
            this.folderPathSplitTxt.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "open:";
            // 
            // openPathSplitTxt
            // 
            this.openPathSplitTxt.Depth = 0;
            this.openPathSplitTxt.Font = new System.Drawing.Font("Verdana", 9F);
            this.openPathSplitTxt.Hint = "Select a PDF to split...";
            this.openPathSplitTxt.Location = new System.Drawing.Point(75, 66);
            this.openPathSplitTxt.Margin = new System.Windows.Forms.Padding(2);
            this.openPathSplitTxt.MaxLength = 32767;
            this.openPathSplitTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.openPathSplitTxt.Name = "openPathSplitTxt";
            this.openPathSplitTxt.PasswordChar = '\0';
            this.openPathSplitTxt.SelectedText = "";
            this.openPathSplitTxt.SelectionLength = 0;
            this.openPathSplitTxt.SelectionStart = 0;
            this.openPathSplitTxt.Size = new System.Drawing.Size(437, 28);
            this.openPathSplitTxt.TabIndex = 14;
            this.openPathSplitTxt.TabStop = false;
            this.openPathSplitTxt.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 19.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Split PDF by pages";
            // 
            // splitBtn
            // 
            this.splitBtn.AutoSize = true;
            this.splitBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.splitBtn.Depth = 0;
            this.splitBtn.Icon = null;
            this.splitBtn.Location = new System.Drawing.Point(17, 173);
            this.splitBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.splitBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.splitBtn.Name = "splitBtn";
            this.splitBtn.Primary = false;
            this.splitBtn.Size = new System.Drawing.Size(68, 36);
            this.splitBtn.TabIndex = 0;
            this.splitBtn.Text = "Split";
            this.splitBtn.UseVisualStyleBackColor = true;
            this.splitBtn.Click += new System.EventHandler(this.SplitPDFToolStripMenuItem_Click);
            // 
            // convertPage
            // 
            this.convertPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.convertPage.Controls.Add(this.htmlBtn);
            this.convertPage.Controls.Add(this.textFileToPDFBtn);
            this.convertPage.Controls.Add(this.imageToPDFBtn);
            this.convertPage.Location = new System.Drawing.Point(4, 22);
            this.convertPage.Margin = new System.Windows.Forms.Padding(2);
            this.convertPage.Name = "convertPage";
            this.convertPage.Size = new System.Drawing.Size(617, 355);
            this.convertPage.TabIndex = 2;
            this.convertPage.Text = "Convert";
            // 
            // htmlBtn
            // 
            this.htmlBtn.FlatAppearance.BorderSize = 0;
            this.htmlBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.htmlBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.htmlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htmlBtn.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.htmlBtn.ForeColor = System.Drawing.Color.LightGray;
            this.htmlBtn.Image = ((System.Drawing.Image)(resources.GetObject("htmlBtn.Image")));
            this.htmlBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.htmlBtn.Location = new System.Drawing.Point(225, 81);
            this.htmlBtn.Margin = new System.Windows.Forms.Padding(2);
            this.htmlBtn.Name = "htmlBtn";
            this.htmlBtn.Size = new System.Drawing.Size(179, 209);
            this.htmlBtn.TabIndex = 4;
            this.htmlBtn.Text = "HTML to PDF";
            this.htmlBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.htmlBtn.UseVisualStyleBackColor = true;
            this.htmlBtn.Click += new System.EventHandler(this.htmlBtn_Click);
            // 
            // textFileToPDFBtn
            // 
            this.textFileToPDFBtn.FlatAppearance.BorderSize = 0;
            this.textFileToPDFBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.textFileToPDFBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.textFileToPDFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textFileToPDFBtn.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.textFileToPDFBtn.ForeColor = System.Drawing.Color.LightGray;
            this.textFileToPDFBtn.Image = ((System.Drawing.Image)(resources.GetObject("textFileToPDFBtn.Image")));
            this.textFileToPDFBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.textFileToPDFBtn.Location = new System.Drawing.Point(42, 81);
            this.textFileToPDFBtn.Margin = new System.Windows.Forms.Padding(2);
            this.textFileToPDFBtn.Name = "textFileToPDFBtn";
            this.textFileToPDFBtn.Size = new System.Drawing.Size(179, 209);
            this.textFileToPDFBtn.TabIndex = 1;
            this.textFileToPDFBtn.Text = "Text File to PDF";
            this.textFileToPDFBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.textFileToPDFBtn.UseVisualStyleBackColor = true;
            this.textFileToPDFBtn.Click += new System.EventHandler(this.TextToPDFToolStripMenuItem_Click);
            // 
            // imageToPDFBtn
            // 
            this.imageToPDFBtn.FlatAppearance.BorderSize = 0;
            this.imageToPDFBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.imageToPDFBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.imageToPDFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageToPDFBtn.Font = new System.Drawing.Font("Verdana", 10.8F);
            this.imageToPDFBtn.ForeColor = System.Drawing.Color.LightGray;
            this.imageToPDFBtn.Image = ((System.Drawing.Image)(resources.GetObject("imageToPDFBtn.Image")));
            this.imageToPDFBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.imageToPDFBtn.Location = new System.Drawing.Point(408, 81);
            this.imageToPDFBtn.Margin = new System.Windows.Forms.Padding(2);
            this.imageToPDFBtn.Name = "imageToPDFBtn";
            this.imageToPDFBtn.Size = new System.Drawing.Size(179, 209);
            this.imageToPDFBtn.TabIndex = 0;
            this.imageToPDFBtn.Text = "Image to PDF";
            this.imageToPDFBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.imageToPDFBtn.UseVisualStyleBackColor = true;
            this.imageToPDFBtn.Click += new System.EventHandler(this.ImageToPDFToolStripMenuItem_Click);
            // 
            // createPage
            // 
            this.createPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.createPage.Controls.Add(this.label10);
            this.createPage.Controls.Add(this.createBtn);
            this.createPage.Controls.Add(this.label14);
            this.createPage.Controls.Add(this.pageNum);
            this.createPage.Controls.Add(this.label13);
            this.createPage.Location = new System.Drawing.Point(4, 22);
            this.createPage.Margin = new System.Windows.Forms.Padding(2);
            this.createPage.Name = "createPage";
            this.createPage.Size = new System.Drawing.Size(617, 355);
            this.createPage.TabIndex = 3;
            this.createPage.Text = "Create";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(27, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(414, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "*Creates a blank PDF with the inputted number of pages.";
            // 
            // createBtn
            // 
            this.createBtn.AutoSize = true;
            this.createBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createBtn.Depth = 0;
            this.createBtn.Icon = null;
            this.createBtn.Location = new System.Drawing.Point(30, 128);
            this.createBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.createBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.createBtn.Name = "createBtn";
            this.createBtn.Primary = false;
            this.createBtn.Size = new System.Drawing.Size(85, 36);
            this.createBtn.TabIndex = 18;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.BlankPDF);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9F);
            this.label14.ForeColor = System.Drawing.Color.LightGray;
            this.label14.Location = new System.Drawing.Point(27, 76);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 18);
            this.label14.TabIndex = 17;
            this.label14.Text = "Number of pages:";
            // 
            // pageNum
            // 
            this.pageNum.Font = new System.Drawing.Font("Verdana", 9F);
            this.pageNum.Location = new System.Drawing.Point(174, 74);
            this.pageNum.Margin = new System.Windows.Forms.Padding(2);
            this.pageNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pageNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageNum.Name = "pageNum";
            this.pageNum.Size = new System.Drawing.Size(85, 26);
            this.pageNum.TabIndex = 16;
            this.pageNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 19.2F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(23, 19);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(367, 40);
            this.label13.TabIndex = 15;
            this.label13.Text = "Create a blank PDF";
            // 
            // compressPage
            // 
            this.compressPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.compressPage.Controls.Add(this.label11);
            this.compressPage.Controls.Add(this.compressBtn);
            this.compressPage.Controls.Add(this.openPDFtoCompressBtn);
            this.compressPage.Controls.Add(this.compressedPDFsavePathBtn);
            this.compressPage.Controls.Add(this.label18);
            this.compressPage.Controls.Add(this.compressSaveTxt);
            this.compressPage.Controls.Add(this.label15);
            this.compressPage.Controls.Add(this.label19);
            this.compressPage.Controls.Add(this.compressOpenTxt);
            this.compressPage.Location = new System.Drawing.Point(4, 22);
            this.compressPage.Margin = new System.Windows.Forms.Padding(2);
            this.compressPage.Name = "compressPage";
            this.compressPage.Padding = new System.Windows.Forms.Padding(2);
            this.compressPage.Size = new System.Drawing.Size(617, 355);
            this.compressPage.TabIndex = 4;
            this.compressPage.Text = "Compress";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.label11.ForeColor = System.Drawing.Color.LightGray;
            this.label11.Location = new System.Drawing.Point(9, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(425, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "*Reduces the quality of images in PDF to decrease file size.";
            // 
            // compressBtn
            // 
            this.compressBtn.AutoSize = true;
            this.compressBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.compressBtn.Depth = 0;
            this.compressBtn.Icon = null;
            this.compressBtn.Location = new System.Drawing.Point(12, 164);
            this.compressBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.compressBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.compressBtn.Name = "compressBtn";
            this.compressBtn.Primary = false;
            this.compressBtn.Size = new System.Drawing.Size(112, 36);
            this.compressBtn.TabIndex = 26;
            this.compressBtn.Text = "Compress";
            this.compressBtn.UseVisualStyleBackColor = true;
            this.compressBtn.Click += new System.EventHandler(this.compressBtn_Click);
            // 
            // openPDFtoCompressBtn
            // 
            this.openPDFtoCompressBtn.AutoSize = true;
            this.openPDFtoCompressBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openPDFtoCompressBtn.Depth = 0;
            this.openPDFtoCompressBtn.Icon = null;
            this.openPDFtoCompressBtn.Location = new System.Drawing.Point(513, 50);
            this.openPDFtoCompressBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.openPDFtoCompressBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.openPDFtoCompressBtn.Name = "openPDFtoCompressBtn";
            this.openPDFtoCompressBtn.Primary = false;
            this.openPDFtoCompressBtn.Size = new System.Drawing.Size(36, 36);
            this.openPDFtoCompressBtn.TabIndex = 25;
            this.openPDFtoCompressBtn.Text = "...";
            this.openPDFtoCompressBtn.UseVisualStyleBackColor = true;
            this.openPDFtoCompressBtn.Click += new System.EventHandler(this.openPDFtoCompressBtn_Click);
            // 
            // compressedPDFsavePathBtn
            // 
            this.compressedPDFsavePathBtn.AutoSize = true;
            this.compressedPDFsavePathBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.compressedPDFsavePathBtn.Depth = 0;
            this.compressedPDFsavePathBtn.Icon = null;
            this.compressedPDFsavePathBtn.Location = new System.Drawing.Point(513, 106);
            this.compressedPDFsavePathBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.compressedPDFsavePathBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.compressedPDFsavePathBtn.Name = "compressedPDFsavePathBtn";
            this.compressedPDFsavePathBtn.Primary = false;
            this.compressedPDFsavePathBtn.Size = new System.Drawing.Size(36, 36);
            this.compressedPDFsavePathBtn.TabIndex = 24;
            this.compressedPDFsavePathBtn.Text = "...";
            this.compressedPDFsavePathBtn.UseVisualStyleBackColor = true;
            this.compressedPDFsavePathBtn.Click += new System.EventHandler(this.compressedPDFsavePathBtn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 9.8F);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(8, 125);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 20);
            this.label18.TabIndex = 23;
            this.label18.Text = "save:";
            // 
            // compressSaveTxt
            // 
            this.compressSaveTxt.Depth = 0;
            this.compressSaveTxt.Font = new System.Drawing.Font("Verdana", 9F);
            this.compressSaveTxt.Hint = "Select a folder to save the output file in...";
            this.compressSaveTxt.Location = new System.Drawing.Point(69, 121);
            this.compressSaveTxt.Margin = new System.Windows.Forms.Padding(2);
            this.compressSaveTxt.MaxLength = 32767;
            this.compressSaveTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.compressSaveTxt.Name = "compressSaveTxt";
            this.compressSaveTxt.PasswordChar = '\0';
            this.compressSaveTxt.SelectedText = "";
            this.compressSaveTxt.SelectionLength = 0;
            this.compressSaveTxt.SelectionStart = 0;
            this.compressSaveTxt.Size = new System.Drawing.Size(437, 28);
            this.compressSaveTxt.TabIndex = 22;
            this.compressSaveTxt.TabStop = false;
            this.compressSaveTxt.UseSystemPasswordChar = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 19.2F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(5, 11);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(316, 40);
            this.label15.TabIndex = 16;
            this.label15.Text = "Compress a PDF";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Verdana", 9.8F);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(8, 68);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 20);
            this.label19.TabIndex = 21;
            this.label19.Text = "open:";
            // 
            // compressOpenTxt
            // 
            this.compressOpenTxt.Depth = 0;
            this.compressOpenTxt.Font = new System.Drawing.Font("Verdana", 9F);
            this.compressOpenTxt.Hint = "Select a PDF to compress...";
            this.compressOpenTxt.Location = new System.Drawing.Point(69, 64);
            this.compressOpenTxt.Margin = new System.Windows.Forms.Padding(2);
            this.compressOpenTxt.MaxLength = 32767;
            this.compressOpenTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.compressOpenTxt.Name = "compressOpenTxt";
            this.compressOpenTxt.PasswordChar = '\0';
            this.compressOpenTxt.SelectedText = "";
            this.compressOpenTxt.SelectionLength = 0;
            this.compressOpenTxt.SelectionStart = 0;
            this.compressOpenTxt.Size = new System.Drawing.Size(437, 28);
            this.compressOpenTxt.TabIndex = 20;
            this.compressOpenTxt.TabStop = false;
            this.compressOpenTxt.UseSystemPasswordChar = false;
            // 
            // removePage
            // 
            this.removePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.removePage.Controls.Add(this.openPDFtoRemovePagesBtn);
            this.removePage.Controls.Add(this.pageList);
            this.removePage.Controls.Add(this.removeOpenButton);
            this.removePage.Controls.Add(this.removeSaveBtn);
            this.removePage.Controls.Add(this.removeLbl);
            this.removePage.Controls.Add(this.label6);
            this.removePage.Controls.Add(this.removeSaveLbl);
            this.removePage.Controls.Add(this.removePageBtn);
            this.removePage.Controls.Add(this.savePathRemoveTxt);
            this.removePage.Controls.Add(this.openPathRemoveTxt);
            this.removePage.Controls.Add(this.removeOpenLbl);
            this.removePage.Location = new System.Drawing.Point(4, 22);
            this.removePage.Name = "removePage";
            this.removePage.Padding = new System.Windows.Forms.Padding(3);
            this.removePage.Size = new System.Drawing.Size(617, 355);
            this.removePage.TabIndex = 5;
            this.removePage.Text = "Remove";
            // 
            // openPDFtoRemovePagesBtn
            // 
            this.openPDFtoRemovePagesBtn.AutoSize = true;
            this.openPDFtoRemovePagesBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openPDFtoRemovePagesBtn.Depth = 0;
            this.openPDFtoRemovePagesBtn.Icon = null;
            this.openPDFtoRemovePagesBtn.Location = new System.Drawing.Point(12, 93);
            this.openPDFtoRemovePagesBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.openPDFtoRemovePagesBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.openPDFtoRemovePagesBtn.Name = "openPDFtoRemovePagesBtn";
            this.openPDFtoRemovePagesBtn.Primary = false;
            this.openPDFtoRemovePagesBtn.Size = new System.Drawing.Size(67, 36);
            this.openPDFtoRemovePagesBtn.TabIndex = 29;
            this.openPDFtoRemovePagesBtn.Text = "Open";
            this.openPDFtoRemovePagesBtn.UseVisualStyleBackColor = true;
            this.openPDFtoRemovePagesBtn.Click += new System.EventHandler(this.openPDFtoRemovePagesBtn_Click);
            // 
            // pageList
            // 
            this.pageList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pageList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageList.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.pageList.ForeColor = System.Drawing.Color.White;
            this.pageList.FormattingEnabled = true;
            this.pageList.Location = new System.Drawing.Point(12, 162);
            this.pageList.Name = "pageList";
            this.pageList.Size = new System.Drawing.Size(535, 92);
            this.pageList.TabIndex = 28;
            this.pageList.Visible = false;
            // 
            // removeOpenButton
            // 
            this.removeOpenButton.AutoSize = true;
            this.removeOpenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeOpenButton.Depth = 0;
            this.removeOpenButton.Icon = null;
            this.removeOpenButton.Location = new System.Drawing.Point(511, 49);
            this.removeOpenButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.removeOpenButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeOpenButton.Name = "removeOpenButton";
            this.removeOpenButton.Primary = false;
            this.removeOpenButton.Size = new System.Drawing.Size(36, 36);
            this.removeOpenButton.TabIndex = 21;
            this.removeOpenButton.Text = "...";
            this.removeOpenButton.UseVisualStyleBackColor = true;
            this.removeOpenButton.Click += new System.EventHandler(this.removeOpenButton_Click);
            // 
            // removeSaveBtn
            // 
            this.removeSaveBtn.AutoSize = true;
            this.removeSaveBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeSaveBtn.Depth = 0;
            this.removeSaveBtn.Icon = null;
            this.removeSaveBtn.Location = new System.Drawing.Point(511, 273);
            this.removeSaveBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.removeSaveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.removeSaveBtn.Name = "removeSaveBtn";
            this.removeSaveBtn.Primary = false;
            this.removeSaveBtn.Size = new System.Drawing.Size(36, 36);
            this.removeSaveBtn.TabIndex = 20;
            this.removeSaveBtn.Text = "...";
            this.removeSaveBtn.UseVisualStyleBackColor = true;
            this.removeSaveBtn.Visible = false;
            this.removeSaveBtn.Click += new System.EventHandler(this.removeSaveBtn_Click);
            // 
            // removeLbl
            // 
            this.removeLbl.AutoSize = true;
            this.removeLbl.Font = new System.Drawing.Font("Verdana", 9F);
            this.removeLbl.ForeColor = System.Drawing.Color.LightGray;
            this.removeLbl.Location = new System.Drawing.Point(9, 141);
            this.removeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.removeLbl.Name = "removeLbl";
            this.removeLbl.Size = new System.Drawing.Size(197, 18);
            this.removeLbl.TabIndex = 21;
            this.removeLbl.Text = "Remove selected pages: ";
            this.removeLbl.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 19.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(452, 40);
            this.label6.TabIndex = 19;
            this.label6.Text = "Remove page(s) in PDF";
            // 
            // removeSaveLbl
            // 
            this.removeSaveLbl.AutoSize = true;
            this.removeSaveLbl.Font = new System.Drawing.Font("Verdana", 9.8F);
            this.removeSaveLbl.ForeColor = System.Drawing.Color.White;
            this.removeSaveLbl.Location = new System.Drawing.Point(8, 281);
            this.removeSaveLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.removeSaveLbl.Name = "removeSaveLbl";
            this.removeSaveLbl.Size = new System.Drawing.Size(56, 20);
            this.removeSaveLbl.TabIndex = 27;
            this.removeSaveLbl.Text = "save:";
            this.removeSaveLbl.Visible = false;
            // 
            // removePageBtn
            // 
            this.removePageBtn.AutoSize = true;
            this.removePageBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removePageBtn.Depth = 0;
            this.removePageBtn.Icon = null;
            this.removePageBtn.Location = new System.Drawing.Point(12, 312);
            this.removePageBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.removePageBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.removePageBtn.Name = "removePageBtn";
            this.removePageBtn.Primary = false;
            this.removePageBtn.Size = new System.Drawing.Size(161, 36);
            this.removePageBtn.TabIndex = 22;
            this.removePageBtn.Text = "Remove Page(s)";
            this.removePageBtn.UseVisualStyleBackColor = true;
            this.removePageBtn.Visible = false;
            this.removePageBtn.Click += new System.EventHandler(this.removePageBtn_Click);
            // 
            // savePathRemoveTxt
            // 
            this.savePathRemoveTxt.Depth = 0;
            this.savePathRemoveTxt.Font = new System.Drawing.Font("Verdana", 9F);
            this.savePathRemoveTxt.Hint = "Select a folder to save the output file in...";
            this.savePathRemoveTxt.Location = new System.Drawing.Point(69, 277);
            this.savePathRemoveTxt.Margin = new System.Windows.Forms.Padding(2);
            this.savePathRemoveTxt.MaxLength = 32767;
            this.savePathRemoveTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.savePathRemoveTxt.Name = "savePathRemoveTxt";
            this.savePathRemoveTxt.PasswordChar = '\0';
            this.savePathRemoveTxt.SelectedText = "";
            this.savePathRemoveTxt.SelectionLength = 0;
            this.savePathRemoveTxt.SelectionStart = 0;
            this.savePathRemoveTxt.Size = new System.Drawing.Size(437, 28);
            this.savePathRemoveTxt.TabIndex = 26;
            this.savePathRemoveTxt.TabStop = false;
            this.savePathRemoveTxt.UseSystemPasswordChar = false;
            this.savePathRemoveTxt.Visible = false;
            // 
            // openPathRemoveTxt
            // 
            this.openPathRemoveTxt.Depth = 0;
            this.openPathRemoveTxt.Font = new System.Drawing.Font("Verdana", 9F);
            this.openPathRemoveTxt.Hint = "Select a PDF...";
            this.openPathRemoveTxt.Location = new System.Drawing.Point(69, 53);
            this.openPathRemoveTxt.Margin = new System.Windows.Forms.Padding(2);
            this.openPathRemoveTxt.MaxLength = 32767;
            this.openPathRemoveTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.openPathRemoveTxt.Name = "openPathRemoveTxt";
            this.openPathRemoveTxt.PasswordChar = '\0';
            this.openPathRemoveTxt.SelectedText = "";
            this.openPathRemoveTxt.SelectionLength = 0;
            this.openPathRemoveTxt.SelectionStart = 0;
            this.openPathRemoveTxt.Size = new System.Drawing.Size(437, 28);
            this.openPathRemoveTxt.TabIndex = 24;
            this.openPathRemoveTxt.TabStop = false;
            this.openPathRemoveTxt.UseSystemPasswordChar = false;
            this.openPathRemoveTxt.TextChanged += new System.EventHandler(this.openPathRemoveTxt_TextChanged);
            // 
            // removeOpenLbl
            // 
            this.removeOpenLbl.AutoSize = true;
            this.removeOpenLbl.Font = new System.Drawing.Font("Verdana", 9.8F);
            this.removeOpenLbl.ForeColor = System.Drawing.Color.White;
            this.removeOpenLbl.Location = new System.Drawing.Point(8, 57);
            this.removeOpenLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.removeOpenLbl.Name = "removeOpenLbl";
            this.removeOpenLbl.Size = new System.Drawing.Size(59, 20);
            this.removeOpenLbl.TabIndex = 25;
            this.removeOpenLbl.Text = "open:";
            // 
            // tabSelector
            // 
            this.tabSelector.BaseTabControl = null;
            this.tabSelector.Depth = 0;
            this.tabSelector.Location = new System.Drawing.Point(14, 461);
            this.tabSelector.Margin = new System.Windows.Forms.Padding(2);
            this.tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelector.Name = "tabSelector";
            this.tabSelector.Size = new System.Drawing.Size(625, 41);
            this.tabSelector.TabIndex = 12;
            this.tabSelector.Text = "materialTabSelector1";
            // 
            // htmlPDFDialog
            // 
            this.htmlPDFDialog.DefaultExt = "PDF";
            this.htmlPDFDialog.Title = "Select PDF file";
            // 
            // saveHtmlPDFDialog
            // 
            this.saveHtmlPDFDialog.Title = "Save merged PDF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 532);
            this.Controls.Add(this.tabSelector);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Verdana", 6.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(653, 532);
            this.MinimumSize = new System.Drawing.Size(166, 84);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Toolbox v1.4.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.mergePage.ResumeLayout(false);
            this.mergePage.PerformLayout();
            this.splitPage.ResumeLayout(false);
            this.splitPage.PerformLayout();
            this.convertPage.ResumeLayout(false);
            this.createPage.ResumeLayout(false);
            this.createPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNum)).EndInit();
            this.compressPage.ResumeLayout(false);
            this.compressPage.PerformLayout();
            this.removePage.ResumeLayout(false);
            this.removePage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox pdfList;
        private System.Windows.Forms.OpenFileDialog pdfOpen;
        private System.Windows.Forms.SaveFileDialog pdfSave;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.Button downBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SaveFileDialog imageSaveDialog;
        private System.Windows.Forms.OpenFileDialog imageOpenDialog;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tectraWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubPageToolStripMenuItem;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage mergePage;
        private System.Windows.Forms.TabPage splitPage;
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private System.Windows.Forms.TabPage convertPage;
        private System.Windows.Forms.TabPage createPage;
        private MaterialSkin.Controls.MaterialFlatButton splitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField folderPathSplitTxt;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField openPathSplitTxt;
        private MaterialSkin.Controls.MaterialFlatButton openPdfBtn;
        private MaterialSkin.Controls.MaterialFlatButton openFolderBtn;
        private MaterialSkin.Controls.MaterialFlatButton addBtn;
        private MaterialSkin.Controls.MaterialFlatButton mergeBtn;
        private MaterialSkin.Controls.MaterialFlatButton clearBtn;
        private MaterialSkin.Controls.MaterialFlatButton removeBtn;
        private System.Windows.Forms.Button textFileToPDFBtn;
        private System.Windows.Forms.Button imageToPDFBtn;
        private System.Windows.Forms.Label label13;
        private MaterialSkin.Controls.MaterialFlatButton createBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown pageNum;
        private System.Windows.Forms.Button htmlBtn;
        private System.Windows.Forms.OpenFileDialog htmlPDFDialog;
        private System.Windows.Forms.SaveFileDialog saveHtmlPDFDialog;
        private System.Windows.Forms.TabPage compressPage;
        private System.Windows.Forms.Label label15;
        private MaterialSkin.Controls.MaterialFlatButton openPDFtoCompressBtn;
        private MaterialSkin.Controls.MaterialFlatButton compressedPDFsavePathBtn;
        private System.Windows.Forms.Label label18;
        private MaterialSkin.Controls.MaterialSingleLineTextField compressSaveTxt;
        private System.Windows.Forms.Label label19;
        private MaterialSkin.Controls.MaterialSingleLineTextField compressOpenTxt;
        private MaterialSkin.Controls.MaterialFlatButton compressBtn;
        private System.Windows.Forms.TabPage removePage;
        private MaterialSkin.Controls.MaterialFlatButton removeOpenButton;
        private MaterialSkin.Controls.MaterialFlatButton removeSaveBtn;
        private System.Windows.Forms.Label removeLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label removeSaveLbl;
        private MaterialSkin.Controls.MaterialFlatButton removePageBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField savePathRemoveTxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField openPathRemoveTxt;
        private System.Windows.Forms.Label removeOpenLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox pageList;
        private MaterialSkin.Controls.MaterialFlatButton openPDFtoRemovePagesBtn;
    }
}

