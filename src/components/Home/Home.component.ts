import { Component, OnInit } from '@angular/core';
import { HomeBodyComponent } from '../HomeBody/HomeBody.component';
import { AboutComponent } from '../About/About.component';
import { LoginComponent } from '../Login/Login.component';
import $ from 'jquery';
import { JsgaYonlendirmeComponent } from '../JsgaYonlendirme/JsgaYonlendirme.component';

@Component({
  selector: 'Home',
  templateUrl: './Home.component.html',
  styleUrls: ['./Home.component.css'],
  imports:[HomeBodyComponent,AboutComponent,LoginComponent,JsgaYonlendirmeComponent],
  standalone: true
})
export class HomeComponent implements OnInit {

  constructor() { }

  ngOnInit() {
    this.Gizle();
    $("homeBody").show();
  }

  
  imgUrlString = 'https://www.jsga.edu.tr/kurumlar/jsga.edu.tr/Logo/deneme/jsga_isay_logo_3.png';
  imgFooterUrlString = "https://www.jsga.edu.tr/kurumlar/jsga.edu.tr/Logo/jsga_logo.png";
  
  a="https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/4c2209b1-d571-4cc7-baad-15dbd1cb920a/ddhn5n2-2751ee2b-f95b-4de2-ab72-b5df041ddb78.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzRjMjIwOWIxLWQ1NzEtNGNjNy1iYWFkLTE1ZGJkMWNiOTIwYVwvZGRobjVuMi0yNzUxZWUyYi1mOTViLTRkZTItYWI3Mi1iNWRmMDQxZGRiNzguanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.PfeFUuqZS2S7xyrb9c0dJCYm7qoDfp1MlqmPm1pCtC0";
  background_img1_UrlString = "https://cdn1.ntv.com.tr/gorsel/2Uu5W3bc_kCxBtqljM_auQ.jpg?width=1080&mode=crop&scale=both"
  background_img2_UrlString = "https://e1.pxfuel.com/desktop-wallpaper/84/429/desktop-wallpaper-military-soldier-asker-resmi-thumbnail.jpg";

  schoolIconPath = "../assets/education-1.png";
  aboutIconPath = "../assets/about.png";
  homeIconPath = "../assets/home.png";
  jsgaUrlString = "https://www.jsga.edu.tr/";

  public click():void {
    //this.router.navigate(["Home","Login"],{relativeTo:this.activatedRoute});
    //location.pathname="Home/Login";
    //location.replace("Home/Login");
    $(".Item").filter(".active").removeClass("active");
    this.Gizle();
    $("login").show();
  } 
 
  public activatedControl(event:Event,str:String|undefined): void{
    //var locUrl = location.pathname;
    $(".Item").filter(".active").removeClass("active");
    this.Gizle();

    if(str !== undefined){
      switch(str){
        case 'Hakkinda':
            $("#Hakkinda").addClass("active");
            $("about").show();
        break;
        case 'Anasayfa':
          $("#Anasayfa").addClass("active");
          $("homeBody").show();
          break;
        case 'JSGA':
          $("#JSGA").addClass("active");
          $("jsgaYonlendirme").show();
          break;
        default:
          break;
      }
    }
  }

  private Gizle():void{
    $("about").hide();
    $("login").hide();
    $("jsgaYonlendirme").hide();
    $("homeBody").hide();
  }
}
