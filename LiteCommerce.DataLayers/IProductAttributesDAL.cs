using LiteCommerce.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteCommerce.DataLayers
{
    public interface IProductAttributesDAL
    {
        List<ProductAttributes> GetAll(int productID);
        int Delete(int[] AttributeIDs);
        int Update(List<ProductAttributes> data);
        int Add(List<ProductAttributes> data);
    }
}
