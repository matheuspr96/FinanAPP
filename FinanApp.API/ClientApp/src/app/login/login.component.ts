import { Component, OnInit } from '@angular/core';
import { Usuario } from '../model/usuario';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls:['./login.component.css']
})

export class LoginComponent implements OnInit {
    public usuario;
    public usuarioAutenticado : boolean;
    public returnUrl : string;

    constructor(private router: Router, private activateRouter: ActivatedRoute) {
        this.usuario = new Usuario();
        this.returnUrl = this.activateRouter.snapshot.queryParams['return']
    }
    
    login(){
        if(this.usuario.email == 'matheuspr96@hotmail.com' && this.usuario.senha == '@Qwerty1'){
            sessionStorage.setItem("usuario-autenticado","1");
            this.router.navigate([this.returnUrl]);
        }
    }

    ngOnInit() { }
}