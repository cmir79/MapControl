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
            this.numOrder = new System.Windows.Forms.NumericUpDown();
            this.mapControl1 = new Map.MapControl();
            this.btnMapSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTriSegCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTriSegRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalTriCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalTriRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTriNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // numTriSegCol
            // 
            this.numTriSegCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numTriSegCol.Enabled = false;
            this.numTriSegCol.Location = new System.Drawing.Point(707, 13);
            this.numTriSegCol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numTriSegCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTriSegCol.Name = "numTriSegCol";
            this.numTriSegCol.Size = new System.Drawing.Size(70, 23);
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
            this.numTriSegRow.Location = new System.Drawing.Point(707, 47);
            this.numTriSegRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numTriSegRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTriSegRow.Name = "numTriSegRow";
            this.numTriSegRow.Size = new System.Drawing.Size(70, 23);
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
            this.label8.Location = new System.Drawing.Point(582, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "TriNumPerSegCol";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(582, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "TriNumPerSegRow";
            // 
            // numTotalTriCol
            // 
            this.numTotalTriCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numTotalTriCol.Enabled = false;
            this.numTotalTriCol.Location = new System.Drawing.Point(707, 81);
            this.numTotalTriCol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numTotalTriCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTotalTriCol.Name = "numTotalTriCol";
            this.numTotalTriCol.Size = new System.Drawing.Size(70, 23);
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
            this.numTotalTriRow.Location = new System.Drawing.Point(707, 114);
            this.numTotalTriRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numTotalTriRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTotalTriRow.Name = "numTotalTriRow";
            this.numTotalTriRow.Size = new System.Drawing.Size(70, 23);
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
            this.label10.Location = new System.Drawing.Point(582, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "TriNumTotalCol";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(582, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "TriNumTotalRow";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(702, 495);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 29);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSetStatusEach
            // 
            this.btnSetStatusEach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetStatusEach.Location = new System.Drawing.Point(702, 531);
            this.btnSetStatusEach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetStatusEach.Name = "btnSetStatusEach";
            this.btnSetStatusEach.Size = new System.Drawing.Size(75, 29);
            this.btnSetStatusEach.TabIndex = 5;
            this.btnSetStatusEach.Text = "1by1";
            this.btnSetStatusEach.UseVisualStyleBackColor = true;
            this.btnSetStatusEach.Click += new System.EventHandler(this.btnSetStatusEach_Click);
            // 
            // btnSetStatusTogether
            // 
            this.btnSetStatusTogether.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetStatusTogether.Location = new System.Drawing.Point(702, 568);
            this.btnSetStatusTogether.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetStatusTogether.Name = "btnSetStatusTogether";
            this.btnSetStatusTogether.Size = new System.Drawing.Size(75, 29);
            this.btnSetStatusTogether.TabIndex = 5;
            this.btnSetStatusTogether.Text = "Together";
            this.btnSetStatusTogether.UseVisualStyleBackColor = true;
            this.btnSetStatusTogether.Click += new System.EventHandler(this.btnSetStatusTogether_Click);
            // 
            // numTriNum
            // 
            this.numTriNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numTriNum.Enabled = false;
            this.numTriNum.Location = new System.Drawing.Point(626, 499);
            this.numTriNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numTriNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTriNum.Name = "numTriNum";
            this.numTriNum.Size = new System.Drawing.Size(70, 23);
            this.numTriNum.TabIndex = 1;
            this.numTriNum.Tag = "";
            // 
            // numCurrentRow
            // 
            this.numCurrentRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numCurrentRow.Enabled = false;
            this.numCurrentRow.Location = new System.Drawing.Point(650, 571);
            this.numCurrentRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCurrentRow.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCurrentRow.Name = "numCurrentRow";
            this.numCurrentRow.Size = new System.Drawing.Size(46, 23);
            this.numCurrentRow.TabIndex = 1;
            this.numCurrentRow.Tag = "";
            // 
            // numCurrentCol
            // 
            this.numCurrentCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numCurrentCol.Enabled = false;
            this.numCurrentCol.Location = new System.Drawing.Point(598, 571);
            this.numCurrentCol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numCurrentCol.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCurrentCol.Name = "numCurrentCol";
            this.numCurrentCol.Size = new System.Drawing.Size(46, 23);
            this.numCurrentCol.TabIndex = 1;
            this.numCurrentCol.Tag = "";
            // 
            // numOrder
            // 
            this.numOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numOrder.Enabled = false;
            this.numOrder.Location = new System.Drawing.Point(626, 535);
            this.numOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numOrder.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numOrder.Name = "numOrder";
            this.numOrder.Size = new System.Drawing.Size(70, 23);
            this.numOrder.TabIndex = 1;
            this.numOrder.Tag = "";
            // 
            // mapControl1
            // 
            this.mapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapControl1.BackColor = System.Drawing.Color.Black;
            this.mapControl1.BorderSize = 1;
            this.mapControl1.CellLineWidth = 1;
            this.mapControl1.Color_Active = System.Drawing.Color.Blue;
            this.mapControl1.Color_Border = System.Drawing.Color.Black;
            this.mapControl1.Color_Good = System.Drawing.Color.Lime;
            this.mapControl1.Color_Header = System.Drawing.Color.Silver;
            this.mapControl1.Color_ItemBorder = System.Drawing.Color.Black;
            this.mapControl1.Color_NotUse = System.Drawing.Color.Black;
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
            this.mapControl1.ColumnHeadLocation = Map.eMapColHeadLocation.None;
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
            this.mapControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mapControl1.MouseActiveEnable = true;
            this.mapControl1.MouseSelectEnable = true;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.RoundRectFact = 0.5F;
            this.mapControl1.RowHeadLocation = Map.eMapRowHeadLocation.None;
            this.mapControl1.RowTextType = Map.eMapLabelType.Number;
            this.mapControl1.SegmentCount_Col = 3;
            this.mapControl1.SegmentCount_Row = 3;
            this.mapControl1.Size = new System.Drawing.Size(571, 611);
            this.mapControl1.TabIndex = 3;
            this.mapControl1.VisibleIndex = false;
            this.mapControl1.VisibleLabel = false;
            this.mapControl1.VisibleTriNum = false;
            // 
            // btnMapSettings
            // 
            this.btnMapSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMapSettings.Location = new System.Drawing.Point(585, 144);
            this.btnMapSettings.Name = "btnMapSettings";
            this.btnMapSettings.Size = new System.Drawing.Size(187, 23);
            this.btnMapSettings.TabIndex = 6;
            this.btnMapSettings.Text = "Map Settings";
            this.btnMapSettings.UseVisualStyleBackColor = true;
            this.btnMapSettings.Click += new System.EventHandler(this.btnMapSettings_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.btnMapSettings);
            this.Controls.Add(this.btnSetStatusTogether);
            this.Controls.Add(this.btnSetStatusEach);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.mapControl1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numCurrentCol);
            this.Controls.Add(this.numCurrentRow);
            this.Controls.Add(this.numOrder);
            this.Controls.Add(this.numTriNum);
            this.Controls.Add(this.numTotalTriRow);
            this.Controls.Add(this.numTriSegRow);
            this.Controls.Add(this.numTotalTriCol);
            this.Controls.Add(this.numTriSegCol);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TestForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numTriSegCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTriSegRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalTriCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalTriRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTriNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MapControl mapControl1;
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
        private System.Windows.Forms.NumericUpDown numOrder;
        private System.Windows.Forms.Button btnMapSettings;
    }
}

