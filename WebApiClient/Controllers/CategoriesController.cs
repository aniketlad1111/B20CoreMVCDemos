using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebApiClient.Models;
using System.Net.Http.Headers;

namespace WebApiClient.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (hrm, cert, cetChain, policyErrors) => true;

            HttpClient client = new HttpClient(handler);
            client.BaseAddress = new Uri("https://localhost:7286/api/");

            string result =
                client.GetStringAsync(client.BaseAddress + "Categories").Result;

            List<CategoryModel> categories =
                JsonSerializer.Deserialize<List<CategoryModel>>(result);

            return View(categories);
        }
    }
}
