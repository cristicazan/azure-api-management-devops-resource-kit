﻿// --------------------------------------------------------------------------
//  <copyright file="LoggerCredentials.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.Logger
{
    public class LoggerCredentials
    {
        public string Name { get; set; }
        public string ConnectionString { get; set; }
        public string InstrumentationKey { get; set; }
    }
}
