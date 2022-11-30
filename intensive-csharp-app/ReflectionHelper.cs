using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace intensive_csharp_app
{
    public static class ReflectionHelper
    {
        public static string GetTableName(Type gpsdModelType)
        {
            var items = gpsdModelType.GetCustomAttributes();
            foreach (var item in items)
            {
                if (item.GetType() == typeof(TableNameAttribute))
                {
                    var result = item as TableNameAttribute;
                    return result?.TableName ?? "";
                }
            }
            return string.Empty;
        }


        public static Dictionary<string, object?> GetProperties(object gpsdModel)
        {
            var result = new Dictionary<string, object?>();
            var type = gpsdModel.GetType();
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                result.Add(property.Name, property.GetValue(gpsdModel));


            }

            return result;

        }


        public static string get_data_all(object gpsdModel) {
            var sql_querry = $"SELECT * FROM {ReflectionHelper.GetTableName(gpsdModel.GetType())}";
            return string.Empty;
        }



        public static string GetHeaderForSelectQuerry(Dictionary<string, object> peopertises) => String.Join(", ", peopertises.Keys);


        public static string generateSqlQuerryGet(object obj) {
            var properties = ReflectionHelper.GetProperties(obj);
            var header = ReflectionHelper.GetHeaderForSelectQuerry(properties);
            var result = $"select * from {ReflectionHelper.GetTableName(typeof(GpsdVersionModel))}";
            return result;
        }




        public static void selectThrow(string sql)
        {
            var connection = new  Npgsql.NpgsqlConnection();
            connection.ConnectionString = string.Format("User ID={0};Password={1};Host={2};Port={3};Database={4};Pooling=true;", "gpsd", "123456", "192.168.88.75","5432" ,"gpsd");
            connection.Open();
            var command = new Npgsql.NpgsqlCommand(sql, connection);
            var reader = command.ExecuteReader();
            while (reader.Read()) {
                Console.WriteLine(reader["id"]);
            }

        }


        public static string doSqlQuerry_insert(object gpsdModel, bool is_easy) {

            var result = GetProperties(gpsdModel);

            if (is_easy) {

                var sql_querry = $"INSERT INTO {ReflectionHelper.GetTableName(gpsdModel.GetType())} SELECT ";
                var values = " ";
                int a = 1;
                foreach (var item in GetProperties(gpsdModel))
                {
                    var current_value = item.Value;
                    var string_value = "";
                    if (current_value.GetType() != a.GetType())
                    {
                        string_value = $"'{current_value}'";
                    }
                    else string_value = current_value.ToString();


                    sql_querry = sql_querry + string_value + ", ";
                }
                sql_querry = sql_querry.Remove(sql_querry.Length - 2);

                return sql_querry;
            }

            return String.Empty;        
        }

    }
}


