export class ProductSpecs{  
    
    public productSpecsId : number;
    public productId : number;
    public cpu: string;
    public gpu: string;
    public ram: string;
    public storage: string;
    public size: string;
    public weight: number;
    public productColor: string; 


    constructor(productSpecsId : number,productId : number,cpu: string, gpu: string, ram: string, 
        storage: string, size:string, weight: number){
        this.productSpecsId = productSpecsId;
        this.productId = productId;
        this.cpu = cpu;
        this.gpu = gpu;
        this.ram = ram;
        this.storage = storage;
        this.size = size;
        this.weight = weight;
    }
}




