import { Injectable } from '@angular/core';
import { Secao } from './dto/secao.dto';
import 'rxjs/add/observable/throw';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import { ServiceBase } from '../common/service.base';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class SecoesService extends ServiceBase<Secao> {

  constructor(protected _httpClient: HttpClient) {
    super(_httpClient);
  }

  protected doGetRoute() {
    return '/api/sessions';
  }

}
