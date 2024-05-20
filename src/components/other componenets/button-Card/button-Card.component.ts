import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'buttonCard',
  templateUrl: './button-Card.component.html',
  styleUrls: ['./button-Card.component.css'],
  standalone: true
})
export class ButtonCardComponent implements OnInit {

  @Input() imgSrc: string ="";
  @Input() imgAlt: string ="";
  @Input() hrefA: string ="";
  @Input() content: string="";

  constructor() { }

  ngOnInit() {
  }

}
