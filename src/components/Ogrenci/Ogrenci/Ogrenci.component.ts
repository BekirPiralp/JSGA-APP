import { Component, OnInit } from '@angular/core';
import { AkademikTakvimComponent } from '../Other/AkademikTakvim/akademik-takvim.component';
import { AnaSayfaComponent } from '../Other/AnaSayfa/ana-sayfa.component';
import { DonemBilgiComponent } from '../Other/DonemBilgi/donem-bilgi.component';
import { HaftalikDersPlaniComponent } from '../Other/Haftalik-Ders-Plani/haftalik-ders-plani.component';
import { TranskriptComponent } from '../Other/Transkript/transkript.component';
import * as alertify from 'alertifyjs';
import { PlatformLocation } from '@angular/common';

@Component({
  selector: 'app-Ogrenci',
  templateUrl: './Ogrenci.component.html',
  styleUrls: ['./Ogrenci.component.css'],
  imports:[
    AkademikTakvimComponent,AnaSayfaComponent,DonemBilgiComponent,HaftalikDersPlaniComponent,TranskriptComponent,
  ],
  standalone:true
})
export class OgrenciComponent implements OnInit {


  constructor(private platformLocation: PlatformLocation) {

    //back button set null
    history.back
    history.pushState(null,"",location.href);
    platformLocation.onPopState(()=>{
      history.pushState(null,'',location.href);
      return false;
    });
   }

  ngOnInit() {
    var items = document.getElementsByClassName('nav')[0].getElementsByClassName('navitem');
    Array.from(items).forEach(element => {
      element.addEventListener('click',this.navItemOnClick);
    });

    OgrenciComponent.navItemAddProperty();
    OgrenciComponent.GovdeItemSetDisplayNone('AnaSayfa');
  }

  navItemOnClick(event:Event){
    var element = (event.target as Element);
    OgrenciComponent.navItemRemoveOfActive();
    element.classList.add('active');
    var IdFor = (element as HTMLElement).getAttribute('for');
    if(IdFor !== 'none' || IdFor != null){
      var forElement = document.getElementById(IdFor!);
      if(forElement != null){
        OgrenciComponent.GovdeItemSetDisplayNone();
        forElement!.style.display='flex';
      }
        
    }
  }


  public static navItemRemoveOfActive():void{
    var items = document.getElementsByClassName('nav')[0].getElementsByClassName('navitem');
    Array.from(items).forEach(element => {
      element.classList.remove('active');
    });
    
  }

  public static GovdeItemSetDisplayNone(defaultID:string|null = null){
    var items = document.getElementById('govde')!.children;
    Array.from(items).forEach(
      element=>{
        var htmlElement = (element as HTMLElement);
        
        if(htmlElement.id !== defaultID)
          htmlElement.style.display='none';
      }
    );
  }

  public static navItemAddProperty(){
    var items = document.getElementsByClassName('nav')[0].getElementsByClassName('navitem');
    Array.from(items).forEach(element => {
      //(element as HTMLElement).setAttribute('for','none');
    });
  }


  CikisClick() {
    document.location.href="/";
  }

  settingsClick() {
    alertify.warning('Tasarlamaya devam ediyoruz...');
  }

}
