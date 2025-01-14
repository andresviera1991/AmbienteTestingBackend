using AutoMapper;
using MGP.Location.Persistance.Data.Tables;
using MGP.Location.Persistance.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MGP.Location.Persistance
{
    public class StreetRepository : IStreetRepository
    {
        private readonly MyDbContext _dbContext;

        public StreetRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Street>> GetStreetsByNameAsync(long localityId, string streetName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(streetName))
                {
                    return await _dbContext.Streets
                                           .Where(street => street.LocalityId == localityId)
                                           .ToListAsync();
                }

                string cleanedStreetName = streetName
                    .Split(' ')
                    .Select(word => word.Trim())
                    .Where(word => !string.IsNullOrWhiteSpace(word))
                    .Aggregate((current, next) => $"{current} & {next}");

                var sqlQuery = @"SELECT * FROM ""Street"" 
                                WHERE ""LocalityId"" = @p0
                                  AND (
                                    to_tsvector('simple', ""Name"") @@ to_tsquery('simple', @p1)
                                    OR ""Name"" ILIKE @p2
                                  )
                                ORDER BY ""Name""";

                var streets = await _dbContext.Streets
                                              .FromSqlRaw(sqlQuery, localityId, cleanedStreetName, $"%{streetName}%")
                                              .ToListAsync();

                return streets;
            }
            catch(Exception)
            {
                return null;
            }
            
        }
    }
}