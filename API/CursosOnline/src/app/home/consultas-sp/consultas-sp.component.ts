import { Component, OnInit } from '@angular/core';
import { ApiPersonasService } from 'src/app/services/apipersonas.service';
import { MatDialog } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import {ConsultaSP} from 'src/app/models/consultasp';


@Component({
  selector: 'app-consultas-sp',
  templateUrl: './consultas-sp.component.html',
  styleUrls: ['./consultas-sp.component.scss']
})
export class ConsultasSPComponent implements OnInit {

  public lst: any[];
  public columnas: string[] = ['Descripcion', "Valor"];
  width: '400';
  
  tiposolicitud: number;
  paramsolicitud: string;



  constructor(
    private apiPersonas: ApiPersonasService,
    public dialog: MatDialog,
    public snackbar: MatSnackBar

  ) { }

  ngOnInit(): void {
  }

  GetPersEdad() {
    const consulta: ConsultaSP = {
      tiposolicitud:1,
      paramsolicitud: "",
    }

    this.apiPersonas.Get_SP(consulta).subscribe(response => {
      this.lst = response.data;
    })
  
  }

}
