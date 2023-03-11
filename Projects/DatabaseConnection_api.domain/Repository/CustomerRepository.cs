using Dapper;
using DatabaseConnection_api.domain.Models;
using DatabaseConnection_api.domain.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection_api.domain.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;
        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<CustomerDetails> GetCustomerData(string customerId)    //GetUser() gets one record, GetUsers() gets multiple
        {
            string query = $@"select customer_name CustomerName, customer_no CustomerNumber, cif_creation_date CustomerRelationshipDate,
                            decode (customer_type, 'I', 'INDIVIDUAL', 'CORPORATE') CustomerType, date_of_birth_incorp dateofbirth, bus_sgt businesssegment, 
                            gender gender, (select rm_name from rm_map where rm_code = a.rm_code) RmName, nvl(floor((sysdate - date_of_birth_incorp)/365), 0) CustomerAge
                            from customer_master a where customer_no = :CustId";

            using (var connection = _context.CreateConnection())
            {
                var customerData = await connection.QueryFirstOrDefaultAsync<CustomerDetails>(query, new { CustId = customerId });
                return customerData;
            }
        }

        public string GetCustomerId(string accountNumber)    //GetUser() gets one record, GetUsers() gets multiple
        {
            string query = "select cust_no from account_master where cust_ac_no = :AcctNumber";

            using (var connection = _context.CreateConnection())
            {
                string customerId = connection.QueryFirstOrDefault<string>(query, new { AcctNumber = accountNumber });
                return customerId;
            }
        }

        public async Task<List<AccountDetails>> GetAccountData(string customerId)    //GetUser() gets one record, GetUsers() gets multiple
        {
            string query = $@"select cust_ac_no AccountNumber, a.ac_desc AccountName, a.acc_class_desc AccountClass, a.ac_open_date AccountOpeningDate, 
                            a.lcy_curr_balance LcyBalance, a.acy_curr_balance AcyBalance, a.active_status AccountStatus, b.br_name BranchName, CCY Currency
                            from account_master a, new_branch_map b where a.branch_code = b.br_code and cust_no = :CustId";

            try
            {
                using (var connection = _context.CreateConnection())
                {
                    var accountData = await connection.QueryAsync<AccountDetails>(query, new { CustId = customerId });
                    return accountData.ToList();
                }
            }
            catch (Exception ex)
            {

                string errorMessage = ex.Message;
                return new List<AccountDetails>();
            }
        }
    }
}
