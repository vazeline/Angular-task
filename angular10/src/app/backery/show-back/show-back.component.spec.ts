import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowBackComponent } from './show-back.component';

describe('ShowBackComponent', () => {
  let component: ShowBackComponent;
  let fixture: ComponentFixture<ShowBackComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ShowBackComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowBackComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
