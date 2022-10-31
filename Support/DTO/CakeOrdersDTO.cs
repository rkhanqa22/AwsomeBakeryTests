using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlowProject1.StepDefinitions;

namespace SpecFlowProject1.Support.DTO
{
    public class CakeOrdersDTO
    {
        public string CreatedAt { get; set; }
        public string CakeName { get; set; }
        public string CakeOrderPrice { get; set; }
        public string ClientEmail { get; set; }
        public long CakeOrderId { get; set; }
        public string id { get; set; }
        public long Id { get; set; }
        public long Quantity { get; set; }
        public string price { get; set; }
        public long Price { get; set; }

    }
}
