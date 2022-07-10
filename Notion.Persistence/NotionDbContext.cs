using Microsoft.EntityFrameworkCore;
using Notes.Application.Interfaces;
using Notion.Domain;
using Notion.Persistence.EntityTypeConfigurations;

namespace Notion.Persistence;

public class NotionDbContext: DbContext, INotionDbContext
{
    public DbSet<Note> Notion { get; set; }
    
    public NotionDbContext(DbContextOptions<NotionDbContext> options)
        : base(options){}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new NoteConfiguration());
        base.OnModelCreating(builder);
    }
}