import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MatSidenavModule } from '@angular/material/sidenav';
import { MatDialogModule } from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { HomeComponent } from './home/home.component';
import { CursosComponent } from './cursos/cursos.component';
import { PersonasComponent } from './personas/personas.component';

import { HttpClientModule } from '@angular/common/http';
import { MatTableModule } from '@angular/material/table';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { FormsModule } from '@angular/forms';
import {MatDatepickerModule} from '@angular/material/datepicker';
import { PersonasDialogComponent } from './personas/personas-dialog/personas-dialog.component';
import { PersDialogBorrarComponent } from './personas/pers-dialog-borrar/pers-dialog-borrar.component';








@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    PersonasComponent,
    CursosComponent,
    PersonasDialogComponent,
    PersDialogBorrarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatSidenavModule,
    MatTableModule,
    MatInputModule,
    MatButtonModule,
    MatDialogModule,
    MatSnackBarModule,
    FormsModule,
    MatDatepickerModule,
    

    HttpClientModule


   
  
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
