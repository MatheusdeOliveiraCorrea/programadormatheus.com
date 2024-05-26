import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AboutComponent } from './about/about.component';
import { AboutMeComponent } from './about-me/about-me.component';
import { InfoComponent } from './info/info.component';



@NgModule({
  declarations: [
    AboutComponent,
    AboutMeComponent,
    InfoComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    AboutComponent,
    AboutMeComponent
  ]
})
export class ContentInfoModule { }
