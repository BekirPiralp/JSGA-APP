import { Component, OnInit } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import $ from 'jquery';
import { routes } from './app.routes';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  title = 'JSGAFrontend';


  imgUrlString = 'https://www.jsga.edu.tr/kurumlar/jsga.edu.tr/Logo/deneme/jsga_isay_logo_3.png';
  imgFooterUrlString = "https://www.jsga.edu.tr/kurumlar/jsga.edu.tr/Logo/jsga_logo.png";
  
  a="https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/4c2209b1-d571-4cc7-baad-15dbd1cb920a/ddhn5n2-2751ee2b-f95b-4de2-ab72-b5df041ddb78.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzRjMjIwOWIxLWQ1NzEtNGNjNy1iYWFkLTE1ZGJkMWNiOTIwYVwvZGRobjVuMi0yNzUxZWUyYi1mOTViLTRkZTItYWI3Mi1iNWRmMDQxZGRiNzguanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.PfeFUuqZS2S7xyrb9c0dJCYm7qoDfp1MlqmPm1pCtC0";
  background_img1_UrlString = "https://cdn1.ntv.com.tr/gorsel/2Uu5W3bc_kCxBtqljM_auQ.jpg?width=1080&mode=crop&scale=both"
  background_img2_UrlString = "https://e1.pxfuel.com/desktop-wallpaper/84/429/desktop-wallpaper-military-soldier-asker-resmi-thumbnail.jpg";

  schoolIconPath = "../assets/education-1.png";
  aboutIconPath = "../assets/about.png";
  homeIconPath = "../assets/home.png";
  jsgaUrlString = "https://www.jsga.edu.tr/";
  constructor(private router:Router){
    
  }

  ngOnInit(){
  }
  
  public click():void {
    this.router.navigate(["Login"]);
  } 
 
}
