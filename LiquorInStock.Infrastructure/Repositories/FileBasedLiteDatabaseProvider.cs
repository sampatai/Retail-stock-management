using LiteDB;
using Retail.Stock.Application.Common;

namespace Retail.Stock.Infrastructure.Repositories
{
    public class FileBasedLiteDatabaseProvider : ILiteDatabaseProvider
    {
        private readonly string _databaseFilePath;

        public FileBasedLiteDatabaseProvider(string databaseFileName)
        {
            string databaseDirectoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Databases");
            Directory.CreateDirectory(databaseDirectoryPath);
            _databaseFilePath = Path.Combine(databaseDirectoryPath, databaseFileName);
        }

        public LiteDatabase GetDatabase()
        {
            return new LiteDatabase($"Filename={_databaseFilePath};Mode=Shared");
        }
    }


}
