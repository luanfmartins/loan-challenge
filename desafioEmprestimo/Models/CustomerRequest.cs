namespace desafioEmprestimo.Models
{
    public class CustomerRequest
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public required string Location { get; set; }
    }
}
