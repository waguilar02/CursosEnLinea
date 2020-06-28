import { Component, OnInit } from '@angular/core';

import { ApiPersonasService } from '../services/apipersonas.service';
import { MatDialog } from '@angular/material/dialog';
import { PersonasDialogComponent } from './personas-dialog/personas-dialog.component';
import { Personas } from '../models/personas';
import { PersDialogBorrarComponent } from './pers-dialog-borrar/pers-dialog-borrar.component';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-personas',
  templateUrl: './personas.component.html',
  styleUrls: ['./personas.component.scss']
})
export class PersonasComponent implements OnInit {

  public lst: any[];
  public columnas: string[] = ['numeroIdentificacion', "Nombres", "Apellidos", "Hobbies", "Actions"];
  width: '400';


  constructor(
    private apiPersonas: ApiPersonasService,
    public dialog: MatDialog,
    public snackbar: MatSnackBar

  ) { }

  ngOnInit(): void {

  }

  getPersonas() {
    this.apiPersonas.getpersonas().subscribe(response => {
      this.lst = response.data;
      console.log(response);
    })

  }

  openAddPersona() {
    const dialogRef = this.dialog.open(PersonasDialogComponent, {
      width: this.width
    });
  }

  openEditPersona(persona: Personas) {
    const dialogRef = this.dialog.open(PersonasDialogComponent, { //Ventana de Dialogo editar persona
      width: this.width,
      data: persona
    });
    dialogRef.afterClosed().subscribe(result => {
      this.getPersonas();
    });

  }

  borrarPersona(persona: Personas) {

    const dialogRef = this.dialog.open(PersDialogBorrarComponent, {
      width: this.width,
      data: persona
      
    });

    console.log(persona);
  

    dialogRef.afterClosed().subscribe(result => {
      
      


      this.getPersonas();
    });
    //console.log(persona);

    /* 
    dialogRef.afterClosed().subscribe(result => {
   
      
      if (result) {
        
        this.apiPersonas.editPBorrar(persona).subscribe(response => {
          if (response.exito === 1) {
            this.snackbar.open('Persona Borrada Con exito', '', { duration: 2000 });
            this.getPersonas();
          }

        })

      }
      

    });

    */


  }

}
