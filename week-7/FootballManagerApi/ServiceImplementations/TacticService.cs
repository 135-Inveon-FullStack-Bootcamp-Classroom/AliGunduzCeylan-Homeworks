using FootballManagerApi.Data;
using FootballManagerApi.Entities;
using FootballManagerApi.ServiceAbstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballManagerApi.ServiceImplementations
{
    public class TacticService : ITacticService
    {
        private readonly ApplicationDbContext _context;
        public TacticService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Tactic>> GetAllAsync()
        {
            return await _context.Tactics.ToListAsync();
        }


        public async Task<Tactic> GetAsync(int id)
        {
            var tactics = await _context.Tactics.FindAsync(id);
            return tactics;
        }

        public async Task UpdateAsync(int id, Tactic tactics)
        {
            if (id != tactics.Id)
            {
                throw new Exception("Idler Uyuşmadı");
            }
            _context.Entry(tactics).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TacticExists(id))
                {
                    throw new Exception($"Id'si '{id}' olan taktik bulunamadı");
                }
                else
                {
                    throw;
                }
            }
        }

        public async Task<Tactic> CreateAsync(Tactic tactics)
        {
            _context.Tactics.Add(tactics);
            await _context.SaveChangesAsync();

            return tactics;
        }

        public async Task DeleteAsync(int id)
        {
            var tactics = await _context.Tactics.FindAsync(id);

            if (tactics == null)
            {
                throw new Exception("Futbolcu Bulunamadı");
            }

            _context.Tactics.Remove(tactics);
            await _context.SaveChangesAsync();
        }

        private bool TacticExists(int id)
        {
            return _context.Tactics.Any(e => e.Id == id);
        }
    }
}
