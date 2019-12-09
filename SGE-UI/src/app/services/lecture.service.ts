import { Injectable, Injector } from '@angular/core';
import { ServiceBase } from '../shared/base/service.base';

@Injectable({
  providedIn: 'root'
})
export class LectureService extends ServiceBase {
  constructor(injector: Injector) {
    super(injector, 'palestra');
  }

  add = (data: any) => this.post(data);

  find = (body: any) => this.get('consulta-simples');

  remove(body: any) {
    const { aggregateId } = body;
    body = { ...body, ativo: false };

    return this.put(`${aggregateId}`, body);
  }
}
