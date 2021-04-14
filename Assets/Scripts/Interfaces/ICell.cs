namespace UnNumber
{
    public interface ICell
    {
        public string Value { get; set; }
        public CellType Type { get; set; }
    }
}