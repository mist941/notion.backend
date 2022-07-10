namespace Notion.Persistence;

public class DbInitializer
{
    public static void Initialize(NotionDbContext context)
    {
        context.Database.EnsureCreated();
    }
}