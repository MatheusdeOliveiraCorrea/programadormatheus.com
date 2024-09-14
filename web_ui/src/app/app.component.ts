import { Component } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {

  constructor(private translate: TranslateService){

    const savedLanguage = localStorage.getItem('language') || 'pt';

    this.translate.setDefaultLang(savedLanguage);
  }
}
