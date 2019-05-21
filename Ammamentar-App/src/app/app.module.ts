import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { CadastrosComponent } from './cadastros/cadastros.component';
import { NavComponent } from './nav/nav.component';
import { CadastroDetalheComponent } from './cadastro-detalhe/cadastro-detalhe.component';
import { CadastroNovoComponent } from './cadastro-novo/cadastro-novo.component';
import { CadastroEditarComponent } from './cadastro-editar/cadastro-editar.component';
import { Route } from '@angular/compiler/src/core';



@NgModule({
   declarations: [
      AppComponent,
      CadastrosComponent,
      NavComponent,
      CadastroDetalheComponent,
      CadastroNovoComponent,
      CadastroEditarComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      FormsModule
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
