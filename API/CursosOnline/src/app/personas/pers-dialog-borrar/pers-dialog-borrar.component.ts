import { Component, OnInit, Inject } from '@angular/core';

import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ApiPersonasService } from 'src/app/services/apipersonas.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import {Personas} from 'src/app/models/personas';


@Component({
  selector: 'app-pers-dialog-borrar',
  templateUrl: './pers-dialog-borrar.component.html',
  styleUrls: ['./pers-dialog-borrar.component.scss']
})
export class PersDialogBorrarComponent {
    
  public numeroIdentificacion: number;



  constructor(
    public dialogRef:MatDialogRef<PersDialogBorrarComponent>,
    public apiPersonas: ApiPersonasService,
    public snackBar: MatSnackBar,
    @Inject(MAT_DIALOG_DATA) public personas:Personas //inyeccion de la propiedad personas

  ) { 
    this.numeroIdentificacion = personas.numeroIdentificacion;

  }

  ngOnInit(): void {
  
  
  }
  close() {
    this.dialogRef.close();
  }

  
borrarPersonas(){ 
        
  const Persona: Personas = {

    tiposolicitud: 2,
    numeroIdentificacion: this.numeroIdentificacion,
    rol: null,
    nombres: null,
    apellidos: null,
    genero: null,
    lugarNacimiento: null,
    edad: null,
    hobbies: null,
    Estado: "Borrado",
                 
  };
   
  console.log(Persona);
  
  
      this.apiPersonas.editPBorrar(Persona).subscribe(response => {
        console.log(Persona);
        
        if(response.exito == 1){
          this.dialogRef.close();
          this.snackBar.open('Persona Borrada con éxito','',{duration:2000})
      }else{
          this.dialogRef.close();
          this.snackBar.open('Persona no pudo ser Borrada','',{duration:2000})
      }
      console.log(response);
      console.log(response.exito);
  });
}


  
}
