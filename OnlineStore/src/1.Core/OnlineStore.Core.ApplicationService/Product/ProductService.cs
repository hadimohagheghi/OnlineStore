using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Core.ApplicationService.Product
{
    //ورودی و خروجی ها
    public class ProductDto
    {

    }

    public interface IProductService
    {
        //
        //ورودی و خروی ها را به عنوان DTO تعریف می کنیم
        Task<IList<ProductDto>> GetAll();   //ورودی ندارد ولی احتمالا لیستی از محصولات خروجی آن است
        Task<ProductDto> GetById(int id);
       Task Create(ProductDto Dto);//خروجی این رو خودت تشخیص بده
        Task Update(ProductDto Dto);
       Task Delete(int id);
    }



    internal class ProductService
    {
    }
}
