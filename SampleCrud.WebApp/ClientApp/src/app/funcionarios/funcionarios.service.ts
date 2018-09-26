import { Injectable } from '@angular/core';
import 'rxjs/add/observable/throw';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import { ServiceBase } from '../common/service.base';
import { HttpClient } from '@angular/common/http';
import { Funcionario } from './dto/funcionario.dto';

@Injectable()
export class SecoesService extends ServiceBase<Funcionario> {

  constructor(protected _httpClient: HttpClient) {
    super(_httpClient);
  }

  protected doGetRoute() {
    return '/api/employees';
  }

}
