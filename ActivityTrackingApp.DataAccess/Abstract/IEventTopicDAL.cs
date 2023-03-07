﻿using ActivityTrackingApp.Core.DataAccess;
using ActivityTrackingApp.Entities.Concrete;

namespace ActivityTrackingApp.DataAccess.Abstract;
public interface IEventTopicDal : IEntityRepositoryAsync<EventTopic>
{
}
