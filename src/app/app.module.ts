import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { NavigatorsComponent } from './navigators/navigators.component';
import { MainBodyComponent } from './main-body/main-body.component';
import { HomeComponent } from './home/home.component';
import { TrendingComponent } from './home/trending/trending.component';
import { TestimonialsComponent } from './home/testimonials/testimonials.component';
import { SuggestedComponent } from './home/suggested/suggested.component';
import { LatestComponent } from './home/latest/latest.component';

@NgModule({
  declarations: [
    AppComponent,
    NavigatorsComponent,
    MainBodyComponent,
    HomeComponent,
    TrendingComponent,
    TestimonialsComponent,
    SuggestedComponent,
    LatestComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
