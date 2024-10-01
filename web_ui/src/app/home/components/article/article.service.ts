import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ArticleService {

  private apiUrl = 'http://34.205.53.74/article';

  constructor(private http: HttpClient) { }

  getArticles(): Observable<any>{
    return this.http.get(this.apiUrl);
  }
}
