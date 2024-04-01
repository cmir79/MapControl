using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Map
{
    #region Event Args

    public class MapEventArgs : EventArgs
    {
        public int SelectedCol;
        public int SelectedRow;
        public int SelectedTriNum;
        public int SelectedIndex;
        public eMapStatus Status;

        public MapEventArgs(int col, int row, int trinum, int idx, eMapStatus value)
        {
            SelectedCol = col;
            SelectedRow = row;
            SelectedTriNum = trinum;
            SelectedIndex = idx;
            Status = value;
        }
    }

    public delegate void MapEventHandler(object sender, MapEventArgs e);

    #endregion Event Args

    #region Map Enum

    public enum eMapLabelType
    { Number, Alphabet }

    public enum eMapColHeadLocation
    { None, Top, Bottom }

    public enum eMapRowHeadLocation
    { None, Left, Right }

    /// <summary>
    /// 0000
    /// 1st 0 Straight or Zigzag / 0 : Straigth, 1 : Zigzag
    /// 2nd 0 Dir / 0 : Hor, 1 : Ver
    /// 3rd 0 Start Point1 / 0 : Left, 1 : Right
    /// 4th 0 Start Point2 / 0 : Top, 1 : Bottom
    /// </summary>
    public enum eMapDirection
    {
        LTtoRT_S = 0b0000,
        LTtoLB_S = 0b0100,
        RTtoLT_S = 0b0010,
        RTtoRB_S = 0b0110,
        LBtoRB_S = 0b0001,
        LBtoLT_S = 0b0101,
        RBtoLB_S = 0b0011,
        RBtoRT_S = 0b0111,
        LTtoRT_Z = 0b1000,
        LTtoLB_Z = 0b1100,
        RTtoLT_Z = 0b1010,
        RTtoRB_Z = 0b1110,
        LBtoRB_Z = 0b1001,
        LBtoLT_Z = 0b1101,
        RBtoLB_Z = 0b1011,
        RBtoRT_Z = 0b1111,
    }

    public enum eMapStatus
    { Ready, XMark, NotUse, Good, Res01, Res02, Res03, Res04, Res05, Res06, Res07, Res08, Res09, Res10, Res11, Res12, Res13, Res14, Res15, Res16 };

    #endregion Map Enum

    public partial class MapControl : UserControl
    {
        private const string AlphabetString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        #region Member

        #region Count

        private int m_Item_Col = 10;
        private int m_Item_Row = 5;

        private int m_Seg_Col = 6;
        private int m_Seg_Row = 3;

        private int m_Fil_Col = 2;
        private int m_Fil_Row = 2;

        #endregion Count

        #region Header

        private eMapColHeadLocation m_HeadLoc_Col = eMapColHeadLocation.Top;
        private eMapRowHeadLocation m_HeadLoc_Row = eMapRowHeadLocation.Left;

        private RectangleF[] m_HeadRects_Col;
        private RectangleF[] m_HeadRects_Row;

        private string[] m_HeadTexts_Col;
        private string[] m_HeadTexts_Row;

        private eMapLabelType m_HeadTextType_Col = eMapLabelType.Number;
        private eMapLabelType m_HeadTextType_Row = eMapLabelType.Number;

        private bool m_HeadNumStartOne_Col = false;
        private bool m_HeadNumStartOne_Row = false;

        #endregion Header

        #region Item

        private bool m_VisiableLabel = true;
        private bool m_VisiableTriNum = false;
        private bool m_VisiableIndex = true;

        private eMapDirection m_FillDirection = eMapDirection.RBtoLB_S;

        private RectangleF[,] m_ItemRects;

        private eMapStatus[,] m_Status;

        private string[,] m_ItemLabels;
        private int[,] m_ItemTriNums;
        private int[,] m_ItemIndexs;

        #endregion Item

        #region Geometry

        private Color m_Clr_Border = Color.Black;
        private Color m_Clr_ItemBorder = Color.Black;
        private Color m_Clr_Header = Color.White;

        private Color[] m_Clr_Result = new Color[20]; // eMapStatus하고 연동

        private Color m_Clr_Selected = Color.Red;
        private Color m_Clr_Active = Color.Blue;

        private int m_DistanceItem = 2;
        private int m_DistanceSeg = 5;
        private int m_BorderSize = 1;
        private Padding m_Padding = new Padding(3);

        private int m_LineWidth = 1;
        private float m_RoundRectFact = 0.2f;

        #endregion Geometry

        #region 연산용

        private int m_TriCntPerSegCol = -1;
        private int m_TriCntPerSegRow = -1;

        private int m_TotalTriCntCol = -1;
        private int m_TotalTriCntRow = -1;

        private int m_TmpFillNum = 0;

        #endregion 연산용

        #region Event

        private bool m_SelectedEnable = true;
        private int m_Selected_Col = -1;
        private int m_Selected_Row = -1;

        private bool m_ActiveEnable = true;
        private int m_Active_Col = -1;
        private int m_Active_Row = -1;

        private MapEventHandler _OnSelected;
        private MapEventHandler _OnActive;

        #endregion Event

        #endregion Member

        #region 초기화 및 저장, 불러오기

        public MapControl()
        {
            m_Clr_Result[0] = Color.White;
            m_Clr_Result[1] = Color.DarkGray;
            m_Clr_Result[2] = Color.Transparent;
            m_Clr_Result[3] = Color.Lime;
            m_Clr_Result[4] = Color.Red;
            m_Clr_Result[5] = Color.Black;
            m_Clr_Result[6] = Color.Yellow;
            m_Clr_Result[7] = Color.Purple;
            m_Clr_Result[8] = Color.Orange;
            m_Clr_Result[9] = Color.Red;
            m_Clr_Result[10] = Color.Black;
            m_Clr_Result[11] = Color.Yellow;
            m_Clr_Result[12] = Color.Purple;
            m_Clr_Result[13] = Color.Orange;
            m_Clr_Result[14] = Color.Red;
            m_Clr_Result[15] = Color.Black;
            m_Clr_Result[16] = Color.Yellow;
            m_Clr_Result[17] = Color.Purple;
            m_Clr_Result[18] = Color.Orange;
            m_Clr_Result[19] = Color.Red;

            Paint += MapControl_Paint;
            Resize += MapControl_Resize;
            MouseMove += MapControl_MouseMove;
            MouseClick += MapControl_MouseClick;
            MouseLeave += MapControl_MouseLeave;

            ReStruct();
            ResizeRect();
            SetStatusReadyAll();

            DoubleBuffered = true;
        }

        public MapControl(MapControl Source)
        {
            AssignFrom(Source);
        }

        public void AssignTo(MapControl Dest)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                using (BinaryReader br = new BinaryReader(ms))
                {
                    using (BinaryWriter bw = new BinaryWriter(ms))
                    {
                        SaveStream(ms, bw);
                        ms.Seek(0, SeekOrigin.Begin);
                        Dest.LoadStream(ms, br);
                        bw.Close();
                    }
                    br.Close();
                }
                ms.Close();
            }
        }

        public void AssignFrom(MapControl Source)
        {
            Source.AssignTo(this);
        }

        public void SaveStream(Stream stream, BinaryWriter bw)
        {
            try
            {
                bw.Write(m_Item_Col);
                bw.Write(m_Item_Row);
                bw.Write(m_Seg_Col);
                bw.Write(m_Seg_Row);
                bw.Write(m_Fil_Col);
                bw.Write(m_Fil_Row);

                bw.Write((int)m_HeadLoc_Col);
                bw.Write((int)m_HeadLoc_Row);

                bw.Write((int)m_HeadTextType_Col);
                bw.Write((int)m_HeadTextType_Row);

                bw.Write(m_HeadNumStartOne_Col);
                bw.Write(m_HeadNumStartOne_Row);

                bw.Write(m_VisiableLabel);
                bw.Write(m_VisiableTriNum);
                bw.Write(m_VisiableIndex);

                bw.Write((int)m_FillDirection);

                bw.Write(m_Clr_Border.ToArgb());
                bw.Write(m_Clr_ItemBorder.ToArgb());
                bw.Write(m_Clr_Header.ToArgb());

                for (int i = 0; i < m_Clr_Result.Length; i++)
                    bw.Write(m_Clr_Result[i].ToArgb());

                bw.Write(m_Clr_Selected.ToArgb());
                bw.Write(m_Clr_Active.ToArgb());

                bw.Write(m_DistanceItem);
                bw.Write(m_DistanceSeg);
                bw.Write(m_BorderSize);

                bw.Write(m_Padding.Left);
                bw.Write(m_Padding.Top);
                bw.Write(m_Padding.Right);
                bw.Write(m_Padding.Bottom);

                bw.Write(m_LineWidth);
                bw.Write(m_RoundRectFact);

                for (int col = 0; col < m_Item_Col; col++)
                    for (int row = 0; row < m_Item_Row; row++)
                        bw.Write((int)m_Status[col, row]);

                for (int col = 0; col < m_Item_Col; col++)
                    for (int row = 0; row < m_Item_Row; row++)
                        bw.Write(m_ItemTriNums[col, row]);

                for (int col = 0; col < m_Item_Col; col++)
                    for (int row = 0; row < m_Item_Row; row++)
                        bw.Write(m_ItemIndexs[col, row]);
            }
            catch { }
        }

        public void LoadStream(Stream stream, BinaryReader br)
        {
            try
            {
                m_Item_Col = br.ReadInt32();
                m_Item_Row = br.ReadInt32();
                m_Seg_Col = br.ReadInt32();
                m_Seg_Row = br.ReadInt32();
                m_Fil_Col = br.ReadInt32();
                m_Fil_Row = br.ReadInt32();

                m_HeadLoc_Col = (eMapColHeadLocation)br.ReadInt32();
                m_HeadLoc_Row = (eMapRowHeadLocation)br.ReadInt32();

                m_HeadTextType_Col = (eMapLabelType)br.ReadInt32();
                m_HeadTextType_Row = (eMapLabelType)br.ReadInt32();

                m_HeadNumStartOne_Col = br.ReadBoolean();
                m_HeadNumStartOne_Row = br.ReadBoolean();

                m_VisiableLabel = br.ReadBoolean();
                m_VisiableTriNum = br.ReadBoolean();
                m_VisiableIndex = br.ReadBoolean();

                m_FillDirection = (eMapDirection)br.ReadInt32();

                m_Clr_Border = Color.FromArgb(br.ReadInt32());
                m_Clr_ItemBorder = Color.FromArgb(br.ReadInt32());
                m_Clr_Header = Color.FromArgb(br.ReadInt32());

                for (int i = 0; i < m_Clr_Result.Length; i++)
                    m_Clr_Result[i] = Color.FromArgb(br.ReadInt32());

                m_Clr_Selected = Color.FromArgb(br.ReadInt32());
                m_Clr_Active = Color.FromArgb(br.ReadInt32());

                m_DistanceItem = br.ReadInt32();
                m_DistanceSeg = br.ReadInt32();
                m_BorderSize = br.ReadInt32();

                m_Padding.Left = br.ReadInt32();
                m_Padding.Top = br.ReadInt32();
                m_Padding.Right = br.ReadInt32();
                m_Padding.Bottom = br.ReadInt32();

                m_LineWidth = br.ReadInt32();
                m_RoundRectFact = br.ReadSingle();

                ReStruct();

                for (int col = 0; col < m_Item_Col; col++)
                    for (int row = 0; row < m_Item_Row; row++)
                        m_Status[col, row] = (eMapStatus)br.ReadInt32();

                for (int col = 0; col < m_Item_Col; col++)
                    for (int row = 0; row < m_Item_Row; row++)
                        m_ItemTriNums[col, row] = br.ReadInt32();

                for (int col = 0; col < m_Item_Col; col++)
                    for (int row = 0; row < m_Item_Row; row++)
                        m_ItemIndexs[col, row] = br.ReadInt32();

                ResizeRect();
                Invalidate();
            }
            catch { }
        }

        public void SaveToFile(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    SaveStream(fs, bw);
                    bw.Close();
                }
                fs.Close();
            }
        }

        public void LoadFromFile(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    LoadStream(fs, br);
                    br.Close();
                }
                fs.Close();
            }
        }

        #endregion 초기화 및 저장, 불러오기

        #region 내부 함수

        private void ReStruct()
        {
            try
            {
                if (m_HeadRects_Col == null || m_HeadRects_Col.Length != m_Item_Col)
                    m_HeadRects_Col = new RectangleF[m_Item_Col];

                if (m_HeadRects_Row == null || m_HeadRects_Row.Length != m_Item_Row)
                    m_HeadRects_Row = new RectangleF[m_Item_Row];

                if (m_HeadTexts_Col == null || m_HeadTexts_Col.Length != m_Item_Col)
                    m_HeadTexts_Col = new string[m_Item_Col];

                if (m_HeadTexts_Row == null || m_HeadTexts_Row.Length != m_Item_Row)
                    m_HeadTexts_Row = new string[m_Item_Row];

                if (m_ItemRects == null || m_ItemRects.GetLength(0) != m_Item_Col || m_ItemRects.GetLength(1) != m_Item_Row)
                    m_ItemRects = new RectangleF[m_Item_Col, m_Item_Row];

                if (m_Status == null || m_Status.GetLength(0) != m_Item_Col || m_Status.GetLength(1) != m_Item_Row)
                    m_Status = new eMapStatus[m_Item_Col, m_Item_Row];

                if (m_ItemLabels == null || m_ItemLabels.GetLength(0) != m_Item_Col || m_ItemLabels.GetLength(1) != m_Item_Row)
                    m_ItemLabels = new string[m_Item_Col, m_Item_Row];

                if (m_ItemTriNums == null || m_ItemTriNums.GetLength(0) != m_Item_Col || m_ItemTriNums.GetLength(1) != m_Item_Row)
                    m_ItemTriNums = new int[m_Item_Col, m_Item_Row];

                if (m_ItemIndexs == null || m_ItemIndexs.GetLength(0) != m_Item_Col || m_ItemIndexs.GetLength(1) != m_Item_Row)
                    m_ItemIndexs = new int[m_Item_Col, m_Item_Row];

                m_TriCntPerSegCol = (m_Seg_Col - 1) / m_Fil_Col + 1;
                m_TriCntPerSegRow = (m_Seg_Row - 1) / m_Fil_Row + 1;

                m_TotalTriCntCol = m_Item_Col / m_Seg_Col * m_TriCntPerSegCol + (m_Item_Col % m_Seg_Col != 0 ? (m_Item_Col % m_Seg_Col - 1) / m_Fil_Col + 1 : 0);
                m_TotalTriCntRow = m_Item_Row / m_Seg_Row * m_TriCntPerSegRow + (m_Item_Row % m_Seg_Row != 0 ? (m_Item_Row % m_Seg_Row - 1) / m_Fil_Row + 1 : 0);
            }
            catch
            {
                m_TriCntPerSegCol = -1;
                m_TriCntPerSegRow = -1;

                m_TotalTriCntCol = -1;
                m_TotalTriCntRow = -1;
            }
        }

        private void ResizeRect()
        {
            float width = Width - 1 - ((m_Item_Col - 1) * m_DistanceItem) - ((m_Item_Col - 1) / m_Seg_Col * m_DistanceSeg) - (m_BorderSize * 2) - (m_Padding.Left + m_Padding.Right);
            float height = Height - 1 - ((m_Item_Row - 1) * m_DistanceItem) - ((m_Item_Row - 1) / m_Seg_Row * m_DistanceSeg) - (m_BorderSize * 2) - (m_Padding.Top + m_Padding.Bottom);

            if (m_HeadLoc_Row != eMapRowHeadLocation.None)
            {
                width -= m_DistanceSeg;
                width /= m_Item_Col + 1;
            }
            else
                width /= m_Item_Col;

            if (m_HeadLoc_Col != eMapColHeadLocation.None)
            {
                height -= m_DistanceSeg;
                height /= m_Item_Row + 1;
            }
            else
                height /= m_Item_Row;

            #region Header

            {
                // HeadRect_Col
                if (m_HeadLoc_Col != eMapColHeadLocation.None)
                {
                    float tmpX = m_BorderSize - m_DistanceSeg;

                    for (int i = 0; i < m_HeadRects_Col.Length; i++)
                    {
                        if (i % m_Seg_Col == 0)
                            tmpX += m_DistanceSeg;

                        m_HeadRects_Col[i].Width = width;
                        m_HeadRects_Col[i].Height = height;

                        if (((int)m_FillDirection & 0b0010) != 0b0010)
                        {
                            m_HeadRects_Col[i].X = tmpX + m_Padding.Left;

                            if (m_HeadLoc_Row == eMapRowHeadLocation.Left) m_HeadRects_Col[i].X += width + m_DistanceSeg + m_DistanceItem;
                        }
                        else
                        {
                            m_HeadRects_Col[i].X = Width - (tmpX + width + m_Padding.Right);

                            if (m_HeadLoc_Row == eMapRowHeadLocation.Right) m_HeadRects_Col[i].X -= width + m_DistanceSeg + m_DistanceItem;
                        }

                        m_HeadRects_Col[i].Y = m_HeadLoc_Col == eMapColHeadLocation.Top ? m_BorderSize + m_Padding.Top : Height - (m_BorderSize + height + m_Padding.Bottom);

                        switch (m_HeadTextType_Col)
                        {
                            case eMapLabelType.Alphabet:
                                m_HeadTexts_Col[i] = AlphabetString.Substring(i, 1);
                                break;

                            case eMapLabelType.Number:
                                if (m_HeadNumStartOne_Col)
                                    m_HeadTexts_Col[i] = (i + 1).ToString();
                                else
                                    m_HeadTexts_Col[i] = i.ToString();
                                break;
                        }

                        tmpX += width + m_DistanceItem;
                    }
                }
                else
                {
                    switch (m_HeadTextType_Col)
                    {
                        case eMapLabelType.Alphabet:
                            for (int i = 0; i < m_HeadRects_Col.Length; i++)
                                m_HeadTexts_Col[i] = AlphabetString.Substring(i, 1);
                            break;

                        case eMapLabelType.Number:
                            if (m_HeadNumStartOne_Col)
                                for (int i = 0; i < m_HeadRects_Col.Length; i++)
                                    m_HeadTexts_Col[i] = (i + 1).ToString();
                            else
                                for (int i = 0; i < m_HeadRects_Col.Length; i++)
                                    m_HeadTexts_Col[i] = i.ToString();
                            break;
                    }
                }

                // HeadRect_Row
                if (m_HeadLoc_Row != eMapRowHeadLocation.None)
                {
                    float tmpY = m_BorderSize - m_DistanceSeg;

                    for (int i = 0; i < m_HeadRects_Row.Length; i++)
                    {
                        if (i % m_Seg_Row == 0)
                            tmpY += m_DistanceSeg;

                        m_HeadRects_Row[i].Width = width;
                        m_HeadRects_Row[i].Height = height;

                        m_HeadRects_Row[i].X = m_HeadLoc_Row == eMapRowHeadLocation.Left ? m_BorderSize + m_Padding.Left : Width - (m_BorderSize + width + m_Padding.Right);

                        if (((int)m_FillDirection & 0b0001) != 0b0001)
                        {
                            m_HeadRects_Row[i].Y = tmpY + m_Padding.Top;

                            if (m_HeadLoc_Col == eMapColHeadLocation.Top) m_HeadRects_Row[i].Y += height + m_DistanceSeg + m_DistanceItem;
                        }
                        else
                        {
                            m_HeadRects_Row[i].Y = Height - (tmpY + height + m_Padding.Top);

                            if (m_HeadLoc_Col == eMapColHeadLocation.Bottom) m_HeadRects_Row[i].Y -= height + m_DistanceSeg + m_DistanceItem;
                        }

                        switch (m_HeadTextType_Row)
                        {
                            case eMapLabelType.Alphabet:
                                m_HeadTexts_Row[i] = AlphabetString.Substring(i, 1);
                                break;

                            case eMapLabelType.Number:
                                if (m_HeadNumStartOne_Row)
                                    m_HeadTexts_Row[i] = (i + 1).ToString();
                                else
                                    m_HeadTexts_Row[i] = i.ToString();
                                break;
                        }

                        tmpY += height + m_DistanceItem;
                    }
                }
                else
                {
                    switch (m_HeadTextType_Row)
                    {
                        case eMapLabelType.Alphabet:
                            for (int i = 0; i < m_HeadRects_Row.Length; i++)
                                m_HeadTexts_Row[i] = AlphabetString.Substring(i, 1);
                            break;

                        case eMapLabelType.Number:
                            if (m_HeadNumStartOne_Row)
                                for (int i = 0; i < m_HeadRects_Row.Length; i++)
                                    m_HeadTexts_Row[i] = (i + 1).ToString();
                            else
                                for (int i = 0; i < m_HeadRects_Row.Length; i++)
                                    m_HeadTexts_Row[i] = i.ToString();
                            break;
                    }
                }
            }

            #endregion Header

            #region Items

            {
                float tmpX = m_BorderSize - m_DistanceSeg;
                float tmpY = m_BorderSize - m_DistanceSeg;
                int idx = 0;

                if (((int)m_FillDirection & 0b0100) == 0b0100)
                {
                    for (int col = 0; col < m_ItemRects.GetLength(0); col++)
                    {
                        if (col % m_Seg_Col == 0)
                            tmpX += m_DistanceSeg;

                        tmpY = m_BorderSize - m_DistanceSeg;

                        for (int row = 0; row < m_ItemRects.GetLength(1); row++)
                        {
                            if (row % m_Seg_Row == 0)
                                tmpY += m_DistanceSeg;

                            m_ItemRects[col, row].Width = width;
                            m_ItemRects[col, row].Height = height;

                            if (((int)m_FillDirection & 0b0010) != 0b0010)
                            {
                                m_ItemRects[col, row].X = tmpX + m_Padding.Left;

                                if (m_HeadLoc_Row == eMapRowHeadLocation.Left) m_ItemRects[col, row].X += width + m_DistanceSeg + m_DistanceItem;
                            }
                            else
                            {
                                m_ItemRects[col, row].X = Width - (tmpX + width + m_Padding.Right) - 1;

                                if (m_HeadLoc_Row == eMapRowHeadLocation.Right) m_ItemRects[col, row].X -= width + m_DistanceSeg + m_DistanceItem;
                            }

                            if (((int)m_FillDirection & 0b0001) != 0b0001)
                            {
                                m_ItemRects[col, row].Y = tmpY + m_Padding.Top;

                                if (m_HeadLoc_Col == eMapColHeadLocation.Top) m_ItemRects[col, row].Y += height + m_DistanceSeg + m_DistanceItem;
                            }
                            else
                            {
                                m_ItemRects[col, row].Y = Height - (tmpY + height + m_Padding.Bottom) - 1;

                                if (m_HeadLoc_Col == eMapColHeadLocation.Bottom) m_ItemRects[col, row].Y -= height + m_DistanceSeg + m_DistanceItem;
                            }

                            tmpY += height + m_DistanceItem;

                            m_ItemLabels[col, row] = m_HeadTexts_Col[col] + "-" + m_HeadTexts_Row[row];

                            if (((int)m_FillDirection & 0b1000) == 0b1000 && col % 2 != 0)
                                m_ItemIndexs[col, row] = --idx;
                            else m_ItemIndexs[col, row] = idx++;
                        }

                        tmpX += width + m_DistanceItem;

                        if (((int)m_FillDirection & 0b1000) == 0b1000)
                            idx += m_ItemRects.GetLength(1);
                    }
                }
                else
                {
                    for (int row = 0; row < m_ItemRects.GetLength(1); row++)
                    {
                        if (row % m_Seg_Row == 0)
                            tmpY += m_DistanceSeg;

                        tmpX = m_BorderSize - m_DistanceSeg;

                        for (int col = 0; col < m_ItemRects.GetLength(0); col++)
                        {
                            if (col % m_Seg_Col == 0)
                                tmpX += m_DistanceSeg;

                            m_ItemRects[col, row].Width = width;
                            m_ItemRects[col, row].Height = height;

                            if (((int)m_FillDirection & 0b0010) != 0b0010)
                            {
                                m_ItemRects[col, row].X = tmpX + m_Padding.Left;

                                if (m_HeadLoc_Row == eMapRowHeadLocation.Left) m_ItemRects[col, row].X += width + m_DistanceSeg + m_DistanceItem;
                            }
                            else
                            {
                                m_ItemRects[col, row].X = Width - (tmpX + width + m_Padding.Right) - 1;

                                if (m_HeadLoc_Row == eMapRowHeadLocation.Right) m_ItemRects[col, row].X -= width + m_DistanceSeg + m_DistanceItem;
                            }

                            if (((int)m_FillDirection & 0b0001) != 0b0001)
                            {
                                m_ItemRects[col, row].Y = tmpY + m_Padding.Top;

                                if (m_HeadLoc_Col == eMapColHeadLocation.Top) m_ItemRects[col, row].Y += height + m_DistanceSeg + m_DistanceItem;
                            }
                            else
                            {
                                m_ItemRects[col, row].Y = Height - (tmpY + height + m_Padding.Bottom) - 1;

                                if (m_HeadLoc_Col == eMapColHeadLocation.Bottom) m_ItemRects[col, row].Y -= height + m_DistanceSeg + m_DistanceItem;
                            }

                            tmpX += width + m_DistanceItem;

                            m_ItemLabels[col, row] = m_HeadTexts_Col[col] + "-" + m_HeadTexts_Row[row];

                            if (((int)m_FillDirection & 0b1000) == 0b1000 && row % 2 != 0)
                                m_ItemIndexs[col, row] = --idx;
                            else m_ItemIndexs[col, row] = idx++;
                        }

                        tmpY += height + m_DistanceItem;

                        if (((int)m_FillDirection & 0b1000) == 0b1000)
                            idx += m_ItemRects.GetLength(0);
                    }
                }
            }

            #endregion Items
        }

        /// <summary>
        /// Invalidate() 사용 시 이벤트 연동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MapControl_Paint(object sender, PaintEventArgs e)
        {
            if (InvokeRequired)
                Invoke(new MethodInvoker(delegate () { MapControl_Paint(sender, e); return; }));

            Graphics gra = e.Graphics;
            gra.SmoothingMode = SmoothingMode.Default;

            GraphicsPath path = new GraphicsPath();

            StringFormat strfm = new StringFormat();
            strfm.LineAlignment = StringAlignment.Center;
            strfm.Alignment = StringAlignment.Center;

            for (int m = 0; m < m_BorderSize; m++)
                gra.DrawRectangle(new Pen(m_Clr_Border, 1), m, m, Width - 1 - m * 2, Height - 1 - m * 2);

            if (m_HeadLoc_Col != eMapColHeadLocation.None)
                for (int i = 0; i < m_HeadRects_Col.Length; i++)
                {
                    GetRoundedRectPath(ref path, m_HeadRects_Col[i], m_RoundRectFact);
                    gra.FillPath(new SolidBrush(m_Clr_Header), path);
                    gra.DrawPath(new Pen(m_Clr_ItemBorder, m_LineWidth), path);
                    gra.DrawString(m_HeadTexts_Col[i], Font, new SolidBrush(ForeColor),
                        m_HeadRects_Col[i].X + m_HeadRects_Col[i].Width / 2,
                        m_HeadRects_Col[i].Y + m_HeadRects_Col[i].Height / 2, strfm);
                }

            if (m_HeadLoc_Row != eMapRowHeadLocation.None)
                for (int i = 0; i < m_HeadRects_Row.Length; i++)
                {
                    GetRoundedRectPath(ref path, m_HeadRects_Row[i], m_RoundRectFact);
                    gra.FillPath(new SolidBrush(m_Clr_Header), path);
                    gra.DrawPath(new Pen(m_Clr_ItemBorder, m_LineWidth), path);
                    gra.DrawString(m_HeadTexts_Row[i], Font, new SolidBrush(ForeColor),
                        m_HeadRects_Row[i].X + m_HeadRects_Row[i].Width / 2,
                        m_HeadRects_Row[i].Y + m_HeadRects_Row[i].Height / 2, strfm);
                }

            for (int col = 0; col < m_ItemRects.GetLength(0); col++)
            {
                for (int row = 0; row < m_ItemRects.GetLength(1); row++)
                {
                    GetRoundedRectPath(ref path, m_ItemRects[col, row], m_RoundRectFact);
                    gra.FillPath(new SolidBrush(m_Clr_Result[(int)m_Status[col, row]]), path);
                    gra.DrawPath(new Pen(m_Clr_ItemBorder, m_LineWidth), path);

                    if (m_VisiableLabel)
                    {
                        gra.DrawString(m_ItemLabels[col, row], Font, new SolidBrush(ForeColor),
                            m_ItemRects[col, row].X + m_ItemRects[col, row].Width / 2,
                            m_ItemRects[col, row].Y + m_ItemRects[col, row].Height * 2 / 4, strfm);

                        if (m_VisiableTriNum)
                        {
                            gra.DrawString(m_ItemTriNums[col, row].ToString(), Font, new SolidBrush(ForeColor),
                                m_ItemRects[col, row].X + m_ItemRects[col, row].Width / 2,
                                m_ItemRects[col, row].Y + m_ItemRects[col, row].Height / 4, strfm);
                        }

                        if (m_VisiableIndex)
                        {
                            gra.DrawString(m_ItemIndexs[col, row].ToString(), Font, new SolidBrush(ForeColor),
                                m_ItemRects[col, row].X + m_ItemRects[col, row].Width / 2,
                                m_ItemRects[col, row].Y + m_ItemRects[col, row].Height * 3 / 4, strfm);
                        }
                    }
                    else
                    {
                        if (m_VisiableTriNum)
                        {
                            gra.DrawString(m_ItemTriNums[col, row].ToString(), Font, new SolidBrush(ForeColor),
                                m_ItemRects[col, row].X + m_ItemRects[col, row].Width / 2,
                                m_ItemRects[col, row].Y + m_ItemRects[col, row].Height / 3, strfm);
                        }

                        if (m_VisiableIndex)
                        {
                            gra.DrawString(m_ItemIndexs[col, row].ToString(), Font, new SolidBrush(ForeColor),
                                m_ItemRects[col, row].X + m_ItemRects[col, row].Width / 2,
                                m_ItemRects[col, row].Y + m_ItemRects[col, row].Height * 2 / 3, strfm);
                        }
                    }

                    if (m_SelectedEnable && col == m_Selected_Col && row == m_Selected_Row)
                    {
                        RectangleF tmpRect = new RectangleF();

                        tmpRect.X = m_ItemRects[col, row].X + 1;
                        tmpRect.Y = m_ItemRects[col, row].Y + 1;
                        tmpRect.Width = m_ItemRects[col, row].Width - 2;
                        tmpRect.Height = m_ItemRects[col, row].Height - 2;

                        GetRoundedRectPath(ref path, tmpRect, m_RoundRectFact);
                        gra.DrawPath(new Pen(m_Clr_Selected, 1), path);
                    }

                    if (m_ActiveEnable && col == m_Active_Col && row == m_Active_Row)
                    {
                        RectangleF tmpRect = new RectangleF();

                        tmpRect.X = m_ItemRects[col, row].X + 2;
                        tmpRect.Y = m_ItemRects[col, row].Y + 2;
                        tmpRect.Width = m_ItemRects[col, row].Width - 4;
                        tmpRect.Height = m_ItemRects[col, row].Height - 4;
                        GetRoundedRectPath(ref path, tmpRect, m_RoundRectFact);
                        gra.DrawPath(new Pen(m_Clr_Active, 1), path);
                    }
                }
            }
        }

        private void MapControl_Resize(object sender, EventArgs e)
        {
            ResizeRect();
            Invalidate();
        }

        private void MapControl_MouseLeave(object sender, EventArgs e)
        {
            if (m_ActiveEnable)
            {
                m_Active_Col = -1;
                m_Active_Row = -1;

                Invalidate();
            }
        }

        private void MapControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (m_SelectedEnable)
            {
                m_Selected_Col = -1;
                m_Selected_Row = -1;

                for (int col = 0; col < m_ItemRects.GetLength(0); col++)
                    for (int row = 0; row < m_ItemRects.GetLength(1); row++)
                    {
                        if (m_ItemRects[col, row].Contains(e.X, e.Y))
                        {
                            m_Selected_Col = col;
                            m_Selected_Row = row;
                            break;
                        }
                    }

                if (m_Selected_Col > -1 || m_Selected_Row > -1)
                {
                    _OnSelected?.Invoke(this, new MapEventArgs(m_Selected_Col, m_Selected_Row, m_ItemTriNums[m_Selected_Col, m_Selected_Row], m_ItemIndexs[m_Selected_Col, m_Selected_Row], m_Status[m_Selected_Col, m_Selected_Row]));

                    Invalidate();
                }
            }
        }

        private void MapControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (m_ActiveEnable)
            {
                m_Active_Col = -1;
                m_Active_Row = -1;

                for (int col = 0; col < m_ItemRects.GetLength(0); col++)
                    for (int row = 0; row < m_ItemRects.GetLength(1); row++)
                    {
                        if (m_ItemRects[col, row].Contains(e.X, e.Y))
                        {
                            m_Active_Col = col;
                            m_Active_Row = row;
                            break;
                        }
                    }

                if (m_Selected_Col > -1 || m_Selected_Row > -1)
                {
                    _OnActive?.Invoke(this, new MapEventArgs(m_Active_Col, m_Active_Row, m_ItemTriNums[m_Active_Col, m_Active_Row], m_ItemIndexs[m_Active_Col, m_Active_Row], m_Status[m_Active_Col, m_Active_Row]));

                    Invalidate();
                }
            }
        }

        private void GetRoundedRectPath(ref GraphicsPath path, RectangleF rect, float roundFact)
        {
            path.Reset();

            float len = Math.Min(rect.Width, rect.Height);
            float dia = len * roundFact;

            if (dia == 0.0) dia = 1.0f;

            RectangleF arcRect = new RectangleF(rect.Location, new SizeF(dia, dia));

            path.AddArc(arcRect, 180.0f, 90.0f);

            arcRect.X = rect.Right - dia;
            path.AddArc(arcRect, 270.0f, 90.0f);

            arcRect.Y = rect.Bottom - dia;
            path.AddArc(arcRect, 0.0f, 90.0f);

            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90.0f, 90.0f);

            path.CloseFigure();
        }

        #endregion 내부 함수

        #region Properties

        public int ItemCount_Col
        {
            get { return m_Item_Col; }
            set
            {
                if (m_Item_Col != value)
                {
                    m_Item_Col = value;

                    if (m_Item_Col < m_Seg_Col) SegmentCount_Col = m_Item_Col;

                    ReStruct();
                    ResizeRect();
                    Invalidate();
                }
            }
        }

        public int ItemCount_Row
        {
            get { return m_Item_Row; }
            set
            {
                if (m_Item_Row != value)
                {
                    m_Item_Row = value;

                    if (m_Item_Row < m_Seg_Row) SegmentCount_Row = m_Item_Row;

                    ReStruct();
                    ResizeRect();
                    Invalidate();
                }
            }
        }

        public int SegmentCount_Col
        {
            get { return m_Seg_Col; }
            set
            {
                if (m_Seg_Col != value)
                {
                    if (m_Item_Col < value) m_Seg_Col = m_Item_Col;
                    else m_Seg_Col = value;

                    if (m_Seg_Col < m_Fil_Col) FillCount_Col = m_Seg_Col;

                    ReStruct();
                    ResizeRect();
                    Invalidate();
                }
            }
        }

        public int SegmentCount_Row
        {
            get { return m_Seg_Row; }
            set
            {
                if (m_Seg_Row != value)
                {
                    if (m_Item_Row < value) m_Seg_Row = m_Item_Row;
                    else m_Seg_Row = value;

                    if (m_Seg_Row < m_Fil_Row) FillCount_Row = m_Seg_Row;

                    ReStruct();
                    ResizeRect();
                    Invalidate();
                }
            }
        }

        public int FillCount_Col
        {
            get { return m_Fil_Col; }
            set
            {
                if (m_Fil_Col != value)
                {
                    if (m_Seg_Col < value) m_Fil_Row = m_Seg_Col;
                    else m_Fil_Col = value;

                    ReStruct();
                    ResizeRect();
                    Invalidate();
                }
            }
        }

        public int FillCount_Row
        {
            get { return m_Fil_Row; }
            set
            {
                if (m_Fil_Row != value)
                {
                    if (m_Seg_Row < value) m_Fil_Row = m_Seg_Row;
                    else m_Fil_Row = value;

                    ReStruct();
                    ResizeRect();
                    Invalidate();
                }
            }
        }

        public eMapColHeadLocation ColumnHeadLocation
        {
            get { return m_HeadLoc_Col; }
            set
            {
                if (m_HeadLoc_Col != value)
                {
                    m_HeadLoc_Col = value;
                    ResizeRect();
                    Invalidate();
                }
            }
        }

        public eMapRowHeadLocation RowHeadLocation
        {
            get { return m_HeadLoc_Row; }
            set
            {
                if (m_HeadLoc_Row != value)
                {
                    m_HeadLoc_Row = value;
                    ResizeRect();
                    Invalidate();
                }
            }
        }

        public eMapLabelType CulumnTextType
        {
            get { return m_HeadTextType_Col; }
            set
            {
                if (m_HeadTextType_Col != value)
                {
                    m_HeadTextType_Col = value;
                    ResizeRect();
                    Invalidate();
                }
            }
        }

        public eMapLabelType RowTextType
        {
            get { return m_HeadTextType_Row; }
            set
            {
                if (m_HeadTextType_Row != value)
                {
                    m_HeadTextType_Row = value;
                    ResizeRect();
                    Invalidate();
                }
            }
        }

        public bool ColumnNumberStartOne
        {
            get { return m_HeadNumStartOne_Col; }
            set
            {
                if (m_HeadNumStartOne_Col != value)
                {
                    m_HeadNumStartOne_Col = value;
                    ResizeRect();
                    Invalidate();
                }
            }
        }

        public bool VisibleLabel
        {
            get { return m_VisiableLabel; }
            set
            {
                if (m_VisiableLabel != value)
                {
                    m_VisiableLabel = value;
                    Invalidate();
                }
            }
        }

        public bool VisiableTriNum
        {
            get { return m_VisiableTriNum; }
            set
            {
                if (m_VisiableTriNum != value)
                {
                    m_VisiableTriNum = value;
                    Invalidate();
                }
            }
        }

        public bool VisiableIndex
        {
            get { return m_VisiableIndex; }
            set
            {
                if (m_VisiableIndex != value)
                {
                    m_VisiableIndex = value;
                    Invalidate();
                }
            }
        }

        public eMapDirection FillDirection
        {
            get { return m_FillDirection; }
            set
            {
                if (m_FillDirection != value)
                {
                    m_FillDirection = value;
                    ResizeRect();
                    Invalidate();
                }
            }
        }

        public Color Color_Border
        {
            get { return m_Clr_Border; }
            set
            {
                m_Clr_Border = value;
                Invalidate();
            }
        }

        public Color Color_ItemBorder
        {
            get { return m_Clr_ItemBorder; }
            set
            {
                m_Clr_ItemBorder = value;
                Invalidate();
            }
        }

        public Color Color_Header
        {
            get { return m_Clr_Header; }
            set
            {
                m_Clr_Header = value;
                Invalidate();
            }
        }

        public Color Color_Ready
        {
            get { return m_Clr_Result[0]; }
            set
            {
                m_Clr_Result[0] = value;
                Invalidate();
            }
        }

        public Color Color_XMark
        {
            get { return m_Clr_Result[1]; }
            set
            {
                m_Clr_Result[1] = value;
                Invalidate();
            }
        }

        public Color Color_NotUse
        {
            get { return m_Clr_Result[2]; }
            set
            {
                m_Clr_Result[2] = value;
                Invalidate();
            }
        }

        public Color Color_Good
        {
            get { return m_Clr_Result[3]; }
            set
            {
                m_Clr_Result[3] = value;
                Invalidate();
            }
        }

        public Color Color_Res01
        {
            get { return m_Clr_Result[4]; }
            set
            {
                m_Clr_Result[4] = value;
                Invalidate();
            }
        }

        public Color Color_Res02
        {
            get { return m_Clr_Result[5]; }
            set
            {
                m_Clr_Result[5] = value;
                Invalidate();
            }
        }

        public Color Color_Res03
        {
            get { return m_Clr_Result[6]; }
            set
            {
                m_Clr_Result[6] = value;
                Invalidate();
            }
        }

        public Color Color_Res04
        {
            get { return m_Clr_Result[7]; }
            set
            {
                m_Clr_Result[7] = value;
                Invalidate();
            }
        }

        public Color Color_Res05
        {
            get { return m_Clr_Result[8]; }
            set
            {
                m_Clr_Result[8] = value;
                Invalidate();
            }
        }

        public Color Color_Res06
        {
            get { return m_Clr_Result[9]; }
            set
            {
                m_Clr_Result[9] = value;
                Invalidate();
            }
        }

        public Color Color_Res07
        {
            get { return m_Clr_Result[10]; }
            set
            {
                m_Clr_Result[10] = value;
                Invalidate();
            }
        }

        public Color Color_Res08
        {
            get { return m_Clr_Result[11]; }
            set
            {
                m_Clr_Result[11] = value;
                Invalidate();
            }
        }

        public Color Color_Res09
        {
            get { return m_Clr_Result[12]; }
            set
            {
                m_Clr_Result[12] = value;
                Invalidate();
            }
        }

        public Color Color_Res10
        {
            get { return m_Clr_Result[13]; }
            set
            {
                m_Clr_Result[13] = value;
                Invalidate();
            }
        }

        public Color Color_Res11
        {
            get { return m_Clr_Result[14]; }
            set
            {
                m_Clr_Result[14] = value;
                Invalidate();
            }
        }

        public Color Color_Res12
        {
            get { return m_Clr_Result[15]; }
            set
            {
                m_Clr_Result[15] = value;
                Invalidate();
            }
        }

        public Color Color_Res13
        {
            get { return m_Clr_Result[16]; }
            set
            {
                m_Clr_Result[16] = value;
                Invalidate();
            }
        }

        public Color Color_Res14
        {
            get { return m_Clr_Result[17]; }
            set
            {
                m_Clr_Result[17] = value;
                Invalidate();
            }
        }

        public Color Color_Res15
        {
            get { return m_Clr_Result[18]; }
            set
            {
                m_Clr_Result[18] = value;
                Invalidate();
            }
        }

        public Color Color_Res16
        {
            get { return m_Clr_Result[19]; }
            set
            {
                m_Clr_Result[19] = value;
                Invalidate();
            }
        }

        public Color Color_Selected
        {
            get { return m_Clr_Selected; }
            set
            {
                m_Clr_Selected = value;
                Invalidate();
            }
        }

        public Color Color_Active
        {
            get { return m_Clr_Active; }
            set
            {
                m_Clr_Active = value;
                Invalidate();
            }
        }

        public int DistanceItem
        {
            get { return m_DistanceItem; }
            set
            {
                m_DistanceItem = value;
                ResizeRect();
                Invalidate();
            }
        }

        public int DistanceSeg
        {
            get { return m_DistanceSeg; }
            set
            {
                m_DistanceSeg = value;
                ResizeRect();
                Invalidate();
            }
        }

        public int BorderSize
        {
            get { return m_BorderSize; }
            set
            {
                m_BorderSize = value;
                ResizeRect();
                Invalidate();
            }
        }

        public Padding DrawOffset
        {
            get { return m_Padding; }
            set
            {
                m_Padding = value;
                ResizeRect();
                Invalidate();
            }
        }

        public int CellLineWidth
        {
            get { return m_LineWidth; }
            set
            {
                m_LineWidth = value;
                Invalidate();
            }
        }

        public float RoundRectFact
        {
            get { return m_RoundRectFact; }
            set
            {
                m_RoundRectFact = value;
                Invalidate();
            }
        }

        public int TriggerCountPerSegCol
        { get { return m_TriCntPerSegCol; } }

        public int TriggerCountPerSegRow
        { get { return m_TriCntPerSegRow; } }

        public int TotalTriggerCountCol
        { get { return m_TotalTriCntCol; } }

        public int TotalTriggerCountRow
        { get { return m_TotalTriCntRow; } }

        #endregion Properties

        #region Event Handler

        public event MapEventHandler OnSelected
        {
            add
            {
                if (_OnSelected == null) _OnSelected += value;
                else lock (_OnSelected) _OnSelected += value;
            }
            remove
            {
                if (_OnSelected == null) return;
                else lock (_OnSelected) _OnSelected -= value;
            }
        }

        public event MapEventHandler OnActive
        {
            add
            {
                if (_OnActive == null) _OnActive += value;
                else
                    lock (_OnActive) _OnActive += value;
            }
            remove
            {
                if (_OnActive == null) return;
                else lock (_OnActive) _OnActive -= value;
            }
        }

        #endregion Event Handler

        /// <summary>
        /// Not Use를 제외한 모든 결과를 Ready로 돌린다
        /// </summary>
        public void SetStatusReadyAll()
        {
            for (int col = 0; col < m_Status.GetLength(0); col++)
                for (int row = 0; row < m_Status.GetLength(1); row++)
                    if (m_Status[col, row] != eMapStatus.NotUse)
                        m_Status[col, row] = eMapStatus.Ready;

            Invalidate();
        }

        /// <summary>
        /// 트리거 번호에 맞는 위치에 결과 삽입
        /// </summary>
        /// <param name="triNum">트리거 넘버 0 ~</param>
        /// <param name="skipNotUse">트리거넘버에 해당하는 위치가 전부 Not Use면 자동으로 다음 TriNum에 결과 삽입 default = true</param>
        /// <param name="status">결과 순서는 Direction과 동일하여야 함</param>
        public void SetStatuses(int triNum, bool skipNotUse, params eMapStatus[] status)
        {
            if (status.Length == m_Fil_Col * m_Fil_Row) return;

            m_TmpFillNum = 0;
        }

        public void SetStatus(int triNum, bool skipNotUse, eMapStatus status)
        {
            int idxX = -1;
            int idxY = -1;

            if (((int)m_FillDirection & 0b0100) == 0b0100)
            {
            }
            else
            {
                //idxX = m_Item_Col / m_Fil_Col
            }
        }

        /// <summary>
        /// Fill 영역에 들어오지 않아서 Not Use를 건너뛰었을 때 실제 트리거 넘버와 계산용 가상트리거를 연산해서 출력
        /// </summary>
        /// <param name="triNum">실제로 들어온 트리거 넘버</param>
        /// <returns></returns>
        public int GetVirTriNum(int triNum)
        {
            int ret = 0;

            while (ret != triNum)
            {
                for (int col = 0; col < m_Status.GetLength(0); col++)
                {
                    for (int row = 0; row <= m_Status.GetLength(1); row++)
                    {
                        if (m_Status[col, row] != eMapStatus.NotUse)
                        {
                        }
                    }
                }
            }
            return ret;
        }

        public void GetTriNumIndex(int triNum, out int col, out int row)
        {
            col = -1; row = -1;

            if (triNum == m_TotalTriCntCol * m_TotalTriCntRow) return;

            if (((int)m_FillDirection & 0b0100) == 0b0100)
            {
                int tmpNum = triNum;
                if (((int)m_FillDirection & 0b1000) == 0b1000 && triNum / m_TotalTriCntRow % 2 != 0)
                    tmpNum = m_TotalTriCntRow - triNum % m_TotalTriCntRow - 1;

                col = triNum / m_TotalTriCntRow * m_Fil_Col - triNum / m_TotalTriCntRow / m_TriCntPerSegCol * (m_Fil_Col - m_Seg_Col % m_Fil_Col);
                row = tmpNum % m_TotalTriCntRow * m_Fil_Row - tmpNum % m_TotalTriCntRow / m_TriCntPerSegRow * (m_Fil_Row - m_Seg_Row % m_Fil_Row);
            }
            else
            {
                int tmpNum = triNum;
                if (((int)m_FillDirection & 0b1000) == 0b1000 && triNum / m_TotalTriCntCol % 2 != 0)
                    tmpNum = m_TotalTriCntCol - triNum % m_TotalTriCntCol - 1;

                col = tmpNum % m_TotalTriCntCol * m_Fil_Col - tmpNum % m_TotalTriCntCol / m_TriCntPerSegCol * (m_Fil_Col - m_Seg_Col % m_Fil_Col);
                row = triNum / m_TotalTriCntCol * m_Fil_Row - triNum / m_TotalTriCntCol / m_TriCntPerSegRow * (m_Fil_Row - m_Seg_Row % m_Fil_Row);
            }
        }
    }
}