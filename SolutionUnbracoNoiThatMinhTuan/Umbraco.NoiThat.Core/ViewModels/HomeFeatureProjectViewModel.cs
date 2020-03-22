using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbraco.NoiThat.Core.ViewModels
{
   public  class HomeFeatureProjectViewModel
    {
        public string FeatureProjectIntro { get; set; }
        public List<FeatureProjectContentItem> FeatureProjectContentItems { get; set; }
    }
}
