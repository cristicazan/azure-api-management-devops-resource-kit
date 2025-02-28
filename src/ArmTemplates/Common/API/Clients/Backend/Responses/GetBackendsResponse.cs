﻿// --------------------------------------------------------------------------
//  <copyright file="GetBackendsResponse.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------

using System.Collections.Generic;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.Backend;
using Newtonsoft.Json;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.API.Clients.Backend.Responses
{
    public class GetBackendsResponse
    {
        [JsonProperty("value")]
        public List<BackendTemplateResource> Backends { get; set; }

        public int Count { get; set; }
    }
}
