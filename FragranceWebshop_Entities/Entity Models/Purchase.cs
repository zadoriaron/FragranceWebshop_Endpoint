using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FragranceWebshop_Entities.Entity_Models
{
    public class Purchase
    {
        public string PurchaseId { get; set; }
        public string PerfumId { get; set; }
        public string CustomerId { get; set; }
        public DateTime PurchaseDate { get; set; }

        public virtual Perfum PurchasedPerfum { get; set; }

        public Purchase(string customerid, Perfum purchasedPerfum)
        {
            PurchaseId = Guid.NewGuid().ToString();
            PerfumId = purchasedPerfum.PerfumId;
            CustomerId = customerid;
            PurchaseDate = DateTime.Now;
            PurchasedPerfum = purchasedPerfum;
        }

        public Purchase()
        {
            
        }

    }
}
