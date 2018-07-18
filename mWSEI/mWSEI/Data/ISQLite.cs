using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace mWSEI.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
