import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CeinturesLombairesComponent } from './ceintures-lombaires.component';

describe('CeinturesLombairesComponent', () => {
  let component: CeinturesLombairesComponent;
  let fixture: ComponentFixture<CeinturesLombairesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CeinturesLombairesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CeinturesLombairesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
