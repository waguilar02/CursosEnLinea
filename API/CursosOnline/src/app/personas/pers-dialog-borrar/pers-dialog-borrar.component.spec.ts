import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PersDialogBorrarComponent } from './pers-dialog-borrar.component';

describe('PersDialogBorrarComponent', () => {
  let component: PersDialogBorrarComponent;
  let fixture: ComponentFixture<PersDialogBorrarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PersDialogBorrarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PersDialogBorrarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
