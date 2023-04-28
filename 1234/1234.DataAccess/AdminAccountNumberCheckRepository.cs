namespace _1234
{
    public class AdminAccountNumberCheckRepository
    {
        public async Task<AdminAccountNumberCheckModel> GetAdminAccountNumberCheckAsync(string accountNumber)
        {
            using (var context = new DbContext())
            {
                var query = from a in context.AdminAccountNumberChecks
                            where a.AccountNumber == accountNumber
                            select a;
                var result = await query.FirstOrDefaultAsync();
                return new AdminAccountNumberCheckModel
                {
                    Id = result.Id,
                    AccountNumber = result.AccountNumber,
                    AccountName = result.AccountName,
                    AccountBalance = result.AccountBalance,
                    IsValidAccount = result.IsValidAccount
                };
            }
        }

        public async Task<bool> CreateAdminAccountNumberCheckAsync(AdminAccountNumberCheckModel model)
        {
            using (var context = new DbContext())
            {
                var newAccountCheck = new AdminAccountNumberCheck
                {
                    AccountNumber = model.AccountNumber,
                    AccountName = model.AccountName,
                    AccountBalance = model.AccountBalance,
                    IsValidAccount = model.IsValidAccount
                };

                context.AdminAccountNumberChecks.Add(newAccountCheck);
                var result = await context.SaveChangesAsync();
                return result > 0;
            }
        }
        
        public async Task<bool> UpdateAdminAccountNumberCheckAsync(AdminAccountNumberCheckModel model)
        {
            using (var context = new DbContext())
            {
                var accountCheck = await context.AdminAccountNumberChecks.FindAsync(model.Id);
                if (accountCheck == null)
                {
                    return false;
                }

                accountCheck.AccountNumber = model.AccountNumber;
                accountCheck.AccountName = model.AccountName;
                accountCheck.AccountBalance = model.AccountBalance;
                accountCheck.IsValidAccount = model.IsValidAccount;

                var result = await context.SaveChangesAsync();
                return result > 0;
            }
        }

        public async Task<bool> DeleteAdminAccountNumberCheckAsync(int id)
        {
            using (var context = new DbContext())
            {
                var accountCheck = await context.AdminAccountNumberChecks.FindAsync(id);
                if (accountCheck == null)
                {
                    return false;
                }

                context.AdminAccountNumberChecks.Remove(accountCheck);
                var result = await context.SaveChangesAsync();
                return result > 0;
            }
        }
    }
}