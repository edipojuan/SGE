import { TestBed } from '@angular/core/testing';

import { PalestranteService } from './palestrante.service';

describe('PalestranteService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: PalestranteService = TestBed.get(PalestranteService);
    expect(service).toBeTruthy();
  });
});
