import { Component, OnInit } from '@angular/core';
import Swiper from 'swiper';
import { Autoplay, Navigation, Pagination } from 'swiper/modules';
import 'swiper/css';
import 'swiper/css/navigation';
import 'swiper/css/pagination';

@Component({
  selector: 'homeBody',
  templateUrl: './HomeBody.component.html',
  styleUrls: ['./HomeBody.component.css'],
  standalone: true
})
export class HomeBodyComponent implements OnInit {

  swiper:Swiper | null = null;
  constructor() {
    Swiper.use([Navigation,Pagination,Autoplay]);
   }

  ngOnInit() {
    this.swiper = new Swiper('.swiper', {
      // Optional parameters
      direction: 'horizontal',
      loop: true,
    
      // If we need pagination
      pagination: {
        el: '.swiper-pagination',
      },
    
      // Navigation arrows
      navigation: {
        nextEl: '.swiper-button-next',
        prevEl: '.swiper-button-prev',
      },
    
      // And if we need scrollbar
      scrollbar: {
        el: '.swiper-scrollbar',
      },

      autoplay: {
        delay: 3000,
      },
    });
  }

}
