using MickieSoftAssignmentTest.Model;
using MickieSoftAssignmentTest.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace MickieSoft_Assignment.RestApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class QrCodeController : ControllerBase
	{
		private readonly IQrCodeService _qrcodeService;

		public QrCodeController(IQrCodeService qrcodeService)
		{
			_qrcodeService = qrcodeService;
		}

		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			var qrcode = _qrcodeService.Get(id);
			return Ok(qrcode);
		}

		[HttpGet]
		public IActionResult Find()
		{
			var qrcodes = _qrcodeService.Find();
			return Ok(qrcodes);
		}

		[HttpPost]
		public IActionResult Create(QrCode qrcode)
		{
			var createdQrcode = _qrcodeService.Create(qrcode);
			return Ok(createdQrcode);
		}

		[HttpPut("{id}")]
		public IActionResult Update([FromRoute] int id, [FromBody] QrCode qrcode)
		{
			var updatedQrcode = _qrcodeService.Update(id, qrcode);
			return Ok(updatedQrcode);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var isDeleted = _qrcodeService.Delete(id);
			if (!isDeleted)
			{
				return BadRequest();
			}

			return Ok();
		}
	}
}
