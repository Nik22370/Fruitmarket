using system;


namespace Product
{

    public class Product
    {

        public Product(int Ean, string ItemName, itemCategory ItemCategory)
        {
            Ean = ean;
            ItemName = ItemName;
            ItemCategory = itemCategory;
            ItemCategoryId = itemCategoryId.id;

        }
        
        public string Name { get; set; } = default!;
        public int ProductCategoryId { get; set; }
        public  productCategory ProductCategory { get; set; } = default!;
        
        
    }
    
    
    
    
    
    
    
    
}



