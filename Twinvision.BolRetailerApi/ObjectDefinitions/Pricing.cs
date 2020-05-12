﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Twinvision.BolRetailerApi
{
    public class Pricing
    {
        /// <summary>A set of prices (containing a quantity and selling price) that apply to this offer.</summary>
        public List<BundlePrice> BundlePrices { get; set; }

        public Pricing(List<BundlePrice> bundlePrices)
        {
            BundlePrices = bundlePrices;
        }
    }
}
