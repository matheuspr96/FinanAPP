import { Injectable,Inject} from "@angular/core";
import { HttpClient, HttpHeaders} from "@angular/common/http";
import { Observable } from 'rxjs';
import { inject } from "@angular/core/testing";
import { Usuario } from "../../model/usuario";

@Injectable({
    providedIn: "root"
})
export class UsuarioServico{

    private baseURL:string;
    private _usuario: Usuario;
    
    constructor(private http: HttpClient, @Inject('BASE_URL')  baseurl: string) {
        this.baseURL=baseurl;
    }

    get usuario(): Usuario{
        let usuario_json = sessionStorage.getItem("usuario-autenticado");
        this._usuario = JSON.parse(usuario_json);
        return this._usuario;
    }

    set usuario(usuario: Usuario){
        sessionStorage.setItem("usuario-autenticado", JSON.stringify(usuario));
        this._usuario = usuario;
    }

    public usuario_autenticado(): boolean{
        return this._usuario != null && this._usuario.email != null && this._usuario.senha != null;
    }

    public limpar_sessao(){
        sessionStorage.setItem("usuario-autenticado","");
        this._usuario = null;
    }


    public verificarUsuario(usuario: Usuario) : Observable<Usuario>{

        const headers = new HttpHeaders().set('content-type', 'application/json');
        var body = {
            email: usuario.email,
            senha: usuario.senha
        }
        return this.http.post<Usuario>(this.baseURL + "api/usuario/VerificarUsuario", body, {headers});
    }

    public cadastrarUsuario(usuario: Usuario) : Observable<Usuario>{
        const headers = new HttpHeaders().set('content-type', 'application/json');
        var body = {
            email: usuario.email,
            senha: usuario.senha,
            nome: usuario.nome,
            salario: usuario.salario
        }

        return this.http.post<Usuario>(this.baseURL + "api/usuario", body, { headers });
    }
}
