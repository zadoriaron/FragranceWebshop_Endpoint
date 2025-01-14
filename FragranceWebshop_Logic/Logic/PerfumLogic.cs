using FragranceWebshop_Data;
using FragranceWebshop_Entities.Entity_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FragranceWebshop_Logic.Logic
{
    public class PerfumLogic
    {
        Repository<Perfum> repo;


        public PerfumLogic(Repository<Perfum> repo)
        {
            this.repo = repo;
        }



    }
}
