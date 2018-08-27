using System.Data;

namespace TIIDE.Compile
{
    internal class SQLiteConnection : IDbConnection
    {
        private object p;

        public SQLiteConnection(object p)
        {
            this.p = p;
        }
    }
}