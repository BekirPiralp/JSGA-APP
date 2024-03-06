﻿namespace JSGAOlusturucu
{
	public abstract class OlusuturCreateHandler : IOlusturucuCreateHandler
	{
		protected IOlusturucuCreateHandler? _nextHandler;
		public void HandleAndNext()
		{
			this.CreateObj();
			if(this._nextHandler != null)
			{
				this._nextHandler.HandleAndNext();
			}
		}

		/// <summary>
		/// Writing your code and add next handler
		/// Sample: this._nextHandler = Handler   ->(OlusturCreateHandle to Layer)
		/// </summary>
		public abstract void CreateObj();//next handler ataması ve obje kayıt yapılacak.
	}
}
