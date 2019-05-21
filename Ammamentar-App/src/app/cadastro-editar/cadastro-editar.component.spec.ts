import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastroEditarComponent } from './cadastro-editar.component';

describe('CadastroEditarComponent', () => {
  let component: CadastroEditarComponent;
  let fixture: ComponentFixture<CadastroEditarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CadastroEditarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CadastroEditarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
