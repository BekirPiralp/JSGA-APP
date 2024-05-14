import { Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { LoginComponent } from '../components/Login/Login.component';

export const routes: Routes = [
    {path:'Home', component: AppComponent},
    {path:'#', component: AppComponent},
    {path:'Login',component:LoginComponent},
    {path:'login',component:LoginComponent},
    {path:'',redirectTo:'/Home',pathMatch:'full'}
];
