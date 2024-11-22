using System.Data;
using System.Data.SQLite;

namespace campus_molndal_oop_adv_todo.Data
{
    internal class TodoContext
    {
        private const string CONNECTION_STRING = "Data Source=todo.db";

        public IDbConnection GetConnection()
        {
            return new SQLiteConnection(CONNECTION_STRING);
        }
    }
}
