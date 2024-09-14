import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import {MatCardModule} from '@angular/material/card';
import {MatChipsModule} from '@angular/material/chips';
import { ArticleComponent } from './home/components/article/article.component';
import { AboutMeComponent } from './about_me/components/about-me/about-me.component';
import {MatGridListModule} from '@angular/material/grid-list';
import {MatToolbarModule} from '@angular/material/toolbar';
import { NavBarComponent } from './shared/nav-bar/nav-bar.component';
import { ContactsComponent } from './contact/components/contacts/contacts.component';
import { FooterComponent } from './shared/footer/footer.component';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { TranslateModule, TranslateLoader } from '@ngx-translate/core';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';

export function HttpLoaderFactory(http: HttpClient) {
  return new TranslateHttpLoader(http, './assets/i18n/', '.json');
}

@NgModule({
  declarations: [
    AppComponent,
    ArticleComponent,
    AboutMeComponent,
    NavBarComponent,
    ContactsComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatCardModule,
    MatChipsModule,
    MatGridListModule,
    MatToolbarModule,
    HttpClientModule,
    TranslateModule.forRoot({
      loader: {
        provide: TranslateLoader,
        useFactory: HttpLoaderFactory,
        deps: [HttpClient]
      }
    })
  ],
  providers: [
    provideAnimationsAsync()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
