using EFBestPractice.Domain.Master;
using Microsoft.EntityFrameworkCore;

namespace EFBestPractice.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<AppSetting> AppSettings { get; set; }
    Task<int> SaveChangesAsync();
}