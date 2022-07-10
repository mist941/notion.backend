using Microsoft.EntityFrameworkCore;
using Notion.Domain;

namespace Notes.Application.Interfaces;

public interface INotionDbContext
{
    DbSet<Note> Notion { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}