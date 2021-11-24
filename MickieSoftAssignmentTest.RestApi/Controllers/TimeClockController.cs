using Microsoft.AspNetCore.Mvc;
using MickieSoftAssignmentTest.Model;

namespace MickieSoft_Assignment.RestApi
{
	[ApiController]
	[Route("[controller]")]
	public class TimeClockController : ControllerBase
	{
		private readonly TimeClockController _timeclockService;

		public TimeClockController(TimeClockController timeclockService)
		{
			_timeclockService = timeclockService;
		}

		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			var timeclock = _timeclockService.Get(id);
			return Ok(timeclock);
		}

		[HttpGet]
		public IActionResult Find()
		{
			var timeclocks = _timeclockService.Find();
			return Ok(timeclocks);
		}

		[HttpPost]
		public IActionResult Create(TimeClock timclock)
		{
			var createdTimeclock = _timeclockService.Create(timclock);
			return Ok(createdTimeclock);
		}

		[HttpPut("{id}")]
		public IActionResult Update([FromRoute] int id, [FromBody] TimeClock timeclock)
		{
			var updatedTimeclock = _timeclockService.Update(id, timeclock);
			return Ok(updatedTimeclock);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var isDeleted = _timeclockService.Delete(id);
			return Ok();
		}
	}
}