using System;
using System.Windows.Forms;

namespace Map
{
    public partial class TestForm : Form
    {
        private bool Initialized = false;

        public TestForm()
        {
            InitializeComponent();

            ReadMapPara();

            Initialized = true;
        }

        private void ReadMapPara()
        {
            numTriSegRow.Value = mapControl1.TriggerCountPerSegRow;
            numTriSegCol.Value = mapControl1.TriggerCountPerSegCol;
            numTotalTriRow.Value = mapControl1.TotalTriggerCountRow;
            numTotalTriCol.Value = mapControl1.TotalTriggerCountCol;
        }

        private void nummeric_ValueChanged(object sender, EventArgs e)
        {
            if (!Initialized) return;

            int num = Convert.ToInt32((sender as NumericUpDown).Tag);

            switch (num)
            {
                case 0: mapControl1.ItemCount_Col = (int)(sender as NumericUpDown).Value; break;
                case 1: mapControl1.ItemCount_Row = (int)(sender as NumericUpDown).Value; break;
                case 2: mapControl1.SegmentCount_Col = (int)(sender as NumericUpDown).Value; break;
                case 3: mapControl1.SegmentCount_Row = (int)(sender as NumericUpDown).Value; break;
                case 4: mapControl1.FillCount_Col = (int)(sender as NumericUpDown).Value; break;
                case 5: mapControl1.FillCount_Row = (int)(sender as NumericUpDown).Value; break;
            }

            ReadMapPara();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mapControl1.SetStatusReadyAll();
            numTriNum.Value = 0;
            numOrder.Value = 0;
            numCurrentCol.Value = 0;
            numCurrentRow.Value = 0;
        }

        private void btnSetStatusEach_Click(object sender, EventArgs e)
        {
            if (mapControl1.TotalTriggerCountCol * mapControl1.TotalTriggerCountRow > numTriNum.Value)
            {
                mapControl1.SetStatus((int)numTriNum.Value, true, eMapStatus.Good, (int)numOrder.Value++);

                if (numOrder.Value == mapControl1.FillCount_Col * mapControl1.FillCount_Row)
                {
                    numOrder.Value = 0;
                    numTriNum.Value++;
                }
            }
        }

        private void btnSetStatusTogether_Click(object sender, EventArgs e)
        {
            if (mapControl1.TotalTriggerCountCol * mapControl1.TotalTriggerCountRow > numTriNum.Value)
            {
                eMapStatus[] statuses = new eMapStatus[mapControl1.FillCount_Col * mapControl1.FillCount_Row];

                for (int i = 0; i < statuses.Length; i++)
                {
                    statuses[i] = eMapStatus.Res01;
                }

                mapControl1.SetStatuses((int)numTriNum.Value++, true, out int iX, out int iY, statuses);

                if (iX < 0 || iY < 0) return;

                numCurrentCol.Value = iX;
                numCurrentRow.Value = iY;
            }
        }

        private void btnMapSettings_Click(object sender, EventArgs e)
        {
            using (Form frmMap = new Form())
            {
                MapEditor editor = new MapEditor(mapControl1);

                frmMap.Controls.Add(editor);
                editor.Dock = DockStyle.Fill;

                editor.VisibleSetSegment = false;
                editor.UseFunc1Button = true;

                editor.OnFunc1Click += Editor_OnFunc1Click;
                editor.btnFunc1.Text = "Auto Map";

                frmMap.MinimumSize = new System.Drawing.Size(850, 500);
                frmMap.ShowDialog();

                if (MessageBox.Show("Get Map Control?", string.Empty, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    mapControl1.AssignFrom(editor.GetMapControl, true);
                    ReadMapPara();
                }

                editor.OnFunc1Click -= Editor_OnFunc1Click;
            }
        }

        private void Editor_OnFunc1Click(object sender, EventArgs e)
        {
        }
    }
}