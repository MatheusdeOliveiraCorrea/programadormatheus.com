import { Component } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrl: './nav-bar.component.css'
})
export class NavBarComponent {

constructor(private translate: TranslateService){}

switchLanguage(language: string) {
  this.translate.use(language);
  localStorage.setItem('language', language);
}

}
