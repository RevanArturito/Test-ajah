// See https://aka.ms/new-console-template for more information
using Admin.ProdukSpek;
using Authentication.Controllers;

class Program
{
    public static List<Account> accounts = new List<Account>();
    public static List<Produk> products = new List<Produk>();

    
    public static void Main(string[] args)
    {
       /* IAccountService accountService = new AccountService();

        accounts = accountService.GetAccounts();

        *//*AccountService accountService = new AccountService();
        accounts = accountService.GetAccounts();*//*
        foreach (var account in accounts)
        {
            Console.WriteLine($"Username: {account.username}, Username: {account.password}, Email: {account.phone}, Phone: {account.phone}, Role: {account.role}");
        }*/

        IProductService productService = new ProductService();

        products = productService.GetProducts();

        foreach (var product in products)
        {
            Console.WriteLine($"Nama produk : {product.namaproduk}");
        }

        productService.AddProducts(new Produk("00", "tes", "tes", "tes", "tes", "tes", 10, "deskripsi"));
    }
   
}

