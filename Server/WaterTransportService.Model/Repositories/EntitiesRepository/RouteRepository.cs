using Microsoft.EntityFrameworkCore;
using WaterTransportService.Model.Context;
using WaterTransportService.Model.Entities;

namespace WaterTransportService.Model.Repositories.EntitiesRepository;

public class RouteRepository(WaterTransportDbContext context) : IEntityRepository<Route, Guid>
{
    private readonly WaterTransportDbContext _context = context;

    public async Task<Route> AddAsync(Route entity)
    {
        _context.Routes.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<IEnumerable<Route>> GetAllAsync() => await _context.Routes.ToListAsync();

    public async Task<Route?> GetByIdAsync(Guid id) => await _context.Routes.FindAsync(id);

    public async Task<bool> UpdateAsync(Route entity, Guid id)
    {
        var old = await _context.Routes.FirstOrDefaultAsync(x => x.Id == id);
        if (old == null) return false;

        _context.Entry(old).CurrentValues.SetValues(entity);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var old = await GetByIdAsync(id);
        if (old == null) return false;
        _context.Routes.Remove(old);
        await _context.SaveChangesAsync();
        return true;
    }
}
