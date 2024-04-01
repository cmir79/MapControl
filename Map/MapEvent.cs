using System;

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
}