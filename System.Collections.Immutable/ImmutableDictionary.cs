// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// Stub file, not functional.

using System.Collections.Generic;

namespace System.Collections.Immutable
{
	public class ImmutableDictionary<K, V>
	{
	}

	internal static class EnumerableExtensions
	{
		public static ImmutableDictionary<TKey, TValue> ToImmutableDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source)
		{
			throw new NotImplementedException();
		}
	}
}
