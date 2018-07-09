using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymatou.StaticContent.DataModel.Template.CountryPavilion.AsianPavilion
{
    public class BeautyBlock : Ymatou.StaticContent.DataModel.Template.CountryPavilion.AmericanPavilion.BeautyBlock
    {
        private string _externalLink = string.Format("/Admin/OverseaPavilion/addproductblockitem?templateid={0}&templateblockid={1}",
                                                        (int)TemplateEnum.AsianPavilionTemplate, AsianPavilionBlockEnum.BeautyBlock);
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
