import { Component, OnInit, TemplateRef } from '@angular/core';
import { CadastroService } from '../_services/cadastro.service';
import { Pessoa } from '../_models/Pessoa';
import { BsModalRef, BsModalService } from 'ngx-bootstrap';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-cadastros',
  templateUrl: './cadastros.component.html',
  styleUrls: ['./cadastros.component.css']
})
export class CadastrosComponent implements OnInit {
  
  
  ngOnInit() {
    this.getCadastros(); // chamando o metodo cadastro.
    
  
  // vai ser chamado antes do metodo ser execultado
  }
  cadastrosFiltrados: Pessoa[];
  cadastros: Pessoa[] = [];
  registerForm: FormGroup;
  
  _filtroLista: string;
  
  constructor(
    private cadastroService: CadastroService
  , private modalService: BsModalService,
    private fb: FormBuilder
    ) { }
  
    get filtroLista(): string{
    return this._filtroLista;
  }
  
  set filtroLista(values: string){
    this._filtroLista = values;
    this.cadastrosFiltrados = this.filtroLista ? this.filtraCadastros(this.filtroLista) :this.cadastros;
  }
  
  openModal(template: any){
    template.show();
  }
  
  filtraCadastros(filtrarPor: string): Pessoa[] {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.cadastros.filter(
      cadastro => cadastro.nome.toLocaleLowerCase().indexOf(filtrarPor) !== - 1
      );
    }

      // Validação do formulario
    validtion(){
      this.registerForm = this.fb.group({
        nome: ['', [Validators.required, Validators.minLength(10), Validators.maxLength(100)]],
        email: ['', [Validators.required, Validators.email]],
        senha: ['', Validators.required],
        cpf: ['', Validators.required],
        rg: ['', Validators.required],
        telefone: ['', Validators.required],
        celular: ['', Validators.required],
        dataCadastro: ['', Validators.required]
      });
    }
    
    salvarAlteracao(){

    }
    
    // Fazendo uma chamada get na Api Web
    getCadastros(){
      this.cadastroService.getAllCadastro().subscribe(
        (_cadastros: Pessoa[])  => {
          this.cadastros = _cadastros;
          console.log(_cadastros);
        }, error => {
          console.log(error);
        }
        );
      }
      
    }
    