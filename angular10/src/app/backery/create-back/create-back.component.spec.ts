import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateBackComponent } from './create-back.component';

describe('CreateBackComponent', () => {
  let component: CreateBackComponent;
  let fixture: ComponentFixture<CreateBackComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreateBackComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateBackComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
