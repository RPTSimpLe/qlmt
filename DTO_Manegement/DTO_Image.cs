using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Manegement
{
    public class DTO_Image
    {
        private long productId;
        private string url;

        public DTO_Image(long productId, string url)
        {
            this.productId = productId;
            this.url = url;
        }
        public DTO_Image() { }
        public long getProductId()
        {
            return productId;
        }

        public void setProductId(long productId)
        {
            this.productId = productId;
        }

        public String getUrl()
        {
            return url;
        }

        public void setUrl(String url)
        {
            this.url = url;
        }
    }
}
