// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights.Models
{
    using System.Linq;

    /// <summary>
    /// The log profile resource.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class LogProfileResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the LogProfileResource class.
        /// </summary>
        public LogProfileResource() { }

        /// <summary>
        /// Initializes a new instance of the LogProfileResource class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="locations">List of regions for which Activity Log
        /// events should be stored or streamed. It is a comma separated list
        /// of valid ARM locations including the 'global' location.</param>
        /// <param name="id">Azure resource Id</param>
        /// <param name="name">Azure resource name</param>
        /// <param name="type">Azure resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="storageAccountId">the resource id of the storage
        /// account to which you would like to send the Activity Log.</param>
        /// <param name="serviceBusRuleId">The service bus rule ID of the
        /// service bus namespace in which you would like to have Event Hubs
        /// created for streaming the Activity Log. The rule ID is of the
        /// format: '{service bus resource ID}/authorizationrules/{key
        /// name}'.</param>
        /// <param name="categories">the categories of the logs. These
        /// categories are created as is convenient to the user. Some values
        /// are: 'Write', 'Delete', and/or 'Action.'</param>
        /// <param name="retentionPolicy">the retention policy for the events
        /// in the log.</param>
        public LogProfileResource(string location, System.Collections.Generic.IList<string> locations, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string storageAccountId = default(string), string serviceBusRuleId = default(string), System.Collections.Generic.IList<string> categories = default(System.Collections.Generic.IList<string>), RetentionPolicy retentionPolicy = default(RetentionPolicy))
            : base(location, id, name, type, tags)
        {
            StorageAccountId = storageAccountId;
            ServiceBusRuleId = serviceBusRuleId;
            Locations = locations;
            Categories = categories;
            RetentionPolicy = retentionPolicy;
        }

        /// <summary>
        /// Gets or sets the resource id of the storage account to which you
        /// would like to send the Activity Log.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the service bus rule ID of the service bus namespace
        /// in which you would like to have Event Hubs created for streaming
        /// the Activity Log. The rule ID is of the format: '{service bus
        /// resource ID}/authorizationrules/{key name}'.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.serviceBusRuleId")]
        public string ServiceBusRuleId { get; set; }

        /// <summary>
        /// Gets or sets list of regions for which Activity Log events should
        /// be stored or streamed. It is a comma separated list of valid ARM
        /// locations including the 'global' location.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.locations")]
        public System.Collections.Generic.IList<string> Locations { get; set; }

        /// <summary>
        /// Gets or sets the categories of the logs. These categories are
        /// created as is convenient to the user. Some values are: 'Write',
        /// 'Delete', and/or 'Action.'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.categories")]
        public System.Collections.Generic.IList<string> Categories { get; set; }

        /// <summary>
        /// Gets or sets the retention policy for the events in the log.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.retentionPolicy")]
        public RetentionPolicy RetentionPolicy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Locations == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Locations");
            }
            if (this.RetentionPolicy != null)
            {
                this.RetentionPolicy.Validate();
            }
        }
    }
}
