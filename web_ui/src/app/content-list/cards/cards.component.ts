import { Component, OnInit } from '@angular/core';
import { ArticleServiceService } from '../article.service.service';
import { Card } from 'src/app/models/card';

@Component({
  selector: 'app-cards',
  templateUrl: './cards.component.html',
  styleUrls: ['./cards.component.css']
})
export class CardsComponent implements OnInit {

  cards: Card[] = [];

  constructor(private cardsService: ArticleServiceService){

  }
  ngOnInit(): void {
    this.cards = this.cardsService.articles;
  }



}
