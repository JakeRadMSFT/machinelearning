// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// Generated from PrimitiveDataFrameColumnArithmetic.tt. Do not modify directly

namespace Microsoft.Data.Analysis
{
    internal interface IPrimitiveDataFrameColumnArithmetic<T>
        where T : unmanaged
    {
        void Add(PrimitiveColumnContainer<T> left, PrimitiveColumnContainer<T> right);
        void Add(PrimitiveColumnContainer<T> column, T scalar);
        void Add(T scalar, PrimitiveColumnContainer<T> column);
        void Subtract(PrimitiveColumnContainer<T> left, PrimitiveColumnContainer<T> right);
        void Subtract(PrimitiveColumnContainer<T> column, T scalar);
        void Subtract(T scalar, PrimitiveColumnContainer<T> column);
        void Multiply(PrimitiveColumnContainer<T> left, PrimitiveColumnContainer<T> right);
        void Multiply(PrimitiveColumnContainer<T> column, T scalar);
        void Multiply(T scalar, PrimitiveColumnContainer<T> column);
        void Divide(PrimitiveColumnContainer<T> left, PrimitiveColumnContainer<T> right);
        void Divide(PrimitiveColumnContainer<T> column, T scalar);
        void Divide(T scalar, PrimitiveColumnContainer<T> column);
        void Modulo(PrimitiveColumnContainer<T> left, PrimitiveColumnContainer<T> right);
        void Modulo(PrimitiveColumnContainer<T> column, T scalar);
        void Modulo(T scalar, PrimitiveColumnContainer<T> column);
        void And(PrimitiveColumnContainer<T> left, PrimitiveColumnContainer<T> right);
        void And(PrimitiveColumnContainer<T> column, T scalar);
        void And(T scalar, PrimitiveColumnContainer<T> column);
        void Or(PrimitiveColumnContainer<T> left, PrimitiveColumnContainer<T> right);
        void Or(PrimitiveColumnContainer<T> column, T scalar);
        void Or(T scalar, PrimitiveColumnContainer<T> column);
        void Xor(PrimitiveColumnContainer<T> left, PrimitiveColumnContainer<T> right);
        void Xor(PrimitiveColumnContainer<T> column, T scalar);
        void Xor(T scalar, PrimitiveColumnContainer<T> column);
        void LeftShift(PrimitiveColumnContainer<T> column, int value);
        void RightShift(PrimitiveColumnContainer<T> column, int value);
        PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<T> left, PrimitiveColumnContainer<T> right);
        PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<T> column, T scalar);
        PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<T> left, PrimitiveColumnContainer<T> right);
        PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<T> column, T scalar);
        PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<T> left, PrimitiveColumnContainer<T> right);
        PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<T> column, T scalar);
        PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<T> left, PrimitiveColumnContainer<T> right);
        PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<T> column, T scalar);
        PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<T> left, PrimitiveColumnContainer<T> right);
        PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<T> column, T scalar);
        PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<T> left, PrimitiveColumnContainer<T> right);
        PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<T> column, T scalar);
    }
}
