﻿using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Entities.Concrete;
using BungalowVip.Core.Utilities.Result;

namespace ActivityTrackingApp.Business.Concrete;

public class EventManager : IEventService
{
    public Task<IDataResult<Event>> AddAsync(Event model)
    {
        throw new NotImplementedException();
    }
}