using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotationLocalization.Resources
{
    public class DataAnnotationResource
    {
        private static IStringLocalizer<DataAnnotationResource> _localization;
        public static void DataAnnotationResourceConfigure(IStringLocalizer<DataAnnotationResource> localization)
        {
            _localization = localization;
        }
        public static string Required => _localization["{0} is Required"].Value;
        public static string MaxLength => _localization["{0} Max {1}"].Value;
        public static string MinLength => _localization["{0} Min {1}"].Value;
        public static string StringLength => _localization["{0} is {1} is {2}"].Value;
    }
}
