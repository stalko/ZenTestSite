using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenTestSite.Models.DataBase;

namespace ZenTestSite.Models
{
    public class FileParser : Parser
    {
        public FileParser(IItemsRepository rep) : base(rep)
        {

        }

        protected async override Task GetText(string str)
        {
            try
            {
                Text = System.IO.File.ReadAllText(str);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
