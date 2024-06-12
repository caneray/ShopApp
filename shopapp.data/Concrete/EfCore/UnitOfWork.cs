using shopapp.data.Abstract;

namespace shopapp.data.Concrete.EfCore
{
    public class UnitOfWork : IUnitOfWork //birden fazla veritaban� i�lemlerini tek bir i�lemde toplamak i�in kullan�l�r.
    {
        private readonly ShopContext _context;
        public UnitOfWork(ShopContext context)
        {
            _context = context;
        }
        
        private EfCoreCartRepository _cartRepository;
        private EfCoreCategoryRepository _categoryRepository;
        private EfCoreOrderRepository _orderRepository;
        private EfCoreProductRepository _productRepository;

        public ICartRepository Carts => 
            _cartRepository = _cartRepository ?? new EfCoreCartRepository(_context);

        public ICategoryRepository Categories => 
            _categoryRepository = _categoryRepository ?? new EfCoreCategoryRepository(_context);             

        public IOrderRepository Orders => 
            _orderRepository = _orderRepository ?? new EfCoreOrderRepository(_context);

        public IProductRepository Products => 
            _productRepository = _productRepository ?? new EfCoreProductRepository(_context);

        public void Dispose() //bellek temizleme
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}