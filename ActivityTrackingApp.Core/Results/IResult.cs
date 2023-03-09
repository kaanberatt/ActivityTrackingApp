namespace ActivityTrackingApp.Core.Utilities.Result;
public interface IResult
{
	bool isSuccess { get; }

	string Message { get; }
}