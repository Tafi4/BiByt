namespace BiByt.Database;

public class Query
{
    public static T Get<T>(Func<T, bool> predicate) where T : class
    {
        using (AppContext context = new AppContext())
            return context.Set<T>().FirstOrDefault(predicate);
    }

    public static T Create<T>(Func<T> createFunc) where T : class
    {
        using (AppContext context = new AppContext())
        {
            T entity = createFunc();
            context.Set<T>().Add(entity);
            context.SaveChanges();

            return entity;
        }
    }
}