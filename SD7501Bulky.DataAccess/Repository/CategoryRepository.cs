using BulkyWeb.Data;
using BulkyWeb.Models;
using SD7501Bulky.DataAccess.Repository.IRepository;
using SD7501Bulky.Models;

namespace SD7501Bulky.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Category obj)
        {
            _db.Update(obj);
        }
    }
}
