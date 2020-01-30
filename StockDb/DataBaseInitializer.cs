using System.Data.Entity;

namespace StockDb
{
    public class DataBaseInitializer<T> where T : DbContext, new()
    {
        private static bool _isDbInitialized = false;
        private static object _objLock = new object();

        public static void InitializedDatabase(bool force = false)
        {
            lock (_objLock)
            {
                if (!_isDbInitialized)
                {
                    Database.SetInitializer<T>(new InitializerIfNotExists<T>());
                    T instance = new T();
                    instance.Database.Initialize(force);
                    _isDbInitialized = true;
                }
            }
        }
    }
}