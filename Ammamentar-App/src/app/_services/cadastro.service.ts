import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Pessoa } from '../_models/Pessoa';

@Injectable({
  providedIn: 'root'
})
export class CadastroService {
baseURL = 'http://localhost:5000/api/pessoa';
constructor(private Http: HttpClient) { }

  getAllCadastro(): Observable<Pessoa[]> {
    return this.Http.get<Pessoa[]>(this.baseURL);
  }

  getCadastroByNome(nome: string): Observable<Pessoa[]> {
    return this.Http.get<Pessoa[]>(`${this.baseURL}/getByNome/${nome}`);
  }

  getCadastroById(id: number): Observable<Pessoa> {
    return this.Http.get<Pessoa>(`${this.baseURL}/${id}`);
  }

}
