﻿// --------------------------------------------------------------------------
//  <copyright file="ApiVersionSetProperties.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.ApiVersionSet
{
    public class ApiVersionSetProperties
    {
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string VersionQueryName { get; set; }
        public string VersionHeaderName { get; set; }
        public string VersioningScheme { get; set; }
    }
}
