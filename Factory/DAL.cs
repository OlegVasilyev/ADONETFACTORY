using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.IO;
using System.ComponentModel;
using System.Data;
namespace Factory
{
    class DAL
    {
        private string ConnectionString;
        public DAL()
        {
            this.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Factory.mdf;;Integrated Security=True";
        }
        public BindingList<DbDataRecord> GetClient()
        {
            BindingList<DbDataRecord> list = new BindingList<DbDataRecord>();
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM Client", connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    foreach (DbDataRecord record in reader)
                    {
                        list.Add(record);
                    }
                    return list;
                }
                catch
                {
                }
            }
            return list;

        }
        public BindingList<DbDataRecord> GetOrder(int id)
        {
            BindingList<DbDataRecord> list = new BindingList<DbDataRecord>();
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {

                SqlCommand command = new SqlCommand($"SELECT * FROM [Order] WHERE [IdClient] = @id", connection);
                try
                {
                    command.Parameters.AddWithValue("id", id);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    foreach (DbDataRecord record in reader)
                    {
                        list.Add(record);
                    }
                    return list;
                }
                catch
                {
                }
            }
            return list;
        }
        public bool AddClient(string firstname, string secondname, string numberphone, string adress)
        {
            string cmdText = string.Format("INSERT INTO [Client] ( [FirstName], [SecondName], [NumberPhone], [Adress]) VALUES (@FirstName, @SecondName, @NumberPhone, @Adress)");
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "FirstName",
                    Value = firstname,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "SecondName",
                    Value = secondname,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "NumberPhone",
                    Value = numberphone,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Adress",
                    Value = adress,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }
        public bool AddOrder(string subject, string type, string price, string status, string date, string commnet, string idclient)
        {
            string cmdText = string.Format("INSERT INTO [Order] ( [Subject], [Type], [Price], [Status], [Date], [Comment], [IdClient] ) VALUES (@Subject, @Type, @Price, @Status, @Date, @Comment, @IdClient)", new object[0]);
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "Subject",
                    Value = subject,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Type",
                    Value = type,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Price",
                    Value = price,
                    SqlDbType = SqlDbType.Decimal
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Status",
                    Value = status,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Date",
                    Value = date,
                    SqlDbType = SqlDbType.Date
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "Comment",
                    Value = commnet,
                    SqlDbType = SqlDbType.NVarChar
                };
                command.Parameters.Add(parameter);
                parameter = new SqlParameter
                {
                    ParameterName = "IdClient",
                    Value = idclient,
                    SqlDbType = SqlDbType.Int
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }
        public bool EditStatusOrder(int id, string status)
        {
            string cmdText = string.Format("UPDATE [Order] SET [Status] = @changeStatus WHERE [Id] = @id");
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);
                SqlParameter param = new SqlParameter { ParameterName = "id", Value = id, SqlDbType = SqlDbType.Int };
                command.Parameters.Add(param);
                param = new SqlParameter { ParameterName = "changeStatus", Value = status, SqlDbType = SqlDbType.NVarChar };
                command.Parameters.Add(param);

                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                }
                catch
                {
                }
            }
            return false;
        }
        public ArrayList SearchClient(string find)
        {
            ArrayList list = new ArrayList();
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand("SearchClient", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "Find",
                    Value = find,
                    SqlDbType = SqlDbType.NVarChar,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    foreach (DbDataRecord record in reader)
                    {
                        list.Add(record);
                    }
                    return list;
                }
                catch
                {
                }
            }
            return list;
        }
        public ArrayList SearchOrder(string find)
        {
            ArrayList list = new ArrayList();
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand("SearchOrder", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlParameter parameter = new SqlParameter
                {
                    ParameterName = "Find",
                    Value = find,
                    SqlDbType = SqlDbType.NVarChar,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    foreach (DbDataRecord record in reader)
                    {
                        list.Add(record);
                    }
                    return list;
                }
                catch
                {
                }
            }
            return list;
        }
    }
}
