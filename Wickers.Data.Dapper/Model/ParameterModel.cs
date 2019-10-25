using System.Data;

namespace Wickers.Data.Dapper.Model
{
    public class ParameterModel
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public DbType DataType { get; set; }
        public ParameterDirection Direction { get; set; }
        public int Size { get; set; }
    }
}
