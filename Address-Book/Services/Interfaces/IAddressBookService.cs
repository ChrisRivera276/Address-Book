using Address_Book.Models;

namespace Address_Book.Services.Interfaces
{
    public interface IAddressBookService
    {
        Task AddContactToCategory(int categoryId, int contactId);
        Task <bool> IsContactInCategory(int categoryId, int contactId);
        Task<IEnumerable<Category>> GetUserCategoriesAsync(string userId);
        Task<ICollection<int>> GetContactCategoryIdsAsync(int contactId);
        Task<ICollection<Category>>GetContactCategoriesAsync(int contactId);
        Task RemoveContactFromCategoryAsync(int categoryid, int contactId);
    }
}
