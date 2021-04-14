using System.Collections.Generic;

namespace UnNumber
{
    public interface IGrid
    {
        public List<ICell> Cells { get;}
        public int GridSize { get; }

        public void UpdateCell(string value, int index);
    }
}