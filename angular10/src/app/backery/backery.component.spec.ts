import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BackeryComponent } from './backery.component';

describe('BackeryComponent', () => {
  let component: BackeryComponent;
  let fixture: ComponentFixture<BackeryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BackeryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BackeryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
