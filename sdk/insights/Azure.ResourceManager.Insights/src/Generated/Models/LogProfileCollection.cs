// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> Represents a collection of log profiles. </summary>
    public partial class LogProfileCollection
    {
        /// <summary> Initializes a new instance of LogProfileCollection. </summary>
        /// <param name="value"> the values of the log profiles. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal LogProfileCollection(IEnumerable<LogProfileResource> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of LogProfileCollection. </summary>
        /// <param name="value"> the values of the log profiles. </param>
        internal LogProfileCollection(IReadOnlyList<LogProfileResource> value)
        {
            Value = value;
        }

        /// <summary> the values of the log profiles. </summary>
        public IReadOnlyList<LogProfileResource> Value { get; }
    }
}
