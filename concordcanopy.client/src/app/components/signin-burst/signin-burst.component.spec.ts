import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SigninBurstComponent } from './signin-burst.component';

describe('SigninBurstComponent', () => {
  let component: SigninBurstComponent;
  let fixture: ComponentFixture<SigninBurstComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [SigninBurstComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SigninBurstComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
