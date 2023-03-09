using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.Entities.Concrete;
using ActivityTrackingApp.Core.Utilities.Result;
using ActivityTrackingApp.DataAccess.Abstract;
using ActivityTrackingApp.Business.Constants;

namespace ActivityTrackingApp.Business.Concrete;

public class EventTopicManager : IEventTopicService
{
    private readonly IEventTopicDAL _eventTopicDAL;

    public EventTopicManager(IEventTopicDAL eventTopicDAL)
    {
        _eventTopicDAL = eventTopicDAL;
    }

    public Task<IDataResult<EventTopic>> AddAsync(EventTopic eventTopic)
    {
        throw new NotImplementedException();
    }

    public async Task<IResult> DataVerification(int id)
    {
        try
        {
            var data = await _eventTopicDAL.GetFirstOrDefaultAsync(x => x.Id == id);   
            if (data != null)
            {
                return new SuccessResult(Messages.VerificationTrue);
            }
            return new ErrorResult(Messages.ErrorMessage);
        }
        catch (Exception ex)
        {
            return new ErrorResult(ex.Message);
        }
    }
}
