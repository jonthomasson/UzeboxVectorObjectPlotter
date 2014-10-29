namespace VectorObjectPlotter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnLinkEnds = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.showGrid5 = new System.Windows.Forms.ToolStripMenuItem();
            this.showGrid10 = new System.Windows.Forms.ToolStripMenuItem();
            this.showGrid15 = new System.Windows.Forms.ToolStripMenuItem();
            this.showGrid20 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToggleXY = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.canvasWidth = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.canvasHeight = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrentPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkLineBreak = new System.Windows.Forms.CheckBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.btnPasteFromClipboard = new System.Windows.Forms.ToolStripButton();
            this.btnCopyToClipboard = new System.Windows.Forms.ToolStripButton();
            this.btnSync = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.cboExportFormat = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1750, 1029);
            this.splitContainer1.SplitterDistance = 33;
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClear,
            this.btnUndo,
            this.btnLinkEnds,
            this.toolStripDropDownButton2,
            this.btnToggleXY,
            this.toolStripButton1,
            this.btnZoomIn,
            this.btnZoomOut,
            this.toolStripLabel1,
            this.canvasWidth,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.canvasHeight,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1750, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(23, 36);
            this.btnClear.Text = "Delete Object";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(23, 36);
            this.btnUndo.Text = "Undo Last Grid Change";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnLinkEnds
            // 
            this.btnLinkEnds.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLinkEnds.Image = ((System.Drawing.Image)(resources.GetObject("btnLinkEnds.Image")));
            this.btnLinkEnds.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLinkEnds.Name = "btnLinkEnds";
            this.btnLinkEnds.Size = new System.Drawing.Size(23, 36);
            this.btnLinkEnds.Text = "Link Ends Together";
            this.btnLinkEnds.Click += new System.EventHandler(this.btnLinkEnds_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGrid5,
            this.showGrid10,
            this.showGrid15,
            this.showGrid20});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 36);
            this.toolStripDropDownButton2.Text = "Show Grid Lines";
            this.toolStripDropDownButton2.ToolTipText = "Show Grid Lines";
            // 
            // showGrid5
            // 
            this.showGrid5.Name = "showGrid5";
            this.showGrid5.Size = new System.Drawing.Size(141, 36);
            this.showGrid5.Text = "5px";
            this.showGrid5.Click += new System.EventHandler(this.showGrid5_Click);
            // 
            // showGrid10
            // 
            this.showGrid10.Name = "showGrid10";
            this.showGrid10.Size = new System.Drawing.Size(141, 36);
            this.showGrid10.Text = "10px";
            this.showGrid10.Click += new System.EventHandler(this.showGrid10_Click);
            // 
            // showGrid15
            // 
            this.showGrid15.Name = "showGrid15";
            this.showGrid15.Size = new System.Drawing.Size(141, 36);
            this.showGrid15.Text = "15px";
            this.showGrid15.Click += new System.EventHandler(this.showGrid15_Click);
            // 
            // showGrid20
            // 
            this.showGrid20.Name = "showGrid20";
            this.showGrid20.Size = new System.Drawing.Size(141, 36);
            this.showGrid20.Text = "20px";
            this.showGrid20.Click += new System.EventHandler(this.showGrid20_Click);
            // 
            // btnToggleXY
            // 
            this.btnToggleXY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToggleXY.Image = ((System.Drawing.Image)(resources.GetObject("btnToggleXY.Image")));
            this.btnToggleXY.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToggleXY.Name = "btnToggleXY";
            this.btnToggleXY.Size = new System.Drawing.Size(23, 36);
            this.btnToggleXY.Text = "Toggle X and Y Axis Lines";
            this.btnToggleXY.Click += new System.EventHandler(this.btnToggleXY_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 36);
            this.toolStripButton1.Text = "Toggle Coordinates";
            this.toolStripButton1.Click += new System.EventHandler(this.btnShowCoords_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
            this.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(23, 36);
            this.btnZoomIn.Text = "Zoom In";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
            this.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(23, 36);
            this.btnZoomOut.Text = "Zoom Out";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(161, 36);
            this.toolStripLabel1.Text = "Canvas Width";
            // 
            // canvasWidth
            // 
            this.canvasWidth.Name = "canvasWidth";
            this.canvasWidth.Size = new System.Drawing.Size(100, 39);
            this.canvasWidth.Text = "256";
            this.canvasWidth.ToolTipText = "Canvas Width";
            this.canvasWidth.KeyUp += new System.Windows.Forms.KeyEventHandler(this.canvasWidth_KeyPress);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(40, 36);
            this.toolStripLabel2.Text = "px";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(169, 36);
            this.toolStripLabel3.Text = "Canvas Height";
            // 
            // canvasHeight
            // 
            this.canvasHeight.Name = "canvasHeight";
            this.canvasHeight.Size = new System.Drawing.Size(100, 39);
            this.canvasHeight.Text = "256";
            this.canvasHeight.ToolTipText = "Canvas Height";
            this.canvasHeight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.canvasHeight_KeyUp);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(40, 36);
            this.toolStripLabel4.Text = "px";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Panel1.Controls.Add(this.statusStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.chkLineBreak);
            this.splitContainer2.Panel2.Controls.Add(this.rtbOutput);
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer2.Panel2MinSize = 200;
            this.splitContainer2.Size = new System.Drawing.Size(1750, 992);
            this.splitContainer2.SplitterDistance = 555;
            this.splitContainer2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pbCanvas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1750, 518);
            this.panel1.TabIndex = 4;
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.White;
            this.pbCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCanvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbCanvas.Location = new System.Drawing.Point(741, 146);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(310, 318);
            this.pbCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCanvas.TabIndex = 3;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Click += new System.EventHandler(this.pbCanvas_Click);
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            this.pbCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbCanvas_MouseMove);
            
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblCurrentPosition});
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1750, 37);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(192, 32);
            this.toolStripStatusLabel1.Text = "Current Position:";
            // 
            // lblCurrentPosition
            // 
            this.lblCurrentPosition.Name = "lblCurrentPosition";
            this.lblCurrentPosition.Size = new System.Drawing.Size(0, 32);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(897, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 3;
            // 
            // chkLineBreak
            // 
            this.chkLineBreak.AutoSize = true;
            this.chkLineBreak.Location = new System.Drawing.Point(1603, 11);
            this.chkLineBreak.Name = "chkLineBreak";
            this.chkLineBreak.Size = new System.Drawing.Size(147, 29);
            this.chkLineBreak.TabIndex = 2;
            this.chkLineBreak.Text = "Line Break";
            this.chkLineBreak.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chkLineBreak.UseVisualStyleBackColor = true;
            this.chkLineBreak.CheckedChanged += new System.EventHandler(this.chkLineBreak_CheckedChanged);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbOutput.Location = new System.Drawing.Point(0, 40);
            this.rtbOutput.MinimumSize = new System.Drawing.Size(4, 300);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(1750, 393);
            this.rtbOutput.TabIndex = 1;
            this.rtbOutput.Text = "";
            this.rtbOutput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbOutput_KeyUp);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel6,
            this.btnPasteFromClipboard,
            this.btnCopyToClipboard,
            this.btnSync,
            this.toolStripLabel5,
            this.cboExportFormat,
            this.toolStripLabel7,
            this.toolStripTextBox3});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1750, 40);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "Regex";
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(193, 37);
            this.toolStripLabel6.Text = "Output Options";
            // 
            // btnPasteFromClipboard
            // 
            this.btnPasteFromClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPasteFromClipboard.Image = ((System.Drawing.Image)(resources.GetObject("btnPasteFromClipboard.Image")));
            this.btnPasteFromClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPasteFromClipboard.Name = "btnPasteFromClipboard";
            this.btnPasteFromClipboard.Size = new System.Drawing.Size(23, 37);
            this.btnPasteFromClipboard.Text = "Paste From Clipboard";
            this.btnPasteFromClipboard.Click += new System.EventHandler(this.btnPasteFromClipboard_Click);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCopyToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyToClipboard.Image")));
            this.btnCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(23, 37);
            this.btnCopyToClipboard.Text = "Copy To Clipboard";
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnSync
            // 
            this.btnSync.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSync.Image = ((System.Drawing.Image)(resources.GetObject("btnSync.Image")));
            this.btnSync.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(23, 37);
            this.btnSync.Text = "Sync Changes To Grid (NOTE: must keep <x> and <y> variables to show appropriate x" +
    " and y coordinate.)";
            this.btnSync.ToolTipText = "Sync Changes To Grid (NOTE: must keep <x> and <y> variables to show appropriate x" +
    " and y coordinate.)";
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(244, 37);
            this.toolStripLabel5.Text = "Import/Export Format";
            // 
            // cboExportFormat
            // 
            this.cboExportFormat.Items.AddRange(new object[] {
            "Cartesian (x, y)",
            "Polar (r, θ)"});
            this.cboExportFormat.Name = "cboExportFormat";
            this.cboExportFormat.Size = new System.Drawing.Size(127, 40);
            this.cboExportFormat.ToolTipText = "Export Format";
            this.cboExportFormat.SelectedIndexChanged += new System.EventHandler(this.cboExportFormat_SelectedIndexChanged);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(91, 37);
            this.toolStripLabel7.Text = "Pattern";
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(150, 40);
            this.toolStripTextBox3.Text = "{ <x>, <y> },";
            this.toolStripTextBox3.ToolTipText = "The format the x and y coords will appear in. ";
            this.toolStripTextBox3.TextChanged += new System.EventHandler(this.toolStripTextBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 1029);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Uzebox Vector Object Plotter";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        

      

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripComboBox cboExportFormat;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentPosition;
        private System.Windows.Forms.ToolStripButton btnPasteFromClipboard;
        private System.Windows.Forms.ToolStripButton btnSync;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripButton btnLinkEnds;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem showGrid5;
        private System.Windows.Forms.ToolStripMenuItem showGrid10;
        private System.Windows.Forms.ToolStripMenuItem showGrid15;
        private System.Windows.Forms.ToolStripMenuItem showGrid20;
        private System.Windows.Forms.ToolStripButton btnToggleXY;
        private System.Windows.Forms.ToolStripButton btnZoomIn;
        private System.Windows.Forms.ToolStripButton btnZoomOut;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox canvasWidth;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox canvasHeight;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton btnCopyToClipboard;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkLineBreak;
        private System.Windows.Forms.Label label1;

    }
}

