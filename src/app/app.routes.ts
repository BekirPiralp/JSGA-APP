import { Routes } from '@angular/router';
import { HomeComponent } from '../components/Home/Home.component';

export const routes: Routes = [
    {path:'Home', component:HomeComponent},
    {path:'',component:HomeComponent},
    {path:'#',redirectTo:''},
    {path:'**',pathMatch:'full',redirectTo:''}
];
