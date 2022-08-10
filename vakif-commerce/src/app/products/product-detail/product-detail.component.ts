import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { ShoppingListService } from 'src/app/shopping-list/shopping-list.service';
import { Product } from '../product.model';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent implements OnInit {

  product:Product;
  id: number;

  constructor(private productService: ProductService, 
    private activatedRoute: ActivatedRoute, 
    private shoppingListService:ShoppingListService) {}

  ngOnInit(): void {
    this.activatedRoute.params.subscribe(
      (params: Params) => {
        this.id = +params['id'];
        this.product = this.productService.getProductsById(this.id);
      }
    )
  }

  addToList(){
    this.shoppingListService.addProductToList(this.product);
  }

  removeFromList(){
    this.shoppingListService.removeProductFromList(this.product);
  }
}



