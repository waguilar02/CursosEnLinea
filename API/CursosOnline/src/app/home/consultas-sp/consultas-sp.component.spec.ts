import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ConsultasSPComponent } from './consultas-sp.component';

describe('ConsultasSPComponent', () => {
  let component: ConsultasSPComponent;
  let fixture: ComponentFixture<ConsultasSPComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ConsultasSPComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ConsultasSPComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
