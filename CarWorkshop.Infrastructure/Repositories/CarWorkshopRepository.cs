﻿using CarWorkshop.Domain.Interfaces;
using CarWorkshop.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Infrastructure.Repositories {
    public class CarWorkshopRepository : ICarWorkshopRepoitory {
        private readonly CarWorkshopDbContext _dbContext;

        public CarWorkshopRepository( CarWorkshopDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task Create(Domain.Entities.CarWorkshop carWorkshop)
        {
            _dbContext.Add(carWorkshop);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Domain.Entities.CarWorkshop>> GetAll()
        => await _dbContext.carWorkshops.ToListAsync();
        public Task<Domain.Entities.CarWorkshop?> GetByName(string name)
           => _dbContext.carWorkshops.FirstOrDefaultAsync(seek => seek.Name.ToLower() == name.ToLower());
    }
}
