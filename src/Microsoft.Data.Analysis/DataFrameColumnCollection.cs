﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Microsoft.Data.Analysis
{
    /// <summary>
    /// A DataFrameColumnCollection is just a container that holds a number of DataFrameColumn instances. 
    /// </summary>
    public class DataFrameColumnCollection : Collection<DataFrameColumn>
    {
        private readonly Action ColumnsChanged;

        private readonly List<string> _columnNames = new List<string>();

        private readonly Dictionary<string, int> _columnNameToIndexDictionary = new Dictionary<string, int>(StringComparer.Ordinal);

        internal long RowCount { get; set; }

        internal DataFrameColumnCollection(IEnumerable<DataFrameColumn> columns, Action columnsChanged) : base()
        {
            columns = columns ?? throw new ArgumentNullException(nameof(columns));
            ColumnsChanged = columnsChanged;
            foreach (DataFrameColumn column in columns)
            {
                Add(column);
            }
        }

        internal IReadOnlyList<string> GetColumnNames()
        {
            var ret = new List<string>(Count);
            for (int i = 0; i < Count; i++)
            {
                ret.Add(this[i].Name);
            }
            return ret;
        }

        public void RenameColumn(string currentName, string newName)
        {
            var column = this[currentName];
            column.SetName(newName);
        }

        [Obsolete]
        public void SetColumnName(DataFrameColumn column, string newName)
        {
            column.SetName(newName);
        }

        //Updates column's metadata (is used as a callback from Column class)
        internal void UpdateColumnNameMetadata(DataFrameColumn column, string newName)
        {
            string currentName = column.Name;
            int currentIndex = _columnNameToIndexDictionary[currentName];
            _columnNames[currentIndex] = newName;
            _columnNameToIndexDictionary.Remove(currentName);
            _columnNameToIndexDictionary.Add(newName, currentIndex);
            ColumnsChanged?.Invoke();
        }

        public void Insert<T>(int columnIndex, IEnumerable<T> column, string columnName)
            where T : unmanaged
        {
            DataFrameColumn newColumn = new PrimitiveDataFrameColumn<T>(columnName, column);
            Insert(columnIndex, newColumn); // calls InsertItem internally
        }

        protected override void InsertItem(int columnIndex, DataFrameColumn column)
        {
            column = column ?? throw new ArgumentNullException(nameof(column));

            if (Count == 0)
            {
                //change RowCount on inserting first row to dataframe
                RowCount = column.Length;
            }
            else if (column.Length != RowCount)
            {
                //check all columns in the dataframe have the same lenght (amount of rows)
                throw new ArgumentException(Strings.MismatchedColumnLengths, nameof(column));
            }

            if (_columnNameToIndexDictionary.ContainsKey(column.Name))
            {
                throw new ArgumentException(string.Format(Strings.DuplicateColumnName, column.Name), nameof(column));
            }

            column.AddOwner(this);

            _columnNames.Insert(columnIndex, column.Name);
            _columnNameToIndexDictionary[column.Name] = columnIndex;
            for (int i = columnIndex + 1; i < Count; i++)
            {
                _columnNameToIndexDictionary[_columnNames[i]]++;
            }
            base.InsertItem(columnIndex, column);
            ColumnsChanged?.Invoke();
        }

        protected override void SetItem(int columnIndex, DataFrameColumn column)
        {
            column = column ?? throw new ArgumentNullException(nameof(column));
            if (RowCount > 0 && column.Length != RowCount)
            {
                throw new ArgumentException(Strings.MismatchedColumnLengths, nameof(column));
            }
            bool existingColumn = _columnNameToIndexDictionary.TryGetValue(column.Name, out int existingColumnIndex);
            if (existingColumn && existingColumnIndex != columnIndex)
            {
                throw new ArgumentException(string.Format(Strings.DuplicateColumnName, column.Name), nameof(column));
            }

            _columnNameToIndexDictionary.Remove(_columnNames[columnIndex]);
            _columnNames[columnIndex] = column.Name;
            _columnNameToIndexDictionary[column.Name] = columnIndex;

            this[columnIndex].RemoveOwner(this);
            base.SetItem(columnIndex, column);

            ColumnsChanged?.Invoke();
        }

        protected override void RemoveItem(int columnIndex)
        {
            _columnNameToIndexDictionary.Remove(_columnNames[columnIndex]);
            for (int i = columnIndex + 1; i < Count; i++)
            {
                _columnNameToIndexDictionary[_columnNames[i]]--;
            }
            _columnNames.RemoveAt(columnIndex);

            this[columnIndex].RemoveOwner(this);
            base.RemoveItem(columnIndex);

            //Reset RowCount if the last column was removed and dataframe is empty
            if (Count == 0)
                RowCount = 0;

            ColumnsChanged?.Invoke();
        }

        public void Remove(string columnName)
        {
            int columnIndex = IndexOf(columnName);
            if (columnIndex != -1)
            {
                RemoveAt(columnIndex); // calls RemoveItem internally
            }
        }

        /// <summary>
        /// Searches for a <see cref="DataFrameColumn"/> with the specified <paramref name="columnName"/> and returns the zero-based index of the first occurrence if found. Returns -1 otherwise
        /// </summary>
        /// <param name="columnName"></param>
        public int IndexOf(string columnName)
        {
            if (columnName != null && _columnNameToIndexDictionary.TryGetValue(columnName, out int columnIndex))
            {
                return columnIndex;
            }
            return -1;
        }

        protected override void ClearItems()
        {
            base.ClearItems();
            ColumnsChanged?.Invoke();
            _columnNames.Clear();
            _columnNameToIndexDictionary.Clear();

            //reset RowCount as DataFrame is now empty
            RowCount = 0;
        }

        /// <summary>
        /// An indexer based on <see cref="DataFrameColumn.Name"/>
        /// </summary>
        /// <param name="columnName">The name of a <see cref="DataFrameColumn"/></param>
        /// <returns>A <see cref="DataFrameColumn"/> if it exists.</returns>
        /// <exception cref="ArgumentException">Throws if <paramref name="columnName"/> is not present in this <see cref="DataFrame"/></exception>
        public DataFrameColumn this[string columnName]
        {
            get
            {
                int columnIndex = IndexOf(columnName);
                if (columnIndex == -1)
                {
                    throw new ArgumentException(String.Format(Strings.InvalidColumnName, columnName), nameof(columnName));
                }
                return this[columnIndex];
            }
            set
            {
                int columnIndex = IndexOf(columnName);
                DataFrameColumn newColumn = value;
                newColumn.SetName(columnName);
                if (columnIndex == -1)
                {
                    Insert(Count, newColumn);
                }
                else
                {
                    this[columnIndex] = newColumn;
                }
            }
        }

        /// <summary>
        /// Gets the <see cref="PrimitiveDataFrameColumn{T}"/> with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the column</param>
        /// <returns><see cref="PrimitiveDataFrameColumn{T}"/>.</returns>
        /// <exception cref="ArgumentException">A column named <paramref name="name"/> cannot be found, or if the column's type doesn't match.</exception>
        public PrimitiveDataFrameColumn<T> GetPrimitiveColumn<T>(string name)
            where T : unmanaged
        {
            DataFrameColumn column = this[name];
            if (column is PrimitiveDataFrameColumn<T> ret)
            {
                return ret;
            }

            throw new ArgumentException(string.Format(Strings.BadColumnCast, column.DataType, typeof(T)), nameof(T));
        }

        /// <summary>
        /// Gets the <see cref="ArrowStringDataFrameColumn"/> with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the column</param>
        /// <returns><see cref="ArrowStringDataFrameColumn"/>.</returns>
        /// <exception cref="ArgumentException">A column named <paramref name="name"/> cannot be found, or if the column's type doesn't match.</exception>
        public ArrowStringDataFrameColumn GetArrowStringColumn(string name)
        {
            DataFrameColumn column = this[name];
            if (column is ArrowStringDataFrameColumn ret)
            {
                return ret;
            }

            throw new ArgumentException(string.Format(Strings.BadColumnCast, column.DataType, typeof(string)));
        }

        /// <summary>
        /// Gets the <see cref="StringDataFrameColumn"/> with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the column</param>
        /// <returns><see cref="StringDataFrameColumn"/>.</returns>
        /// <exception cref="ArgumentException">A column named <paramref name="name"/> cannot be found, or if the column's type doesn't match.</exception>
        public StringDataFrameColumn GetStringColumn(string name)
        {
            DataFrameColumn column = this[name];
            if (column is StringDataFrameColumn ret)
            {
                return ret;
            }

            throw new ArgumentException(string.Format(Strings.BadColumnCast, column.DataType, typeof(string)));
        }

        /// <summary>
        /// Gets the <see cref="PrimitiveDataFrameColumn{T}"/> with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the column</param>
        /// <returns><see cref="PrimitiveDataFrameColumn{T}"/>.</returns>
        /// <exception cref="ArgumentException">A column named <paramref name="name"/> cannot be found, or if the column's type doesn't match.</exception>
        public PrimitiveDataFrameColumn<bool> GetBooleanColumn(string name)
        {
            DataFrameColumn column = this[name];
            if (column is PrimitiveDataFrameColumn<bool> ret)
            {
                return ret;
            }

            throw new ArgumentException(string.Format(Strings.BadColumnCast, column.DataType, typeof(Boolean)));
        }

        /// <summary>
        /// Gets the <see cref="PrimitiveDataFrameColumn{T}"/> with the specified <paramref name="name"/> and attempts to return it as an <see cref="PrimitiveDataFrameColumn{T}"/>. If <see cref="DataFrameColumn.DataType"/> is not of type <see cref="Byte"/>, an exception is thrown.
        /// </summary>
        /// <param name="name">The name of the column</param>
        /// <returns><see cref="PrimitiveDataFrameColumn{T}"/>.</returns>
        /// <exception cref="ArgumentException">A column named <paramref name="name"/> cannot be found, or if the column's type doesn't match.</exception>
        public PrimitiveDataFrameColumn<byte> GetByteColumn(string name)
        {
            DataFrameColumn column = this[name];
            if (column is PrimitiveDataFrameColumn<byte> ret)
            {
                return ret;
            }

            throw new ArgumentException(string.Format(Strings.BadColumnCast, column.DataType, typeof(Byte)));
        }

        /// <summary>
        /// Gets the <see cref="PrimitiveDataFrameColumn{T}"/> with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the column</param>
        /// <returns><see cref="PrimitiveDataFrameColumn{T}"/>.</returns>
        /// <exception cref="ArgumentException">A column named <paramref name="name"/> cannot be found, or if the column's type doesn't match.</exception>
        public PrimitiveDataFrameColumn<char> GetCharColumn(string name)
        {
            DataFrameColumn column = this[name];
            if (column is PrimitiveDataFrameColumn<char> ret)
            {
                return ret;
            }

            throw new ArgumentException(string.Format(Strings.BadColumnCast, column.DataType, typeof(Char)));
        }

        /// <summary>
        /// Gets the <see cref="PrimitiveDataFrameColumn{T}"/> with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the column</param>
        /// <returns><see cref="PrimitiveDataFrameColumn{T}"/>.</returns>
        /// <exception cref="ArgumentException">A column named <paramref name="name"/> cannot be found, or if the column's type doesn't match.</exception>
        public PrimitiveDataFrameColumn<double> GetDoubleColumn(string name)
        {
            DataFrameColumn column = this[name];
            if (column is PrimitiveDataFrameColumn<double> ret)
            {
                return ret;
            }

            throw new ArgumentException(string.Format(Strings.BadColumnCast, column.DataType, typeof(Double)));
        }

        /// <summary>
        /// Gets the <see cref="PrimitiveDataFrameColumn{T}"/> with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the column</param>
        /// <returns><see cref="PrimitiveDataFrameColumn{T}"/>.</returns>
        /// <exception cref="ArgumentException">A column named <paramref name="name"/> cannot be found, or if the column's type doesn't match.</exception>
        public PrimitiveDataFrameColumn<decimal> GetDecimalColumn(string name)
        {
            DataFrameColumn column = this[name];
            if (column is PrimitiveDataFrameColumn<decimal> ret)
            {
                return ret;
            }

            throw new ArgumentException(string.Format(Strings.BadColumnCast, column.DataType, typeof(Decimal)));
        }

        /// <summary>
        /// Gets the <see cref="PrimitiveDataFrameColumn{T}"/> with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the column</param>
        /// <returns><see cref="PrimitiveDataFrameColumn{T}"/>.</returns>
        /// <exception cref="ArgumentException">A column named <paramref name="name"/> cannot be found, or if the column's type doesn't match.</exception>
        public PrimitiveDataFrameColumn<float> GetSingleColumn(string name)
        {
            DataFrameColumn column = this[name];
            if (column is PrimitiveDataFrameColumn<float> ret)
            {
                return ret;
            }

            throw new ArgumentException(string.Format(Strings.BadColumnCast, column.DataType, typeof(Single)));
        }

        /// <summary>
        /// Gets the <see cref="PrimitiveDataFrameColumn{T}"/> with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the column</param>
        /// <returns><see cref="PrimitiveDataFrameColumn{T}"/>.</returns>
        /// <exception cref="ArgumentException">A column named <paramref name="name"/> cannot be found, or if the column's type doesn't match.</exception>
        public PrimitiveDataFrameColumn<int> GetInt32Column(string name)
        {
            DataFrameColumn column = this[name];
            if (column is PrimitiveDataFrameColumn<int> ret)
            {
                return ret;
            }

            throw new ArgumentException(string.Format(Strings.BadColumnCast, column.DataType, typeof(Int32)));
        }

        /// <summary>
        /// Gets the <see cref="PrimitiveDataFrameColumn{T}"/> with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the column</param>
        /// <returns><see cref="PrimitiveDataFrameColumn{T}"/>.</returns>
        /// <exception cref="ArgumentException">A column named <paramref name="name"/> cannot be found, or if the column's type doesn't match.</exception>
        public PrimitiveDataFrameColumn<long> GetInt64Column(string name)
        {
            DataFrameColumn column = this[name];
            if (column is PrimitiveDataFrameColumn<long> ret)
            {
                return ret;
            }

            throw new ArgumentException(string.Format(Strings.BadColumnCast, column.DataType, typeof(Int64)));
        }

        /// <summary>
        /// Gets the <see cref="PrimitiveDataFrameColumn{T}"/> with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the column</param>
        /// <returns><see cref="PrimitiveDataFrameColumn{T}"/>.</returns>
        /// <exception cref="ArgumentException">A column named <paramref name="name"/> cannot be found, or if the column's type doesn't match.</exception>
        public PrimitiveDataFrameColumn<sbyte> GetSByteColumn(string name)
        {
            DataFrameColumn column = this[name];
            if (column is PrimitiveDataFrameColumn<sbyte> ret)
            {
                return ret;
            }

            throw new ArgumentException(string.Format(Strings.BadColumnCast, column.DataType, typeof(SByte)));
        }

        /// <summary>
        /// Gets the <see cref="PrimitiveDataFrameColumn{T}"/> with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the column</param>
        /// <returns><see cref="PrimitiveDataFrameColumn{T}"/>.</returns>
        /// <exception cref="ArgumentException">A column named <paramref name="name"/> cannot be found, or if the column's type doesn't match.</exception>
        public PrimitiveDataFrameColumn<short> GetInt16Column(string name)
        {
            DataFrameColumn column = this[name];
            if (column is PrimitiveDataFrameColumn<short> ret)
            {
                return ret;
            }

            throw new ArgumentException(string.Format(Strings.BadColumnCast, column.DataType, typeof(Int16)));
        }

        /// <summary>
        /// Gets the <see cref="PrimitiveDataFrameColumn{T}"/> with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the column</param>
        /// <returns><see cref="PrimitiveDataFrameColumn{T}"/>.</returns>
        /// <exception cref="ArgumentException">A column named <paramref name="name"/> cannot be found, or if the column's type doesn't match.</exception>
        public PrimitiveDataFrameColumn<uint> GetUInt32Column(string name)
        {
            DataFrameColumn column = this[name];
            if (column is PrimitiveDataFrameColumn<uint> ret)
            {
                return ret;
            }

            throw new ArgumentException(string.Format(Strings.BadColumnCast, column.DataType, typeof(string)));
        }

        /// <summary>
        /// Gets the <see cref="PrimitiveDataFrameColumn{T}"/> with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the column</param>
        /// <returns><see cref="PrimitiveDataFrameColumn{T}"/>.</returns>
        /// <exception cref="ArgumentException">A column named <paramref name="name"/> cannot be found, or if the column's type doesn't match.</exception>
        public PrimitiveDataFrameColumn<ulong> GetUInt64Column(string name)
        {
            DataFrameColumn column = this[name];
            if (column is PrimitiveDataFrameColumn<ulong> ret)
            {
                return ret;
            }

            throw new ArgumentException(string.Format(Strings.BadColumnCast, column.DataType, typeof(UInt64)));
        }

        /// <summary>
        /// Gets the <see cref="PrimitiveDataFrameColumn{T}"/> with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the column</param>
        /// <returns><see cref="PrimitiveDataFrameColumn{T}"/>.</returns>
        /// <exception cref="ArgumentException">A column named <paramref name="name"/> cannot be found, or if the column's type doesn't match.</exception>
        public PrimitiveDataFrameColumn<ushort> GetUInt16Column(string name)
        {
            DataFrameColumn column = this[name];
            if (column is PrimitiveDataFrameColumn<ushort> ret)
            {
                return ret;
            }

            throw new ArgumentException(string.Format(Strings.BadColumnCast, column.DataType, typeof(UInt16)));
        }

    }
}
