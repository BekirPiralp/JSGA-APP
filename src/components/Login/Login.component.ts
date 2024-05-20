import { Component, OnInit } from '@angular/core';
import { ButtonCardComponent } from '../other componenets/button-Card/button-Card.component';
import { HomeComponent } from '../Home/Home.component';

@Component({
  selector: 'login',
  templateUrl: './Login.component.html',
  styleUrls: ['./Login.component.css'],
  imports:[ButtonCardComponent],
  standalone: true,
})
export class LoginComponent implements OnInit{


  constructor() {
   }

  ngOnInit() {
  }

}
