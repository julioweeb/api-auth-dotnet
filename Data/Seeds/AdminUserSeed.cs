using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;
using api_auth.Domain.Entities;

namespace api_auth.Data.Seeds
{
    public class AdminUserSeed
    {
        public static async Task EnsureAdminUserAsync(AppDbContext context)
        {
            var adminExists = await context.Users.AnyAsync(u => u.Role == "Admin");

            if (adminExists)
                return;

            var admin = new User
            {
                Id = Guid.NewGuid(),
                Name = "Administrador",
                Email = "admin@admin.com",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("Admin@123"),
                Role = "Admin",
                IsActive = true,
                CreateAt = DateTime.UtcNow
            };

            context.Users.Add(admin);
            await context.SaveChangesAsync();
        }
    }
}
