using Nop.Core;
using Nop.Services.Vendors;
using Nop.Web.Framework.Mvc;

namespace Nop.Web.Models.Common
{
    public partial class HeaderModel : BaseNopModel
    {
        public string VendorLogoUrl { get; set; }
        public string VendorName { get; set; }
    }
}