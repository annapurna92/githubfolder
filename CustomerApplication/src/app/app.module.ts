import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent, Appcomponent1 } from './app.component';

@NgModule({
  declarations: [ AppComponent,Appcomponent1],
  imports: [BrowserModule ],
  providers: [],
  bootstrap: [AppComponent, Appcomponent1]
})
export class AppModule { }
