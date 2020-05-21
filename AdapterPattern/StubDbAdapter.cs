using System;
using System.Data;

namespace AdapterPattern
{
    public class StubDbAdapter : IDbDataAdapter
    {
        public int Fill(DataSet dataSet)
        {
            var myDataTable = new DataTable();
            myDataTable.Columns.Add(new DataColumn("Id", typeof(int)));
            myDataTable.Columns.Add(new DataColumn("Name", typeof(string)));
            myDataTable.Columns.Add(new DataColumn("Description", typeof(string)));

            var myRow = myDataTable.NewRow();
            myRow[0] = 1;
            myRow[1] = "Adapter";
            myRow[2] = "Adapter Description";
            myDataTable.Rows.Add(myRow);
            dataSet.Tables.Add(myDataTable);
            dataSet.AcceptChanges();

            return 1;
        }

        public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
        {
            throw new NotImplementedException();
        }

        public IDataParameter[] GetFillParameters()
        {
            throw new NotImplementedException();
        }

        public int Update(DataSet dataSet)
        {
            throw new NotImplementedException();
        }

        public MissingMappingAction MissingMappingAction { get; set; }
        public MissingSchemaAction MissingSchemaAction { get; set; }
        public ITableMappingCollection TableMappings { get; }
        public IDbCommand DeleteCommand { get; set; }
        public IDbCommand InsertCommand { get; set; }
        public IDbCommand SelectCommand { get; set; }
        public IDbCommand UpdateCommand { get; set; }
    }
}
