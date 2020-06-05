import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ClienteComponent } from './cliente/cliente.component';
import { AvaliacaoComponent } from './avaliacao/avaliacao.component';

const routes: Routes = [

{ path: 'cliente', component: ClienteComponent },
{ path: 'avaliacao', component: AvaliacaoComponent }


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
