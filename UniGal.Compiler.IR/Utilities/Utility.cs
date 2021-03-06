using System.Collections;
using System.Collections.Generic;

namespace UniGal.Compiler.IR.Utilities
{
	internal static class Utility
	{
		public static bool IsNotEmpty(this IEnumerable? collection)
		{
			if (collection == null) return false;
			return collection.GetEnumerator().MoveNext();
		}

		public static bool IsNotEmpty<T>(this IEnumerable<T>? collection)
		{
			if (collection == null) return false;
			using var iterator = collection.GetEnumerator();
			return iterator.MoveNext();
		}
	}
}
