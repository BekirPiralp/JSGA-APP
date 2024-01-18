using System.Linq.Expressions;

namespace JSGABackend.Extensions
{
	public static class FilterExtension
	{
		/**
		 * predicate yüklem, tanım, doğrulayıcı vb...
		 */
		public static bool isNull(this Expression? predicate)
		{
			return predicate == null;
		}

		public static bool isNotNull(this Expression?  predicate)
		{
			return predicate != null;
		}
	}
}
