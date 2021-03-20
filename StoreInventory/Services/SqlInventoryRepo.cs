using System.Collections.Generic;
using System.Threading.Tasks;
using StoreInventory.Models;
using StoreInventory.Contexts;

namespace StoreInventory.Services{
    public class SqlInventoryRepo : IService{
        private readonly ClothesContext _context;
        public SqlInventoryRepo(ClothesContext context){
            _context = context;
        }

        public Task<IEnumerable<string>> GetClothTypes(string gender)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Clothes>> GetAllClothesOfType(string type, string gender)
        {
            throw new System.NotImplementedException();
        }

        public Task<Clothes> GetInfoOnItem(string item)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}