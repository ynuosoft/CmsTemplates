using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.AmericanPavilion
{
    public class BrandBlock : NewDiscoveryBlock
    {
        public override int BlcokID
        {
            get { return AmericanPavilionBlockEnum.BrandBlock; }
        }

        public override string BlockName
        {
            get { return "美国品牌"; }
        }

        private string _externalLink = string.Format("/Admin/OverseaPavilion/addproductblockitem?templateid={0}&templateblockid={1}",
                                                        (int)TemplateEnum.AmericanPavilionTemplate, AmericanPavilionBlockEnum.BrandBlock);
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
