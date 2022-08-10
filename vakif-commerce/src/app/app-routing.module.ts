import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuard } from './guards/auth-guard.service';
import { HomeComponent } from './home/home.component';
import { ProductDetailComponent } from './products/product-detail/product-detail.component';
import { ProductSelectorComponent } from './products/product-selector/product-selector.component';
import { ProductStartComponent } from './products/product-start/product-start.component';
import { ProductsComponent } from './products/products.component';
import { ShoppingListComponent } from './shopping-list/shopping-list.component';
import { UserDashboardComponent } from './user-dashboard/user-dashboard.component';
import { UserRegisterComponent } from './user-register/user-register.component';

const routes: Routes = [{path:'', redirectTo: 'en/home', pathMatch: 'full'},
                        {path:'en/home', component:HomeComponent},
                        {path:'en/products', component:ProductSelectorComponent},
                        {path: 'en/products/:id', component: ProductsComponent , children:[
                          {path: '', component:ProductStartComponent},
                          {path:':id', component:ProductDetailComponent}
                        ]},
                        {path:'en/shopping-list', component:ShoppingListComponent, canActivate: [AuthGuard]},
                        {path:'en/user-dashboard', component:UserDashboardComponent},
                        {path: 'en/user-register', component:UserRegisterComponent}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
