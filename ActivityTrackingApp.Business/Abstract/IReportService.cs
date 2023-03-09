namespace ActivityTrackingApp.Business.Abstract
{
    public interface IReportService
    {
        (string, TimeSpan) GetMostFrequentActivityForWomen();
        (string, TimeSpan) GetBestActivity();
        (string, TimeSpan) GetWorstActivity();
    }
}
