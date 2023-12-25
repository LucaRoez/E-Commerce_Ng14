import { Component } from '@angular/core';

@Component({
  selector: 'home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
  images: ImageKeeper[] = [

    {
      src: "assets/img/home-carousel-male.png",
      alt: "menswear kind",
      title: "Minimal Men Style",
      description: "Consectetur enim commodo eiusmod excepteur pariatur amet ad adipisicing dolor. Culpa in ex quis aliqua deserunt dolor fugiat Lorem sunt ex ipsum. Occaecat consequat aliquip exercitation reprehenderit reprehenderit sint."
    },

    {
      src: "assets/img/home-carousel-female.png",
      alt: "feminine fashion kind",
      title: "Minimal Ladies Style",
      description: "Velit qui est adipisicing excepteur ut ullamco labore pariatur proident. Nulla anim enim aliquip qui voluptate in velit minim commodo qui ad occaecat dolore. Ex proident laborum nisi exercitation aliquip. In laborum labore minim esse incididunt eiusmod exercitation ea sint. Lorem esse excepteur laborum labore. Ex quis eu veniam adipisicing."
    }

  ]

}

export class ImageKeeper {
  src: string = "";
  alt: string = "";
  title: string = "";
  description: string = "";
}
