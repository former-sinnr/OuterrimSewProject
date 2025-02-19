using Database.Context;
using Repository.Repository;

namespace Repository.SpecifiedRepositories;

public class AircraftCrewRepository(AircraftContext context): ARepository<AircraftContext>(context)
{
    private readonly AircraftContext _context = context;
}