using AirApp.Data.Context;
using AirApp.WebApi.Helpers;
using AirApp.WebApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AirApp.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MainController : ControllerBase
    {
        private readonly IApplicationRepository _applicationRepository;
        private readonly DBContext _context;

        public MainController(
            IApplicationRepository applicationRepository, 
            DBContext context)
        {
            _applicationRepository = applicationRepository;
            _context = context;
        }

        [HttpGet]
        public DateTime? Index()
        {
            try
            {
                Logger.LogInfo("Zaczynam rozpoczêcie testu");
                var response = _applicationRepository.Test();
                Logger.LogInfo("Koñczê testowanie");

                return response;
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                Logger.LogInfo("B³¹d w teœcie");
                return new DateTime(2100, 1, 1);
            }
        }
    }
}