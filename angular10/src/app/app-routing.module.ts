import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import {BackeryComponent} from './backery/backery.component';


const routes: Routes = [{path:'',component:BackeryComponent},];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
