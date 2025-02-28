﻿using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.Abstractions;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.Backend;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.NamedValues;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.Policy;
using Microsoft.Azure.Management.ApiManagement.ArmTemplates.Extractor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Extractor.EntityExtractors.Abstractions
{
    public interface IBackendExtractor
    {
        Task<Template<BackendTemplateResources>> GenerateBackendsTemplateAsync(
            string singleApiName,
            List<PolicyTemplateResource> apiPolicies,
            List<NamedValueTemplateResource> namedValues,
            string baseFilesGenerationDirectory,
            ExtractorParameters extractorParameters);

        Task<bool> IsNamedValueUsedInBackends(
            string singleApiName,
            List<PolicyTemplateResource> apiPolicies,
            string propertyName,
            string propertyDisplayName,
            ExtractorParameters extractorParameters,
            string baseFilesGenerationDirectory);
    }
}
