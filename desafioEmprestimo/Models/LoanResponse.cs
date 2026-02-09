namespace desafioEmprestimo.Models
{
    public class LoanResponse
    {
        public string Name { get; set; }
        public List<Loan> AvailableLoans { get; set; }

    }
}
