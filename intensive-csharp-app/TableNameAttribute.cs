using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intensive_csharp_app
{
    public  class TableNameAttribute: Attribute
    {
        private string _tableName = String.Empty;

        public TableNameAttribute(string tableName) {
            _tableName = tableName;
        }

        public string TableName => _tableName;

    }
}
