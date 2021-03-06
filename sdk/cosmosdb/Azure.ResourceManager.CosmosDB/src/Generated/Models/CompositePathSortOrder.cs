// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Sort order for composite paths. </summary>
    public readonly partial struct CompositePathSortOrder : IEquatable<CompositePathSortOrder>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CompositePathSortOrder"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CompositePathSortOrder(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AscendingValue = "Ascending";
        private const string DescendingValue = "Descending";

        /// <summary> Ascending. </summary>
        public static CompositePathSortOrder Ascending { get; } = new CompositePathSortOrder(AscendingValue);
        /// <summary> Descending. </summary>
        public static CompositePathSortOrder Descending { get; } = new CompositePathSortOrder(DescendingValue);
        /// <summary> Determines if two <see cref="CompositePathSortOrder"/> values are the same. </summary>
        public static bool operator ==(CompositePathSortOrder left, CompositePathSortOrder right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CompositePathSortOrder"/> values are not the same. </summary>
        public static bool operator !=(CompositePathSortOrder left, CompositePathSortOrder right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CompositePathSortOrder"/>. </summary>
        public static implicit operator CompositePathSortOrder(string value) => new CompositePathSortOrder(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CompositePathSortOrder other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CompositePathSortOrder other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
