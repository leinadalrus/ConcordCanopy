import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ConcaveFillComponent } from './concave-fill.component';

describe('ConcaveFillComponent', () => {
  let component: ConcaveFillComponent;
  let fixture: ComponentFixture<ConcaveFillComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ConcaveFillComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ConcaveFillComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
