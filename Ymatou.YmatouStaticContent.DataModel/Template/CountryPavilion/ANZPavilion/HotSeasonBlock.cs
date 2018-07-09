using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.ANZPavilion
{
    public class HotSeasonBlock : Ymatou.StaticContent.DataModel.Template.CountryPavilion.AmericanPavilion.HotSeasonBlock
    {
        private string _externalLink = string.Format("/Admin/OverseaPavilion/addproductblockitem?templateid={0}&templateblockid={1}",
                                                        (int)TemplateEnum.ANZPavilionTemplate, ANZPavilionBlockEnum.HotSeasonBlock);
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
