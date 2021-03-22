using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StoreInventory.Models;

namespace StoreInventory.Services{
    public interface IService{
        Task<bool> SaveChangesAsync();
        Task<IEnumerable<ClothesType>> GetClothTypesAsync(Gender gender);
        Task<IEnumerable<Clothes>> GetAllClothesOfType(string type, string gender);
        Task<Clothes> GetInfoOnItem(string item);
         /*Task<Book> GetBookAsync(Guid id);
 
         void AddBook(Book bookToAdd);
 
         Task<bool> SaveChangesAsync();
 
         Task<IEnumerable<BookCover>> GetBookCoversAsync(Guid bookId);*/
    }
}