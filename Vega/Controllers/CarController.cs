using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Vega.Data;
using Vega.Models;

namespace Vega.Controllers
{
    public class CarController : Controller
    {
        /// <summary>
        /// The Database context.
        /// </summary>
        VegaContext context;

        public CarController(VegaContext context)
        {
            this.context = context;
        }

        [HttpGet("/api/makes")]
        public List<Make> GetMakes()
        {
            return context.Makes.ToList();
        }
    }
}