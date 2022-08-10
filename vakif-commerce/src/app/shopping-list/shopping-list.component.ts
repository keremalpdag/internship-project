import { Component, OnDestroy, OnInit } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { Subscription } from 'rxjs';
import { Product } from '../products/product.model';
import { ShoppingListService } from './shopping-list.service';

@Component({
  selector: 'app-shopping-list',
  templateUrl: './shopping-list.component.html',
  styleUrls: ['./shopping-list.component.css']
})
export class ShoppingListComponent implements OnInit, OnDestroy {

  products: Product[] = [];
  private productChangeSubscription: Subscription; //for storing our subscription

  constructor(private shoppingListService: ShoppingListService,
              private jwtHelper: JwtHelperService) {}

  ngOnInit(): void {
    this.products = this.shoppingListService.getProductsInList();
    this.productChangeSubscription = this.shoppingListService.shoppingListUpdated.subscribe(
      (products: Product[]) => {this.products = products;}
    )
  }

  isUserAuthenticated(){
    const token: string = localStorage.getItem("jwt");
    if (token && !this.jwtHelper.isTokenExpired(token)){
      return true;
    }
    else{
      return false;
    }
  }

  ngOnDestroy(): void {
    this.productChangeSubscription.unsubscribe(); 
  }

}
