namespace _1234
{
    public class AdminAccountNumberCheckModel
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public int AccountBalance { get; set; }
        public bool IsValidAccount { get; set; }
    }
}