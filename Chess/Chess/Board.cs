using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Board
    {
        #region Prop

        public Cell[,] CellsTable { get; set; }
        public int Rows     { get; set; }
        public int Colomns  { get; set; }

        #endregion

        #region Ctor

        public Board(int rows, int colomns)
        {
            Rows = rows;
            Colomns  = colomns;

            CellsTable = new Cell[Rows, Colomns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Colomns; j++)
                {
                    CellsTable[i, j] = new Cell(i + 1, j + 1);
                }
            }

        }

        #endregion
    }
}
