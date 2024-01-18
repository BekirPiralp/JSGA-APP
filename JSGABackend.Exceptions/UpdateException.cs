namespace JSGABackend.Exceptions
{
	public class UpdateException : Exception
	{
		static string _message = "Güncelleme esnasında hata oluştu";
		public UpdateException() : base(_message)
		{

		}

		public UpdateException(string? message) : base(_message)
		{
			_message += message;
		}

		public UpdateException(string? message, Exception? innerException) : base(_message, innerException)
		{
			_message += message;
		}
	}
}
