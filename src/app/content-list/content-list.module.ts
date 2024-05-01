import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CardsComponent } from './cards/cards.component';
import {MatCardModule} from '@angular/material/card';
import {MatChipsModule} from '@angular/material/chips';

@NgModule({
  declarations: [
    CardsComponent
  ],
  imports: [
    CommonModule,
    MatCardModule,
    MatChipsModule
  ],
  exports: [
    CardsComponent
  ]
})
export class ContentListModule { }
