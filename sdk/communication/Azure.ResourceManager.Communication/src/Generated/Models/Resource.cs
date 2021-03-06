// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Communication.Models
{
    /// <summary> The core properties of ARM resources. </summary>
    public partial class Resource
    {
        /// <summary> Initializes a new instance of Resource. </summary>
        public Resource()
        {
        }

        /// <summary> Initializes a new instance of Resource. </summary>
        /// <param name="id"> Fully qualified resource ID for the resource. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the service - e.g. &quot;Microsoft.Communication/CommunicationServices&quot;. </param>
        internal Resource(string id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        /// <summary> Fully qualified resource ID for the resource. </summary>
        public string Id { get; }
        /// <summary> The name of the resource. </summary>
        public string Name { get; }
        /// <summary> The type of the service - e.g. &quot;Microsoft.Communication/CommunicationServices&quot;. </summary>
        public string Type { get; }
    }
}
