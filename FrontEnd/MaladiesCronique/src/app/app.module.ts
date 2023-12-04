import { AuthModule } from './components/auth/auth.module';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PrimeNGModules } from './configs/primeng-dependencies';
import { HttpClientModule } from '@angular/common/http';
import { HomeComponent } from './layouts/home/home.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule ,ReactiveFormsModule } from '@angular/forms';

@NgModule({
 
  imports: [
    BrowserModule,
    CommonModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    ...PrimeNGModules,
    FormsModule,
    ReactiveFormsModule ,
  ],
  declarations: [
    AppComponent,
    HomeComponent,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
