namespace BiByt.Database;

public class Query
{
    public T Get<T>(Func<T, bool> predicate) where T : class
    {
        using (ApplicationContext context = new ApplicationContext())
            return context.Set<T>().FirstOrDefault(predicate);
    }

    public T Create<T>(Func<T> createFunc) where T : class
    {
        using (ApplicationContext context = new ApplicationContext())
        {
            T entity = createFunc();
            context.Set<T>().Add(entity);
            context.SaveChanges();

            return entity;
        }
    }
}