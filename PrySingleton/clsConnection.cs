using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
namespace PrySingleton
{
    class clsConnection
    {
        //Singleton
        clsConnection() { }
        public static readonly clsConnection instance = new clsConnection();
        private string stringConn = @"Data Source=localhost; Initial Catalog=bdsingleton; User Id=root; Password=FKStein13";
        private MySqlConnection cnn;
        private MySqlDataAdapter search;
        private MySqlCommand oper;
        private DataTable Table;
        private MySqlDataReader read;
        public DataTable Load_Data(string op)
        {
            cnn = new MySqlConnection(stringConn);
            cnn.Open();
            string sp = "spList";
            oper = new MySqlCommand(sp, cnn);
            oper.CommandType = CommandType.StoredProcedure;
            Table = new DataTable();
            oper.Parameters.AddWithValue("@op", op);
            read = oper.ExecuteReader();
            Table.Load(read);
            read.Close();
            cnn.Close();
            return Table;
        }
        public void All_prods(string op, string nom, string tipo, string prov, string marca, string cod, int id)
        {
            cnn = new MySqlConnection(stringConn);
            cnn.Open();
            string Stored_Procedure = "spAllprods";
            oper = new MySqlCommand(Stored_Procedure, cnn);
            oper.CommandType = CommandType.StoredProcedure;
            oper.Parameters.AddWithValue("@op", op);
            oper.Parameters.AddWithValue("@nom", nom);
            oper.Parameters.AddWithValue("@tipo", tipo);
            oper.Parameters.AddWithValue("@prov", prov);
            oper.Parameters.AddWithValue("@marca", marca);
            oper.Parameters.AddWithValue("@cod", cod);
            oper.Parameters.AddWithValue("@id", id);
            oper.ExecuteNonQuery();
            cnn.Close();
        }
        public void All_details(string op, int prod, float pc, float pv, int stock, float ganancia, int id)
        {
            cnn = new MySqlConnection(stringConn);
            cnn.Open();
            string Stored_Procedure = "spAllDetails";
            oper = new MySqlCommand(Stored_Procedure, cnn);
            oper.CommandType = CommandType.StoredProcedure;
            oper.Parameters.AddWithValue("@op", op);
            oper.Parameters.AddWithValue("@idp", prod);
            oper.Parameters.AddWithValue("@pc", pc);
            oper.Parameters.AddWithValue("@pv", pv);
            oper.Parameters.AddWithValue("@stock", stock);
            oper.Parameters.AddWithValue("@ganancia", ganancia);
            oper.Parameters.AddWithValue("@id", id);
            oper.ExecuteNonQuery();
            cnn.Close();
        }
    }
}