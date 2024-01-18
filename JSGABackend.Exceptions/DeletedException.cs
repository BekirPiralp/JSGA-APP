namespace JSGABackend.Exceptions
{
	public class DeletedException : Exception
	{
		static string _message = "Daha önce bu nesne silinmiş";
		public DeletedException() : base(_message)
		{

		}

		public DeletedException(string? message) : base(_message)
		{
			_message += message;
		}

		public DeletedException(string? message, Exception? innerException) : base(_message, innerException)
		{
			_message += message;
		}
	}
}
