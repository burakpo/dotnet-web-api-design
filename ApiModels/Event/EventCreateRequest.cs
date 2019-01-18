using System;
using System.Collections.Generic;
using System.Text;

namespace ApiModels.Event
{
    public class EventCreateRequest
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime? Date { get; set; }
    }
}
