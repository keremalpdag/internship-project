import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { Category } from 'src/app/models/category.model';

@Component({
  selector: 'app-product-selector',
  templateUrl: './product-selector.component.html',
  styleUrls: ['./product-selector.component.css']
})
export class ProductSelectorComponent implements OnInit {

  public categoryArray: Category[] = [];

  constructor(private htppClient: HttpClient,
              @Inject('baseURL') private baseURL:string) { }

  ngOnInit(): void {
    this.getCategories();
  }

  getCategories(){
    this.htppClient.get<any>(this.baseURL+'/Categories/GetCategories').subscribe(
      response => {
        console.log(response);
        this.categoryArray = response;
      }
    );
  }

}

