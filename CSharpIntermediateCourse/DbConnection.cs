namespace CSharpIntermediateCourse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal abstract class DbConnection
    {
        private string connectionString;

        private TimeSpan timeOut;

        public DbConnection(string connectionString, TimeSpan timeOut)
        {

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Invalid Connectionstring.");
            }
            this.connectionString = connectionString;
            this.timeOut = timeOut;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}
