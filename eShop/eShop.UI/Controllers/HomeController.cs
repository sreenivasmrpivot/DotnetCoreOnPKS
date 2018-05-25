using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using eShop.UI.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
// using Microsoft.Extensions.Configuration;

namespace eShop.UI.Controllers
{
    public class HomeController : Controller
    {
        // public IConfiguration Configuration { get; }

        // public HomeController(IConfiguration configuration)
        // {
        //     Configuration = configuration;
        // }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Product()
        {
            ViewData["Message"] = "Your Products page.";
            List<Product> prods = null;

            using (HttpClient client1 = new HttpClient())
            {

                HttpResponseMessage response1 = null;
                string stringData1 = null;

                #region "Get Products"

                // var reqUri1 = new Uri(Configuration.GetValue<string>("ESHOP_CATALOG_API_ENDPOINT"));
                var reqUri1 = new Uri("http://35.231.230.129/api/products");
                var request1 = new HttpRequestMessage(HttpMethod.Get, reqUri1);
                request1.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                response1 = client1.SendAsync(request1).Result;

                stringData1 = response1.Content.
                    ReadAsStringAsync().Result;
                prods = JsonConvert.DeserializeObject
                    <List<Product>>(stringData1);

                #endregion

            }

            return View(prods);
        }
        public IActionResult Movie()
        {
            ViewData["Message"] = "Your Movies page.";
            List<Movie> movies = null;

            using (HttpClient client2 = new HttpClient())
            {

                HttpResponseMessage response2 = null;
                string stringData2 = null;

                #region "Get Movies"

                // var reqUri2 = new Uri(Configuration.GetValue<string>("apiendpoint.eshopmovies"));
                var reqUri2 = new Uri("http://35.231.214.13/api/movies");
                var request2 = new HttpRequestMessage(HttpMethod.Get, reqUri2);
                request2.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                response2 = client2.SendAsync(request2).Result;

                stringData2 = response2.Content.
                    ReadAsStringAsync().Result;
                movies = JsonConvert.DeserializeObject
                    <List<Movie>>(stringData2);

                #endregion

            }

            return View(movies);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
