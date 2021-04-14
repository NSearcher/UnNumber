using System.Collections.Generic;

namespace UnNumber
{
    public class UnNumberGrid : IGrid
    {
        private readonly int _minValue;
        private readonly int _maxValue;

        public UnNumberGrid(List<ICell> cells, int min = -99, int max = 99, int size = 5)
        {
            _minValue = min;
            _maxValue = max;

            GridSize = size;
            Cells = cells;
        }

        public List<ICell> Cells { get; private set; }
        public int GridSize { get; private set; }

        public void UpdateCell(string value, int index)
        {
            int currentValue = int.Parse(value);

            if (currentValue < _minValue || currentValue > _maxValue || Cells[index].Type == CellType.MenuCell)
                throw new System.Exception("Incorrect value or type");

            Cells[index].Value = value;
        }
    }
}
