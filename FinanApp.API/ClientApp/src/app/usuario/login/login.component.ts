import { Component, OnInit } from '@angular/core';
import { Usuario } from '../../model/usuario';
import { Router, ActivatedRoute } from '@angular/router';
import { UsuarioServico } from '../../servicos/usuario/usuario.servico';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls:['./login.component.css']
})

export class LoginComponent implements OnInit {
    public usuario;
    public usuarioAutenticado : boolean;
    public returnUrl : string;
    public mensagem : string;
    public ativar_spinner : boolean;
    constructor(private router: Router, private activateRouter: ActivatedRoute, private usuarioServico: UsuarioServico) {

    }
    ngOnInit(): void {
        this.usuario = new Usuario();
        this.returnUrl = this.activateRouter.snapshot.queryParams['return'];
    }
    
    login(){
        this.ativar_spinner = true;
        this.usuarioServico.verificarUsuario(this.usuario)
        .subscribe(
            usuario_json => {

                this.usuarioServico.usuario = usuario_json;

                if(this.returnUrl == null){
                    this.router.navigate(['/']);
                }
                else{
                    this.router.navigate([this.returnUrl]);
                }
            },
            err => {
                console.log(err.mesage);
                this.mensagem = err.error;
                this.ativar_spinner = false;
            }
        );
    }
}