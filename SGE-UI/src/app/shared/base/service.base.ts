import { Injector } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { environment } from 'src/environments/environment';

import * as moment from 'moment';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

export abstract class ServiceBase {
  protected httpClient: HttpClient;
  protected urlBase = environment.sge_api;

  constructor(injector: Injector, controllerName: string, urlBase?: string) {
    this.httpClient = injector.get(HttpClient);

    if (urlBase) {
      this.urlBase = urlBase;
    }

    if (controllerName) {
      this.urlBase = `${this.urlBase}/${controllerName}`;
    }
  }

  get(url?: string, params?: any) {
    params = this.buildQueryParams(params);

    return this.httpClient.get(this.getUrl(url), params);
  }

  post(url: string, body: any) {
    body = JSON.stringify(body);

    return this.httpClient.post<any>(this.getUrl(url), body, httpOptions);
  }

  put(url: string, body: any) {
    body = JSON.stringify(body);

    return this.httpClient.put<any>(this.getUrl(url), body, httpOptions);
  }

  delete(url: string, id: any) {
    url = `${this.getUrl(url)}/${id}`;

    return this.httpClient.delete<any>(url, httpOptions);
  }

  getUrl = (url: string) => (url ? `${this.urlBase}/${url}` : this.urlBase);

  buildQueryParams(model: any) {
    if (!model) {
      return;
    }

    const urlSearchParams = new URLSearchParams();
    Object.keys(model).map((key) => {
      if (
        (model[key] || typeof model[key] === 'boolean') &&
        model[key] !== 'undefined'
      ) {
        if (model[key] instanceof Array) {
          if (key === 'periodo' && model[key].length > 1) {
            urlSearchParams.append(
              `${key}.inicio`,
              moment(model[key][0]).format('YYYY-MM-DD')
            );
            urlSearchParams.append(
              `${key}.fim`,
              moment(model[key][1]).format('YYYY-MM-DD')
            );
          }
        } else if (model[key] instanceof Date) {
          urlSearchParams.append(key, moment(model[key]).format('YYYY-MM-DD'));
        } else if (model[key].length === 10) {
          if (moment(model[key], 'DD/MM/YYYY', true).isValid()) {
            urlSearchParams.append(
              key,
              moment(model[key], 'DD/MM/YYYY').format('YYYY-MM-DD')
            );
          } else {
            urlSearchParams.append(key, model[key]);
          }
        } else {
          urlSearchParams.append(key, model[key]);
        }
      }
    });
    return urlSearchParams.toString();
  }
}
