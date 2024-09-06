import { NgModule } from '@angular/core';
import { RouterModule, Routes, withDebugTracing } from '@angular/router';
import { AppComponent } from './app.component';
import { ArticleDetailComponent } from './article-detail/article-detail.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'article', component: ArticleDetailComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, { enableTracing: false })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
