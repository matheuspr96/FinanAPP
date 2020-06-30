import { Component, OnInit } from '@angular/core';
import { Usuario } from '../model/usuario';
import { Router } from '@angular/router';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls:['./login.component.css']
})

export class LoginComponent implements OnInit {
    public usuario;
    public usuarioAutenticado : boolean;

    constructor(private router: Router) {
        this.usuario = new Usuario();
    }

    login(){
        if(this.usuario.email == 'matheuspr96@hotmail.com' && this.usuario.senha == '@Qwerty1'){
            sessionStorage.setItem("usuario-autenticado","1");
            this.router.navigate(['/']);
        }
    }

    ngOnInit() { }
}