import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';
import {ApiPersonasService} from 'src/app/services/apipersonas.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import {Personas} from 'src/app/models/personas'

@Component({
  selector: 'app-personas-dialog',
  templateUrl: './personas-dialog.component.html',
  styleUrls: ['./personas-dialog.component.scss']
})
export class PersonasDialogComponent implements OnInit {


  public numeroIdentificacion: number;
  public rol: number;
  public nombres: string;
  public apellidos: string;
  public genero: number;
  public lugarNacimiento: string;
  public edad: number;
  public hobbies: string;




  constructor(
    public dialogRef:MatDialogRef<PersonasDialogComponent>,
        public apiPersonas: ApiPersonasService,
        public snackBar: MatSnackBar,


  ) { }

  ngOnInit(): void {
  }
  close(){
    this.dialogRef.close();
  }
  addPersonas(){
        
    const Persona: Personas = {

      tiposolicitud: 5,
      numeroIdentificacion: this.numeroIdentificacion,
      rol: this.rol,
      nombres: this.nombres,
      apellidos: this.apellidos,
      genero: this.genero,
      lugarNacimiento: this.lugarNacimiento,
      edad: this.edad,
      hobbies: this.hobbies,
      Estado: "Activo",
                   
    };
    
    
    
        this.apiPersonas.  addP(Persona).subscribe(response => {
        if(response.exito == 1){
            this.dialogRef.close();
            this.snackBar.open('Persona registrada con éxito','',{duration:2000})
        }else{
            this.dialogRef.close();
            this.snackBar.open('Persona no pudo ser Registrada','',{duration:2000})
        }
        console.log(response);
    });
}



}
