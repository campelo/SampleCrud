import { Component, OnInit } from '@angular/core';
import { ISecao } from './dto/secao.dto';
import { Router } from '@angular/router';


@Component({
  selector: 'app-secoes-view',
  templateUrl: './secoes-view.component.html'
})
export class SecoesViewComponent implements OnInit {
  public secoes: ISecao[];

  constructor(private _router: Router) {
  }

  ngOnInit(): void {
    this.secoes = [];
  }

  public create() {
    this._router.navigate(['/secoes/edit']);
  }
}
