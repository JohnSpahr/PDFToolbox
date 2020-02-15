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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mergeBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.clearBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.removeBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.addBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openPdfBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.openFolderBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.folderPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.openPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.splitBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.htmlBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textFileToPDFBtn = new System.Windows.Forms.Button();
            this.imageToPDFBtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.label14 = new System.Windows.Forms.Label();
            this.pageNum = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.htmlPDFDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveHtmlPDFDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNum)).BeginInit();
            this.SuspendLayout();
            // 
            // pdfList
            // 
            this.pdfList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pdfList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pdfList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdfList.ForeColor = System.Drawing.Color.White;
            this.pdfList.FormattingEnabled = true;
            this.pdfList.ItemHeight = 25;
            this.pdfList.Location = new System.Drawing.Point(20, 45);
            this.pdfList.Name = "pdfList";
            this.pdfList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.pdfList.Size = new System.Drawing.Size(462, 302);
            this.pdfList.TabIndex = 0;
            this.pdfList.MouseHover += new System.EventHandler(this.listBox1_MouseHover);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "PDF";
            this.openFileDialog1.Title = "Select PDF file";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Save merged PDF";
            // 
            // upBtn
            // 
            this.upBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.upBtn.FlatAppearance.BorderSize = 0;
            this.upBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upBtn.ForeColor = System.Drawing.Color.White;
            this.upBtn.Image = ((System.Drawing.Image)(resources.GetObject("upBtn.Image")));
            this.upBtn.Location = new System.Drawing.Point(494, 45);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(48, 38);
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
            this.downBtn.Location = new System.Drawing.Point(494, 89);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(48, 38);
            this.downBtn.TabIndex = 6;
            this.downBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.downBtn.UseVisualStyleBackColor = true;
            this.downBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Merge PDF files";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 627);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tectraWebsiteToolStripMenuItem
            // 
            this.tectraWebsiteToolStripMenuItem.Name = "tectraWebsiteToolStripMenuItem";
            this.tectraWebsiteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tectraWebsiteToolStripMenuItem.Text = "Tectra Website";
            this.tectraWebsiteToolStripMenuItem.Click += new System.EventHandler(this.TectraWebsiteToolStripMenuItem_Click);
            // 
            // gitHubPageToolStripMenuItem
            // 
            this.gitHubPageToolStripMenuItem.Name = "gitHubPageToolStripMenuItem";
            this.gitHubPageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gitHubPageToolStripMenuItem.Text = "GitHub Page";
            this.gitHubPageToolStripMenuItem.Click += new System.EventHandler(this.GitHubPageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(16, 90);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(715, 469);
            this.materialTabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.mergeBtn);
            this.tabPage1.Controls.Add(this.clearBtn);
            this.tabPage1.Controls.Add(this.removeBtn);
            this.tabPage1.Controls.Add(this.addBtn);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pdfList);
            this.tabPage1.Controls.Add(this.downBtn);
            this.tabPage1.Controls.Add(this.upBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(707, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Merge";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label9.ForeColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(523, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 58);
            this.label9.TabIndex = 14;
            this.label9.Text = "quickly";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(588, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 39);
            this.label10.TabIndex = 13;
            this.label10.Text = "merge";
            // 
            // mergeBtn
            // 
            this.mergeBtn.AutoSize = true;
            this.mergeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mergeBtn.Depth = 0;
            this.mergeBtn.Icon = null;
            this.mergeBtn.Location = new System.Drawing.Point(494, 171);
            this.mergeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.clearBtn.Location = new System.Drawing.Point(182, 382);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.removeBtn.Location = new System.Drawing.Point(84, 382);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.addBtn.Location = new System.Drawing.Point(20, 382);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addBtn.Name = "addBtn";
            this.addBtn.Primary = false;
            this.addBtn.Size = new System.Drawing.Size(56, 36);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.openPdfBtn);
            this.tabPage2.Controls.Add(this.openFolderBtn);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.folderPath);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.openPath);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.splitBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(707, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Split";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label7.ForeColor = System.Drawing.Color.LightBlue;
            this.label7.Location = new System.Drawing.Point(483, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 58);
            this.label7.TabIndex = 14;
            this.label7.Text = "instantly";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(614, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 39);
            this.label8.TabIndex = 13;
            this.label8.Text = "split";
            // 
            // openPdfBtn
            // 
            this.openPdfBtn.AutoSize = true;
            this.openPdfBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openPdfBtn.Depth = 0;
            this.openPdfBtn.Icon = null;
            this.openPdfBtn.Location = new System.Drawing.Point(471, 57);
            this.openPdfBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.openFolderBtn.Location = new System.Drawing.Point(471, 127);
            this.openFolderBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "save:";
            // 
            // folderPath
            // 
            this.folderPath.Depth = 0;
            this.folderPath.Hint = "Select a folder to save the output file at...";
            this.folderPath.Location = new System.Drawing.Point(86, 135);
            this.folderPath.MaxLength = 32767;
            this.folderPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.folderPath.Name = "folderPath";
            this.folderPath.PasswordChar = '\0';
            this.folderPath.SelectedText = "";
            this.folderPath.SelectionLength = 0;
            this.folderPath.SelectionStart = 0;
            this.folderPath.Size = new System.Drawing.Size(500, 28);
            this.folderPath.TabIndex = 16;
            this.folderPath.TabStop = false;
            this.folderPath.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "open:";
            // 
            // openPath
            // 
            this.openPath.Depth = 0;
            this.openPath.Hint = "Select a PDF file to split...";
            this.openPath.Location = new System.Drawing.Point(86, 65);
            this.openPath.MaxLength = 32767;
            this.openPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.openPath.Name = "openPath";
            this.openPath.PasswordChar = '\0';
            this.openPath.SelectedText = "";
            this.openPath.SelectionLength = 0;
            this.openPath.SelectionStart = 0;
            this.openPath.Size = new System.Drawing.Size(500, 28);
            this.openPath.TabIndex = 14;
            this.openPath.TabStop = false;
            this.openPath.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Split PDF by pages";
            // 
            // splitBtn
            // 
            this.splitBtn.AutoSize = true;
            this.splitBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.splitBtn.Depth = 0;
            this.splitBtn.Icon = null;
            this.splitBtn.Location = new System.Drawing.Point(20, 213);
            this.splitBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.splitBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.splitBtn.Name = "splitBtn";
            this.splitBtn.Primary = false;
            this.splitBtn.Size = new System.Drawing.Size(68, 36);
            this.splitBtn.TabIndex = 0;
            this.splitBtn.Text = "Split";
            this.splitBtn.UseVisualStyleBackColor = true;
            this.splitBtn.Click += new System.EventHandler(this.SplitPDFToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage3.Controls.Add(this.htmlBtn);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.textFileToPDFBtn);
            this.tabPage3.Controls.Add(this.imageToPDFBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(707, 440);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Convert";
            // 
            // htmlBtn
            // 
            this.htmlBtn.FlatAppearance.BorderSize = 0;
            this.htmlBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.htmlBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.htmlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htmlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.htmlBtn.ForeColor = System.Drawing.Color.LightGray;
            this.htmlBtn.Image = ((System.Drawing.Image)(resources.GetObject("htmlBtn.Image")));
            this.htmlBtn.Location = new System.Drawing.Point(333, 24);
            this.htmlBtn.Name = "htmlBtn";
            this.htmlBtn.Size = new System.Drawing.Size(248, 176);
            this.htmlBtn.TabIndex = 4;
            this.htmlBtn.Text = "HTML to PDF";
            this.htmlBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.htmlBtn.UseVisualStyleBackColor = true;
            this.htmlBtn.Click += new System.EventHandler(this.htmlBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label6.ForeColor = System.Drawing.Color.LightGreen;
            this.label6.Location = new System.Drawing.Point(416, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 58);
            this.label6.TabIndex = 3;
            this.label6.Text = "seamlessly";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(561, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 39);
            this.label5.TabIndex = 2;
            this.label5.Text = "convert";
            // 
            // textFileToPDFBtn
            // 
            this.textFileToPDFBtn.FlatAppearance.BorderSize = 0;
            this.textFileToPDFBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.textFileToPDFBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.textFileToPDFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textFileToPDFBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.textFileToPDFBtn.ForeColor = System.Drawing.Color.LightGray;
            this.textFileToPDFBtn.Image = ((System.Drawing.Image)(resources.GetObject("textFileToPDFBtn.Image")));
            this.textFileToPDFBtn.Location = new System.Drawing.Point(19, 230);
            this.textFileToPDFBtn.Name = "textFileToPDFBtn";
            this.textFileToPDFBtn.Size = new System.Drawing.Size(248, 176);
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
            this.imageToPDFBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.imageToPDFBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageToPDFBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.imageToPDFBtn.ForeColor = System.Drawing.Color.LightGray;
            this.imageToPDFBtn.Image = ((System.Drawing.Image)(resources.GetObject("imageToPDFBtn.Image")));
            this.imageToPDFBtn.Location = new System.Drawing.Point(19, 24);
            this.imageToPDFBtn.Name = "imageToPDFBtn";
            this.imageToPDFBtn.Size = new System.Drawing.Size(248, 176);
            this.imageToPDFBtn.TabIndex = 0;
            this.imageToPDFBtn.Text = "Image to PDF";
            this.imageToPDFBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.imageToPDFBtn.UseVisualStyleBackColor = true;
            this.imageToPDFBtn.Click += new System.EventHandler(this.ImageToPDFToolStripMenuItem_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage4.Controls.Add(this.materialFlatButton1);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.pageNum);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(707, 440);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Create";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(34, 158);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(85, 36);
            this.materialFlatButton1.TabIndex = 18;
            this.materialFlatButton1.Text = "Create";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.BlankPDF);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label14.ForeColor = System.Drawing.Color.LightGray;
            this.label14.Location = new System.Drawing.Point(31, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 18);
            this.label14.TabIndex = 17;
            this.label14.Text = "Number of pages: ";
            // 
            // pageNum
            // 
            this.pageNum.Location = new System.Drawing.Point(180, 89);
            this.pageNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pageNum.Name = "pageNum";
            this.pageNum.Size = new System.Drawing.Size(97, 22);
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
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(27, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(322, 38);
            this.label13.TabIndex = 15;
            this.label13.Text = "Create a blank PDF";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label11.ForeColor = System.Drawing.Color.MediumPurple;
            this.label11.Location = new System.Drawing.Point(470, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(234, 58);
            this.label11.TabIndex = 14;
            this.label11.Text = "efficiently";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label12.ForeColor = System.Drawing.Color.LightGray;
            this.label12.Location = new System.Drawing.Point(593, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 39);
            this.label12.TabIndex = 13;
            this.label12.Text = "create";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = null;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(16, 567);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(715, 50);
            this.materialTabSelector1.TabIndex = 12;
            this.materialTabSelector1.Text = "materialTabSelector1";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 655);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.materialTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PDF Toolbox v1.3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox pdfList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
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
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialFlatButton splitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField folderPath;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField openPath;
        private MaterialSkin.Controls.MaterialFlatButton openPdfBtn;
        private MaterialSkin.Controls.MaterialFlatButton openFolderBtn;
        private MaterialSkin.Controls.MaterialFlatButton addBtn;
        private MaterialSkin.Controls.MaterialFlatButton mergeBtn;
        private MaterialSkin.Controls.MaterialFlatButton clearBtn;
        private MaterialSkin.Controls.MaterialFlatButton removeBtn;
        private System.Windows.Forms.Button textFileToPDFBtn;
        private System.Windows.Forms.Button imageToPDFBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown pageNum;
        private System.Windows.Forms.Button htmlBtn;
        private System.Windows.Forms.OpenFileDialog htmlPDFDialog;
        private System.Windows.Forms.SaveFileDialog saveHtmlPDFDialog;
    }
}

