import { Routes } from '@angular/router';
import { HomeComponent } from '../components/Home/Home.component';
import { OgrenciComponent } from '../components/Ogrenci/Ogrenci/Ogrenci.component';
import { OgretmenComponent } from '../components/Ogretmen/Ogretmen/Ogretmen.component';
import { PersonelComponent } from '../components/Personel/Personel/Personel.component';
import { OgrenciLoginComponent } from '../components/Ogrenci/OgrenciLogin/OgrenciLogin.component';
import { OgretmenLoginComponent } from '../components/Ogretmen/OgretmenLogin/OgretmenLogin.component';
import { PersonelLoginComponent } from '../components/Personel/PersonelLogin/PersonelLogin.component';

export const routes: Routes = [
    {path:'Home', component:HomeComponent},
    {path:'Ogrenci',
        children:[
            {path:'Login', component:OgrenciLoginComponent},
            {path:'',component:OgrenciComponent},
            {path:'**',pathMatch:'full',redirectTo:'Login'}
        ],
    },
    {path:'Ogretmen',
        children:[
            {path:'Login', component:OgretmenLoginComponent},
            {path:'',component:OgretmenComponent},
            {path:'**',pathMatch:'full',redirectTo:'Login'}
        ],
    },
    {path:'Personel',
        children:[
            {path:'Login', component:PersonelLoginComponent},
            {path:'',component:PersonelComponent},
            {path:'**',pathMatch:'full',redirectTo:'Login'}
        ],
    },
    {path:'',component:HomeComponent},
    {path:'#',redirectTo:''},
    {path:'**',pathMatch:'full',redirectTo:''}
];
