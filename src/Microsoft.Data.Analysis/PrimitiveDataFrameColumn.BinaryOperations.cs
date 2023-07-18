
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// Generated from PrimitiveDataFrameColumn.BinaryOperations.tt. Do not modify directly

using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Microsoft.Data.Analysis
{
    public partial class PrimitiveDataFrameColumn<T> : DataFrameColumn
        where T : unmanaged
    {
        internal enum ColumnOp
        {
            Add,
            Subtract,
            Multiply,
            Divide,
            Modulo,
            And,
            Or,
            Xor,
            LeftShift,
            RightShift,
            ElementwiseEquals,
            ElementwiseNotEquals,
            ElementwiseGreaterThanOrEqual,
            ElementwiseGreaterThan,
            ElementwiseLessThanOrEqual,
            ElementwiseLessThan,
        }
        /// <inheritdoc/>
        public override DataFrameColumn Add(DataFrameColumn column, bool inPlace = false)
        {
            return HandleOperation(column, inPlace, ColumnOp.Add);
        }

        /// <inheritdoc/>
        public override DataFrameColumn Add<U>(U value, bool inPlace = false)
        {
            DataFrameColumn column = value as DataFrameColumn;
            if (column != null)
            {
                HandleOperation(column, inPlace, ColumnOp.Add);
            }
            return HandleOperationImplementation(value, inPlace, ColumnOp.Add);
        }

        public override DataFrameColumn Subtract(DataFrameColumn column, bool inPlace = false)
        {
            return HandleOperation(column, inPlace, ColumnOp.Add);
        }

        /// <inheritdoc/>
        public override DataFrameColumn Subtract<U>(U value, bool inPlace = false)
        {
            DataFrameColumn column = value as DataFrameColumn;
            if (column != null)
            {
                HandleOperation(column, inPlace, ColumnOp.Subtract);
            }
            return HandleOperationImplementation(value, inPlace, ColumnOp.Subtract);
        }

        public override DataFrameColumn Multiply(DataFrameColumn column, bool inPlace = false)
        {
            return HandleOperation(column, inPlace, ColumnOp.Multiply);
        }

        /// <inheritdoc/>
        public override DataFrameColumn Multiply<U>(U value, bool inPlace = false)
        {
            DataFrameColumn column = value as DataFrameColumn;
            if (column != null)
            {
                HandleOperation(column, inPlace, ColumnOp.Multiply);
            }
            return HandleOperationImplementation(value, inPlace, ColumnOp.Multiply);
        }

        public override DataFrameColumn Divide(DataFrameColumn column, bool inPlace = false)
        {
            return HandleOperation(column, inPlace, ColumnOp.Divide);
        }

        /// <inheritdoc/>
        public override DataFrameColumn Divide<U>(U value, bool inPlace = false)
        {
            DataFrameColumn column = value as DataFrameColumn;
            if (column != null)
            {
                HandleOperation(column, inPlace, ColumnOp.Divide);
            }
            return HandleOperationImplementation(value, inPlace, ColumnOp.Divide);
        }

        public override DataFrameColumn Modulo(DataFrameColumn column, bool inPlace = false)
        {
            return HandleOperation(column, inPlace, ColumnOp.Modulo);
        }

        /// <inheritdoc/>
        public override DataFrameColumn Modulo<U>(U value, bool inPlace = false)
        {
            DataFrameColumn column = value as DataFrameColumn;
            if (column != null)
            {
                HandleOperation(column, inPlace, ColumnOp.Modulo);
            }
            return HandleOperationImplementation(value, inPlace, ColumnOp.Modulo);
        }

        public override PrimitiveDataFrameColumn<bool> And(DataFrameColumn column, bool inPlace = false)
        {
            return HandleOperation(column, inPlace, ColumnOp.And) as PrimitiveDataFrameColumn<bool>;
        }

        /// <inheritdoc/>
        public override PrimitiveDataFrameColumn<bool> And(bool value, bool inPlace = false)
        {
            return HandleOperationImplementation(value, inPlace, ColumnOp.And) as PrimitiveDataFrameColumn<bool>;
        }

        public override PrimitiveDataFrameColumn<bool> Or(DataFrameColumn column, bool inPlace = false)
        {
            return HandleOperation(column, inPlace, ColumnOp.Or) as PrimitiveDataFrameColumn<bool>;
        }

        /// <inheritdoc/>
        public PrimitiveDataFrameColumn<bool> Or<U>(U value, bool inPlace = false)
        {
            DataFrameColumn column = value as DataFrameColumn;
            if (column != null)
            {
                HandleOperation(column, inPlace, ColumnOp.Or);
            }
            return HandleOperationImplementation(value, inPlace, ColumnOp.Or) as PrimitiveDataFrameColumn<bool>;
        }

        public override PrimitiveDataFrameColumn<bool> Xor(DataFrameColumn column, bool inPlace = false)
        {
            return HandleOperation(column, inPlace, ColumnOp.Xor) as PrimitiveDataFrameColumn<bool>;
        }

        /// <inheritdoc/>
        public PrimitiveDataFrameColumn<bool> Xor<U>(U value, bool inPlace = false)
        {
            DataFrameColumn column = value as DataFrameColumn;
            if (column != null)
            {
                HandleOperation(column, inPlace, ColumnOp.Xor);
            }
            return HandleOperationImplementation(value, inPlace, ColumnOp.Xor) as PrimitiveDataFrameColumn<bool>;
        }

        public DataFrameColumn LeftShift(DataFrameColumn column, bool inPlace = false)
        {
            return HandleOperation(column, inPlace, ColumnOp.LeftShift);
        }

        /// <inheritdoc/>
        public DataFrameColumn LeftShift<U>(U value, bool inPlace = false)
        {
            DataFrameColumn column = value as DataFrameColumn;
            if (column != null)
            {
                HandleOperation(column, inPlace, ColumnOp.LeftShift);
            }
            return HandleOperationImplementation(value, inPlace, ColumnOp.LeftShift);
        }

        public DataFrameColumn RightShift(DataFrameColumn column, bool inPlace = false)
        {
            return HandleOperation(column, inPlace, ColumnOp.RightShift);
        }

        /// <inheritdoc/>
        public DataFrameColumn RightShift<U>(U value, bool inPlace = false)
        {
            DataFrameColumn column = value as DataFrameColumn;
            if (column != null)
            {
                HandleOperation(column, inPlace, ColumnOp.RightShift);
            }
            return HandleOperationImplementation(value, inPlace, ColumnOp.RightShift);
        }

        public PrimitiveDataFrameColumn<bool> ElementwiseEquals(DataFrameColumn column, bool inPlace = false)
        {
            return HandleOperation(column, inPlace, ColumnOp.ElementwiseEquals) as PrimitiveDataFrameColumn<bool>;
        }

        /// <inheritdoc/>
        public PrimitiveDataFrameColumn<bool> ElementwiseEquals<U>(U value, bool inPlace = false)
        {
            DataFrameColumn column = value as DataFrameColumn;
            if (column != null)
            {
                HandleOperation(column, inPlace, ColumnOp.ElementwiseEquals);
            }
            return HandleOperationImplementation(value, inPlace, ColumnOp.ElementwiseEquals) as PrimitiveDataFrameColumn<bool>;
        }

        public override PrimitiveDataFrameColumn<bool> ElementwiseNotEquals(DataFrameColumn column)
        {
            return HandleOperation(column, false, ColumnOp.ElementwiseNotEquals) as PrimitiveDataFrameColumn<bool>;
        }

        /// <inheritdoc/>
        public override PrimitiveDataFrameColumn<bool> ElementwiseNotEquals<U>(U value)
        {
            DataFrameColumn column = value as DataFrameColumn;
            if (column != null)
            {
                HandleOperation(column, false, ColumnOp.ElementwiseNotEquals);
            }
            return HandleOperationImplementation(value, false, ColumnOp.ElementwiseNotEquals) as PrimitiveDataFrameColumn<bool>;
        }

        public override PrimitiveDataFrameColumn<bool> ElementwiseGreaterThanOrEqual(DataFrameColumn column)
        {
            return HandleOperation(column, false, ColumnOp.ElementwiseGreaterThanOrEqual) as PrimitiveDataFrameColumn<bool>;
        }

        /// <inheritdoc/>
        public override PrimitiveDataFrameColumn<bool> ElementwiseGreaterThanOrEqual<U>(U value)
        {
            DataFrameColumn column = value as DataFrameColumn;
            if (column != null)
            {
                HandleOperation(column, false, ColumnOp.ElementwiseGreaterThanOrEqual);
            }
            return HandleOperationImplementation(value, false, ColumnOp.ElementwiseGreaterThanOrEqual) as PrimitiveDataFrameColumn<bool>;
        }

        public override PrimitiveDataFrameColumn<bool> ElementwiseGreaterThan(DataFrameColumn column)
        {
            return HandleOperation(column, false, ColumnOp.ElementwiseGreaterThan) as PrimitiveDataFrameColumn<bool>;
        }

        /// <inheritdoc/>
        public override PrimitiveDataFrameColumn<bool> ElementwiseGreaterThan<U>(U value)
        {
            DataFrameColumn column = value as DataFrameColumn;
            if (column != null)
            {
                HandleOperation(column, false, ColumnOp.ElementwiseGreaterThan);
            }
            return HandleOperationImplementation(value, false, ColumnOp.ElementwiseGreaterThan) as PrimitiveDataFrameColumn<bool>;
        }

        public override PrimitiveDataFrameColumn<bool> ElementwiseLessThanOrEqual(DataFrameColumn column)
        {
            return HandleOperation(column, false, ColumnOp.ElementwiseLessThanOrEqual) as PrimitiveDataFrameColumn<bool>;
        }

        /// <inheritdoc/>
        public override PrimitiveDataFrameColumn<bool> ElementwiseLessThanOrEqual<U>(U value)
        {
            DataFrameColumn column = value as DataFrameColumn;
            if (column != null)
            {
                HandleOperation(column, false, ColumnOp.ElementwiseLessThanOrEqual);
            }
            return HandleOperationImplementation(value, false, ColumnOp.ElementwiseLessThanOrEqual) as PrimitiveDataFrameColumn<bool>;
        }

        public override PrimitiveDataFrameColumn<bool> ElementwiseLessThan(DataFrameColumn column)
        {
            return HandleOperation(column, false, ColumnOp.ElementwiseLessThan) as PrimitiveDataFrameColumn<bool>;
        }

        /// <inheritdoc/>
        public override PrimitiveDataFrameColumn<bool> ElementwiseLessThan<U>(U value)
        {
            DataFrameColumn column = value as DataFrameColumn;
            if (column != null)
            {
                HandleOperation(column, false, ColumnOp.ElementwiseLessThan);
            }
            return HandleOperationImplementation(value, false, ColumnOp.ElementwiseLessThan) as PrimitiveDataFrameColumn<bool>;
        }

        internal DataFrameColumn HandleOperation(DataFrameColumn column, bool inPlace, ColumnOp op)
        {
            switch (column)
            {
                case PrimitiveDataFrameColumn<bool> boolColumn:
                    return HandleOperationImplementation(boolColumn, inPlace, op);
                case PrimitiveDataFrameColumn<byte> byteColumn:
                    return HandleOperationImplementation(byteColumn, inPlace, op);
                case PrimitiveDataFrameColumn<char> charColumn:
                    return HandleOperationImplementation(charColumn, inPlace, op);
                case PrimitiveDataFrameColumn<decimal> decimalColumn:
                    return HandleOperationImplementation(decimalColumn, inPlace, op);
                case PrimitiveDataFrameColumn<double> doubleColumn:
                    return HandleOperationImplementation(doubleColumn, inPlace, op);
                case PrimitiveDataFrameColumn<float> floatColumn:
                    return HandleOperationImplementation(floatColumn, inPlace, op);
                case PrimitiveDataFrameColumn<int> intColumn:
                    return HandleOperationImplementation(intColumn, inPlace, op);
                case PrimitiveDataFrameColumn<long> longColumn:
                    return HandleOperationImplementation(longColumn, inPlace, op);
                case PrimitiveDataFrameColumn<sbyte> sbyteColumn:
                    return HandleOperationImplementation(sbyteColumn, inPlace, op);
                case PrimitiveDataFrameColumn<short> shortColumn:
                    return HandleOperationImplementation(shortColumn, inPlace, op);
                case PrimitiveDataFrameColumn<uint> uintColumn:
                    return HandleOperationImplementation(uintColumn, inPlace, op);
                case PrimitiveDataFrameColumn<ulong> ulongColumn:
                    return HandleOperationImplementation(ulongColumn, inPlace, op);
                case PrimitiveDataFrameColumn<ushort> ushortColumn:
                    return HandleOperationImplementation(ushortColumn, inPlace, op);
                case PrimitiveDataFrameColumn<DateTime> DateTimeColumn:
                    return HandleOperationImplementation(DateTimeColumn, inPlace, op);

                default:
                    throw new NotSupportedException();
            }
        }

        private DataFrameColumn HandleOperationImplementation<U>(PrimitiveDataFrameColumn<U> column, bool inPlace, ColumnOp op)
            where U : unmanaged
        {
            if (typeof(U) == typeof(T))
            {
                // No conversions
                PrimitiveDataFrameColumn<U> left = this as PrimitiveDataFrameColumn<U>;
                left = inPlace ? left : left.Clone();
                PrimitiveDataFrameColumn<U> right = column;

                switch (op)
                {
                    case ColumnOp.Add:
                        left._columnContainer.Add(right._columnContainer);
                        return left;
                    case ColumnOp.Subtract:
                        left._columnContainer.Subtract(right._columnContainer);
                        return left;
                    case ColumnOp.Multiply:
                        left._columnContainer.Multiply(right._columnContainer);
                        return left;
                    case ColumnOp.Divide:
                        left._columnContainer.Divide(right._columnContainer);
                        return left;
                    case ColumnOp.Modulo:
                        left._columnContainer.Modulo(right._columnContainer);
                        return left;
                    case ColumnOp.And:
                        left._columnContainer.And(right._columnContainer);
                        return left;
                    case ColumnOp.Or:
                        left._columnContainer.Or(right._columnContainer);
                        return left;
                    case ColumnOp.Xor:
                        left._columnContainer.Xor(right._columnContainer);
                        return left;
                    case ColumnOp.ElementwiseEquals:
                        var ret = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseEquals(right._columnContainer, ret._columnContainer);
                        return ret;
                    case ColumnOp.ElementwiseNotEquals:
                        var ret1 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right._columnContainer, ret1._columnContainer);
                        return ret1;
                    case ColumnOp.ElementwiseGreaterThanOrEqual:
                        var ret2 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right._columnContainer, ret2._columnContainer);
                        return ret2;
                    case ColumnOp.ElementwiseGreaterThan:
                        var ret3 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right._columnContainer, ret3._columnContainer);
                        return ret3;
                    case ColumnOp.ElementwiseLessThanOrEqual:
                        var ret4 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right._columnContainer, ret4._columnContainer);
                        return ret4;
                    case ColumnOp.ElementwiseLessThan:
                        var ret5 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right._columnContainer, ret5._columnContainer);
                        return ret5;
                    default:
                        throw new NotSupportedException();
                }

            }
            else if (inPlace)
            {
                throw new ArgumentException(string.Format(Strings.MismatchedColumnValueType, typeof(T)), nameof(column));
            }
            else if (typeof(U) == typeof(bool) || typeof(T) == typeof(bool) || typeof(T) == typeof(DateTime) || typeof(U) == typeof(DateTime))
            {
                throw new NotSupportedException();
            }
            else if (typeof(U) == typeof(decimal))
            {
                PrimitiveDataFrameColumn<decimal> left = CloneTruncating<decimal>();
                PrimitiveDataFrameColumn<decimal> right = column as PrimitiveDataFrameColumn<decimal>;
                switch (op)
                {
                    case ColumnOp.Add:
                        left._columnContainer.Add(right._columnContainer);
                        return left;
                    case ColumnOp.Subtract:
                        left._columnContainer.Subtract(right._columnContainer);
                        return left;
                    case ColumnOp.Multiply:
                        left._columnContainer.Multiply(right._columnContainer);
                        return left;
                    case ColumnOp.Divide:
                        left._columnContainer.Divide(right._columnContainer);
                        return left;
                    case ColumnOp.Modulo:
                        left._columnContainer.Modulo(right._columnContainer);
                        return left;
                    case ColumnOp.And:
                        left._columnContainer.And(right._columnContainer);
                        return left;
                    case ColumnOp.Or:
                        left._columnContainer.Or(right._columnContainer);
                        return left;
                    case ColumnOp.Xor:
                        left._columnContainer.Xor(right._columnContainer);
                        return left;
                    case ColumnOp.ElementwiseEquals:
                        var ret = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseEquals(right._columnContainer, ret._columnContainer);
                        return ret;
                    case ColumnOp.ElementwiseNotEquals:
                        var ret1 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right._columnContainer, ret1._columnContainer);
                        return ret1;
                    case ColumnOp.ElementwiseGreaterThanOrEqual:
                        var ret2 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right._columnContainer, ret2._columnContainer);
                        return ret2;
                    case ColumnOp.ElementwiseGreaterThan:
                        var ret3 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right._columnContainer, ret3._columnContainer);
                        return ret3;
                    case ColumnOp.ElementwiseLessThanOrEqual:
                        var ret4 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right._columnContainer, ret4._columnContainer);
                        return ret4;
                    case ColumnOp.ElementwiseLessThan:
                        var ret5 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right._columnContainer, ret5._columnContainer);
                        return ret5;
                    default:
                        throw new NotSupportedException();
                }
            }
            else
            {
                PrimitiveDataFrameColumn<double> left = CloneTruncating<double>();
                PrimitiveDataFrameColumn<double> right = column.CloneTruncating<double>();
                switch (op)
                {
                    case ColumnOp.Add:
                        left._columnContainer.Add(right._columnContainer);
                        return left;
                    case ColumnOp.Subtract:
                        left._columnContainer.Subtract(right._columnContainer);
                        return left;
                    case ColumnOp.Multiply:
                        left._columnContainer.Multiply(right._columnContainer);
                        return left;
                    case ColumnOp.Divide:
                        left._columnContainer.Divide(right._columnContainer);
                        return left;
                    case ColumnOp.Modulo:
                        left._columnContainer.Modulo(right._columnContainer);
                        return left;
                    case ColumnOp.And:
                        left._columnContainer.And(right._columnContainer);
                        return left;
                    case ColumnOp.Or:
                        left._columnContainer.Or(right._columnContainer);
                        return left;
                    case ColumnOp.Xor:
                        left._columnContainer.Xor(right._columnContainer);
                        return left;
                    case ColumnOp.ElementwiseEquals:
                        var ret = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseEquals(right._columnContainer, ret._columnContainer);
                        return ret;
                    case ColumnOp.ElementwiseNotEquals:
                        var ret1 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right._columnContainer, ret1._columnContainer);
                        return ret1;
                    case ColumnOp.ElementwiseGreaterThanOrEqual:
                        var ret2 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right._columnContainer, ret2._columnContainer);
                        return ret2;
                    case ColumnOp.ElementwiseGreaterThan:
                        var ret3 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right._columnContainer, ret3._columnContainer);
                        return ret3;
                    case ColumnOp.ElementwiseLessThanOrEqual:
                        var ret4 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right._columnContainer, ret4._columnContainer);
                        return ret4;
                    case ColumnOp.ElementwiseLessThan:
                        var ret5 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right._columnContainer, ret5._columnContainer);
                        return ret5;
                    default:
                        throw new NotSupportedException();
                }
            }
        }

        internal DataFrameColumn HandleOperationImplementation<U>(U value, bool inPlace, ColumnOp op)
        {
            if (typeof(U) == typeof(T))
            {
                // No conversions
                PrimitiveDataFrameColumn<T> left = this as PrimitiveDataFrameColumn<T>;
                left = inPlace ? left : left.Clone();
                T right = Unsafe.As<U, T>(ref value);

                switch (op)
                {
                    case ColumnOp.Add:
                        left._columnContainer.Add(right);
                        return left;
                    case ColumnOp.Subtract:
                        left._columnContainer.Subtract(right);
                        return left;
                    case ColumnOp.Multiply:
                        left._columnContainer.Multiply(right);
                        return left;
                    case ColumnOp.Divide:
                        left._columnContainer.Divide(right);
                        return left;
                    case ColumnOp.Modulo:
                        left._columnContainer.Modulo(right);
                        return left;
                    case ColumnOp.And:
                        left._columnContainer.And(right);
                        return left;
                    case ColumnOp.Or:
                        left._columnContainer.Or(right);
                        return left;
                    case ColumnOp.Xor:
                        left._columnContainer.Xor(right);
                        return left;
                    case ColumnOp.ElementwiseEquals:
                        var ret = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseEquals(right, ret._columnContainer);
                        return ret;
                    case ColumnOp.ElementwiseNotEquals:
                        var ret1 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right, ret1._columnContainer);
                        return ret1;
                    case ColumnOp.ElementwiseGreaterThanOrEqual:
                        var ret2 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right, ret2._columnContainer);
                        return ret2;
                    case ColumnOp.ElementwiseGreaterThan:
                        var ret3 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right, ret3._columnContainer);
                        return ret3;
                    case ColumnOp.ElementwiseLessThanOrEqual:
                        var ret4 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right, ret4._columnContainer);
                        return ret4;
                    case ColumnOp.ElementwiseLessThan:
                        var ret5 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right, ret5._columnContainer);
                        return ret5;
                    default:
                        throw new NotSupportedException();
                }

            }
            else if (inPlace)
            {
                throw new ArgumentException(string.Format(Strings.MismatchedColumnValueType, typeof(T)), nameof(value));
            }
            else if (typeof(U) == typeof(bool) || typeof(T) == typeof(bool) || typeof(T) == typeof(DateTime) || typeof(U) == typeof(DateTime))
            {
                throw new NotSupportedException();
            }
            else if (typeof(U) == typeof(decimal))
            {
                PrimitiveDataFrameColumn<decimal> left = CloneTruncating<decimal>();
                decimal right = GetDecimalValue(value);
                switch (op)
                {
                    case ColumnOp.Add:
                        left._columnContainer.Add(right);
                        return left;
                    case ColumnOp.Subtract:
                        left._columnContainer.Subtract(right);
                        return left;
                    case ColumnOp.Multiply:
                        left._columnContainer.Multiply(right);
                        return left;
                    case ColumnOp.Divide:
                        left._columnContainer.Divide(right);
                        return left;
                    case ColumnOp.Modulo:
                        left._columnContainer.Modulo(right);
                        return left;
                    case ColumnOp.And:
                        left._columnContainer.And(right);
                        return left;
                    case ColumnOp.Or:
                        left._columnContainer.Or(right);
                        return left;
                    case ColumnOp.Xor:
                        left._columnContainer.Xor(right);
                        return left;
                    case ColumnOp.ElementwiseEquals:
                        var ret = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseEquals(right, ret._columnContainer);
                        return ret;
                    case ColumnOp.ElementwiseNotEquals:
                        var ret1 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right, ret1._columnContainer);
                        return ret1;
                    case ColumnOp.ElementwiseGreaterThanOrEqual:
                        var ret2 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right, ret2._columnContainer);
                        return ret2;
                    case ColumnOp.ElementwiseGreaterThan:
                        var ret3 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right, ret3._columnContainer);
                        return ret3;
                    case ColumnOp.ElementwiseLessThanOrEqual:
                        var ret4 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right, ret4._columnContainer);
                        return ret4;
                    case ColumnOp.ElementwiseLessThan:
                        var ret5 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right, ret5._columnContainer);
                        return ret5;
                    default:
                        throw new NotSupportedException();
                }
            }
            else
            {
                PrimitiveDataFrameColumn<double> left = CloneTruncating<double>();
                double right = GetDoubleValue(value);
                switch (op)
                {
                    case ColumnOp.Add:
                        left._columnContainer.Add(right);
                        return left;
                    case ColumnOp.Subtract:
                        left._columnContainer.Subtract(right);
                        return left;
                    case ColumnOp.Multiply:
                        left._columnContainer.Multiply(right);
                        return left;
                    case ColumnOp.Divide:
                        left._columnContainer.Divide(right);
                        return left;
                    case ColumnOp.Modulo:
                        left._columnContainer.Modulo(right);
                        return left;
                    case ColumnOp.And:
                        left._columnContainer.And(right);
                        return left;
                    case ColumnOp.Or:
                        left._columnContainer.Or(right);
                        return left;
                    case ColumnOp.Xor:
                        left._columnContainer.Xor(right);
                        return left;
                    case ColumnOp.ElementwiseEquals:
                        var ret = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseEquals(right, ret._columnContainer);
                        return ret;
                    case ColumnOp.ElementwiseNotEquals:
                        var ret1 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right, ret1._columnContainer);
                        return ret1;
                    case ColumnOp.ElementwiseGreaterThanOrEqual:
                        var ret2 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right, ret2._columnContainer);
                        return ret2;
                    case ColumnOp.ElementwiseGreaterThan:
                        var ret3 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right, ret3._columnContainer);
                        return ret3;
                    case ColumnOp.ElementwiseLessThanOrEqual:
                        var ret4 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right, ret4._columnContainer);
                        return ret4;
                    case ColumnOp.ElementwiseLessThan:
                        var ret5 = CloneAsBooleanColumn();
                        left._columnContainer.ElementwiseNotEquals(right, ret5._columnContainer);
                        return ret5;
                    default:
                        throw new NotSupportedException();
                }
            }
        }

        private static decimal GetDecimalValue<U>(U value)
        {
            decimal returnValue;

            switch (value)
            {
                case byte byteValue:
                    returnValue = (decimal)byteValue;
                    break;
                case Char charValue:
                    returnValue = (decimal)charValue;
                    break;
                case double doubleValue:
                    returnValue = (decimal)doubleValue;
                    break;
                case decimal decimalValue:
                    returnValue = (decimal)decimalValue;
                    break;
                case float floatValue:
                    returnValue = (decimal)floatValue;
                    break;
                case int intValue:
                    returnValue = (decimal)intValue;
                    break;
                case long longValue:
                    returnValue = (decimal)longValue;
                    break;
                case short shortValue:
                    returnValue = (decimal)shortValue;
                    break;
                case sbyte sbyteValue:
                    returnValue = (decimal)sbyteValue;
                    break;
                case uint uintValue:
                    returnValue = (decimal)uintValue;
                    break;
                case ulong ulongValue:
                    returnValue = (decimal)ulongValue;
                    break;
                case ushort ushortValue:
                    returnValue = (decimal)ushortValue;
                    break;
                default:
                    throw new NotSupportedException();
            }

            return returnValue;
        }

        private static double GetDoubleValue<U>(U value)
        {
            double returnValue;

            switch (value)
            {
                case byte byteValue:
                    returnValue = (double)byteValue;
                    break;
                case Char charValue:
                    returnValue = (double)charValue;
                    break;
                case decimal decimalValue:
                    returnValue = (double)decimalValue;
                    break;
                case double doubleValue:
                    returnValue = (double)doubleValue;
                    break;
                case float floatValue:
                    returnValue = (double)floatValue;
                    break;
                case int intValue:
                    returnValue = (double)intValue;
                    break;
                case long longValue:
                    returnValue = (double)longValue;
                    break;
                case short shortValue:
                    returnValue = (double)shortValue;
                    break;
                case sbyte sbyteValue:
                    returnValue = (double)sbyteValue;
                    break;
                case uint uintValue:
                    returnValue = (double)uintValue;
                    break;
                case ulong ulongValue:
                    returnValue = (double)ulongValue;
                    break;
                case ushort ushortValue:
                    returnValue = (double)ushortValue;
                    break;
                default:
                    throw new NotSupportedException();
            }

            return returnValue;
        }
    }
}
