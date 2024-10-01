import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ArticleComponent } from './home/components/article/article.component';
import { AboutMeComponent } from './about_me/components/about-me/about-me.component';
import { ContactsComponent } from './contact/components/contacts/contacts.component';

const routes: Routes = [
  {path: '', redirectTo: '/home', pathMatch: 'full'},
  {path: 'home', component: ArticleComponent},
  {path: 'about', component: AboutMeComponent},
  {path: 'contact', component: ContactsComponent},

  {path: '**', redirectTo: '/home'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
