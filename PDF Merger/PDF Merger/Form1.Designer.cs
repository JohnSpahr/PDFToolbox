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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.removeBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.mergeBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.upBtn = new System.Windows.Forms.Button();
            this.downBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextToPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tectraWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.textToPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Location = new System.Drawing.Point(13, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(462, 328);
            this.listBox1.TabIndex = 0;
            // 
            // addBtn
            // 
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Open Sans", 10F);
            this.addBtn.Location = new System.Drawing.Point(239, 417);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(107, 38);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.toolTip1.SetToolTip(this.addBtn, "Adds a new PDF file to the list.");
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "PDF";
            this.openFileDialog1.Title = "Select PDF file";
            // 
            // removeBtn
            // 
            this.removeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.removeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.removeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Open Sans", 10F);
            this.removeBtn.Location = new System.Drawing.Point(126, 417);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(107, 38);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Remove";
            this.toolTip1.SetToolTip(this.removeBtn, "Removes the selected item(s).");
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Open Sans", 10F);
            this.clearBtn.Location = new System.Drawing.Point(13, 417);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(107, 38);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "Clear";
            this.toolTip1.SetToolTip(this.clearBtn, "Clears all of the contents in the list above.");
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // mergeBtn
            // 
            this.mergeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.mergeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.mergeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.mergeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mergeBtn.Font = new System.Drawing.Font("Open Sans", 11F);
            this.mergeBtn.Location = new System.Drawing.Point(482, 178);
            this.mergeBtn.Name = "mergeBtn";
            this.mergeBtn.Size = new System.Drawing.Size(179, 82);
            this.mergeBtn.TabIndex = 4;
            this.mergeBtn.Text = "Merge PDF Files";
            this.toolTip1.SetToolTip(this.mergeBtn, "Merges the selected PDF files.");
            this.mergeBtn.UseVisualStyleBackColor = true;
            this.mergeBtn.Click += new System.EventHandler(this.MergeBtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Save merged PDF";
            // 
            // upBtn
            // 
            this.upBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.upBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.upBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.upBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upBtn.Image = ((System.Drawing.Image)(resources.GetObject("upBtn.Image")));
            this.upBtn.Location = new System.Drawing.Point(478, 72);
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
            this.downBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.downBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.downBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downBtn.Image = ((System.Drawing.Image)(resources.GetObject("downBtn.Image")));
            this.downBtn.Location = new System.Drawing.Point(478, 116);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(48, 38);
            this.downBtn.TabIndex = 6;
            this.downBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.downBtn.UseVisualStyleBackColor = true;
            this.downBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 8F);
            this.label1.Location = new System.Drawing.Point(572, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Version 1.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Merge PDF Files";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.convertToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToPDFToolStripMenuItem,
            this.splitPDFToolStripMenuItem,
            this.richTextToPDFToolStripMenuItem,
            this.textToPDFToolStripMenuItem});
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.convertToolStripMenuItem.Text = "Tools";
            // 
            // imageToPDFToolStripMenuItem
            // 
            this.imageToPDFToolStripMenuItem.Name = "imageToPDFToolStripMenuItem";
            this.imageToPDFToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.imageToPDFToolStripMenuItem.Text = "Image to PDF";
            this.imageToPDFToolStripMenuItem.Click += new System.EventHandler(this.ImageToPDFToolStripMenuItem_Click);
            // 
            // splitPDFToolStripMenuItem
            // 
            this.splitPDFToolStripMenuItem.Name = "splitPDFToolStripMenuItem";
            this.splitPDFToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.splitPDFToolStripMenuItem.Text = "Split PDF by pages";
            this.splitPDFToolStripMenuItem.Click += new System.EventHandler(this.SplitPDFToolStripMenuItem_Click);
            // 
            // richTextToPDFToolStripMenuItem
            // 
            this.richTextToPDFToolStripMenuItem.Name = "richTextToPDFToolStripMenuItem";
            this.richTextToPDFToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.richTextToPDFToolStripMenuItem.Text = "Create blank PDF";
            this.richTextToPDFToolStripMenuItem.Click += new System.EventHandler(this.RichTextToPDFToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tectraWebsiteToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tectraWebsiteToolStripMenuItem
            // 
            this.tectraWebsiteToolStripMenuItem.Name = "tectraWebsiteToolStripMenuItem";
            this.tectraWebsiteToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.tectraWebsiteToolStripMenuItem.Text = "Tectra Website";
            this.tectraWebsiteToolStripMenuItem.Click += new System.EventHandler(this.TectraWebsiteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // textToPDFToolStripMenuItem
            // 
            this.textToPDFToolStripMenuItem.Name = "textToPDFToolStripMenuItem";
            this.textToPDFToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.textToPDFToolStripMenuItem.Text = "Text file to PDF";
            this.textToPDFToolStripMenuItem.Click += new System.EventHandler(this.TextToPDFToolStripMenuItem_Click);
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 468);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.upBtn);
            this.Controls.Add(this.mergeBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PDF Toolbox v1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button mergeBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.Button downBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem imageToPDFToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ToolStripMenuItem splitPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem richTextToPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tectraWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

