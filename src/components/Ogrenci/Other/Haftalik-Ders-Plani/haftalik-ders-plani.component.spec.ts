import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HaftalikDersPlaniComponent } from './haftalik-ders-plani.component';

describe('HaftalikDersPlaniComponent', () => {
  let component: HaftalikDersPlaniComponent;
  let fixture: ComponentFixture<HaftalikDersPlaniComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HaftalikDersPlaniComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(HaftalikDersPlaniComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
