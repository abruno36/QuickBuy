import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router, ActivatedRoute } from "@angular/router";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";


@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"] 
})
export class LoginComponent implements OnInit {    
  public usuario;
  public returnUrl: string;
  public mensagem: string;

  private ativar_spinner: boolean;

  constructor(private router: Router, private activatedRouter: ActivatedRoute) {
    this.usuario = new Usuario();
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
  }

  //constructor(private router: Router, private activatedRouter: ActivatedRoute,
  //          private usuarioServico: UsuarioServico) {    
  //}

  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
  }
  
  entrar() {
    if (this.usuario.email == "abruno36@gmail.com" && this.usuario.senha == "abt038905") {
      sessionStorage.setItem("usuario-autenticado", "1");
      this.router.navigate([this.returnUrl]);
    }
    //this.ativar_spinner = true;
    //this.usuarioServico.verificarUsuario(this.usuario)
    //  .subscribe(
    //    usuario_json => {
    //      // essa linha será executada no caso de retorno sem erros                          
    //      this.usuarioServico.usuario = usuario_json;

    //      if (this.returnUrl == null) {
    //        this.router.navigate(['/']);
    //      } else {
    //        this.router.navigate([this.returnUrl]);
    //      }
    //    },
    //    err => {
    //      console.log(err.error);
    //      this.mensagem = err.error;
    //      this.ativar_spinner = false;
    //    }
    //  );          
  }
    
}
