using Microsoft.AspNetCore.Mvc;

namespace Module9_1302220064.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Farrel","Rafli","faisal"
        };

        private readonly ILogger<MahasiswaController> _logger;

        public MahasiswaController(ILogger<MahasiswaController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Mahasiswa")]
        [HttpPost(Name = "Mahasiswa")]

        public IEnumerable<Mahasiswa> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Mahasiswa
            {
                name = "Farrel",
                nim = "1302220064",
                year = 2004
            })
            .ToArray();
        }
    }
}
