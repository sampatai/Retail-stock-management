using LiteDB;

namespace Retail.Stock.Application.Common
{
    public interface ILiteDatabaseProvider
    {
        LiteDatabase GetDatabase();
    }
}
