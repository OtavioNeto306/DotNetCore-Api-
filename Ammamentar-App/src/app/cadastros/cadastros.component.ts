import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-cadastros',
  templateUrl: './cadastros.component.html',
  styleUrls: ['./cadastros.component.css']
})
export class CadastrosComponent implements OnInit {

  cadastros: any = [];
  _filtroLista: string;
  get filtroLista(): string{
    return this._filtroLista;
  }

  set filtroLista(values: string){
      this._filtroLista = values;
      this.cadastrosFiltrados = this.filtroLista ? this.filtraCadastros(this.filtroLista) :this.cadastros;
  }

  cadastrosFiltrados: any = [];

  constructor(private http: HttpClient) { }

  // vai ser chamado antes do metodo ser execultado
  ngOnInit() {
    this.getCadastros(); // chamando o metodo cadastro.

  }

  filtraCadastros(filtrarPor: string): any {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.cadastros.filter(
      cadastro => cadastro.nome.toLocaleLowerCase().indexOf(filtrarPor) !== - 1
    );
  }

  // Fazendo uma chamada get na Api Web
  getCadastros(){
    this.http.get('http://localhost:5000/api/values').subscribe(response  => {
        this.cadastros = response;
        console.log(response);
      }, error => {
        console.log(error);
      }
    );
  }

}
