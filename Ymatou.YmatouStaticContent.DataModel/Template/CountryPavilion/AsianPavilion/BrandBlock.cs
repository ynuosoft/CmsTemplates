using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.AsianPavilion
{
    public class BrandBlock : Ymatou.StaticContent.DataModel.Template.CountryPavilion.AmericanPavilion.BrandBlock
    {
        public override string BlockName
        {
            get { return "亚洲品牌"; }
        }

        private string _externalLink = string.Format("/Admin/OverseaPavilion/addproductblockitem?templateid={0}&templateblockid={1}",
                                                        (int)TemplateEnum.AsianPavilionTemplate, AsianPavilionBlockEnum.BrandBlock);
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
