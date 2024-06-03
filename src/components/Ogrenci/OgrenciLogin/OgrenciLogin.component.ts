import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { UserLogin } from '../../../Model/LoginTool/UserLogin';
import { CommonModule } from '@angular/common';
import * as alertify from 'alertifyjs';
import { delay } from 'rxjs';
import { transition } from '@angular/animations';

@Component({
  selector: 'app-OgrenciLogin',
  templateUrl: './OgrenciLogin.component.html',
  styleUrls: ['./OgrenciLogin.component.css'],
  imports:[ReactiveFormsModule,FormsModule,CommonModule],
  standalone: true
})
export class OgrenciLoginComponent implements OnInit {
  
  userLogin:UserLogin = new UserLogin;
  constructor() {}

  ngOnInit() {
  }

  onSubmit(){
   
    alertify.success('test'); 
    this.bekle();
    open('Ogrenci','_self');
  }

  notKnowPassword(){
    alertify.warning("Şifre işlemleri için yöneticinize başvurunuz");
    alertify.confirm('').set( {title:'Şifre Değiştirme',message:'Lütfen gerekli işlemler için sistem yöneticinize başvurunuz!.',transition:'slide',onok:function(){}});    
    this.bekle();
  }

  bekle(ms = 1000):void {
    var a = Date.now();
    var b;
    a=a+1000;
    do{
      b = Date.now();
      console.log(b);
    }while(b<=a);
  }
}
