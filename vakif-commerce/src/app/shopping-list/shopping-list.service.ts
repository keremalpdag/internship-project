import { Subject } from "rxjs";
import { Product } from "../products/product.model";


export class ShoppingListService{

    shoppingListUpdated = new Subject<Product[]>(); //EventEmitter is changed to a Subject 

    private productsInList: Product[]= []; 

    constructor(){}

    addProductToList(product: Product){
        this.productsInList.push(product);
        this.shoppingListUpdated.next();  
        window.alert("Added to Shopping List");
    }

    removeProductFromList(product: Product){
        const index = this.productsInList.indexOf(product);
        if(index > -1){
            this.productsInList.splice(index,1);
            this.shoppingListUpdated.next();
            window.alert("Removed From Shopping List");
        }
        else{ window.alert("Item Is Not In the Shopping List") }
    }

    getProductsInList(){
        return this.productsInList.slice();
    }

    clearShoppingList(){
        if(this.productsInList.length === 0){
            window.alert("The Shopping List is Already Empty");
        }
        else{
            window.alert("The Shopping List is Cleared");
        }
        this.productsInList.splice(0,this.productsInList.length); 
        this.shoppingListUpdated.next();
    }
}