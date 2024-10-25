using EFBestPractice.Application.Common.Interfaces;
using EFBestPractice.Domain.Master;
using Microsoft.EntityFrameworkCore;

namespace EFBestPractices.Infrastructure.Persistence;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options), IApplicationDbContext
{
    public DbSet<AppSetting> AppSettings { get; set; }
    
    public Task<int> SaveChangesAsync()
    {
        return base.SaveChangesAsync();
    }
}