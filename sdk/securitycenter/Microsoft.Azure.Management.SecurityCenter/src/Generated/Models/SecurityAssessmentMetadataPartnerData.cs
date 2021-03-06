// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the partner that created the assessment
    /// </summary>
    public partial class SecurityAssessmentMetadataPartnerData
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SecurityAssessmentMetadataPartnerData class.
        /// </summary>
        public SecurityAssessmentMetadataPartnerData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SecurityAssessmentMetadataPartnerData class.
        /// </summary>
        /// <param name="partnerName">Name of the company of the
        /// partner</param>
        /// <param name="secret">Secret to authenticate the partner and verify
        /// it created the assessment - write only</param>
        /// <param name="productName">Name of the product of the partner that
        /// created the assessment</param>
        public SecurityAssessmentMetadataPartnerData(string partnerName, string secret, string productName = default(string))
        {
            PartnerName = partnerName;
            ProductName = productName;
            Secret = secret;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the company of the partner
        /// </summary>
        [JsonProperty(PropertyName = "partnerName")]
        public string PartnerName { get; set; }

        /// <summary>
        /// Gets or sets name of the product of the partner that created the
        /// assessment
        /// </summary>
        [JsonProperty(PropertyName = "productName")]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets secret to authenticate the partner and verify it
        /// created the assessment - write only
        /// </summary>
        [JsonProperty(PropertyName = "secret")]
        public string Secret { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PartnerName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PartnerName");
            }
            if (Secret == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Secret");
            }
        }
    }
}
