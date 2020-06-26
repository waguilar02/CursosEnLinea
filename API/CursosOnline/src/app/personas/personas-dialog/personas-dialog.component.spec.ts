import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonasDialogComponent } from './personas-dialog.component';

describe('PersonasDialogComponent', () => {
  let component: PersonasDialogComponent;
  let fixture: ComponentFixture<PersonasDialogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PersonasDialogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PersonasDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
