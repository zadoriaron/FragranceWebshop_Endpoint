using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FragranceWebshop_Data
{
    public class Repository<T>
    {
        FragranceWebshopDbContext ctx;

        public Repository(FragranceWebshopDbContext ctx)
        {
            this.ctx = ctx;
        }




    }
}
