import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Response } from '../models/response';
import { Personas } from '../models/personas';
import { Cursos } from '../models/cursos';



const httpOption = {
    headers: new HttpHeaders({
      'contend-Type': 'application/json'
    })
  
  };
  
  @Injectable({
    providedIn: 'root'
  })
  export class ApiPersonasService {
  
   
    urlPersonas: string = 'https://localhost:44301/api/personas'; 
  
    constructor(
      private _http: HttpClient
  
    ) { }
    getpersonas(): Observable<Response> {
      return this._http.get<Response>(this.urlPersonas);
    }

     
  addP(personas: Personas): Observable<Response> {
    return this._http.post<Response>(this.urlPersonas, personas, httpOption)//
  }
  

    
    editPBorrar(personas: Personas): Observable<Response> {
      return this._http.put<Response>(this.urlPersonas, personas, httpOption)//
    }
  
    /*borrarP(personas: Personas): Observable<Response> {
      return this._http.put<Response>(this.urlPersonas, personas, httpOption)//
    }*/
    
 
  
  }
  