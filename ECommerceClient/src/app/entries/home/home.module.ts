import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NgbCarouselModule } from '@ng-bootstrap/ng-bootstrap';
import { HomeComponent } from './home.component';
import { TrendingComponent } from './trending/trending.component';
import { LatestComponent } from './latest/latest.component';
import { SuggestedComponent } from './suggested/suggested.component';
import { TestimonialsComponent } from './testimonials/testimonials.component';
import { NextBtnDirective } from './trending/btns/next-btn.directive';
import { PrevBtnDirective } from './trending/btns/prev-btn.directive';

@NgModule({
  declarations: [
    HomeComponent,
    TrendingComponent,
    LatestComponent,
    SuggestedComponent,
    TestimonialsComponent,
    NextBtnDirective,
    PrevBtnDirective
  ],
  imports: [
    CommonModule,
    NgbCarouselModule
  ],
  exports: [
    HomeComponent
  ]
})
export class HomeModule { }
