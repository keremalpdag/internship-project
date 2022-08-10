import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Product } from '../product.model';

import { ProductService } from '../product.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {

  categoryId : number;
  products: Product[];
  selected: string;
 

  constructor(private route: ActivatedRoute,
              private productService: ProductService,
              private httpClient : HttpClient,
              @Inject('baseURL') private baseURL:string) {}

  ngOnInit() {
    this.route.params.subscribe((params) => {
      this.categoryId = params['id'];
    });
    this.getProducts();
  }

  getProducts(){
    this.httpClient.get<any>(this.baseURL+'/Products/GetListByCategory/?id='+this.categoryId.toString()).subscribe(
      response => { 
        this.products = response;
        this.productService.productList = this.products;
      }
    );
  }
}



