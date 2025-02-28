﻿// --------------------------------------------------------------------------
//  <copyright file="ServerX509Names.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation. All rights reserved.
//  </copyright>
// --------------------------------------------------------------------------

namespace Microsoft.Azure.Management.ApiManagement.ArmTemplates.Common.Templates.Backend
{
    public class ServerX509Names
    {
        public string Name { get; set; }
        public string IssuerCertificateThumbprint { get; set; }
    }
}
