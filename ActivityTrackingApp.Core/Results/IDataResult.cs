namespace BungalowVip.Core.Utilities.Result;
public interface IDataResult<out T> : IResult
{
	T Data { get; }
}