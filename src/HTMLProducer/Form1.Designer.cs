namespace HTMLProducer
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
            this.generateCodeBtn = new System.Windows.Forms.Button();
            this.enableSEOBtn = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.keywordsInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.authorInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.fontInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bgColorInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.forceColorInput = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.marginInput = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.paddingInput = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.resetEverythingBtn = new System.Windows.Forms.Button();
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.openSideBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.instantPreviewBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateCodeBtn
            // 
            this.generateCodeBtn.Location = new System.Drawing.Point(14, 13);
            this.generateCodeBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.generateCodeBtn.Name = "generateCodeBtn";
            this.generateCodeBtn.Size = new System.Drawing.Size(377, 30);
            this.generateCodeBtn.TabIndex = 0;
            this.generateCodeBtn.Text = "Generate Code";
            this.generateCodeBtn.UseVisualStyleBackColor = true;
            this.generateCodeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // enableSEOBtn
            // 
            this.enableSEOBtn.AutoSize = true;
            this.enableSEOBtn.Location = new System.Drawing.Point(14, 49);
            this.enableSEOBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.enableSEOBtn.Name = "enableSEOBtn";
            this.enableSEOBtn.Size = new System.Drawing.Size(61, 18);
            this.enableSEOBtn.TabIndex = 1;
            this.enableSEOBtn.Text = "+ SEO";
            this.enableSEOBtn.UseVisualStyleBackColor = true;
            this.enableSEOBtn.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.keywordsInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.descInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.titleInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.authorInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(14, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(363, 188);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEO Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(370, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(260, 188);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SEO Options";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(214, 115);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(138, 66);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "Seperated by comma ,";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Keywords";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(214, 21);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(138, 88);
            this.textBox6.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 14);
            this.label6.TabIndex = 4;
            this.label6.Text = "Descripiton";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(55, 49);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(70, 22);
            this.textBox7.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "Title";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(55, 21);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(70, 22);
            this.textBox8.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Author";
            // 
            // keywordsInput
            // 
            this.keywordsInput.Location = new System.Drawing.Point(8, 115);
            this.keywordsInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.keywordsInput.Multiline = true;
            this.keywordsInput.Name = "keywordsInput";
            this.keywordsInput.Size = new System.Drawing.Size(344, 66);
            this.keywordsInput.TabIndex = 7;
            this.keywordsInput.Text = "Seperated by comma ,";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Keywords";
            // 
            // descInput
            // 
            this.descInput.Location = new System.Drawing.Point(214, 21);
            this.descInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.descInput.Multiline = true;
            this.descInput.Name = "descInput";
            this.descInput.Size = new System.Drawing.Size(138, 88);
            this.descInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Desc";
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(55, 49);
            this.titleInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(109, 22);
            this.titleInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // authorInput
            // 
            this.authorInput.Location = new System.Drawing.Point(55, 21);
            this.authorInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.authorInput.Name = "authorInput";
            this.authorInput.Size = new System.Drawing.Size(109, 22);
            this.authorInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 14);
            this.label9.TabIndex = 9;
            this.label9.Text = "Font";
            // 
            // fontInput
            // 
            this.fontInput.Location = new System.Drawing.Point(48, 21);
            this.fontInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fontInput.Name = "fontInput";
            this.fontInput.Size = new System.Drawing.Size(175, 22);
            this.fontInput.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 14);
            this.label10.TabIndex = 11;
            this.label10.Text = "BGColor";
            // 
            // bgColorInput
            // 
            this.bgColorInput.Location = new System.Drawing.Point(71, 50);
            this.bgColorInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bgColorInput.Name = "bgColorInput";
            this.bgColorInput.Size = new System.Drawing.Size(148, 22);
            this.bgColorInput.TabIndex = 12;
            this.bgColorInput.Text = "#ffffff";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 81);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 14);
            this.label11.TabIndex = 13;
            this.label11.Text = "FColor";
            // 
            // forceColorInput
            // 
            this.forceColorInput.Location = new System.Drawing.Point(66, 78);
            this.forceColorInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.forceColorInput.Name = "forceColorInput";
            this.forceColorInput.Size = new System.Drawing.Size(148, 22);
            this.forceColorInput.TabIndex = 14;
            this.forceColorInput.Text = "#000000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 109);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 14);
            this.label13.TabIndex = 17;
            this.label13.Text = "Margin";
            // 
            // marginInput
            // 
            this.marginInput.Location = new System.Drawing.Point(71, 106);
            this.marginInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.marginInput.Name = "marginInput";
            this.marginInput.Size = new System.Drawing.Size(148, 22);
            this.marginInput.TabIndex = 18;
            this.marginInput.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 135);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 14);
            this.label14.TabIndex = 19;
            this.label14.Text = "Padding";
            // 
            // paddingInput
            // 
            this.paddingInput.Location = new System.Drawing.Point(74, 133);
            this.paddingInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.paddingInput.Name = "paddingInput";
            this.paddingInput.Size = new System.Drawing.Size(148, 22);
            this.paddingInput.TabIndex = 20;
            this.paddingInput.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.paddingInput);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.marginInput);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.forceColorInput);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.bgColorInput);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.fontInput);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(395, 89);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(242, 188);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Site Options";
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(281, 18);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BookmarkColor = System.Drawing.Color.Black;
            this.fastColoredTextBox1.CharHeight = 18;
            this.fastColoredTextBox1.CharWidth = 9;
            this.fastColoredTextBox1.CommentPrefix = null;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.FoldingIndicatorColor = System.Drawing.Color.LawnGreen;
            this.fastColoredTextBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML;
            this.fastColoredTextBox1.LeftBracket = '<';
            this.fastColoredTextBox1.LeftBracket2 = '(';
            this.fastColoredTextBox1.Location = new System.Drawing.Point(13, 282);
            this.fastColoredTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.RightBracket = '>';
            this.fastColoredTextBox1.RightBracket2 = ')';
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(623, 328);
            this.fastColoredTextBox1.TabIndex = 10;
            this.fastColoredTextBox1.Text = "<!-- Generated code here -->";
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // resetEverythingBtn
            // 
            this.resetEverythingBtn.Location = new System.Drawing.Point(398, 13);
            this.resetEverythingBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resetEverythingBtn.Name = "resetEverythingBtn";
            this.resetEverythingBtn.Size = new System.Drawing.Size(239, 30);
            this.resetEverythingBtn.TabIndex = 11;
            this.resetEverythingBtn.Text = "Reset Everything";
            this.resetEverythingBtn.UseVisualStyleBackColor = true;
            this.resetEverythingBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "Windows Metro (Blue).vssf");
            // 
            // openSideBtn
            // 
            this.openSideBtn.Location = new System.Drawing.Point(398, 49);
            this.openSideBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openSideBtn.Name = "openSideBtn";
            this.openSideBtn.Size = new System.Drawing.Size(239, 33);
            this.openSideBtn.TabIndex = 12;
            this.openSideBtn.Text = "Open Side";
            this.openSideBtn.UseVisualStyleBackColor = true;
            this.openSideBtn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // instantPreviewBtn
            // 
            this.instantPreviewBtn.Location = new System.Drawing.Point(654, 12);
            this.instantPreviewBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.instantPreviewBtn.Name = "instantPreviewBtn";
            this.instantPreviewBtn.Size = new System.Drawing.Size(126, 39);
            this.instantPreviewBtn.TabIndex = 14;
            this.instantPreviewBtn.Text = "INSTANT BROWSER PREVIEW";
            this.instantPreviewBtn.UseVisualStyleBackColor = true;
            this.instantPreviewBtn.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 631);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(651, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 653);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.instantPreviewBtn);
            this.Controls.Add(this.openSideBtn);
            this.Controls.Add(this.resetEverythingBtn);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.enableSEOBtn);
            this.Controls.Add(this.generateCodeBtn);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "HTMLProducer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateCodeBtn;
        private System.Windows.Forms.CheckBox enableSEOBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox authorInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox keywordsInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fontInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bgColorInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox forceColorInput;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox marginInput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox paddingInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.Button resetEverythingBtn;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.Button openSideBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button instantPreviewBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

