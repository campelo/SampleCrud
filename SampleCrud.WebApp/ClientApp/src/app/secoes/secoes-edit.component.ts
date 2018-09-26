import { Component, OnInit } from '@angular/core';
import { ISecao, Secao } from './dto/secao.dto';
import { SecoesService } from './secoes.service';
import { ActivatedRoute, Router } from '@angular/router';
import { THROW_IF_NOT_FOUND } from '@angular/core/src/di/injector';

@Component({
  selector: 'app-secoes-edit',
  templateUrl: './secoes-edit.component.html'
})
export class SecoesEditComponent implements OnInit {
  public secao: ISecao;
  public isNew = true;

  constructor(private _secoesService: SecoesService,
    private _activatedRoute: ActivatedRoute,
    private _router: Router) {
  }

  ngOnInit(): void {
    const id = this._activatedRoute.snapshot.params['id'];
    if (id) {
      this.isNew = false;
      this._secoesService.get(+this._activatedRoute.snapshot.params['id'])
        .subscribe(sec => {
          this.secao = sec;
        });
    } else {
      this.isNew = true;
      this.secao = new Secao();
    }
  }

  public cancel() {
    this._router.navigate(['/secoes']);
  }

  public save(formValues) {
    if (this.isNew) {
      this._secoesService.create(formValues);
    } else {
      this._secoesService.update(formValues.id, formValues);
    }
    this._router.navigate(['/secoes']);
  }
}
