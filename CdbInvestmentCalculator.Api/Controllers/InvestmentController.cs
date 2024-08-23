using CdbInvestmentCalculator.Api.Models;
using CdbInvestmentCalculator.Api.Services;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CdbInvestmentCalculator.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/investment")]
    public class InvestmentController : ApiController
    {
        private readonly InvestmentService _investmentService;

        public InvestmentController()
        {
            _investmentService = new InvestmentService();
        }

        [HttpPost]
        [Route("calculate")]
        public IHttpActionResult Calculate(InvestmentRequest request)
        {
            if (request.InitialAmount <= 0 || request.Months < 1)
            {
                return BadRequest("Invalid input parameters.");
            }

            var result = _investmentService.CalculateCdb(request);
            return Ok(result);
        }
    }
}
