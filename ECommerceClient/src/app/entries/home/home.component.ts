import { Component } from '@angular/core';

@Component({
  selector: 'home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  carouselImages: CarouselImages[] = [
    {
      src: "home-carousel-male.png",
      alt: "menswear kind",
      title: "Minimal Men Style",
      description: "Consectetur enim commodo eiusmod excepteur pariatur amet ad adipisicing dolor. Culpa in ex quis aliqua deserunt dolor fugiat Lorem sunt ex ipsum. Occaecat consequat aliquip exercitation reprehenderit reprehenderit sint."
    },

    {
      src: "home-carousel-female.png",
      alt: "feminine fashion kind",
      title: "Minimal Ladies Style",
      description: "Velit qui est adipisicing excepteur ut ullamco labore pariatur proident. Nulla anim enim aliquip qui voluptate in velit minim commodo qui ad occaecat dolore. Ex proident laborum nisi exercitation aliquip."
    }
  ]

  cardImages: CardImages[] = [
    {
      src: "home-card-male.png",
      alt: "male more popular garment",
      text: "Men's Fashion"
    },

    {
      src: "home-card-female.png",
      alt: "female more popular garment",
      text: "Women's Fashion"
    },

    {
      src: "home-card-baby.png",
      alt: "baby more popular garment",
      text: "Baby Fashion"
    }
  ]
}

class CarouselImages {
  src: string = "";
  alt: string = "";
  title: string = "";
  description: string = "";
}

class CardImages {
  src: string = "";
  alt: string = "";
  text: string = "";
  
}
