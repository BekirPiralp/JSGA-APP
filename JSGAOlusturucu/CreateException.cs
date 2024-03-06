﻿namespace JSGAOlusturucu
{
	public class CreateException : Exception
	{
        private static string _message = "Kayıt Esnasında Hata Oluştu.\n";
        public CreateException() : base(_message) 
        {
            
        }
		public CreateException(string? message):base(_message+message)
		{

		}
		public CreateException(string? message, Exception? innerException):base(_message+message, innerException)
        {

        }
    }
}
