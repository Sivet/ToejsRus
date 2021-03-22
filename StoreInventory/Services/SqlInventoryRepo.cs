using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StoreInventory.Models;
using StoreInventory.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace StoreInventory.Services{
    public class SqlInventoryRepo : IService{
        private readonly ClothesContext _context;
        public SqlInventoryRepo(ClothesContext context){
            _context = context;
        }
        public Task<bool> SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }
        public async Task<IEnumerable<ClothesType>> GetClothTypesAsync(Gender gender)
        {
            if(gender.GenderID == null){
                throw new ArgumentNullException(nameof(gender));
            }
            //Get list of clothes types that matches a specific gender

            //See link for info on different queries https://entityframework.net/knowledge-base/30466696/query-a-many-to-many-relationship-with-linq-entity-framework--codefirst

            //Creates an "Exists" sql query
            /*var query = from ClothesType in _context.ClothesTypes 
                        where ClothesType.Genders.Any(c => c.GenderID == gender.GenderID)
                        select ClothesType;*/

            //Creates an Inner join query
            return await _context.Genders
                        .Where(c=>c.GenderID==gender.GenderID)
                        .SelectMany(c=> c.ClothesTypes).ToListAsync<ClothesType>();
        }

        public Task<IEnumerable<Clothes>> GetAllClothesOfType(string type, string gender)
        {
            throw new System.NotImplementedException();
        }

        public Task<Clothes> GetInfoOnItem(string item)
        {
            throw new System.NotImplementedException();
        }
    }
}