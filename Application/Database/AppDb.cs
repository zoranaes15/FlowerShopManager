

namespace Application.Database
{
    public static class AppDb
    {
        //vraca novi db kontext svaki put kad se pozove, a kontext vraca isti db kontekst svaki put
        //db kontekst je klasa koja predstavlja bazu podataka i koristi se za interakciju sa bazom podataka
        public static FlowerShopManagerDbContext CreateContext()
        => new FlowerShopManagerDbContext();
        public static FlowerShopManagerDbContext Context { get; } = new FlowerShopManagerDbContext();
    }
}
