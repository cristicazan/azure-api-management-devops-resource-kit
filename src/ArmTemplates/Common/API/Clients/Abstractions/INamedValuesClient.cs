﻿// --------------------------------------------------------------------------
//  <copyright file="INamedValuesClient.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.NamedValues;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Extractor.Models;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.API.Clients.Abstractions
{
    public interface INamedValuesClient
    {
        Task<List<NamedValueTemplateResource>> GetAllAsync(ExtractorParameters extractorParameters);
    }
}
