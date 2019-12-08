import { Injectable, Injector } from '@angular/core';
import { ServiceBase } from '../shared/base/service.base';

@Injectable({
  providedIn: 'root'
})
export class PalestraService extends ServiceBase {
  constructor(injector: Injector) {
    super(injector, 'palestra');
  }

  find = (body: any) => this.get('consulta-simples');
}
