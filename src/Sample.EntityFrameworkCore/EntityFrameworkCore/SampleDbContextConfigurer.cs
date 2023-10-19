using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Sample.EntityFrameworkCore
{
    public static class SampleDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SampleDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public static void Configure(DbContextOptionsBuilder<SampleDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection.ConnectionString, ServerVersion.AutoDetect(connection.ConnectionString));
        }
    }
}
