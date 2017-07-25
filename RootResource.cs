﻿using Microsoft.Portal.TypeMetadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Portal.Extensions.GettingStartedConcierge.DataModels
{
    [TypeMetadataModel(typeof(RootResource), "GettingStartedConcierge.DataModels", true)]
    public class RootResource : ResourceBase
    {
        public RootResourceProperties Properties { get; set; }
    }
}
