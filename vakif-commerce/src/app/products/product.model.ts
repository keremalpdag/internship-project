export class Product{

    public ProductId : number;
    public CategoryId: number;
    public ProductName: string;
    public ProductDescription: string;
    public ProductImgPath: string;
    public ProductPrice: number; 
    public ProductInStock: boolean;

    constructor(productId:number,categoryId:number,productName: string, productDescription: string, 
        productImgPath: string, price: number, inStock: boolean){
        this.ProductId = productId;
        this.CategoryId = categoryId;
        this.ProductName = productName;
        this.ProductDescription = productDescription;
        this.ProductImgPath = productImgPath;
        this.ProductPrice = price;
        this.ProductInStock = inStock;
    }
}


