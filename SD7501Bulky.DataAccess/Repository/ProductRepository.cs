using BulkyWeb.Data;
using BulkyWeb.Models;
using SD7501Bulky.DataAccess.Repository.IRepository;
using SD7501Bulky.Models;

namespace SD7501Bulky.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}
