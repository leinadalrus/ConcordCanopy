import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ArticleComponent } from './article/article.component';
import { NavmenuComponent } from './components/navmenu/navmenu.component';
import { CardComponent } from './components/card/card.component';
import { ConcaveFillComponent } from './layouts/concave-fill/concave-fill.component';
import { NeumorfFrameComponent } from './templates/neumorf-frame/neumorf-frame.component';
import { NeusladderComponent } from './templates/neusladder/neusladder.component';

@NgModule({
  declarations: [
    AppComponent,
    ArticleComponent,
    NavmenuComponent,
    CardComponent,
    ConcaveFillComponent,
    NeumorfFrameComponent,
    NeusladderComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
