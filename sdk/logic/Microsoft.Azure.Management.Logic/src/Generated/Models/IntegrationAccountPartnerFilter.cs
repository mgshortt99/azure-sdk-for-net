// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The integration account partner filter for odata query.
    /// </summary>
    public partial class IntegrationAccountPartnerFilter
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationAccountPartnerFilter
        /// class.
        /// </summary>
        public IntegrationAccountPartnerFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntegrationAccountPartnerFilter
        /// class.
        /// </summary>
        /// <param name="partnerType">The partner type of integration account
        /// partner. Possible values include: 'NotSpecified', 'B2B'</param>
        public IntegrationAccountPartnerFilter(string partnerType)
        {
            PartnerType = partnerType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the partner type of integration account partner.
        /// Possible values include: 'NotSpecified', 'B2B'
        /// </summary>
        [JsonProperty(PropertyName = "partnerType")]
        public string PartnerType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PartnerType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PartnerType");
            }
        }
    }
}
