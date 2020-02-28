import { TestBed } from '@angular/core/testing';

import { DataServiceService } from './data-service.service';

describe('DataServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: DataServiceService = TestBed.get(DataServiceService);
    expect(service).toBeTruthy();
  });

  it('should receive data', () => {
    const service: DataServiceService = TestBed.get(DataServiceService);
    expect(service.getListMedia).toBeDefined();
  });

});
