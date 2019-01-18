using System;

namespace ApiModels.Event
{
    public class Event : IEntity
    {
        public int EventID { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public decimal Price { get; set; }
    }
}
