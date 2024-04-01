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

            SetDirectionComboBox();
            ReadMapPara();

            Initialized = true;
        }

        private void SetDirectionComboBox()
        {
            for (int i = 0; i < 16; i++)
            {
                comboBox1.Items.Add(((eMapDirection)i).ToString());
            }

            comboBox1.SelectedItem = mapControl1.FillDirection.ToString();
        }

        private void ReadMapPara()
        {
            numItemX.Value = mapControl1.ItemCount_Col;
            numItemY.Value = mapControl1.ItemCount_Row;
            numSegX.Value = mapControl1.SegmentCount_Col;
            numSegY.Value = mapControl1.SegmentCount_Row;
            numFillX.Value = mapControl1.FillCount_Col;
            numFillY.Value = mapControl1.FillCount_Row;

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Initialized) return;

            mapControl1.FillDirection = (eMapDirection)comboBox1.SelectedIndex;
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
                mapControl1.SetStatus((int)numTriNum.Value, true, (int)numOrder.Value++, eMapStatus.Good);

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
                eMapStatus[] statuses = new eMapStatus[(int)numFillX.Value * (int)numFillY.Value];

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
    }
}