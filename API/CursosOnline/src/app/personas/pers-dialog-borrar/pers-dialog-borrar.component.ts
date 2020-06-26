import { Component, OnInit } from '@angular/core';

import { MatDialogRef } from '@angular/material/dialog';
import { ApiPersonasService } from 'src/app/services/apipersonas.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import {Personas} from 'src/app/models/personas';


@Component({
  selector: 'app-pers-dialog-borrar',
  templateUrl: './pers-dialog-borrar.component.html',
  styleUrls: ['./pers-dialog-borrar.component.scss']
})
export class PersDialogBorrarComponent {

  constructor(
    public dialogRef:MatDialogRef<PersDialogBorrarComponent>,
    public apiAlumnos: ApiPersonasService,
    public snackBar: MatSnackBar,

  ) { }

  /*ngOnInit(): void {
  }*/
  close() {
    this.dialogRef.close();
  }
  
}
