﻿// --------------------------------------------------------------------------
//  <copyright file="ApiTemplateAPIVersionSet.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.Apis
{
    public class ApiTemplateApiVersionSet
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string VersionQueryName { get; set; }

        public string VersionHeaderName { get; set; }

        public string VersioningScheme { get; set; }
    }
}
