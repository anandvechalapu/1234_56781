namespace _1234.Service
{
    using System.Threading.Tasks;
    using _1234.DataAccess;
    using _1234.DTO;

    public interface IAdminAccountNumberCheckService
    {
        Task<AdminAccountNumberCheckModel> GetAdminAccountNumberCheckAsync(string accountNumber);
        Task<bool> CreateAdminAccountNumberCheckAsync(AdminAccountNumberCheckModel model);
        Task<bool> UpdateAdminAccountNumberCheckAsync(AdminAccountNumberCheckModel model);
        Task<bool> DeleteAdminAccountNumberCheckAsync(int id);
    }
}