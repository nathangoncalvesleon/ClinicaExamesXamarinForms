using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ClinicaExames.Models;
using Newtonsoft.Json;

namespace ClinicaExames.Services
{
    public class ClinicaService
    {
        private readonly string urlBase = "http://localhost:5528/api/exame";
        public async Task<List<Exames>> GetAll()
        {
            using (var client = new HttpClient()) 
            {
              var result = await client.GetStringAsync(urlBase);
                return JsonConvert.DeserializeObject<List<Exames>>(result);
            }

        }
    }
}
