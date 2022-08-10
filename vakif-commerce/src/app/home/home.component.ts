import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit} from '@angular/core';
import { Category } from '../models/category.model';
import { ProductService } from '../products/product.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  public categoryArray: Category[] = [];

  constructor(private productService: ProductService,
              private httpClient: HttpClient,
              @Inject('baseURL') private baseURL:string) { }

  ngOnInit(): void {
    this.getCategories();
  }

  getCategories(){
    this.httpClient.get<any>(this.baseURL+'/Categories/GetCategories').subscribe(
      response => {
        console.log(response);
        this.categoryArray = response;
      }
    );
  }

}
