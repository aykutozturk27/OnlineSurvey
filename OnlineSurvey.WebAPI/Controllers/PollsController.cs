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

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _pollService.GetAll();
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpGet("getpollresult")]
        public IActionResult GetPollResult(int pollId)
        {
            var result = _pollService.GetPollResult(pollId);
            if (!result.Success)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] PollAddDto pollAddDto)
        {
            var result = _pollService.Add(pollAddDto);
            if(result.Success)
                return BadRequest(result);
            return Ok(result);
        }
    }
}
