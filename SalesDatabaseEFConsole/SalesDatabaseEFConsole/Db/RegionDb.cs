using Microsoft.EntityFrameworkCore;
using SalesDatabaseEFConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabaseEFConsole.Db
{
    internal class RegionDb
    {
        private SalesDbContext dbContext = new();

        public List<Region> GetRegion()
        {
            List<Region> regions = new List<Region>();
            return dbContext.Regions.ToList();
        }

        public Region FindRegion(int id)
        {
            return dbContext.Regions.Where(r => r.Id == id).FirstOrDefault();
        }
        public void AddRegion(Region region) {
            dbContext.Regions.Add(region);
            dbContext.SaveChanges();
        }

        public void RemoveRegion(Region region) { 
            dbContext.Regions.Remove(region);
            dbContext.SaveChanges();
        }













    }
}
