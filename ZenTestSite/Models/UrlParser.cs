using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ZenTestSite.Models.DataBase;

namespace ZenTestSite.Models
{
    public class UrlParser : Parser
    {
        public UrlParser(IItemsRepository rep) : base(rep)
        {

        }

        protected async override Task GetText(string str)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    using (HttpResponseMessage response = client.GetAsync(str, HttpCompletionOption.ResponseHeadersRead).Result)
                    {
                        response.EnsureSuccessStatusCode();
                        Text = await response.Content.ReadAsStringAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
