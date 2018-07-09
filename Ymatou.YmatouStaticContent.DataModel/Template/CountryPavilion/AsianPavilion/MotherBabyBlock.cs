using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.AsianPavilion
{
    public class MotherBabyBlock : Ymatou.StaticContent.DataModel.Template.CountryPavilion.AmericanPavilion.MotherBabyBlock
    {
        private string _externalLink = string.Format("/Admin/OverseaPavilion/addproductblockitem?templateid={0}&templateblockid={1}",
                                                        (int)TemplateEnum.AsianPavilionTemplate, AsianPavilionBlockEnum.MotherBabyBlock);
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
