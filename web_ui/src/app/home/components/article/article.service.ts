import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ArticleService {

  private apiUrl = 'https://zyii3bhr5l.execute-api.us-east-1.amazonaws.com/Prod/article';

  constructor(private http: HttpClient) { }

  getArticles(): Observable<any>{
    return this.http.get(this.apiUrl);
  }
}
