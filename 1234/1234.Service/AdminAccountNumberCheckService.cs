namespace _1234
{
    using System.Threading.Tasks;
    using _1234.DataAccess;
    using _1234.DTO;

    public class AdminAccountNumberCheckService : IAdminAccountNumberCheckService
    {
        private readonly AdminAccountNumberCheckRepository _repository;

        public AdminAccountNumberCheckService()
        {
            _repository = new AdminAccountNumberCheckRepository();
        }

        public async Task<AdminAccountNumberCheckModel> GetAdminAccountNumberCheckAsync(string accountNumber)
        {
            return await _repository.GetAdminAccountNumberCheckAsync(accountNumber);
        }

        public async Task<bool> CreateAdminAccountNumberCheckAsync(AdminAccountNumberCheckModel model)
        {
            return await _repository.CreateAdminAccountNumberCheckAsync(model);
        }

        public async Task<bool> UpdateAdminAccountNumberCheckAsync(AdminAccountNumberCheckModel model)
        {
            return await _repository.UpdateAdminAccountNumberCheckAsync(model);
        }

        public async Task<bool> DeleteAdminAccountNumberCheckAsync(int id)
        {
            return await _repository.DeleteAdminAccountNumberCheckAsync(id);
        }
    }

    public interface IAdminAccountNumberCheckService
    {
        Task<AdminAccountNumberCheckModel> GetAdminAccountNumberCheckAsync(string accountNumber);
        Task<bool> CreateAdminAccountNumberCheckAsync(AdminAccountNumberCheckModel model);
        Task<bool> UpdateAdminAccountNumberCheckAsync(AdminAccountNumberCheckModel model);
        Task<bool> DeleteAdminAccountNumberCheckAsync(int id);
    }
}