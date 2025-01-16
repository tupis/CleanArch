using Application.Contracts.DigitalAccount.Dto;
using Application.Contracts.DigitalAccount.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DigitalAccountController(DigitalAccountService service) : ControllerBase
    {

        private readonly DigitalAccountService _service = service;

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateDigitalAccountDto digitalAccountDto)
        {

            if (digitalAccountDto.Amount <= 0)
                return BadRequest("Amount must be greater than 0");

            if (digitalAccountDto.Amount > 100000)
                return BadRequest("Amount must be less than 100000");

            if(digitalAccountDto == null) 
                return BadRequest("Invalid data");

            CreateDigitalAccountDto digitalAccount = new(Amount: digitalAccountDto.Amount);

            var response = await _service.Create(digitalAccount);
            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(Guid id)
        {
            var data = await _service.GetById(id);

            if (data == null)
                return NotFound(data);

            return Ok(data);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteById(Guid id)
        {
            var data = await _service.DeleteById(id);

            if (data == null) return NotFound(data);

            return Ok(data);
        }
    }
}
