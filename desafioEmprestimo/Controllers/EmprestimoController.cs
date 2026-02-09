using desafioEmprestimo.Models;
using desafioEmprestimo.Services;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace desafioEmprestimo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmprestimoController : ControllerBase
    {
        private readonly LoanService _loanService;
        public EmprestimoController(LoanService loanService)
        {
            _loanService = loanService;
        }

        [HttpPost("customer-loans")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(LoanResponse))]
        public async Task<IActionResult> Consultar([FromBody] CustomerRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            var response = _loanService.Create(request);

            return Ok(response);
        }
    }
}
