using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CustomConfiguration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrenciesController : Controller
    {
        private readonly CurrencyOptions _currencies;

        public CurrenciesController(IOptions<CurrencyOptions> currencies)
        {
            _currencies = currencies.Value;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return _currencies.DefaultCurrency;
        }

    }
}
