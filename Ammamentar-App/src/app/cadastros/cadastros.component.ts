import { Component, OnInit } from '@angular/core';
import { CadastroService } from '../_services/cadastro.service';
import { Pessoa } from '../_models/Pessoa';

@Component({
  selector: 'app-cadastros',
  templateUrl: './cadastros.component.html',
  styleUrls: ['./cadastros.component.css']
})
export class CadastrosComponent implements OnInit {

  cadastrosFiltrados: Pessoa[];
  cadastros: Pessoa[] = [];
  _filtroLista: string;
  get filtroLista(): string{
    return this._filtroLista;
  }

  set filtroLista(values: string){
      this._filtroLista = values;
      this.cadastrosFiltrados = this.filtroLista ? this.filtraCadastros(this.filtroLista) :this.cadastros;
  }


  constructor(private cadastroService: CadastroService) { }

  // vai ser chamado antes do metodo ser execultado
  ngOnInit() {
    this.getCadastros(); // chamando o metodo cadastro.

  }

  filtraCadastros(filtrarPor: string): Pessoa[] {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.cadastros.filter(
      cadastro => cadastro.nome.toLocaleLowerCase().indexOf(filtrarPor) !== - 1
    );
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
