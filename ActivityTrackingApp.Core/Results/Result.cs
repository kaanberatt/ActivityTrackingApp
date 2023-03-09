namespace ActivityTrackingApp.Core.Utilities.Result;
public class Result : IResult
{
	public bool isSuccess { get; }

	public string Message { get; }

	public Result(bool success, string message)
		: this(success)
	{
		Message = message;
	}

	public Result(bool success)
	{
		isSuccess = success;
	}
}