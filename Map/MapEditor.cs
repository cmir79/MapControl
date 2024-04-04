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
        { get { return mapControl; } }

        public MapEditor(MapControl mapControl)
        {
            InitializeComponent();

            Init(mapControl);
        }

        public MapEditor()
        {
            InitializeComponent();
        }

        public void Init(MapControl control)
        {
            if (!Initialized)
            {
                SetComboBox();

                m_TmpMap.AssignFrom(control, true);
                m_TmpMap.SetStatusReadyAll();

                mapControl.OnSelected += MapControl1_OnSelected;
                mapControl.MouseDown += MapControl1_MouseDown;
                mapControl.MouseUp += MapControl1_MouseUp;
                mapControl.OnActive += MapControl1_OnActive;
            }

            Initialized = false;

            mapControl.AssignFrom(control, true);
            ReadMapPara();

            mapControl.SetStatusReadyAll();

            Initialized = true;
        }

        public void ReadMapPara()
        {
            numItemCol.Value = mapControl.ItemCount_Col;
            numItemRow.Value = mapControl.ItemCount_Row;
            numSegCol.Value = mapControl.SegmentCount_Col;
            numSegRow.Value = mapControl.SegmentCount_Row;
            numFilCol.Value = mapControl.FillCount_Col;
            numFilRow.Value = mapControl.FillCount_Row;

            cbDirection.SelectedItem = mapControl.FillDirection.ToString();

            chkVisLabel.Checked = mapControl.VisibleLabel;
            chkVisIdx.Checked = mapControl.VisibleIndex;
            chkVisTri.Checked = mapControl.VisibleTriNum;
        }

        public void SetComboBox()
        {
            for (int i = 0; i < 16; i++)
                cbDirection.Items.Add(((eMapDirection)i).ToString());
        }

        private void MapControl1_MouseUp(object sender, MouseEventArgs e)
        {
            mapControl.MouseActiveEnable = true;

            if (e.Button == MouseButtons.Left)
            {
                for (int col = Math.Min(m_StartX, m_EndX); col <= Math.Max(m_StartX, m_EndX); col++)
                    for (int row = Math.Min(m_StartY, m_EndY); row <= Math.Max(m_StartY, m_EndY); row++)
                        mapControl.SetStatus(col, row, eMapStatus.Ready);
            }
            else if (e.Button == MouseButtons.Right)
            {
                for (int col = Math.Min(m_StartX, m_EndX); col <= Math.Max(m_StartX, m_EndX); col++)
                    for (int row = Math.Min(m_StartY, m_EndY); row <= Math.Max(m_StartY, m_EndY); row++)
                        mapControl.SetStatus(col, row, eMapStatus.NotUse);
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
            mapControl.MouseActiveEnable = false;
        }

        private void nummeric_ValueChanged(object sender, EventArgs e)
        {
            if (!Initialized) return;

            int num = Convert.ToInt32((sender as NumericUpDown).Tag);

            switch (num)
            {
                case 0:
                    mapControl.ItemCount_Col = (int)(sender as NumericUpDown).Value;
                    if (!VisibleSetSegment)
                        mapControl.SegmentCount_Col = (int)(sender as NumericUpDown).Value;
                    break;

                case 1:
                    mapControl.ItemCount_Row = (int)(sender as NumericUpDown).Value;
                    if (!VisibleSetSegment)
                        mapControl.SegmentCount_Row = (int)(sender as NumericUpDown).Value;
                    break;

                case 2: mapControl.SegmentCount_Col = (int)(sender as NumericUpDown).Value; break;
                case 3: mapControl.SegmentCount_Row = (int)(sender as NumericUpDown).Value; break;
                case 4: mapControl.FillCount_Col = (int)(sender as NumericUpDown).Value; break;
                case 5: mapControl.FillCount_Row = (int)(sender as NumericUpDown).Value; break;
            }

            ReadMapPara();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!Initialized) return;

            int num = Convert.ToInt32((sender as CheckBox).Tag);

            switch (num)
            {
                case 0: mapControl.VisibleLabel = (sender as CheckBox).Checked; break;
                case 1: mapControl.VisibleIndex = (sender as CheckBox).Checked; break;
                case 2: mapControl.VisibleTriNum = (sender as CheckBox).Checked; break;
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapControl.FillDirection = (eMapDirection)cbDirection.SelectedIndex;
        }

        private void btnSelAll_Click(object sender, EventArgs e)
        {
            mapControl.SetStatusReadyAll(true);
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            for (int col = 0; col < mapControl.ItemCount_Col; col++)
                for (int row = 0; row < mapControl.ItemCount_Row; row++)
                {
                    if (mapControl.GetStatus(col, row) != eMapStatus.NotUse)
                        mapControl.SetStatus(col, row, eMapStatus.NotUse);
                    else
                        mapControl.SetStatus(col, row, eMapStatus.Ready);
                }

            mapControl.Invalidate();
        }

        private void btnLoadMap_Click(object sender, EventArgs e)
        {
            mapControl.AssignFrom(m_TmpMap, true);
            ReadMapPara();

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
                    mapControl.SegmentCount_Col = mapControl.ItemCount_Col;
                    mapControl.SegmentCount_Row = mapControl.ItemCount_Row;
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
                    mapControl.FillCount_Col = 1;
                    mapControl.FillCount_Row = 1;
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

        public string Func1ButtonText
        {
            get { return btnFunc1.Text; }
            set { btnFunc1.Text = value; }
        }

        public string Func2ButtonText
        {
            get { return btnFunc2.Text; }
            set { btnFunc2.Text = value; }
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