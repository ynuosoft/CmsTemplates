using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.AmericanPavilion
{
    public class HotSeasonBlock : NewDiscoveryBlock
    {
        public override int BlcokID
        {
            get { return AmericanPavilionBlockEnum.HotSeasonBlock; }
        }

        public override string BlockName
        {
            get { return "最热季"; }
        }

        private string _externalLink = string.Format("/Admin/OverseaPavilion/addproductblockitem?templateid={0}&templateblockid={1}",
                                                        (int)TemplateEnum.AmericanPavilionTemplate, AmericanPavilionBlockEnum.HotSeasonBlock);
        public override string ExternalLink
        {
            get
            {
                return _externalLink;
            }
            set
            {
                _externalLink = value;
            }
        }
    }
}
