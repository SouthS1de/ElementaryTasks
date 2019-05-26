using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Cell
    {
        #region Prt Fields

        private int _rows;
        private int _colomns;

        #endregion

        #region Prop

        public ChessBoardColors CellColor
        {
            get
            {
                if (_rows % 2 != 0)
                {
                    if (_colomns % 2 == 0)
                        return ChessBoardColors.Black;
                    else
                        return ChessBoardColors.White;
                }
                else
                {
                    if (_colomns % 2 == 0)
                        return ChessBoardColors.White;
                    else
                        return ChessBoardColors.Black;
                }
            }
        }

        #endregion

        #region Ctor

        public Cell(int rows, int colomns)
        {
            _rows = rows;
            _colomns = colomns;
        }

        #endregion
    }
}
