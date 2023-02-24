using Aplikacija.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija.Services
{
    public class SalaService
    {
        private static SalaService instance;
        private SaleRepository saleRepo;

        private SalaService()
        {
            saleRepo = new SaleRepository();
        }

        public static SalaService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SalaService();
                }

                return instance;
            }
        }
    }
}
