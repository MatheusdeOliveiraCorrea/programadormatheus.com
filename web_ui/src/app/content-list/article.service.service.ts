import { Injectable } from '@angular/core';
import { Card } from '../models/card';

@Injectable({
  providedIn: 'root'
})
export class ArticleServiceService {

  articles: Card[] = [];

  constructor() 
  { 
    this.articles = [
      new Card(1, 'Por que .NET é foda?', '.NET is the free, open-source, cross-platform framework for building modern apps and powerful cloud services....', ''),
      new Card(2, 'Por que Goiás deveria ser um país?', 'Goiás é uma das 27 unidades federativas do Brasil. Situa-se na Região Centro-Oeste do país, no Planalto Central brasileiro...', '')
    ]
  }
}
