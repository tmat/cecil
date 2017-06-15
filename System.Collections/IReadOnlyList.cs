﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Collections.Generic
{
	// Provides a read-only, covariant view of a generic list.
	internal interface IReadOnlyList<T> : IReadOnlyCollection<T>
	{
		T this[int index] { get; }
	}
}