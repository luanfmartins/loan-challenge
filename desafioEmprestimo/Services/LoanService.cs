using desafioEmprestimo.Enums;
using desafioEmprestimo.Models;

namespace desafioEmprestimo.Services
{
    public class LoanService
    {
        public List<Loan> AvailableLoans = [];
        public LoanResponse Create(CustomerRequest request)
        {

            if (request.Salary <= 3000 || request.Salary >= 3000 && request.Salary <= 5000 && request.Age < 30 && request.Location == "SP")
            {
                //PERSONAL 
                AvailableLoans.Add(new Loan
                {
                    Type = (LoanType)1,
                    InterestRate = 4
                });
                //GUARANTEED
                AvailableLoans.Add(new Loan
                {
                    Type = (LoanType)2,
                    InterestRate = 3
                });
            }
            if (request.Salary >= 5000)
            {
                //CONSIGNMENT
                AvailableLoans.Add(new Loan
                {
                    Type = (LoanType)3,
                    InterestRate = 2
                });
            }
            var response = new LoanResponse
            {
                Name = request.Name,
                AvailableLoans = this.AvailableLoans,
            };

            return response;
        }       

    }
}

