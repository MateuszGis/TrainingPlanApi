using Microsoft.EntityFrameworkCore;
using TrainingApi.Data;
using TrainingApi.Interfaces;
using TrainingApi.Models;

namespace TrainingApi.Repositories
{
    public class TrainingPlansRepository : ITrainingPlansRepository
    {
        private readonly DataContext db;

        public TrainingPlansRepository(DataContext db)
        {
            this.db = db;
        }


        public async Task<IEnumerable<TrainingPlan>> GetTrainingPlans() => await db.TrainingPlans.ToListAsync();

        public async Task<TrainingPlan> GetTrainingPlan(int id)
        {
            var result = await db.TrainingPlans.FindAsync(id);
            return result;
        }

        public async Task EditTrainingPlan(int Id, TrainingPlan TrainingPlan)
        {

            db.Entry(TrainingPlan).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrainingPlanExists(Id))
                {
                    throw new KeyNotFoundException("Not found");
                }
            }
        }

        public async Task AddTrainingPlan(TrainingPlan TrainingPlan)
        {
            db.TrainingPlans.Add(TrainingPlan);
            await db.SaveChangesAsync();
        }

        public async Task DeleteTrainingPlan(int id)
        {
            var TrainingPlan = await db.TrainingPlans.FindAsync(id);
            if (TrainingPlan == null)
            {
                throw new KeyNotFoundException("Not found");
            }

            db.TrainingPlans.Remove(TrainingPlan);
            await db.SaveChangesAsync();
        }

        private bool TrainingPlanExists(int id)
        {
            return (db.TrainingPlans?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
