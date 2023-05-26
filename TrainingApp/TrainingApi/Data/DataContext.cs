using Microsoft.EntityFrameworkCore;
using TrainingApi.Models;

namespace TrainingApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<TrainingPlan> TrainingPlans { get; set; }

        public DbSet<BodyPartType> BodyPartTypes { get; set; }


    }
}
