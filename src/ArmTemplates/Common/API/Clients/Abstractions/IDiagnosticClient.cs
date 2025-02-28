﻿// --------------------------------------------------------------------------
//  <copyright file="IDiagnosticClient.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.TemplateModels;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Extractor.Models;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.API.Clients.Abstractions
{
    public interface IDiagnosticClient
    {
        Task<List<DiagnosticTemplateResource>> GetAllAsync(ExtractorParameters extractorParameters);

        Task<List<DiagnosticTemplateResource>> GetApiDiagnosticsAsync(string apiName, ExtractorParameters extractorParameters);
    }
}
