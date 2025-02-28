﻿// --------------------------------------------------------------------------
//  <copyright file="LoggerTemplateProperties.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.Logger
{
    public class LoggerTemplateProperties
    {
        public string LoggerType { get; set; }
        public string Description { get; set; }
        public LoggerCredentials Credentials { get; set; }
        public bool IsBuffered { get; set; }
        public string ResourceId { get; set; }
    }
}
