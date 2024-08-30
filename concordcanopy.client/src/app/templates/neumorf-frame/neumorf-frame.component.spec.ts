import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NeumorfFrameComponent } from './neumorf-frame.component';

describe('NeumorfFrameComponent', () => {
  let component: NeumorfFrameComponent;
  let fixture: ComponentFixture<NeumorfFrameComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [NeumorfFrameComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NeumorfFrameComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
