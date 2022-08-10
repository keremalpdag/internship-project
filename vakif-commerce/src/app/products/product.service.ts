import { Injectable } from "@angular/core";
import { Product } from "./product.model";

@Injectable()
export class ProductService{

    public productList: Product[] = [];

    constructor(){}

    getProductsById(id: number){
        return this.productList[id];
    }
}


