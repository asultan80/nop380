using Nop.Core;
using Nop.Web.Framework.Mvc;

namespace Nop.Web.Models.Checkout
{
    public partial class CheckoutCompletedModel : BaseNopModel
    {
        public int OrderId { get; set; }
        public bool OnePageCheckoutEnabled { get; set; }

        public string VendorFromSesstion
        {
            get
            {
                return VendorLite.GetVendorNameFromContext(SiteContext.CurrentVendor);
            }
        }
    }
}