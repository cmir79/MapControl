using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map
{
    public partial class MapEditor : UserControl
    {
        private bool Initialized = false;

        private int m_StartX = -1;
        private int m_StartY = -1;
        private int m_EndX = -1;
        private int m_EndY = -1;

        private MapControl m_TmpMap = new MapControl();

        private event EventHandler _OnFunc1Click;
        private event EventHandler _OnFunc2Click;

        public MapControl GetMapControl
        { get { return mapControl1; } }

        public MapEditor(MapControl mapControl)
        {
            InitializeComponent();

            m_TmpMap.AssignFrom(mapControl, true);
            mapControl1.AssignFrom(mapControl, true);

            SetComboBox();
            ReadMapPara();

            mapControl1.OnSelected += MapControl1_OnSelected;
            mapControl1.MouseDown += MapControl1_MouseDown;
            mapControl1.MouseUp += MapControl1_MouseUp;
            mapControl1.OnActive += MapControl1_OnActive;

            Initialized = true;
        }

        public void ReadMapPara()
        {
            numItemCol.Value = mapControl1.ItemCount_Col;
            numItemRow.Value = mapControl1.ItemCount_Row;
            numSegCol.Value = mapControl1.SegmentCount_Col;
            numSegRow.Value = mapControl1.SegmentCount_Row;
            numFilCol.Value = mapControl1.FillCount_Col;
            numFilRow.Value = mapControl1.FillCount_Row;

            chkVisLabel.Checked = mapControl1.VisibleLabel;
            chkVisIdx.Checked = mapControl1.VisibleIndex;
            chkVisTri.Checked = mapControl1.VisibleTriNum;
        }

        public void SetComboBox()
        {
            for (int i = 0; i < 16; i++)
                cbDirection.Items.Add(((eMapDirection)i).ToString());

            cbDirection.SelectedItem = mapControl1.FillDirection.ToString();
        }

        private void MapControl1_MouseUp(object sender, MouseEventArgs e)
        {
            mapControl1.MouseActiveEnable = true;

            if (e.Button == MouseButtons.Left)
            {
                for (int col = Math.Min(m_StartX, m_EndX); col <= Math.Max(m_StartX, m_EndX); col++)
                    for (int row = Math.Min(m_StartY, m_EndY); row <= Math.Max(m_StartY, m_EndY); row++)
                        mapControl1.SetStatus(col, row, eMapStatus.Ready);
            }
            else if (e.Button == MouseButtons.Right)
            {
                for (int col = Math.Min(m_StartX, m_EndX); col <= Math.Max(m_StartX, m_EndX); col++)
                    for (int row = Math.Min(m_StartY, m_EndY); row <= Math.Max(m_StartY, m_EndY); row++)
                        mapControl1.SetStatus(col, row, eMapStatus.NotUse);
            }
        }

        private void MapControl1_OnActive(object sender, MapEventArgs e)
        {
            m_StartX = e.SelectedCol;
            m_StartY = e.SelectedRow;
        }

        private void MapControl1_OnSelected(object sender, MapEventArgs e)
        {
            m_EndX = e.SelectedCol;
            m_EndY = e.SelectedRow;
        }

        private void MapControl1_MouseDown(object sender, MouseEventArgs e)
        {
            mapControl1.MouseActiveEnable = false;
        }

        private void nummeric_ValueChanged(object sender, EventArgs e)
        {
            if (!Initialized) return;

            int num = Convert.ToInt32((sender as NumericUpDown).Tag);

            switch (num)
            {
                case 0:
                    mapControl1.ItemCount_Col = (int)(sender as NumericUpDown).Value;
                    if (!VisibleSetSegment)
                        mapControl1.SegmentCount_Col = (int)(sender as NumericUpDown).Value;
                    break;

                case 1:
                    mapControl1.ItemCount_Row = (int)(sender as NumericUpDown).Value;
                    if (!VisibleSetSegment)
                        mapControl1.SegmentCount_Row = (int)(sender as NumericUpDown).Value;
                    break;

                case 2: mapControl1.SegmentCount_Col = (int)(sender as NumericUpDown).Value; break;
                case 3: mapControl1.SegmentCount_Row = (int)(sender as NumericUpDown).Value; break;
                case 4: mapControl1.FillCount_Col = (int)(sender as NumericUpDown).Value; break;
                case 5: mapControl1.FillCount_Row = (int)(sender as NumericUpDown).Value; break;
            }

            ReadMapPara();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!Initialized) return;

            int num = Convert.ToInt32((sender as CheckBox).Tag);

            switch (num)
            {
                case 0: mapControl1.VisibleLabel = (sender as CheckBox).Checked; break;
                case 1: mapControl1.VisibleIndex = (sender as CheckBox).Checked; break;
                case 2: mapControl1.VisibleTriNum = (sender as CheckBox).Checked; break;
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapControl1.FillDirection = (eMapDirection)cbDirection.SelectedIndex;
        }

        private void btnSelAll_Click(object sender, EventArgs e)
        {
            mapControl1.SetStatusReadyAll(true);
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            for (int col = 0; col < mapControl1.ItemCount_Col; col++)
                for (int row = 0; row < mapControl1.ItemCount_Row; row++)
                {
                    if (mapControl1.GetStatus(col, row) != eMapStatus.NotUse)
                        mapControl1.SetStatus(col, row, eMapStatus.NotUse);
                    else
                        mapControl1.SetStatus(col, row, eMapStatus.Ready);
                }

            mapControl1.Invalidate();
        }

        private void btnLoadMap_Click(object sender, EventArgs e)
        {
            mapControl1.AssignFrom(m_TmpMap, true);

            VisibleSetSegment = VisibleSetSegment;
            VisibleSetFill = VisibleSetFill;
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
        }

        private void btnFunc1_Click(object sender, EventArgs e)
        {
            _OnFunc1Click?.Invoke(sender, e);
        }

        private void btnFunc2_Click(object sender, EventArgs e)
        {
            _OnFunc2Click?.Invoke(sender, e);
        }

        public bool VisibleSetSegment
        {
            get { return numSegCol.Visible; }
            set
            {
                if (!value)
                {
                    mapControl1.SegmentCount_Col = mapControl1.ItemCount_Col;
                    mapControl1.SegmentCount_Row = mapControl1.ItemCount_Row;
                }
                numSegCol.Visible = value;
                numSegRow.Visible = value;
                label4.Visible = value;
                label5.Visible = value;
            }
        }

        public bool VisibleSetFill
        {
            get { return numFilCol.Visible; }
            set
            {
                if (!value)
                {
                    mapControl1.FillCount_Col = 1;
                    mapControl1.FillCount_Row = 1;
                }
                numFilCol.Visible = value;
                numFilRow.Visible = value;
                label6.Visible = value;
                label7.Visible = value;
            }
        }

        public bool UseFunc1Button
        {
            get { return btnFunc1.Visible; }
            set { btnFunc1.Visible = value; }
        }

        public bool UseFunc2Button
        {
            get { return btnFunc2.Visible; }
            set { btnFunc2.Visible = value; }
        }

        public event EventHandler OnFunc1Click
        {
            add
            {
                if (_OnFunc1Click == null) _OnFunc1Click += value;
                else lock (_OnFunc1Click) _OnFunc1Click += value;
            }
            remove
            {
                if (_OnFunc1Click == null) return;
                else lock (_OnFunc1Click) _OnFunc1Click -= value;
            }
        }

        public event EventHandler OnFunc2Click
        {
            add
            {
                if (_OnFunc2Click == null) _OnFunc2Click += value;
                else lock (_OnFunc2Click) _OnFunc2Click += value;
            }
            remove
            {
                if (_OnFunc2Click == null) return;
                else lock (_OnFunc2Click) _OnFunc2Click -= value;
            }
        }
    }
}