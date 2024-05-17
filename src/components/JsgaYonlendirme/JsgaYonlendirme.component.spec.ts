/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { JsgaYonlendirmeComponent } from './JsgaYonlendirme.component';

describe('JsgaYonlendirmeComponent', () => {
  let component: JsgaYonlendirmeComponent;
  let fixture: ComponentFixture<JsgaYonlendirmeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ JsgaYonlendirmeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(JsgaYonlendirmeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
