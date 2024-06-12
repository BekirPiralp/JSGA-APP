import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'Transkript',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './transkript.component.html',
  styleUrl: './transkript.component.css',
})
export class TranskriptComponent {

  private timeOutId:number=0;
  mouseover(event:MouseEvent,id:string):void{
    let element = document.getElementById(id);
    let bilgiBox = element?.getElementsByClassName('bilgiBox')[0];

    this.timeOutId = window.setTimeout(()=>{
      if(bilgiBox !== undefined)
        (bilgiBox! as HTMLElement).style.display='flex';
    },1000);
  }

  mouseout(event:MouseEvent,id:string):void{
    clearTimeout(this.timeOutId);

    let element = document.getElementById(id);
    let bilgiBox = element?.getElementsByClassName('bilgiBox')[0];
    if(bilgiBox !== undefined)
      (bilgiBox as HTMLElement).style.display='none';
  }
}
