namespace JSGABackend.Exceptions
{
	public class DeleteException : Exception
	{
		static string _message = "Silme esnasında hata oluştu";
		public DeleteException() : base(_message)
		{

		}

		public DeleteException(string? message) : base(_message)
		{
			_message += message;
		}

		public DeleteException(string? message, Exception? innerException) : base(_message, innerException)
		{
			_message += message;
		}
	}
}
