namespace JSGABackend.Responses
{
	public class Response<T>
	{
		private bool _status = false;
		private bool _messageStatus = false;
		private string? _message;
		private T? _result = default(T); // varsayılanı null ise null olur
		private Response() { }
		public Response(T t,bool status) {
			_status = status;
			_result = t;
		}

		public Response(bool status,string? message) {
			_status = status;
			_message = message;
		}

		public Response(string? message) {
			this.message = message;
		}
		public bool Status { 
			get { return _status; } 
		}
		public string? Message
		{
			get {				
				return _messageStatus ? _message : null ; 
			}
		}

		public T? Value{
			get {
				return this._result;
			}
		}

		private string? message
		{
			set
			{
				if (value == null || value.Trim().Length<0)
				{
					_message = null;
					_messageStatus = false;
				}
				else
				{
					_message = value;
					_messageStatus = true;
				}
			}
		}


	}
}
