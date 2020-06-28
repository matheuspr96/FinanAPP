import { Component } from "@angular/core"


@Component({
  selector: "app-usuario",
  template: "<html><body> Usuario html </body></html>"
})
export class UsuarioComponent {
  id: number;
  nome: string;
  salario: number;
  email: string;
  senha: string;
}
