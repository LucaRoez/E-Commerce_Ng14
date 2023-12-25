import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainBodyComponent } from './main-body/main-body.component';
import { NavigatorsComponent } from './navigators/navigators.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path: '', component: MainBodyComponent, pathMatch: 'full' },
  { path: 'navigators', component: NavigatorsComponent, pathMatch: 'full' },
  { path: 'home', component: HomeComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
