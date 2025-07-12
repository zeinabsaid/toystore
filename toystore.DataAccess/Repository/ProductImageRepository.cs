using toystore.DataAccess.Repository.IRepository;
using toystore.DataAcess.Data;
using toystore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace toystore.DataAccess.Repository
{
    public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository 
        {
        private ApplicationDbContext _db;
        public ProductImageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        

        public void Update(ProductImage obj)
        {
            _db.ProductImages.Update(obj);
        }
    }
}
