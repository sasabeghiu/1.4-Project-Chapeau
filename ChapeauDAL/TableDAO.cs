using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using ChapeauModel;

namespace ChapeauDAL
{
    //Alexandru
    public class TableDAO : BaseDao
    {
        //returns a list of tables
        public List<Table> GetAllTables()
        {
            string query = "SELECT table_id, table_number, table_capacity, table_availability FROM [Table]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //returns a table
        public Table GetTable(int tablenr)
        {
            string query = "SELECT table_id, table_number, table_capacity, table_availability FROM [Table] WHERE table_id=@table_id";
            SqlParameter[] sqlParameters = { new SqlParameter("@table_id", tablenr) };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        //read a list of tables
        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {
                    Table_Number = (int)(dr["table_number"]),
                    Table_Capacity = (int)(dr["table_capacity"]),
                    Table_Availability = (Table_Availability)Enum.Parse(typeof(Table_Availability), dr["table_availability"].ToString())
                };
                tables.Add(table);
            }
            return tables;
        }

        //read 1 table
        private Table ReadTable(DataTable dataTable)
        {
            Table table = null;

            foreach (DataRow dr in dataTable.Rows)
            {
                 table = new Table()
                {
                    Table_Number = (int)(dr["table_number"]),
                    Table_Capacity = (int)(dr["table_capacity"]),
                    Table_Availability = (Table_Availability)Enum.Parse(typeof(Table_Availability), dr["table_availability"].ToString())
                };
            }
            return table;
        }

        //change tablee availabilitys
        public void UpdateTable(Table table)
        {
            SqlCommand queryUpdateOrder = new SqlCommand($"UPDATE [Table] SET table_availability = @table_availability WHERE table_number = @table_number", OpenConnection());
            queryUpdateOrder.Parameters.AddWithValue("@table_availability", table.Table_Availability.ToString());
            queryUpdateOrder.Parameters.AddWithValue("@table_number", table.Table_Number.ToString());
            queryUpdateOrder.ExecuteNonQuery();
            CloseConnection();
        }
    }
}