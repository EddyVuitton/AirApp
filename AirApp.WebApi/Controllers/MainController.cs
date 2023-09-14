using AirApp.Data.Context;
//using AirApp.WebApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AirApp.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MainController : ControllerBase
    {
        private readonly ILogger<MainController> _logger;
        //private readonly IApplicationRepository _applicationRepository;
        private readonly IConfiguration _configuration;
        private readonly DBContext _context;

        public MainController(
            ILogger<MainController> logger, 
            //IApplicationRepository applicationRepository, 
            IConfiguration configuration,
            DBContext context)
        {
            _logger = logger;
            //_applicationRepository = applicationRepository;
            _configuration = configuration;
            _context = context;
        }
    }
}