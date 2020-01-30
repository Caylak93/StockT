using System.Data.Entity;

namespace StockDb
{
    public class InitializerIfNotExists<T> : CreateDatabaseIfNotExists<T> where T : DbContext
    {
        protected override void Seed(T context)
        {
            base.Seed(context);
        }
    }
}