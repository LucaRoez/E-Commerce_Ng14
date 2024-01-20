import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[PrevBtn]'
})
export class PrevBtnDirective {
  constructor(private elmRef: ElementRef) { }

  @HostListener('click')
  prevFunc() {
    var sliderBody = this.elmRef.nativeElement.parentElement.parentElement.children[0];
    var items = sliderBody.getElementsByClassName("slider-item");
    sliderBody.prepend(items[5]);
  }
}
