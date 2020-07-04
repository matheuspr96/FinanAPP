import { Component, OnInit } from '@angular/core';
import { UsuarioServico } from 'src/app/servicos/usuario/usuario.servico';
import { Usuario } from 'src/app/model/usuario';

@Component({
    selector: 'cadastro-usuario',
    templateUrl: './cadastro.component.html',
    styleUrls:['./cadastro.component.css']
})

export class CadastroComponent implements OnInit {
public usuario: Usuario

    constructor(private usuarioService: UsuarioServico) {

     }

    ngOnInit(): void {
        this.usuario = new Usuario();
    }

    public cadastrar(){
        this.usuarioService.cadastrarUsuario(this.usuario)
        .subscribe(
            usuarioJson => {

            },
            err => {

            }
        );
    }
}