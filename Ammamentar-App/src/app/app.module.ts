import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { TooltipModule, BsDropdownModule, ModalModule } from 'ngx-bootstrap';

import { CadastroService } from './_services/cadastro.service';

import { AppComponent } from './app.component';
import { CadastrosComponent } from './cadastros/cadastros.component';
import { NavComponent } from './nav/nav.component';
import { CadastroDetalheComponent } from './cadastro-detalhe/cadastro-detalhe.component';
import { CadastroNovoComponent } from './cadastro-novo/cadastro-novo.component';
import { CadastroEditarComponent } from './cadastro-editar/cadastro-editar.component';
import { Route } from '@angular/compiler/src/core';
import { BsDatepickerModule } from 'ngx-bootstrap';

import { DateTimeFormatPipePipe } from './_helps/DateTimeFormatPipe.pipe';


@NgModule({
   declarations: [
      AppComponent,
      CadastrosComponent,
      NavComponent,
      CadastroDetalheComponent,
      CadastroNovoComponent,
      CadastroEditarComponent,
      DateTimeFormatPipePipe
   ],
   imports: [
      BrowserModule,
      BsDropdownModule.forRoot(),
      TooltipModule.forRoot(),
      ModalModule.forRoot(),
      BsDatepickerModule.forRoot(),
      HttpClientModule,
      FormsModule,
      ReactiveFormsModule
   ],
   providers: [
      CadastroService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
