namespace StudentInfoSystem.Data.Contracts
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using StudentInfoSystem.Models;

    public interface IStudentInfoSystemDbContext : IDisposable
    {
        IDbSet<User> Users { get; set; }

        IDbSet<Student> Students { get; set; }

        DbContext DbContext { get; }

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        IDbSet<T> Set<T>() where T : class;

        int SaveChanges();
    }
}