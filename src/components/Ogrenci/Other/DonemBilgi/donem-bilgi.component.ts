import { CommonModule } from '@angular/common';
import { Component, OnChanges, OnDestroy, OnInit, SimpleChanges } from '@angular/core';

@Component({
  selector: 'DonemBilgi',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './donem-bilgi.component.html',
  styleUrl: './donem-bilgi.component.css'
})
export class DonemBilgiComponent implements OnInit{

 


  ngOnInit(): void {
    
  }
  mouseout(event:Event, id:string) {
    let elementTr = document.getElementById(id)
    let alertDiv = elementTr!.getElementsByClassName('tableAlert')[0] as HTMLElement
    clearTimeout(this._setTimeFunc!);
    alertDiv.style.display = 'none';
    
  }

  private _setTimeFunc: number | null = null;

   public mouseover(event:Event, id:string): void {
    let elementTr = document.getElementById(id)
    let sizex = elementTr!.offsetWidth;
    let sizey = elementTr!.offsetHeight; 
    let alertDiv = elementTr!.getElementsByClassName('tableAlert')[0] as HTMLElement
    let mouseEvent = event as MouseEvent;
    
      this._setTimeFunc = window.setTimeout(()=>{
        alertDiv.style.display = 'flex';
    },1000);

    
  };

  
}
