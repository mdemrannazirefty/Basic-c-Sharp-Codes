
namespace DonerDetailsForm
{
    internal class SqlCommand
    {
        private string query;
        private SqlConnection con;

        public SqlCommand(string query, SqlConnection con)
        {
            this.query = query;
            this.con = con;
        }

        public object Parameters { get; internal set; }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }

        internal SqlDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }
    }
}