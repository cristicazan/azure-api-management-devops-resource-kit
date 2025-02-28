﻿// --------------------------------------------------------------------------
//  <copyright file="IDiagnosticExtractor.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.TemplateModels;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Extractor.Models;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Extractor.EntityExtractors.Abstractions
{
    public interface IDiagnosticExtractor
    {
        Task<List<DiagnosticTemplateResource>> GetApiDiagnosticsResourcesAsync(string apiName, ExtractorParameters extractorParameters);

        Task<List<DiagnosticTemplateResource>> GetServiceDiagnosticsTemplateResourcesAsync(ExtractorParameters extractorParameters);
    }
}
