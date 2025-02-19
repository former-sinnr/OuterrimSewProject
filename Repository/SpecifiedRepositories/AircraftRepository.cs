using Database.Context;
using Database.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Repository;

namespace Repository.SpecifiedRepositories;

public class AircraftRepository(AircraftContext context): ARepository<Aircraft>(context)
{
    private readonly AircraftContext _context = context;
    
}