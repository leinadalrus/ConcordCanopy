import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NeusladderComponent } from './neusladder.component';

describe('NeusladderComponent', () => {
  let component: NeusladderComponent;
  let fixture: ComponentFixture<NeusladderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [NeusladderComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NeusladderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
