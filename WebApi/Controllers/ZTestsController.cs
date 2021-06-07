#if true
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataService.Commons;
using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApi.Handlers;

namespace WebApi.Controllers
{
    [Route("api/tests")]
    [ApiController]
    public class ZTestsController : ControllerBase
    {

        public ZTestsController()
        {
        }

        /// <summary>
        ///    Extract gps location from image
        /// </summary>
        [HttpPost("images/extract-location")]
        [ProducesResponseType(200, Type = typeof(GeoLocation))]
        [ProducesResponseType(400)]
        public IActionResult GetLocationFromPicture([FromForm] FileModel model)
        {
            //giả sử file up lên là ảnh, khỏi valid.
            bool isPicture = DataService.Utilities.ValidateUtils.IsPicture(model.File.ContentType);
            if (!isPicture)
            {
                return BadRequest(new
                {
                    message = "Yêu cầu up lên file ảnh"
                });
            }
            GpsDirectory gps = ImageMetadataReader.ReadMetadata(model.File.OpenReadStream()).OfType<GpsDirectory>()
                .FirstOrDefault();
            if (gps == null)
            {
                return BadRequest(new
                {
                    message = "Ảnh ko có gps info",
                });
            }
            GeoLocation location = gps.GetGeoLocation();
            return Ok(location);
        }

    }

    public class FileModel
    {
        public IFormFile File { get; set; }
    }

}
#endif