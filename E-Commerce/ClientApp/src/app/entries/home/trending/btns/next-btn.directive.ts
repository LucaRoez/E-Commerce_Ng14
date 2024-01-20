import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[NextBtn]'
})
export class NextBtnDirective {
  constructor(private elmRef: ElementRef) { }

  @HostListener('click')
  nextFunc() {
    var sliderBody = this.elmRef.nativeElement.parentElement.parentElement.children[0];
    var items = sliderBody.getElementsByClassName("slider-item");
    sliderBody.append(items[0]);
  }
}
