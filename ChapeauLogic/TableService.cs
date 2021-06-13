using ChapeauDAL;
using ChapeauModel;
using System.Collections.Generic;

namespace ChapeauLogic
{
    public class TableService
    {
        TableDAO tabledb;

        public TableService()
        {
            tabledb = new TableDAO();
        }

        public List<Table> GetTables()
        {
            List<Table> tables = tabledb.GetAllTables();
            return tables;
        }

        public Table GetTable(int tablenr)
        {
            Table table = tabledb.GetTable(tablenr);
            return table;
        }

        public void UpdateTable(Table table)
        {
            tabledb.UpdateTable(table);
        }
    }
}
