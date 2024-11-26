using TechnicoConsoleApp.Models;

namespace TechnicoConsoleApp.Interfaces;

public interface IRepairService
{
    Task<IEnumerable<Repair>> SearchRepairsAsync(string criteria);
    Task<Repair> GetRepairDetailsAsync(int id);
    Task<Repair> CreateRepairAsync(Repair repair);
    Task UpdateRepairAsync(Repair repair);
    Task DeleteRepairAsync(int id);
}