using System;
using System.Collections.Generic;
using System.Linq;

namespace Nop.Core
{
    public class SiteContext
    {
        public static CurrentDestinationPrice CurrentDestinationPriceAdjustment
        {
            get
            {
                return (CurrentDestinationPrice)SessionWrapper.GetObject(ContextKeyNames.DestinationPrice);
            }
            set
            {
                SessionWrapper.SetObject(ContextKeyNames.DestinationPrice, value);
            }
        }

        public static VendorLite CurrentVendor
        {
            get
            {
                return (VendorLite)SessionWrapper.GetObject(ContextKeyNames.CurrentVendor);
            }
            set
            {
                SessionWrapper.SetObject(ContextKeyNames.CurrentVendor, value);
            }
        }

        /// <summary>
        /// Get SiteContext ptoperty
        /// </summary>
        /// <param name="property">ContextKeyName</param>
        /// <returns>Object</returns>
        public static object GetProperty(string property)
        {            
            return SessionWrapper.GetObject(property);
        }

        /// <summary>
        /// Set SiteContextProperty
        /// </summary>
        /// <param name="property">ContextKeyName</param>
        /// <param name="value">Any Object</param>
        public static void SetProperty(string property, object value)
        {
            SessionWrapper.SetObject(property, value);
        }

        /// <summary>
        /// Delete property from SiteContext
        /// </summary>
        /// <param name="property">ContextKeyName</param>
        public static void RemoveProperty(string property)
        {
            SessionWrapper.RemoveObject(property);
        }
    }
}
