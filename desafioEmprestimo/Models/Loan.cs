using desafioEmprestimo.Enums;

namespace desafioEmprestimo.Models
{
    public class Loan
    {
        public virtual LoanType Type { get; set; }
        public int InterestRate { get; set; }

    }
    
}
