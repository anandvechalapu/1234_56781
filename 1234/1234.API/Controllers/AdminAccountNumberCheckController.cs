namespace _1234.API
{
    using System.Threading.Tasks;
    using _1234.DataAccess;
    using _1234.DTO;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class AdminAccountNumberCheckController : ControllerBase
    {
        private readonly AdminAccountNumberCheckService _service;

        public AdminAccountNumberCheckController()
        {
            _service = new AdminAccountNumberCheckService();
        }

        [HttpGet("{accountNumber}")]
        public async Task<ActionResult<AdminAccountNumberCheckModel>> GetAdminAccountNumberCheckAsync(string accountNumber)
        {
            var model = await _service.GetAdminAccountNumberCheckAsync(accountNumber);
            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAdminAccountNumberCheckAsync([FromBody] AdminAccountNumberCheckModel model)
        {
            var isCreated = await _service.CreateAdminAccountNumberCheckAsync(model);
            if (!isCreated)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAdminAccountNumberCheckAsync([FromBody] AdminAccountNumberCheckModel model)
        {
            var isUpdated = await _service.UpdateAdminAccountNumberCheckAsync(model);
            if (!isUpdated)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAdminAccountNumberCheckAsync(int id)
        {
            var isDeleted = await _service.DeleteAdminAccountNumberCheckAsync(id);
            if (!isDeleted)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}