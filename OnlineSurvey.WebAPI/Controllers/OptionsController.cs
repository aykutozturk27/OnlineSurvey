using Microsoft.AspNetCore.Mvc;
using OnlineSurvey.Business.Abstract;
using OnlineSurvey.Entities.Dtos;

namespace OnlineSurvey.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsController : ControllerBase
    {
        private readonly IOptionService _optionService;

        public OptionsController(IOptionService optionService)
        {
            _optionService = optionService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _optionService.GetAll();
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] OptionAddDto optionAddDto)
        {
            var result = _optionService.Add(optionAddDto);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromBody] OptionUpdateDto optionUpdateDto)
        {
            var result = _optionService.Update(optionUpdateDto);

            if(!result.Success)
                return BadRequest(result);

            return Ok(result);
        }
    }
}
