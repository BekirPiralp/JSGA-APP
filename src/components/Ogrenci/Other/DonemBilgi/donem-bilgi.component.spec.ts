import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DonemBilgiComponent } from './donem-bilgi.component';

describe('DonemBilgiComponent', () => {
  let component: DonemBilgiComponent;
  let fixture: ComponentFixture<DonemBilgiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DonemBilgiComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DonemBilgiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
