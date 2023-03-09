using ActivityTrackingApp.Business.Abstract;
using ActivityTrackingApp.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace ActivityTrackingApp.Business.Concrete
{
    public class ReportManager : IReportService
    {
        private readonly IAppUserService _appUserService;
        private readonly IUserActivitiesService _userActivitiesService;
        private readonly IEventService _eventService;
        public ReportManager(IAppUserService appUserService, IUserActivitiesService userActivitiesService, IEventService eventService)
        {
            _appUserService = appUserService;
            _userActivitiesService = userActivitiesService;
            _eventService = eventService;
        }

        public (string, TimeSpan) GetBestActivity()
        {
            var activity = _userActivitiesService.GetListAsync().Result.Data
                .GroupBy(a => a.EventId)
                .OrderByDescending(f => f.Count())
                .Select(g => new { EventId = g.Key, Count = g.Count(), TotalDuration = g.Sum(a => (a.FinishDate - a.StartDate).Duration().TotalSeconds )  })
                .FirstOrDefault();

            var bestActivityName = _eventService.GetByIdAsync(activity.EventId).Result.Data.Name;


            return activity != null ? (bestActivityName, TimeSpan.FromSeconds(activity.TotalDuration)) : ("Yok", TimeSpan.Zero);

        }
        public (string, TimeSpan) GetWorstActivity()
        {
            var activity = _userActivitiesService.GetListAsync().Result.Data
                .GroupBy(a => a.EventId)
                .OrderBy(f => f.Count())
                .Select(g => new { EventId = g.Key, Count = g.Count(), TotalDuration = g.Sum(a => (a.FinishDate - a.StartDate).Duration().TotalSeconds )  })
                .FirstOrDefault();

            var worstActivityName = _eventService.GetByIdAsync(activity.EventId).Result.Data.Name;


            return activity != null ? (worstActivityName, TimeSpan.FromSeconds(activity.TotalDuration)) : ("Yok", TimeSpan.Zero);

        }

        public (string, TimeSpan) GetMostFrequentActivityForWomen()
        {
            // Kadın kullanıcıların id'leri alınır
            var women = _appUserService.GetListAsync().Result.Data.Where(u => u.Gender == "Kadın").Select(x=>x.Id).ToList();

            // Kadınların aktivitelerini seçilir ve toplam süreleri hesaplanır
            var activities = _userActivitiesService.GetListAsync().Result.Data
                .Where(a => women.Contains(a.AppUserId))
                .GroupBy(a => a.EventTopic.Name)
                .Select(g => new { Name = g.Key, TotalDuration = g.Sum(a => (a.FinishDate - a.StartDate).Duration().TotalSeconds) })
                .ToList();

            // En çok zaman harcanan aktivite order by ile sıralanır
            var mostFrequentActivity = activities.OrderByDescending(a => a.TotalDuration).FirstOrDefault();

            return mostFrequentActivity != null ? (mostFrequentActivity.Name, TimeSpan.FromSeconds(mostFrequentActivity.TotalDuration)) : ("Yok", TimeSpan.Zero);
        }
    }
}
