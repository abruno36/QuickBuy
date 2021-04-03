import { Component } from "@angular/core"

@Component({
  selector: "app-produto",
  templateUrl: "./produto.component.html",
  styleUrls: ["./produto.component.css"]
})

export class ProdutoComponent { //Nome das classes começando com maíusculo por conta da convensão PascalCase

  /* camelCase para variáveis, atributos e nome das funcções*/
  public nome: string;
  public liberadoParaVenda: boolean;

  public obterNome(): string {
    return "Samsung"
  }

}
