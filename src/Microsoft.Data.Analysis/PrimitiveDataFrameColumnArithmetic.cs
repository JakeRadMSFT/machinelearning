

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// Generated from PrimitiveDataFrameColumnArithmetic.tt. Do not modify directly

using System;

namespace Microsoft.Data.Analysis
{

    internal static class PrimitiveDataFrameColumnArithmetic<T>
        where T : unmanaged
    {
        public static IPrimitiveDataFrameColumnArithmetic<T> Instance { get; } = PrimitiveDataFrameColumnArithmetic.GetArithmetic<T>();
    }

    internal static class PrimitiveDataFrameColumnArithmetic
    {
        public static IPrimitiveDataFrameColumnArithmetic<T> GetArithmetic<T>()
            where T : unmanaged
        {
            if (typeof(T) == typeof(bool))
            {
                return (IPrimitiveDataFrameColumnArithmetic<T>)new BoolArithmetic();
            }
            else if (typeof(T) == typeof(byte))
            {
                return (IPrimitiveDataFrameColumnArithmetic<T>)new NumberDataFrameColumnArithmetic<byte>();
            }
            else if (typeof(T) == typeof(char))
            {
                return (IPrimitiveDataFrameColumnArithmetic<T>)new NumberDataFrameColumnArithmetic<char>();
            }
            else if (typeof(T) == typeof(decimal))
            {
                return (IPrimitiveDataFrameColumnArithmetic<T>)new FloatingPointDataFrameColumnArithmetic<decimal>();
            }
            else if (typeof(T) == typeof(double))
            {
                return (IPrimitiveDataFrameColumnArithmetic<T>)new FloatingPointDataFrameColumnArithmetic<double>();
            }
            else if (typeof(T) == typeof(float))
            {
                return (IPrimitiveDataFrameColumnArithmetic<T>)new FloatingPointDataFrameColumnArithmetic<float>();
            }
            else if (typeof(T) == typeof(int))
            {
                return (IPrimitiveDataFrameColumnArithmetic<T>)new NumberDataFrameColumnArithmetic<int>();
            }
            else if (typeof(T) == typeof(long))
            {
                return (IPrimitiveDataFrameColumnArithmetic<T>)new NumberDataFrameColumnArithmetic<long>();
            }
            else if (typeof(T) == typeof(sbyte))
            {
                return (IPrimitiveDataFrameColumnArithmetic<T>)new NumberDataFrameColumnArithmetic<sbyte>();
            }
            else if (typeof(T) == typeof(short))
            {
                return (IPrimitiveDataFrameColumnArithmetic<T>)new NumberDataFrameColumnArithmetic<short>();
            }
            else if (typeof(T) == typeof(uint))
            {
                return (IPrimitiveDataFrameColumnArithmetic<T>)new NumberDataFrameColumnArithmetic<uint>();
            }
            else if (typeof(T) == typeof(ulong))
            {
                return (IPrimitiveDataFrameColumnArithmetic<T>)new NumberDataFrameColumnArithmetic<ulong>();
            }
            else if (typeof(T) == typeof(ushort))
            {
                return (IPrimitiveDataFrameColumnArithmetic<T>)new NumberDataFrameColumnArithmetic<ushort>();
            }
            else if (typeof(T) == typeof(DateTime))
            {
                return (IPrimitiveDataFrameColumnArithmetic<T>)new DateTimeArithmetic();
            }
            throw new NotSupportedException();
        }
    }
    internal class BoolArithmetic : IPrimitiveDataFrameColumnArithmetic<bool>
    {

        public void Add(PrimitiveColumnContainer<bool> left, PrimitiveColumnContainer<bool> right)
        {
            throw new NotSupportedException();
        }

        public void Add(PrimitiveColumnContainer<bool> column, bool scalar)
        {
            throw new NotSupportedException();
        }

        public void Add(bool scalar, PrimitiveColumnContainer<bool> column)
        {
            throw new NotSupportedException();
        }

        public void Subtract(PrimitiveColumnContainer<bool> left, PrimitiveColumnContainer<bool> right)
        {
            throw new NotSupportedException();
        }

        public void Subtract(PrimitiveColumnContainer<bool> column, bool scalar)
        {
            throw new NotSupportedException();
        }

        public void Subtract(bool scalar, PrimitiveColumnContainer<bool> column)
        {
            throw new NotSupportedException();
        }

        public void Multiply(PrimitiveColumnContainer<bool> left, PrimitiveColumnContainer<bool> right)
        {
            throw new NotSupportedException();
        }

        public void Multiply(PrimitiveColumnContainer<bool> column, bool scalar)
        {
            throw new NotSupportedException();
        }

        public void Multiply(bool scalar, PrimitiveColumnContainer<bool> column)
        {
            throw new NotSupportedException();
        }

        public void Divide(PrimitiveColumnContainer<bool> left, PrimitiveColumnContainer<bool> right)
        {
            throw new NotSupportedException();
        }

        public void Divide(PrimitiveColumnContainer<bool> column, bool scalar)
        {
            throw new NotSupportedException();
        }

        public void Divide(bool scalar, PrimitiveColumnContainer<bool> column)
        {
            throw new NotSupportedException();
        }

        public void Modulo(PrimitiveColumnContainer<bool> left, PrimitiveColumnContainer<bool> right)
        {
            throw new NotSupportedException();
        }

        public void Modulo(PrimitiveColumnContainer<bool> column, bool scalar)
        {
            throw new NotSupportedException();
        }

        public void Modulo(bool scalar, PrimitiveColumnContainer<bool> column)
        {
            throw new NotSupportedException();
        }

        public void And(PrimitiveColumnContainer<bool> left, PrimitiveColumnContainer<bool> right)
        {
            for (int b = 0; b < left.Buffers.Count; b++)
            {
                var mutableBuffer = left.Buffers.GetOrCreateMutable(b);
                var span = mutableBuffer.Span;
                var otherSpan = right.Buffers[b].ReadOnlySpan;
                for (int i = 0; i < span.Length; i++)
                {
                    span[i] = (bool)(span[i] & otherSpan[i]);
                }
            }
        }

        public void And(PrimitiveColumnContainer<bool> column, bool scalar)
        {
            for (int b = 0; b < column.Buffers.Count; b++)
            {
                var mutableBuffer = column.Buffers.GetOrCreateMutable(b);
                var span = mutableBuffer.Span;
                for (int i = 0; i < span.Length; i++)
                {
                    span[i] = (bool)(span[i] & scalar);
                }
            }
        }

        public void And(bool scalar, PrimitiveColumnContainer<bool> column)
        {
            for (int b = 0; b < column.Buffers.Count; b++)
            {
                var mutableBuffer = column.Buffers.GetOrCreateMutable(b);
                var span = mutableBuffer.Span;
                for (int i = 0; i < span.Length; i++)
                {
                    span[i] = (bool)(scalar & span[i]);
                }
            }
        }

        public void Or(PrimitiveColumnContainer<bool> left, PrimitiveColumnContainer<bool> right)
        {
            for (int b = 0; b < left.Buffers.Count; b++)
            {
                var mutableBuffer = left.Buffers.GetOrCreateMutable(b);
                var span = mutableBuffer.Span;
                var otherSpan = right.Buffers[b].ReadOnlySpan;
                for (int i = 0; i < span.Length; i++)
                {
                    span[i] = (bool)(span[i] | otherSpan[i]);
                }
            }
        }

        public void Or(PrimitiveColumnContainer<bool> column, bool scalar)
        {
            for (int b = 0; b < column.Buffers.Count; b++)
            {
                var mutableBuffer = column.Buffers.GetOrCreateMutable(b);
                var span = mutableBuffer.Span;
                for (int i = 0; i < span.Length; i++)
                {
                    span[i] = (bool)(span[i] | scalar);
                }
            }
        }

        public void Or(bool scalar, PrimitiveColumnContainer<bool> column)
        {
            for (int b = 0; b < column.Buffers.Count; b++)
            {
                var mutableBuffer = column.Buffers.GetOrCreateMutable(b);
                var span = mutableBuffer.Span;
                for (int i = 0; i < span.Length; i++)
                {
                    span[i] = (bool)(scalar | span[i]);
                }
            }
        }

        public void Xor(PrimitiveColumnContainer<bool> left, PrimitiveColumnContainer<bool> right)
        {
            for (int b = 0; b < left.Buffers.Count; b++)
            {
                var mutableBuffer = left.Buffers.GetOrCreateMutable(b);
                var span = mutableBuffer.Span;
                var otherSpan = right.Buffers[b].ReadOnlySpan;
                for (int i = 0; i < span.Length; i++)
                {
                    span[i] = (bool)(span[i] ^ otherSpan[i]);
                }
            }
        }

        public void Xor(PrimitiveColumnContainer<bool> column, bool scalar)
        {
            for (int b = 0; b < column.Buffers.Count; b++)
            {
                var mutableBuffer = column.Buffers.GetOrCreateMutable(b);
                var span = mutableBuffer.Span;
                for (int i = 0; i < span.Length; i++)
                {
                    span[i] = (bool)(span[i] ^ scalar);
                }
            }
        }

        public void Xor(bool scalar, PrimitiveColumnContainer<bool> column)
        {
            for (int b = 0; b < column.Buffers.Count; b++)
            {
                var mutableBuffer = column.Buffers.GetOrCreateMutable(b);
                var span = mutableBuffer.Span;
                for (int i = 0; i < span.Length; i++)
                {
                    span[i] = (bool)(scalar ^ span[i]);
                }
            }
        }

        public void LeftShift(PrimitiveColumnContainer<bool> column, int value)
        {
            throw new NotSupportedException();
        }

        public void RightShift(PrimitiveColumnContainer<bool> column, int value)
        {
            throw new NotSupportedException();
        }

        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<bool> left, PrimitiveColumnContainer<bool> right)
        {
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            long index = 0;
            for (int b = 0; b < left.Buffers.Count; b++)
            {
                var span = left.Buffers[b].ReadOnlySpan;
                var otherSpan = right.Buffers[b].ReadOnlySpan;
                for (int i = 0; i < span.Length; i++)
                {
                    ret[index++] = (span[i] == otherSpan[i]);
                }
            }
            return ret;
        }

        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<bool> column, bool scalar)
        {
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            long index = 0;
            for (int b = 0; b < column.Buffers.Count; b++)
            {
                var span = column.Buffers[b].ReadOnlySpan;
                for (int i = 0; i < span.Length; i++)
                {
                    ret[index++] = (span[i] == scalar);
                }
            }
            return ret;
        }

        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<bool> left, PrimitiveColumnContainer<bool> right)
        {
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            long index = 0;
            for (int b = 0; b < left.Buffers.Count; b++)
            {
                var span = left.Buffers[b].ReadOnlySpan;
                var otherSpan = right.Buffers[b].ReadOnlySpan;
                for (int i = 0; i < span.Length; i++)
                {
                    ret[index++] = (span[i] != otherSpan[i]);
                }
            }
            return ret;
        }

        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<bool> column, bool scalar)
        {
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            long index = 0;
            for (int b = 0; b < column.Buffers.Count; b++)
            {
                var span = column.Buffers[b].ReadOnlySpan;
                for (int i = 0; i < span.Length; i++)
                {
                    ret[index++] = (span[i] != scalar);
                }
            }
            return ret;
        }

        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<bool> left, PrimitiveColumnContainer<bool> right)
        {
            throw new NotSupportedException();
        }

        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<bool> column, bool scalar)
        {
            throw new NotSupportedException();
        }

        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<bool> left, PrimitiveColumnContainer<bool> right)
        {
            throw new NotSupportedException();
        }

        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<bool> column, bool scalar)
        {
            throw new NotSupportedException();
        }

        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<bool> left, PrimitiveColumnContainer<bool> right)
        {
            throw new NotSupportedException();
        }

        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<bool> column, bool scalar)
        {
            throw new NotSupportedException();
        }

        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<bool> left, PrimitiveColumnContainer<bool> right)
        {
            throw new NotSupportedException();
        }

        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<bool> column, bool scalar)
        {
            throw new NotSupportedException();
        }
    }



























        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<byte> left, PrimitiveColumnContainer<byte> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<byte> column, byte scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<byte> left, PrimitiveColumnContainer<byte> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<byte> column, byte scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<byte> left, PrimitiveColumnContainer<byte> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<byte> column, byte scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<byte> left, PrimitiveColumnContainer<byte> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<byte> column, byte scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<byte> left, PrimitiveColumnContainer<byte> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<byte> column, byte scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<byte> left, PrimitiveColumnContainer<byte> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<byte> column, byte scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;


























        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<char> left, PrimitiveColumnContainer<char> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<char> column, char scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<char> left, PrimitiveColumnContainer<char> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<char> column, char scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<char> left, PrimitiveColumnContainer<char> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<char> column, char scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<char> left, PrimitiveColumnContainer<char> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<char> column, char scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<char> left, PrimitiveColumnContainer<char> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<char> column, char scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<char> left, PrimitiveColumnContainer<char> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<char> column, char scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;


























        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<decimal> left, PrimitiveColumnContainer<decimal> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<decimal> column, decimal scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<decimal> left, PrimitiveColumnContainer<decimal> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<decimal> column, decimal scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<decimal> left, PrimitiveColumnContainer<decimal> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<decimal> column, decimal scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<decimal> left, PrimitiveColumnContainer<decimal> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<decimal> column, decimal scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<decimal> left, PrimitiveColumnContainer<decimal> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<decimal> column, decimal scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<decimal> left, PrimitiveColumnContainer<decimal> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<decimal> column, decimal scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;


























        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<double> left, PrimitiveColumnContainer<double> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<double> column, double scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<double> left, PrimitiveColumnContainer<double> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<double> column, double scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<double> left, PrimitiveColumnContainer<double> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<double> column, double scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<double> left, PrimitiveColumnContainer<double> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<double> column, double scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<double> left, PrimitiveColumnContainer<double> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<double> column, double scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<double> left, PrimitiveColumnContainer<double> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<double> column, double scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;


























        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<float> left, PrimitiveColumnContainer<float> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<float> column, float scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<float> left, PrimitiveColumnContainer<float> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<float> column, float scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<float> left, PrimitiveColumnContainer<float> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<float> column, float scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<float> left, PrimitiveColumnContainer<float> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<float> column, float scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<float> left, PrimitiveColumnContainer<float> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<float> column, float scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<float> left, PrimitiveColumnContainer<float> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<float> column, float scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;


























        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<int> left, PrimitiveColumnContainer<int> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<int> column, int scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<int> left, PrimitiveColumnContainer<int> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<int> column, int scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<int> left, PrimitiveColumnContainer<int> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<int> column, int scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<int> left, PrimitiveColumnContainer<int> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<int> column, int scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<int> left, PrimitiveColumnContainer<int> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<int> column, int scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<int> left, PrimitiveColumnContainer<int> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<int> column, int scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;


























        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<long> left, PrimitiveColumnContainer<long> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<long> column, long scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<long> left, PrimitiveColumnContainer<long> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<long> column, long scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<long> left, PrimitiveColumnContainer<long> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<long> column, long scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<long> left, PrimitiveColumnContainer<long> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<long> column, long scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<long> left, PrimitiveColumnContainer<long> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<long> column, long scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<long> left, PrimitiveColumnContainer<long> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<long> column, long scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;


























        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<sbyte> left, PrimitiveColumnContainer<sbyte> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<sbyte> column, sbyte scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<sbyte> left, PrimitiveColumnContainer<sbyte> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<sbyte> column, sbyte scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<sbyte> left, PrimitiveColumnContainer<sbyte> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<sbyte> column, sbyte scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<sbyte> left, PrimitiveColumnContainer<sbyte> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<sbyte> column, sbyte scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<sbyte> left, PrimitiveColumnContainer<sbyte> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<sbyte> column, sbyte scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<sbyte> left, PrimitiveColumnContainer<sbyte> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<sbyte> column, sbyte scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;


























        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<short> left, PrimitiveColumnContainer<short> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<short> column, short scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<short> left, PrimitiveColumnContainer<short> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<short> column, short scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<short> left, PrimitiveColumnContainer<short> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<short> column, short scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<short> left, PrimitiveColumnContainer<short> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<short> column, short scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<short> left, PrimitiveColumnContainer<short> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<short> column, short scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<short> left, PrimitiveColumnContainer<short> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<short> column, short scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;


























        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<uint> left, PrimitiveColumnContainer<uint> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<uint> column, uint scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<uint> left, PrimitiveColumnContainer<uint> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<uint> column, uint scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<uint> left, PrimitiveColumnContainer<uint> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<uint> column, uint scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<uint> left, PrimitiveColumnContainer<uint> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<uint> column, uint scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<uint> left, PrimitiveColumnContainer<uint> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<uint> column, uint scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<uint> left, PrimitiveColumnContainer<uint> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<uint> column, uint scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;


























        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<ulong> left, PrimitiveColumnContainer<ulong> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<ulong> column, ulong scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<ulong> left, PrimitiveColumnContainer<ulong> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<ulong> column, ulong scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<ulong> left, PrimitiveColumnContainer<ulong> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<ulong> column, ulong scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<ulong> left, PrimitiveColumnContainer<ulong> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<ulong> column, ulong scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<ulong> left, PrimitiveColumnContainer<ulong> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<ulong> column, ulong scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<ulong> left, PrimitiveColumnContainer<ulong> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<ulong> column, ulong scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;


























        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<ushort> left, PrimitiveColumnContainer<ushort> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<ushort> column, ushort scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<ushort> left, PrimitiveColumnContainer<ushort> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<ushort> column, ushort scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<ushort> left, PrimitiveColumnContainer<ushort> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<ushort> column, ushort scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<ushort> left, PrimitiveColumnContainer<ushort> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<ushort> column, ushort scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<ushort> left, PrimitiveColumnContainer<ushort> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<ushort> column, ushort scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<ushort> left, PrimitiveColumnContainer<ushort> right)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            return ret;
        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<ushort> column, ushort scalar)
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            return ret;
    internal class DateTimeArithmetic : IPrimitiveDataFrameColumnArithmetic<DateTime>
    {

        public void Add(PrimitiveColumnContainer<DateTime> left, PrimitiveColumnContainer<DateTime> right)
        {
            throw new NotSupportedException();
        }

        public void Add(PrimitiveColumnContainer<DateTime> column, DateTime scalar)
        {
            throw new NotSupportedException();
        }

        public void Add(DateTime scalar, PrimitiveColumnContainer<DateTime> column)
        {
            throw new NotSupportedException();
        }

        public void Subtract(PrimitiveColumnContainer<DateTime> left, PrimitiveColumnContainer<DateTime> right)
        {
            throw new NotSupportedException();
        }

        public void Subtract(PrimitiveColumnContainer<DateTime> column, DateTime scalar)
        {
            throw new NotSupportedException();
        }

        public void Subtract(DateTime scalar, PrimitiveColumnContainer<DateTime> column)
        {
            throw new NotSupportedException();
        }

        public void Multiply(PrimitiveColumnContainer<DateTime> left, PrimitiveColumnContainer<DateTime> right)
        {
            throw new NotSupportedException();
        }

        public void Multiply(PrimitiveColumnContainer<DateTime> column, DateTime scalar)
        {
            throw new NotSupportedException();
        }

        public void Multiply(DateTime scalar, PrimitiveColumnContainer<DateTime> column)
        {
            throw new NotSupportedException();
        }

        public void Divide(PrimitiveColumnContainer<DateTime> left, PrimitiveColumnContainer<DateTime> right)
        {
            throw new NotSupportedException();
        }

        public void Divide(PrimitiveColumnContainer<DateTime> column, DateTime scalar)
        {
            throw new NotSupportedException();
        }

        public void Divide(DateTime scalar, PrimitiveColumnContainer<DateTime> column)
        {
            throw new NotSupportedException();
        }

        public void Modulo(PrimitiveColumnContainer<DateTime> left, PrimitiveColumnContainer<DateTime> right)
        {
            throw new NotSupportedException();
        }

        public void Modulo(PrimitiveColumnContainer<DateTime> column, DateTime scalar)
        {
            throw new NotSupportedException();
        }

        public void Modulo(DateTime scalar, PrimitiveColumnContainer<DateTime> column)
        {
            throw new NotSupportedException();
        }

        public void And(PrimitiveColumnContainer<DateTime> left, PrimitiveColumnContainer<DateTime> right)
        {
            throw new NotSupportedException();
        }

        public void And(PrimitiveColumnContainer<DateTime> column, DateTime scalar)
        {
            throw new NotSupportedException();
        }

        public void And(DateTime scalar, PrimitiveColumnContainer<DateTime> column)
        {
            throw new NotSupportedException();
        }

        public void Or(PrimitiveColumnContainer<DateTime> left, PrimitiveColumnContainer<DateTime> right)
        {
            throw new NotSupportedException();
        }

        public void Or(PrimitiveColumnContainer<DateTime> column, DateTime scalar)
        {
            throw new NotSupportedException();
        }

        public void Or(DateTime scalar, PrimitiveColumnContainer<DateTime> column)
        {
            throw new NotSupportedException();
        }

        public void Xor(PrimitiveColumnContainer<DateTime> left, PrimitiveColumnContainer<DateTime> right)
        {
            throw new NotSupportedException();
        }

        public void Xor(PrimitiveColumnContainer<DateTime> column, DateTime scalar)
        {
            throw new NotSupportedException();
        }

        public void Xor(DateTime scalar, PrimitiveColumnContainer<DateTime> column)
        {
            throw new NotSupportedException();
        }

        public void LeftShift(PrimitiveColumnContainer<DateTime> column, int value)
        {
            throw new NotSupportedException();
        }

        public void RightShift(PrimitiveColumnContainer<DateTime> column, int value)
        {
            throw new NotSupportedException();
        }

        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<DateTime> left, PrimitiveColumnContainer<DateTime> right)
        {
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            long index = 0;
            for (int b = 0; b < left.Buffers.Count; b++)
            {
                var span = left.Buffers[b].ReadOnlySpan;
                var otherSpan = right.Buffers[b].ReadOnlySpan;
                for (int i = 0; i < span.Length; i++)
                {
                    ret[index++] = (span[i] == otherSpan[i]);
                }
            }
            return ret;
        }

        public PrimitiveColumnContainer<bool> ElementwiseEquals(PrimitiveColumnContainer<DateTime> column, DateTime scalar)
        {
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            long index = 0;
            for (int b = 0; b < column.Buffers.Count; b++)
            {
                var span = column.Buffers[b].ReadOnlySpan;
                for (int i = 0; i < span.Length; i++)
                {
                    ret[index++] = (span[i] == scalar);
                }
            }
            return ret;
        }

        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<DateTime> left, PrimitiveColumnContainer<DateTime> right)
        {
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(left.Length);
            long index = 0;
            for (int b = 0; b < left.Buffers.Count; b++)
            {
                var span = left.Buffers[b].ReadOnlySpan;
                var otherSpan = right.Buffers[b].ReadOnlySpan;
                for (int i = 0; i < span.Length; i++)
                {
                    ret[index++] = (span[i] != otherSpan[i]);
                }
            }
            return ret;
        }

        public PrimitiveColumnContainer<bool> ElementwiseNotEquals(PrimitiveColumnContainer<DateTime> column, DateTime scalar)
        {
            PrimitiveColumnContainer<bool> ret = new PrimitiveColumnContainer<bool>(column.Length);
            long index = 0;
            for (int b = 0; b < column.Buffers.Count; b++)
            {
                var span = column.Buffers[b].ReadOnlySpan;
                for (int i = 0; i < span.Length; i++)
                {
                    ret[index++] = (span[i] != scalar);
                }
            }
            return ret;
        }

        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<DateTime> left, PrimitiveColumnContainer<DateTime> right)
        {
            throw new NotSupportedException();
        }

        public PrimitiveColumnContainer<bool> ElementwiseGreaterThanOrEqual(PrimitiveColumnContainer<DateTime> column, DateTime scalar)
        {
            throw new NotSupportedException();
        }

        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<DateTime> left, PrimitiveColumnContainer<DateTime> right)
        {
            throw new NotSupportedException();
        }

        public PrimitiveColumnContainer<bool> ElementwiseLessThanOrEqual(PrimitiveColumnContainer<DateTime> column, DateTime scalar)
        {
            throw new NotSupportedException();
        }

        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<DateTime> left, PrimitiveColumnContainer<DateTime> right)
        {
            throw new NotSupportedException();
        }

        public PrimitiveColumnContainer<bool> ElementwiseGreaterThan(PrimitiveColumnContainer<DateTime> column, DateTime scalar)
        {
            throw new NotSupportedException();
        }

        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<DateTime> left, PrimitiveColumnContainer<DateTime> right)
        {
            throw new NotSupportedException();
        }

        public PrimitiveColumnContainer<bool> ElementwiseLessThan(PrimitiveColumnContainer<DateTime> column, DateTime scalar)
        {
            throw new NotSupportedException();
        }
    }
}
