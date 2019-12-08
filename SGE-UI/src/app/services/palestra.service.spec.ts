import { TestBed } from '@angular/core/testing';

import { PalestraService } from './palestra.service';

describe('PalestraService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: PalestraService = TestBed.get(PalestraService);
    expect(service).toBeTruthy();
  });
});
