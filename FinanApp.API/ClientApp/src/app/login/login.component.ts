import { Component, OnInit } from '@angular/core';
import { Usuario } from '../model/usuario';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls:['./login.component.css']
})

export class LoginComponent implements OnInit {
    public usuario;
    public usuarioAutenticado : boolean;

    constructor() {
        this.usuario = new Usuario();
    }

    login(){
        if(this.usuario.email == 'matheuspr96@hotmail.com' && this.usuario.senha == '@Qwerty1'){
            this.usuarioAutenticado = true;
        }
    }
    
    ngOnInit() { }
}