using ApiData.Infastructure;
using ApiModels.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiData.Repositories
{
    public interface IEventRepository : IRepository<Event>
    {

    }
    public class EventRepository : RepositoryBase<Event, EventContext>, IEventRepository
    {
        public EventRepository(IDbFactory<EventContext> dbFactory) : base(dbFactory)
        {
        }
    }
}
