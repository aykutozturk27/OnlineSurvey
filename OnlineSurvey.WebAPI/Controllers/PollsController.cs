using Microsoft.AspNetCore.Mvc;
using OnlineSurvey.Business.Abstract;
using OnlineSurvey.Entities.Dtos;

namespace OnlineSurvey.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PollsController : ControllerBase
    {
        private readonly IPollService _pollService;

        public PollsController(IPollService pollService)
        {
            _pollService = pollService;
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var result = _pollService.GetById(id);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Add([FromBody] PollDto pollDto)
        {
            var result = _pollService.Add(pollDto);
            if(result.Success)
                return BadRequest(result);
            return Ok(result);
        }
    }
}
