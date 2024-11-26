using Microsoft.EntityFrameworkCore;
using TechnicoConsoleApp.Context;
using TechnicoConsoleApp.Interfaces;
using TechnicoConsoleApp.Models;

namespace TechnicoConsoleApp.Services;

public class RepairService : IRepairService
{
    private readonly ApplicationDbContext _context;

    public RepairService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Repair>> SearchRepairsAsync(string criteria)
    {
        return await _context.Repairs
            .Where(r => r.Description.Contains(criteria) || r.Type.Contains(criteria))
            .Include(r => r.PropertyItem)
            .ThenInclude(p => p.PropertyOwner)
            .ToListAsync();
    }

    public async Task<Repair> GetRepairDetailsAsync(int id)
    {
        return await _context.Repairs.Include(r => r.PropertyItem).FirstOrDefaultAsync(r => r.Id == id);
    }

    public async Task<Repair> CreateRepairAsync(Repair repair)
    {
        _context.Repairs.Add(repair);
        await _context.SaveChangesAsync();
        return repair;
    }

    public async Task UpdateRepairAsync(Repair repair)
    {
        _context.Repairs.Update(repair);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteRepairAsync(int id)
    {
        Repair? repair = await _context.Repairs.FindAsync(id);
        if (repair != null)
        {
            _context.Repairs.Remove(repair);
            await _context.SaveChangesAsync();
        }
    }
}