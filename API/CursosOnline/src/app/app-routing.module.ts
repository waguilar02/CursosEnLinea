import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { CursosComponent } from './cursos/cursos.component';
import { PersonasComponent } from './personas/personas.component';
import {ConsultasSPComponent} from './home/consultas-sp/consultas-sp.component';

const routes: Routes = [

  {path: '',redirectTo: '/home',pathMatch: 'full'},
  {path: 'home', component: HomeComponent},
  {path: 'cursos', component: CursosComponent},
  {path: 'personas', component: PersonasComponent},
  {path: 'consultas',component: ConsultasSPComponent},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
