using System.Data.Common;

namespace Model
{
    public sealed class SqlDataWouldBeTruncatedException : DbException
    {
        public SqlDataWouldBeTruncatedException() : base() { }
        public SqlDataWouldBeTruncatedException(string message) : base(message) { }
    }
}
