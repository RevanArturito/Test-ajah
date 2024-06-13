using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace Authentication.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AuthController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Account>> Get()
        {
            return Ok(_accountService.GetAccounts());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Account newAccount)
        {
            if (newAccount == null)
            {
                return BadRequest("Account data is null.");
            }

            _accountService.AddAccount(newAccount);
            return Ok(newAccount);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var account = _accountService.GetAccountById(id);
            if (account == null)
            {
                return NotFound("Account not found.");
            }

            return Ok(account);
        }
    }

}
