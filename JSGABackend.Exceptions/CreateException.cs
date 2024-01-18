namespace JSGABackend.Exceptions
{
	public class CreateException : Exception
	{
        static string _message= "Kayıt esnasında hata oluştu";
        public CreateException():base(_message)
        {
            
        }

		public CreateException(string? message) : base(_message)
		{
			_message += message;
		}

		public CreateException(string? message,Exception? innerException):base(_message,innerException)
        {
			_message += message;
		}
		
		
	}
}
