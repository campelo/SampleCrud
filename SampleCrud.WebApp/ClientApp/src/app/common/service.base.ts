import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';

export abstract class ServiceBase<TDto> {
  constructor(protected _httpClient: HttpClient) {
  }

  protected abstract doGetRoute();

  public create(request: TDto): Observable<TDto> {
    return this._httpClient.post<TDto>(this.doGetRoute(), request);
  }

  public update(id: any, request: TDto): Observable<TDto> {
    return this._httpClient.put<TDto>(this.doGetRoute() + '/' + id, request);
  }

  public delete(id: number): Observable<{}> {
    return this._httpClient.delete(this.doGetRoute() + '/' + id);
  }

  public get(id: any): Observable<TDto> {
    return this._httpClient.get<TDto>(this.doGetRoute() + '/' + id);
  }

  public getAll(): Observable<TDto[]> {
    return this._httpClient.get<TDto[]>(this.doGetRoute());
  }
}
