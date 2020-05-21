using System.Collections.Generic;
using System.Data;
using AdapterPattern.Model;

namespace AdapterPattern
{
    public class PatternCollectionDbAdapter : IDbDataAdapter
    {
        private readonly IEnumerable<Pattern> _patterns;

        public PatternCollectionDbAdapter(IEnumerable<Pattern> patterns)
        {
            _patterns = patterns;
        }

        public int Fill(DataSet dataSet)
        {
            var myDataTable = new DataTable();
            myDataTable.Columns.Add(new DataColumn("Id", typeof(int)));
            myDataTable.Columns.Add(new DataColumn("Name", typeof(string)));
            myDataTable.Columns.Add(new DataColumn("Description", typeof(string)));

            foreach (var pattern in _patterns)
            {
                var myRow = myDataTable.NewRow();
                myRow[0] = pattern.Id;
                myRow[1] = pattern.Name;
                myRow[2] = pattern.Description;
                myDataTable.Rows.Add(myRow);
            }

            dataSet.Tables.Add(myDataTable);
            dataSet.AcceptChanges();

            return myDataTable.Rows.Count;
        }

        public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
        {
            throw new System.NotImplementedException();
        }

        public IDataParameter[] GetFillParameters()
        {
            throw new System.NotImplementedException();
        }

        public int Update(DataSet dataSet)
        {
            throw new System.NotImplementedException();
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