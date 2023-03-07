using ActivityTrackingApp.Core.DataAccess.EntityFramework;
using ActivityTrackingApp.DataAccess.Abstract;
using ActivityTrackingApp.DataAccess.Context;
using ActivityTrackingApp.Entities.Concrete;

namespace ActivityTrackingApp.DataAccess.Concrete;

public class EfAppUserDAL : EfEntityRepositoryBaseAsync<AppUser, ActivityTrackingDbContext>, IAppUserDAL
{
}
