using System;

namespace Map
{
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
}