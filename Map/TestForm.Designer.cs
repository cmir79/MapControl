namespace Map
{
    partial class TestForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.numItemX = new System.Windows.Forms.NumericUpDown();
            this.numItemY = new System.Windows.Forms.NumericUpDown();
            this.numSegX = new System.Windows.Forms.NumericUpDown();
            this.numSegY = new System.Windows.Forms.NumericUpDown();
            this.numFillX = new System.Windows.Forms.NumericUpDown();
            this.numFillY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numTriSegCol = new System.Windows.Forms.NumericUpDown();
            this.numTriSegRow = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numTotalTriCol = new System.Windows.Forms.NumericUpDown();
            this.numTotalTriRow = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSetStatusEach = new System.Windows.Forms.Button();
            this.btnSetStatusTogether = new System.Windows.Forms.Button();
            this.numTriNum = new System.Windows.Forms.NumericUpDown();
            this.numCurrentRow = new System.Windows.Forms.NumericUpDown();
            this.numCurrentCol = new System.Windows.Forms.NumericUpDown();
            this.mapControl1 = new Map.MapControl();
            ((System.ComponentModel.ISupportInitialize)(this.numItemX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItemY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFillX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFillY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTriSegCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTriSegRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalTriCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalTriRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTriNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentCol)).BeginInit();
            this.SuspendLayout();
            // 
            // numItemX
            // 
            this.numItemX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numItemX.Location = new System.Drawing.Point(718, 12);
            this.numItemX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numItemX.Name = "numItemX";
            this.numItemX.Size = new System.Drawing.Size(70, 21);
            this.numItemX.TabIndex = 1;
            this.numItemX.Tag = "0";
            this.numItemX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numItemX.ValueChanged += new System.EventHandler(this.nummeric_ValueChanged);
            // 
            // numItemY
            // 
            this.numItemY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numItemY.Location = new System.Drawing.Point(718, 39);
            this.numItemY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numItemY.Name = "numItemY";
            this.numItemY.Size = new System.Drawing.Size(70, 21);
            this.numItemY.TabIndex = 1;
            this.numItemY.Tag = "1";
            this.numItemY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numItemY.ValueChanged += new System.EventHandler(this.nummeric_ValueChanged);
            // 
            // numSegX
            // 
            this.numSegX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSegX.Location = new System.Drawing.Point(718, 66);
            this.numSegX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSegX.Name = "numSegX";
            this.numSegX.Size = new System.Drawing.Size(70, 21);
            this.numSegX.TabIndex = 1;
            this.numSegX.Tag = "2";
            this.numSegX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSegX.ValueChanged += new System.EventHandler(this.nummeric_ValueChanged);
            // 
            // numSegY
            // 
            this.numSegY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numSegY.Location = new System.Drawing.Point(718, 93);
            this.numSegY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSegY.Name = "numSegY";
            this.numSegY.Size = new System.Drawing.Size(70, 21);
            this.numSegY.TabIndex = 1;
            this.numSegY.Tag = "3";
            this.numSegY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSegY.ValueChanged += new System.EventHandler(this.nummeric_ValueChanged);
            // 
            // numFillX
            // 
            this.numFillX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numFillX.Location = new System.Drawing.Point(718, 120);
            this.numFillX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFillX.Name = "numFillX";
            this.numFillX.Size = new System.Drawing.Size(70, 21);
            this.numFillX.TabIndex = 1;
            this.numFillX.Tag = "4";
            this.numFillX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFillX.ValueChanged += new System.EventHandler(this.nummeric_ValueChanged);
            // 
            // numFillY
            // 
            this.numFillY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numFillY.Location = new System.Drawing.Point(718, 147);
            this.numFillY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFillY.Name = "numFillY";
            this.numFillY.Size = new System.Drawing.Size(70, 21);
            this.numFillY.TabIndex = 1;
            this.numFillY.Tag = "5";
            this.numFillY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFillY.ValueChanged += new System.EventHandler(this.nummeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "ITEM COL";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "ITEM ROW";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "SEG COL";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "SEG ROW";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(593, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "FILL COL";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "FILL ROW";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(690, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 20);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(593, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "DIR";
            // 
            // numTriSegCol
            // 
            this.numTriSegCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numTriSegCol.Enabled = false;
            this.numTriSegCol.Location = new System.Drawing.Point(718, 200);
            this.numTriSegCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTriSegCol.Name = "numTriSegCol";
            this.numTriSegCol.Size = new System.Drawing.Size(70, 21);
            this.numTriSegCol.TabIndex = 1;
            this.numTriSegCol.Tag = "";
            this.numTriSegCol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numTriSegRow
            // 
            this.numTriSegRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numTriSegRow.Enabled = false;
            this.numTriSegRow.Location = new System.Drawing.Point(718, 227);
            this.numTriSegRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTriSegRow.Name = "numTriSegRow";
            this.numTriSegRow.Size = new System.Drawing.Size(70, 21);
            this.numTriSegRow.TabIndex = 1;
            this.numTriSegRow.Tag = "";
            this.numTriSegRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(593, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "TriNumPerSegCol";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(593, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "TriNumPerSegRow";
            // 
            // numTotalTriCol
            // 
            this.numTotalTriCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numTotalTriCol.Enabled = false;
            this.numTotalTriCol.Location = new System.Drawing.Point(718, 254);
            this.numTotalTriCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTotalTriCol.Name = "numTotalTriCol";
            this.numTotalTriCol.Size = new System.Drawing.Size(70, 21);
            this.numTotalTriCol.TabIndex = 1;
            this.numTotalTriCol.Tag = "";
            this.numTotalTriCol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numTotalTriRow
            // 
            this.numTotalTriRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numTotalTriRow.Enabled = false;
            this.numTotalTriRow.Location = new System.Drawing.Point(718, 281);
            this.numTotalTriRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTotalTriRow.Name = "numTotalTriRow";
            this.numTotalTriRow.Size = new System.Drawing.Size(70, 21);
            this.numTotalTriRow.TabIndex = 1;
            this.numTotalTriRow.Tag = "";
            this.numTotalTriRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(593, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "TriNumTotalCol";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(593, 283);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "TriNumTotalRow";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(718, 308);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSetStatusEach
            // 
            this.btnSetStatusEach.Location = new System.Drawing.Point(718, 337);
            this.btnSetStatusEach.Name = "btnSetStatusEach";
            this.btnSetStatusEach.Size = new System.Drawing.Size(75, 23);
            this.btnSetStatusEach.TabIndex = 5;
            this.btnSetStatusEach.Text = "1by1";
            this.btnSetStatusEach.UseVisualStyleBackColor = true;
            this.btnSetStatusEach.Click += new System.EventHandler(this.btnSetStatusEach_Click);
            // 
            // btnSetStatusTogether
            // 
            this.btnSetStatusTogether.Location = new System.Drawing.Point(718, 366);
            this.btnSetStatusTogether.Name = "btnSetStatusTogether";
            this.btnSetStatusTogether.Size = new System.Drawing.Size(75, 23);
            this.btnSetStatusTogether.TabIndex = 5;
            this.btnSetStatusTogether.Text = "Together";
            this.btnSetStatusTogether.UseVisualStyleBackColor = true;
            this.btnSetStatusTogether.Click += new System.EventHandler(this.btnSetStatusTogether_Click);
            // 
            // numTriNum
            // 
            this.numTriNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numTriNum.Enabled = false;
            this.numTriNum.Location = new System.Drawing.Point(642, 308);
            this.numTriNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTriNum.Name = "numTriNum";
            this.numTriNum.Size = new System.Drawing.Size(70, 21);
            this.numTriNum.TabIndex = 1;
            this.numTriNum.Tag = "";
            // 
            // numCurrentRow
            // 
            this.numCurrentRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCurrentRow.Enabled = false;
            this.numCurrentRow.Location = new System.Drawing.Point(666, 366);
            this.numCurrentRow.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCurrentRow.Name = "numCurrentRow";
            this.numCurrentRow.Size = new System.Drawing.Size(46, 21);
            this.numCurrentRow.TabIndex = 1;
            this.numCurrentRow.Tag = "";
            // 
            // numCurrentCol
            // 
            this.numCurrentCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCurrentCol.Enabled = false;
            this.numCurrentCol.Location = new System.Drawing.Point(614, 366);
            this.numCurrentCol.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCurrentCol.Name = "numCurrentCol";
            this.numCurrentCol.Size = new System.Drawing.Size(46, 21);
            this.numCurrentCol.TabIndex = 1;
            this.numCurrentCol.Tag = "";
            // 
            // mapControl1
            // 
            this.mapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapControl1.BorderSize = 1;
            this.mapControl1.CellLineWidth = 1;
            this.mapControl1.Color_Active = System.Drawing.Color.Blue;
            this.mapControl1.Color_Border = System.Drawing.Color.Black;
            this.mapControl1.Color_Good = System.Drawing.Color.Lime;
            this.mapControl1.Color_Header = System.Drawing.Color.LightGray;
            this.mapControl1.Color_ItemBorder = System.Drawing.Color.Black;
            this.mapControl1.Color_NotUse = System.Drawing.Color.Transparent;
            this.mapControl1.Color_Ready = System.Drawing.Color.White;
            this.mapControl1.Color_Res01 = System.Drawing.Color.Red;
            this.mapControl1.Color_Res02 = System.Drawing.Color.Black;
            this.mapControl1.Color_Res03 = System.Drawing.Color.Yellow;
            this.mapControl1.Color_Res04 = System.Drawing.Color.Purple;
            this.mapControl1.Color_Res05 = System.Drawing.Color.Orange;
            this.mapControl1.Color_Res06 = System.Drawing.Color.Red;
            this.mapControl1.Color_Res07 = System.Drawing.Color.Black;
            this.mapControl1.Color_Res08 = System.Drawing.Color.Yellow;
            this.mapControl1.Color_Res09 = System.Drawing.Color.Purple;
            this.mapControl1.Color_Res10 = System.Drawing.Color.Orange;
            this.mapControl1.Color_Res11 = System.Drawing.Color.Red;
            this.mapControl1.Color_Res12 = System.Drawing.Color.Black;
            this.mapControl1.Color_Res13 = System.Drawing.Color.Yellow;
            this.mapControl1.Color_Res14 = System.Drawing.Color.Purple;
            this.mapControl1.Color_Res15 = System.Drawing.Color.Orange;
            this.mapControl1.Color_Res16 = System.Drawing.Color.Red;
            this.mapControl1.Color_Selected = System.Drawing.Color.Red;
            this.mapControl1.Color_XMark = System.Drawing.Color.DarkGray;
            this.mapControl1.ColumnHeadLocation = Map.eMapColHeadLocation.Top;
            this.mapControl1.ColumnNumberStartOne = false;
            this.mapControl1.CulumnTextType = Map.eMapLabelType.Number;
            this.mapControl1.DistanceItem = 2;
            this.mapControl1.DistanceSeg = 5;
            this.mapControl1.DrawOffset = new System.Windows.Forms.Padding(3);
            this.mapControl1.FillCount_Col = 2;
            this.mapControl1.FillCount_Row = 2;
            this.mapControl1.FillDirection = Map.eMapDirection.LTtoRT_S;
            this.mapControl1.ItemCount_Col = 10;
            this.mapControl1.ItemCount_Row = 5;
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.RoundRectFact = 0.5F;
            this.mapControl1.RowHeadLocation = Map.eMapRowHeadLocation.Left;
            this.mapControl1.RowTextType = Map.eMapLabelType.Number;
            this.mapControl1.SegmentCount_Col = 3;
            this.mapControl1.SegmentCount_Row = 3;
            this.mapControl1.Size = new System.Drawing.Size(587, 450);
            this.mapControl1.TabIndex = 3;
            this.mapControl1.VisiableIndex = true;
            this.mapControl1.VisiableTriNum = false;
            this.mapControl1.VisibleLabel = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSetStatusTogether);
            this.Controls.Add(this.btnSetStatusEach);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.mapControl1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numCurrentCol);
            this.Controls.Add(this.numCurrentRow);
            this.Controls.Add(this.numTriNum);
            this.Controls.Add(this.numTotalTriRow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numTriSegRow);
            this.Controls.Add(this.numTotalTriCol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTriSegCol);
            this.Controls.Add(this.numFillY);
            this.Controls.Add(this.numFillX);
            this.Controls.Add(this.numSegY);
            this.Controls.Add(this.numSegX);
            this.Controls.Add(this.numItemY);
            this.Controls.Add(this.numItemX);
            this.DoubleBuffered = true;
            this.Name = "TestForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numItemX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItemY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFillX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFillY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTriSegCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTriSegRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalTriCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalTriRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTriNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentCol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numItemX;
        private System.Windows.Forms.NumericUpDown numItemY;
        private System.Windows.Forms.NumericUpDown numSegX;
        private System.Windows.Forms.NumericUpDown numSegY;
        private System.Windows.Forms.NumericUpDown numFillX;
        private System.Windows.Forms.NumericUpDown numFillY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MapControl mapControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numTriSegCol;
        private System.Windows.Forms.NumericUpDown numTriSegRow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numTotalTriCol;
        private System.Windows.Forms.NumericUpDown numTotalTriRow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSetStatusEach;
        private System.Windows.Forms.Button btnSetStatusTogether;
        private System.Windows.Forms.NumericUpDown numTriNum;
        private System.Windows.Forms.NumericUpDown numCurrentRow;
        private System.Windows.Forms.NumericUpDown numCurrentCol;
    }
}

