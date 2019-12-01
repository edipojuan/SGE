# SGE (Case técnico)

> Backend do sistema de gerenciamento de Eventos.

[![NPM Version][npm-image]][npm-url]
[![Build Status][travis-image]][travis-url]
[![Downloads Stats][npm-downloads]][npm-url]

Esse sistema foi desenvolvido com o objeto de gerenciar os eventos de occorem na escola dos servidores do TJMT, ou seja, com ele podemos cadastrar, listar, editar e excluir livros. Além de programar notificações que seram enviadas ao app e por e-mail.

![](./SGE-API.png)

## Instalação

Execute o comando

```sh
docker-compose up
```

na pasta anterio.

Observação: Certifique-se de que está com o SDK do .NET Core instalado.

```sh
dotnet --version
```

A versão utilizada para o desenvolvimento do mesmo, encontra-se no arquivo [global.json](global.json)

Caso não esteja, [clique aqui](https://dotnet.microsoft.com/download/dotnet-core/2.2) e faça o download para o OS que está utilizando.

Para as plataformas OS X, Linux ou Windows:

```sh
dotnet run -p ./src/SGE.UI.Web/SGE.UI.Web.csproj
```

Para ficar "escutando" as alterações execute

```sh
dotnet watch -p ./src/SGE.UI.Web/SGE.UI.Web.csproj run
```

O Swagger foi configurado para abrir na raiz do domínio.

## Histórico de lançamentos

- 0.2.0
  - Adicionado o Swashbuckle na versão 5.0.0-rc2.
- 0.1.0
  - Criação do service que que irá adicionar, obter, atualizar e excluir os livros.
  - Criação da camada de abstração
- 0.0.1

  - Criação da estrutura do projeto

## Autor

| [<img src="https://avatars1.githubusercontent.com/u/9813896?v=4&s=115"><br><sub>@edipojuan</sub>](https://github.com/edipojuan) |
| :-----------------------------------------------------------------------------------------------------------------------------: |


## License

Este projeto está licenciado sob a licença MIT - consulte o arquivo [LICENSE](LICENSE) para obter detalhes

[npm-image]: https://img.shields.io/npm/v/datadog-metrics.svg?style=flat-square
[npm-url]: https://npmjs.org/package/datadog-metrics
[npm-downloads]: https://img.shields.io/npm/dm/datadog-metrics.svg?style=flat-square
[travis-image]: https://img.shields.io/travis/dbader/node-datadog-metrics/master.svg?style=flat-square
[travis-url]: https://travis-ci.org/dbader/node-datadog-metrics
[wiki]: https://github.com/edipojuan/SGE/wiki
