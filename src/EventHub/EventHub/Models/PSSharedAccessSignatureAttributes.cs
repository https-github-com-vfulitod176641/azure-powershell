// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.EventHub.Models
{
    using Microsoft.Rest;
    using Microsoft.Azure.Management.EventHub.Models;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties supplied for SharedAccessSignature
    /// </summary>
    public class PSSharedAccessSignatureAttributes
    {
        /// <summary>
        /// Initializes a new instance of the SharedAccessSignature class.
        /// </summary>
        public PSSharedAccessSignatureAttributes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SharedAccessSignature class.
        /// </summary>
        /// <param name="SharedAccessSignature">SharedAccess Signature</param>
        public PSSharedAccessSignatureAttributes(string sharedAccessSignature)
        {
            SharedAccessSignature = sharedAccessSignature.Replace("SharedAccessSignature","");
        }


        /// <summary>
        /// Gets or sets SharedAccessSignature of SASToken
        /// </summary>
        public string SharedAccessSignature { get; set; }
        
    }
}