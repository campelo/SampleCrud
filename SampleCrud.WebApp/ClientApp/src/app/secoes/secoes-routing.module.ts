import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { SecoesViewComponent } from './secoes-view.component';
import { SecoesEditComponent } from './secoes-edit.component';

const routes = [
  { path: '', redirectTo: 'list', pathMatch: 'full'},
  { path: 'list', component: SecoesViewComponent, children: []},
  { path: 'edit', component: SecoesEditComponent, children: []},
  { path: 'edit/:id', component: SecoesEditComponent, children: []}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SecoesRoutingModule {

}
