import { NgModule } from '@angular/core';
import { SecoesViewComponent } from './secoes-view.component';
import { SecoesEditComponent } from './secoes-edit.component';
import { SecoesRoutingModule } from './secoes-routing.module';
import { SecoesService } from './secoes.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@NgModule({
  imports: [
    SecoesRoutingModule,
    CommonModule,
    FormsModule
  ],
  declarations: [
    SecoesViewComponent,
    SecoesEditComponent
  ],
  providers: [
    SecoesService
  ]
})
export class SecoesModule {

}
