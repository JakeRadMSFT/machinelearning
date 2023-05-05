﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Microsoft.Data.Analysis
{
    internal static class PrimitiveColumnContainerHelpers
    {
        internal static DataFrameBuffer<T> GetMutable<T>(this IList<ReadOnlyDataFrameBuffer<T>> bufferList, int index)
            where T : unmanaged
        {
            ReadOnlyDataFrameBuffer<T> sourceBuffer = bufferList[index];
            DataFrameBuffer<T> mutableBuffer = sourceBuffer as DataFrameBuffer<T>;

            if (mutableBuffer == null)
            {
                mutableBuffer = DataFrameBuffer<T>.GetMutableBuffer(sourceBuffer);
            }

            return mutableBuffer;
        }

        internal static void EnsureMutable<T>(this IList<ReadOnlyDataFrameBuffer<T>> bufferList, int index)
            where T : unmanaged
        {
            bufferList.GetMutable(index);
        }
    }
}
