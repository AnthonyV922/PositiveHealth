using System;
using System.Collections.Generic;
using System.Text;

namespace PositiveHealth.Data
{
    using SQLite;

    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
