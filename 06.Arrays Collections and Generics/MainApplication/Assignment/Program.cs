using Assignment;

//PART 1
GenericCollection<int> intGenericCollection = new GenericCollection<int>();

intGenericCollection.Add(1);
intGenericCollection.Add(8);
intGenericCollection.AddByIndex(9, 0);
intGenericCollection.AddByIndex(10, 2);
intGenericCollection.AddByIndex(11, 3);

Console.WriteLine(intGenericCollection.GetItemByIndex(1));
Console.WriteLine(intGenericCollection.GetItemByIndex(2));

intGenericCollection.SwapByIndexes(1, 2);
intGenericCollection.DisplayItems();


//PART 2
Product product1 = new Product(1,"Minge",23.23f ,ProductStatus.Selling);
Product product2 = new Product(2, "Lampa", 400, ProductStatus.Selling);
Product product3 = new Product(3, "Servetele", 10, ProductStatus.Sold);

List<Product> Products = new List<Product>();
Products.Add(product1);
Products.Add(product2);
Products.Add(product3);

Console.WriteLine("List:");
foreach (Product product in Products)
{
    product.Display();
}
Console.WriteLine();

HashSet<Product> productSet = new HashSet<Product>();

productSet.Add(product1);
productSet.Add(product2);
Console.WriteLine("HashSet:");
foreach (Product product in productSet)
{
    product.Display();
}
Console.WriteLine();

HashSet<Product> productSetWithComparer = new(new ProductComparer());
productSetWithComparer.Add(product1);
productSetWithComparer.Add(product1);
productSetWithComparer.Add(product2);
productSetWithComparer.Add(product3);// nu adauga dublicarile in functie de id
productSetWithComparer.Add(new Product(1,"Minge",23,ProductStatus.Stock));


Console.WriteLine("HashSet With Comparere:");
foreach (Product product in productSetWithComparer)
{
    product.Display();
}
Console.WriteLine();

Dictionary<int,Product> keysWithProducts = new Dictionary<int,Product>();

keysWithProducts.Add(product1.Id, product1);
keysWithProducts.Add(product2.Id, product2);

Console.WriteLine("Dictionary:");
foreach(KeyValuePair<int,Product> kvp in keysWithProducts)
{
    Console.WriteLine($"key:{kvp.Key}");
    kvp.Value.Display();
}
Console.WriteLine();


//PART Generic Repository

Product.Insert(product1);
Product.Insert(product2);

//stergem produsul curent
product1.Delete();
