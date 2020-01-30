using System.Data.Entity;

namespace StockDb
{
    public class InitializerDropCreateAlways<T> : CreateDatabaseIfNotExists<T> where T : DbContext
    {
        protected override void Seed(T context)
        {
            base.Seed(context);
        }
    }
}