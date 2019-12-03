<h1 align="center">SGE Sistema de Gerenciamento de Eventos (case técnico)</h1>

<p align="center">
  
  [![NPM Version][npm-image]][npm-url]
  [![Build Status][travis-image]][travis-url]
  [![Downloads Stats][npm-downloads]][npm-url]

</p>

<p align="center">
  O sistema visa gerenciar e notificar os eventos (palestras, cursos etc.) da escola dos servidores.
</p>

## Features

 * Acessibilidade
 * Notificação no app por e-mail e via mensagem no celular
 * Testes de Unidade e Teste de Integração no backend
 * 100% de code coverage com testes unitários e E2E no frontend
 * Desenvolvido utilizando ES6, ES7
 * Utilização de containers para facilitar o desenvolvimento e a publicação.

 ### developed

 * Acessibilidade
 * Desenvolvido utilizando ES6, ES7
 * Utilização de containers para facilitar o desenvolvimento e a publicação.

## Getting Started

### Prerequisites

Você precisará ter o **Docker** e o **Docker Compose** instalado.

### Installing

```
docker-compose up
```

### Containers

- mongo
- mongo-express
- sge_mongo-seed
- sge_server
- sge_client

## Built With

### Client

- [Angular v7](https://angular.io/)
- [Ionic 4](https://ionicframework.com/docs)
- [RxJS](https://rxjs-dev.firebaseapp.com/)
- [Reactive Forms](https://angular.io/guide/reactive-forms)

### Server

- [.NET Core 2.2](https://dotnet.microsoft.com/)
- [Autofac](https://autofac.org/)
- [Swashbuckle](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.0&tabs=visual-studio)
(Acesse através do endereço http://localhost:5000/ ou clicando [aqui](http://localhost:5000/))

### Database

- [mongodb](https://www.mongodb.com/)

> Autenticação: **Usuário:** root **Senha:** SGEMongo2019!

### Admin Interface

- [mongo-express](https://github.com/mongo-express/mongo-express)

Acesse através do endereço http://localhost:8081/ ou clicando [aqui](http://localhost:8081/)

> Autenticação: **Usuário:** sgetjmt **Senha:** SGEExpress2019!

### Others

- [Docker](https://www.docker.com/)
- [NGINX](https://www.nginx.com/)


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