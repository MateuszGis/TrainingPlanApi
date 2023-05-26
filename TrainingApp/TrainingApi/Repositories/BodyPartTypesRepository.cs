using Microsoft.EntityFrameworkCore;
using TrainingApi.Data;
using TrainingApi.Interfaces;
using TrainingApi.Models;

namespace TrainingApi.Repositories
{
    public class BodyPartTypesRepository : IBodyPartTypesRepository
    {
        private readonly DataContext db;

        public BodyPartTypesRepository(DataContext db)
        {
            this.db = db;
        }


        public async Task<IEnumerable<BodyPartType>> GetBodyPartTypes() => await db.BodyPartTypes.ToListAsync();

        public async Task<BodyPartType> GetBodyPartType(int id)
        {
            var result = await db.BodyPartTypes.FindAsync(id);
            return result;
        }

        public async Task EditBodyPartType(int Id, BodyPartType bodyPartType)
        {

            db.Entry(bodyPartType).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BodyPartTypeExists(Id))
                {
                    throw new KeyNotFoundException("Not found");
                }
            }
        }

        public async Task AddBodyPartType(BodyPartType bodyPartType)
        {
            db.BodyPartTypes.Add(bodyPartType);
            await db.SaveChangesAsync();
        }

        public async Task DeleteBodyPartType(int id)
        {
            var bodyPartType = await db.BodyPartTypes.FindAsync(id);
            if (bodyPartType == null)
            {
                throw new KeyNotFoundException("Not found");
            }

            db.BodyPartTypes.Remove(bodyPartType);
            await db.SaveChangesAsync();
        }

        private bool BodyPartTypeExists(int id)
        {
            return (db.BodyPartTypes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
