import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { NavbarModule } from './navbar/navbar.module';
import { TabsModule } from './tabs/tabs.module';
import { ContentListModule } from './content-list/content-list.module';
import { ContentInfoModule } from './content-info/content-info.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    NavbarModule,
    TabsModule,
    ContentListModule,
    ContentInfoModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
