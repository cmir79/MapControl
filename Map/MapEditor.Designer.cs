namespace Map
{
    partial class MapEditor
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panButtons = new System.Windows.Forms.Panel();
            this.btnFunc2 = new System.Windows.Forms.Button();
            this.btnFunc1 = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnLoadMap = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnSelAll = new System.Windows.Forms.Button();
            this.panPara = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.chkVisTri = new System.Windows.Forms.CheckBox();
            this.chkVisIdx = new System.Windows.Forms.CheckBox();
            this.chkVisLabel = new System.Windows.Forms.CheckBox();
            this.cbDirection = new System.Windows.Forms.ComboBox();
            this.numFilRow = new System.Windows.Forms.NumericUpDown();
            this.numFilCol = new System.Windows.Forms.NumericUpDown();
            this.numSegRow = new System.Windows.Forms.NumericUpDown();
            this.numSegCol = new System.Windows.Forms.NumericUpDown();
            this.numItemRow = new System.Windows.Forms.NumericUpDown();
            this.numItemCol = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mapControl = new Map.MapControl();
            this.panButtons.SuspendLayout();
            this.panPara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFilRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFilCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItemRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItemCol)).BeginInit();
            this.SuspendLayout();
            // 
            // panButtons
            // 
            this.panButtons.Controls.Add(this.btnFunc2);
            this.panButtons.Controls.Add(this.btnFunc1);
            this.panButtons.Controls.Add(this.btnLoadFromFile);
            this.panButtons.Controls.Add(this.btnSaveToFile);
            this.panButtons.Controls.Add(this.btnLoadMap);
            this.panButtons.Controls.Add(this.btnInverse);
            this.panButtons.Controls.Add(this.btnSelAll);
            this.panButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panButtons.Location = new System.Drawing.Point(0, 0);
            this.panButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(800, 50);
            this.panButtons.TabIndex = 1;
            // 
            // btnFunc2
            // 
            this.btnFunc2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFunc2.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFunc2.ForeColor = System.Drawing.Color.White;
            this.btnFunc2.Location = new System.Drawing.Point(660, 0);
            this.btnFunc2.Name = "btnFunc2";
            this.btnFunc2.Size = new System.Drawing.Size(110, 50);
            this.btnFunc2.TabIndex = 5;
            this.btnFunc2.Text = "Func2";
            this.btnFunc2.UseVisualStyleBackColor = false;
            this.btnFunc2.Visible = false;
            this.btnFunc2.Click += new System.EventHandler(this.btnFunc2_Click);
            // 
            // btnFunc1
            // 
            this.btnFunc1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnFunc1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFunc1.ForeColor = System.Drawing.Color.White;
            this.btnFunc1.Location = new System.Drawing.Point(550, 0);
            this.btnFunc1.Name = "btnFunc1";
            this.btnFunc1.Size = new System.Drawing.Size(110, 50);
            this.btnFunc1.TabIndex = 4;
            this.btnFunc1.Text = "Func1";
            this.btnFunc1.UseVisualStyleBackColor = false;
            this.btnFunc1.Visible = false;
            this.btnFunc1.Click += new System.EventHandler(this.btnFunc1_Click);
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLoadFromFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoadFromFile.ForeColor = System.Drawing.Color.White;
            this.btnLoadFromFile.Location = new System.Drawing.Point(440, 0);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(110, 50);
            this.btnLoadFromFile.TabIndex = 7;
            this.btnLoadFromFile.Text = "Load from File";
            this.btnLoadFromFile.UseVisualStyleBackColor = false;
            this.btnLoadFromFile.Visible = false;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSaveToFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSaveToFile.ForeColor = System.Drawing.Color.White;
            this.btnSaveToFile.Location = new System.Drawing.Point(330, 0);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(110, 50);
            this.btnSaveToFile.TabIndex = 6;
            this.btnSaveToFile.Text = "Save to File";
            this.btnSaveToFile.UseVisualStyleBackColor = false;
            this.btnSaveToFile.Visible = false;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnLoadMap
            // 
            this.btnLoadMap.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLoadMap.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoadMap.ForeColor = System.Drawing.Color.White;
            this.btnLoadMap.Location = new System.Drawing.Point(220, 0);
            this.btnLoadMap.Name = "btnLoadMap";
            this.btnLoadMap.Size = new System.Drawing.Size(110, 50);
            this.btnLoadMap.TabIndex = 3;
            this.btnLoadMap.Text = "Load Last Map";
            this.btnLoadMap.UseVisualStyleBackColor = false;
            this.btnLoadMap.Click += new System.EventHandler(this.btnLoadMap_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnInverse.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInverse.ForeColor = System.Drawing.Color.White;
            this.btnInverse.Location = new System.Drawing.Point(110, 0);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(110, 50);
            this.btnInverse.TabIndex = 2;
            this.btnInverse.Text = "Inverse";
            this.btnInverse.UseVisualStyleBackColor = false;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // btnSelAll
            // 
            this.btnSelAll.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSelAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelAll.ForeColor = System.Drawing.Color.White;
            this.btnSelAll.Location = new System.Drawing.Point(0, 0);
            this.btnSelAll.Name = "btnSelAll";
            this.btnSelAll.Size = new System.Drawing.Size(110, 50);
            this.btnSelAll.TabIndex = 0;
            this.btnSelAll.Text = "Select All";
            this.btnSelAll.UseVisualStyleBackColor = false;
            this.btnSelAll.Click += new System.EventHandler(this.btnSelAll_Click);
            // 
            // panPara
            // 
            this.panPara.Controls.Add(this.label9);
            this.panPara.Controls.Add(this.chkVisTri);
            this.panPara.Controls.Add(this.chkVisIdx);
            this.panPara.Controls.Add(this.chkVisLabel);
            this.panPara.Controls.Add(this.cbDirection);
            this.panPara.Controls.Add(this.numFilRow);
            this.panPara.Controls.Add(this.numFilCol);
            this.panPara.Controls.Add(this.numSegRow);
            this.panPara.Controls.Add(this.numSegCol);
            this.panPara.Controls.Add(this.numItemRow);
            this.panPara.Controls.Add(this.numItemCol);
            this.panPara.Controls.Add(this.label8);
            this.panPara.Controls.Add(this.label7);
            this.panPara.Controls.Add(this.label5);
            this.panPara.Controls.Add(this.label3);
            this.panPara.Controls.Add(this.label6);
            this.panPara.Controls.Add(this.label4);
            this.panPara.Controls.Add(this.label2);
            this.panPara.Controls.Add(this.label1);
            this.panPara.Dock = System.Windows.Forms.DockStyle.Right;
            this.panPara.Location = new System.Drawing.Point(600, 50);
            this.panPara.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panPara.Name = "panPara";
            this.panPara.Size = new System.Drawing.Size(200, 450);
            this.panPara.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(0, 420);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 30);
            this.label9.TabIndex = 5;
            this.label9.Text = "LEFT CLICK : USE\r\nRIGTH CLICK : NOTUSE\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkVisTri
            // 
            this.chkVisTri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkVisTri.BackColor = System.Drawing.Color.SlateGray;
            this.chkVisTri.ForeColor = System.Drawing.Color.White;
            this.chkVisTri.Location = new System.Drawing.Point(0, 275);
            this.chkVisTri.Margin = new System.Windows.Forms.Padding(0);
            this.chkVisTri.Name = "chkVisTri";
            this.chkVisTri.Size = new System.Drawing.Size(200, 23);
            this.chkVisTri.TabIndex = 4;
            this.chkVisTri.Tag = "2";
            this.chkVisTri.Text = "Visible Trigger Number";
            this.chkVisTri.UseVisualStyleBackColor = false;
            this.chkVisTri.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // chkVisIdx
            // 
            this.chkVisIdx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkVisIdx.BackColor = System.Drawing.Color.SlateGray;
            this.chkVisIdx.ForeColor = System.Drawing.Color.White;
            this.chkVisIdx.Location = new System.Drawing.Point(0, 252);
            this.chkVisIdx.Margin = new System.Windows.Forms.Padding(0);
            this.chkVisIdx.Name = "chkVisIdx";
            this.chkVisIdx.Size = new System.Drawing.Size(200, 23);
            this.chkVisIdx.TabIndex = 4;
            this.chkVisIdx.Tag = "1";
            this.chkVisIdx.Text = "Visible Index";
            this.chkVisIdx.UseVisualStyleBackColor = false;
            this.chkVisIdx.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // chkVisLabel
            // 
            this.chkVisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkVisLabel.BackColor = System.Drawing.Color.SlateGray;
            this.chkVisLabel.ForeColor = System.Drawing.Color.White;
            this.chkVisLabel.Location = new System.Drawing.Point(0, 229);
            this.chkVisLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.chkVisLabel.Name = "chkVisLabel";
            this.chkVisLabel.Size = new System.Drawing.Size(200, 23);
            this.chkVisLabel.TabIndex = 4;
            this.chkVisLabel.Tag = "0";
            this.chkVisLabel.Text = "Visible Label";
            this.chkVisLabel.UseVisualStyleBackColor = false;
            this.chkVisLabel.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbDirection
            // 
            this.cbDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDirection.FormattingEnabled = true;
            this.cbDirection.Location = new System.Drawing.Point(0, 196);
            this.cbDirection.Margin = new System.Windows.Forms.Padding(0);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(200, 23);
            this.cbDirection.TabIndex = 3;
            this.cbDirection.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // numFilRow
            // 
            this.numFilRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numFilRow.Location = new System.Drawing.Point(135, 140);
            this.numFilRow.Margin = new System.Windows.Forms.Padding(0);
            this.numFilRow.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numFilRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFilRow.Name = "numFilRow";
            this.numFilRow.Size = new System.Drawing.Size(65, 23);
            this.numFilRow.TabIndex = 2;
            this.numFilRow.Tag = "5";
            this.numFilRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFilRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFilRow.ValueChanged += new System.EventHandler(this.nummeric_ValueChanged);
            // 
            // numFilCol
            // 
            this.numFilCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numFilCol.Location = new System.Drawing.Point(135, 117);
            this.numFilCol.Margin = new System.Windows.Forms.Padding(0);
            this.numFilCol.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numFilCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFilCol.Name = "numFilCol";
            this.numFilCol.Size = new System.Drawing.Size(65, 23);
            this.numFilCol.TabIndex = 2;
            this.numFilCol.Tag = "4";
            this.numFilCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFilCol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFilCol.ValueChanged += new System.EventHandler(this.nummeric_ValueChanged);
            // 
            // numSegRow
            // 
            this.numSegRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSegRow.Location = new System.Drawing.Point(135, 94);
            this.numSegRow.Margin = new System.Windows.Forms.Padding(0);
            this.numSegRow.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSegRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSegRow.Name = "numSegRow";
            this.numSegRow.Size = new System.Drawing.Size(65, 23);
            this.numSegRow.TabIndex = 2;
            this.numSegRow.Tag = "3";
            this.numSegRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSegRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSegRow.ValueChanged += new System.EventHandler(this.nummeric_ValueChanged);
            // 
            // numSegCol
            // 
            this.numSegCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSegCol.Location = new System.Drawing.Point(135, 71);
            this.numSegCol.Margin = new System.Windows.Forms.Padding(0);
            this.numSegCol.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSegCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSegCol.Name = "numSegCol";
            this.numSegCol.Size = new System.Drawing.Size(65, 23);
            this.numSegCol.TabIndex = 2;
            this.numSegCol.Tag = "2";
            this.numSegCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSegCol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSegCol.ValueChanged += new System.EventHandler(this.nummeric_ValueChanged);
            // 
            // numItemRow
            // 
            this.numItemRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numItemRow.Location = new System.Drawing.Point(135, 48);
            this.numItemRow.Margin = new System.Windows.Forms.Padding(0);
            this.numItemRow.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numItemRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numItemRow.Name = "numItemRow";
            this.numItemRow.Size = new System.Drawing.Size(65, 23);
            this.numItemRow.TabIndex = 2;
            this.numItemRow.Tag = "1";
            this.numItemRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numItemRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numItemRow.ValueChanged += new System.EventHandler(this.nummeric_ValueChanged);
            // 
            // numItemCol
            // 
            this.numItemCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numItemCol.Location = new System.Drawing.Point(135, 25);
            this.numItemCol.Margin = new System.Windows.Forms.Padding(0);
            this.numItemCol.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numItemCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numItemCol.Name = "numItemCol";
            this.numItemCol.Size = new System.Drawing.Size(65, 23);
            this.numItemCol.TabIndex = 2;
            this.numItemCol.Tag = "0";
            this.numItemCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numItemCol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numItemCol.ValueChanged += new System.EventHandler(this.nummeric_ValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.BackColor = System.Drawing.Color.SlateGray;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Map Direction";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.SlateGray;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "[EA] Fill Count Y";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.SlateGray;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "[EA] Segment Count Y";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.SlateGray;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "[EA] Item Count Y";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.SlateGray;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "[EA] Fill Count X";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.SlateGray;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "[EA] Segment Count X";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.SlateGray;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "[EA] Item Count X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Strip Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mapControl
            // 
            this.mapControl.BackColor = System.Drawing.Color.Black;
            this.mapControl.BorderSize = 1;
            this.mapControl.CellLineWidth = 1;
            this.mapControl.Color_Active = System.Drawing.Color.Blue;
            this.mapControl.Color_Border = System.Drawing.Color.Transparent;
            this.mapControl.Color_Good = System.Drawing.Color.Lime;
            this.mapControl.Color_Header = System.Drawing.Color.White;
            this.mapControl.Color_ItemBorder = System.Drawing.Color.Transparent;
            this.mapControl.Color_NotUse = System.Drawing.Color.White;
            this.mapControl.Color_Ready = System.Drawing.Color.Lime;
            this.mapControl.Color_Res01 = System.Drawing.Color.Red;
            this.mapControl.Color_Res02 = System.Drawing.Color.Black;
            this.mapControl.Color_Res03 = System.Drawing.Color.Yellow;
            this.mapControl.Color_Res04 = System.Drawing.Color.Purple;
            this.mapControl.Color_Res05 = System.Drawing.Color.Orange;
            this.mapControl.Color_Res06 = System.Drawing.Color.Red;
            this.mapControl.Color_Res07 = System.Drawing.Color.Black;
            this.mapControl.Color_Res08 = System.Drawing.Color.Yellow;
            this.mapControl.Color_Res09 = System.Drawing.Color.Purple;
            this.mapControl.Color_Res10 = System.Drawing.Color.Orange;
            this.mapControl.Color_Res11 = System.Drawing.Color.Red;
            this.mapControl.Color_Res12 = System.Drawing.Color.Black;
            this.mapControl.Color_Res13 = System.Drawing.Color.Yellow;
            this.mapControl.Color_Res14 = System.Drawing.Color.Purple;
            this.mapControl.Color_Res15 = System.Drawing.Color.Orange;
            this.mapControl.Color_Res16 = System.Drawing.Color.Red;
            this.mapControl.Color_Selected = System.Drawing.Color.Red;
            this.mapControl.Color_XMark = System.Drawing.Color.DarkGray;
            this.mapControl.ColumnHeadLocation = Map.eMapColHeadLocation.None;
            this.mapControl.ColumnNumberStartOne = false;
            this.mapControl.CulumnTextType = Map.eMapLabelType.Number;
            this.mapControl.DistanceItem = 1;
            this.mapControl.DistanceSeg = 2;
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.DrawOffset = new System.Windows.Forms.Padding(3);
            this.mapControl.FillCount_Col = 2;
            this.mapControl.FillCount_Row = 2;
            this.mapControl.FillDirection = Map.eMapDirection.RBtoLB_S;
            this.mapControl.ItemCount_Col = 10;
            this.mapControl.ItemCount_Row = 5;
            this.mapControl.Location = new System.Drawing.Point(0, 50);
            this.mapControl.Margin = new System.Windows.Forms.Padding(0);
            this.mapControl.MouseActiveEnable = true;
            this.mapControl.MouseSelectEnable = true;
            this.mapControl.Name = "mapControl";
            this.mapControl.RoundRectFact = 0.2F;
            this.mapControl.RowHeadLocation = Map.eMapRowHeadLocation.None;
            this.mapControl.RowTextType = Map.eMapLabelType.Number;
            this.mapControl.SegmentCount_Col = 6;
            this.mapControl.SegmentCount_Row = 3;
            this.mapControl.Size = new System.Drawing.Size(600, 450);
            this.mapControl.TabIndex = 0;
            this.mapControl.VisibleIndex = false;
            this.mapControl.VisibleLabel = false;
            this.mapControl.VisibleTriNum = false;
            // 
            // MapEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mapControl);
            this.Controls.Add(this.panPara);
            this.Controls.Add(this.panButtons);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MapEditor";
            this.Size = new System.Drawing.Size(800, 500);
            this.panButtons.ResumeLayout(false);
            this.panPara.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numFilRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFilCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItemRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItemCol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MapControl mapControl;
        private System.Windows.Forms.Panel panButtons;
        private System.Windows.Forms.Panel panPara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelAll;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnLoadMap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numItemCol;
        private System.Windows.Forms.NumericUpDown numSegRow;
        private System.Windows.Forms.NumericUpDown numSegCol;
        private System.Windows.Forms.NumericUpDown numItemRow;
        private System.Windows.Forms.NumericUpDown numFilRow;
        private System.Windows.Forms.NumericUpDown numFilCol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbDirection;
        private System.Windows.Forms.CheckBox chkVisTri;
        private System.Windows.Forms.CheckBox chkVisIdx;
        private System.Windows.Forms.CheckBox chkVisLabel;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Button btnSaveToFile;
        public System.Windows.Forms.Button btnFunc2;
        public System.Windows.Forms.Button btnFunc1;
        private System.Windows.Forms.Label label9;
    }
}
