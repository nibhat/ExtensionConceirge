﻿using Microsoft.Portal.TypeMetadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Portal.Extensions.GettingStartedConcierge.DataModels
{
    [TypeMetadataModel(typeof(RootResourceProperties), "GettingStartedConcierge.DataModels")]
    public class RootResourceProperties
    {
        public string CustomProperty { get; set; }
        public string ProvisioningState { get; set; }
    }
}
