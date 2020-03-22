using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbraco.NoiThat.Core.ViewModels
{
   public  class HomeFeatureServiceViewModel
    {
        public string FeatureServiceIntro { get; set; }
        public List<FeatureServiceContentItem> FeatureServiceContentItems { get; set; }
    }
}
