using AccountsDAL;
namespace AccountsBLL
{
    public static class Facade
    {
        public static ac_AccountTypeBLL accountTypeBLL { get { return new ac_AccountTypeBLL(); } }
        public static ac_AccountTypeDetailBLL accountTypeDetailBLL { get { return new ac_AccountTypeDetailBLL(); } }
        public static ac_ChartOfAccountBLL chartOfAccountBLL { get { return new ac_ChartOfAccountBLL(); } }
        public static ac_TransactionDAO transactionDAO { get { return new ac_TransactionDAO(); } }
    }
}
