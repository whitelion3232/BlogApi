namespace WebApplication5.Context
{
    public class DataDbInitialize
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<BlogContext>();
            context.Database.EnsureCreated();
        }
    }
}
