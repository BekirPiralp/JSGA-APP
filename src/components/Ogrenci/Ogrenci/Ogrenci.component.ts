import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-Ogrenci',
  templateUrl: './Ogrenci.component.html',
  styleUrls: ['./Ogrenci.component.css']
})
export class OgrenciComponent implements OnInit {

  constructor() { }

  ngOnInit() {
    var items = document.getElementsByClassName('nav')[0].getElementsByClassName('navitem');
    Array.from(items).forEach(element => {
      element.addEventListener('click',this.navItemOnClick);
    });
  }

  navItemOnClick(event:Event){
    var element = (event.target as Element);
    OgrenciComponent.navItemRemoveOfActive();
    element.classList.add('active');
  }

  public static navItemRemoveOfActive():void{
    var items = document.getElementsByClassName('nav')[0].getElementsByClassName('navitem');
    Array.from(items).forEach(element => {
      element.classList.remove('active');
    });
    
  }

}
