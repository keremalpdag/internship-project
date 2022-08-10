import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { HomeComponent } from './home/home.component';
import { ProductsComponent } from './products/products.component';
import { ShoppingListComponent } from './shopping-list/shopping-list.component';
import { ProductDetailComponent } from './products/product-detail/product-detail.component';
import { ProductStartComponent } from './products/product-start/product-start.component';
import { ProductItemComponent } from './products/product-list/product-item/product-item.component';
import { ShoppingEditComponent } from './shopping-list/shopping-edit/shopping-edit.component';
import { ProductListComponent } from './products/product-list/product-list.component';
import { FooterComponent } from './footer/footer.component';
import { ProductService } from './products/product.service';
import { ShoppingListService } from './shopping-list/shopping-list.service';
import { UserDashboardComponent } from './user-dashboard/user-dashboard.component';
import { ProductSelectorComponent } from './products/product-selector/product-selector.component';
import { HttpClientModule } from '@angular/common/http';
import { UserRegisterComponent } from './user-register/user-register.component';
import { FormsModule } from '@angular/forms';
import { JwtModule } from '@auth0/angular-jwt';
import { LogInOutService } from './logInOut.service';
import { RegisterService } from './register.service';

export function tokenGetter(){
  return localStorage.getItem("jwt");
}

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomeComponent,
    ProductsComponent,
    ShoppingListComponent,
    ProductDetailComponent,
    ProductStartComponent,
    ProductItemComponent,
    ProductListComponent,
    ShoppingEditComponent,
    FooterComponent,
    UserDashboardComponent,
    ProductSelectorComponent,
    UserRegisterComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    JwtModule.forRoot({
      config: {
        tokenGetter: tokenGetter,
        allowedDomains: ["localhost:5001"], 
        disallowedRoutes: []
      }
    })
  ],
  providers: [ProductService,
              ShoppingListService,
            {provide: 'baseURL', useValue: 'https://localhost:5001/api', multi: true},
            LogInOutService,
            RegisterService],
  bootstrap: [AppComponent]
})
export class AppModule { }
