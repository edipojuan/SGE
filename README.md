<p align="center">
  <a href="https://sge.tjmt.jus.br/" target="blank">
    <img src="./SGE_logo.png" alt="Logo" />
  </a>
  <br>
</p>

<h1 align="center">SGE - Sistema de Gerenciamento de Eventos (case técnico)</h1>

<p align="center">
  
  [![NPM Version][npm-image]][npm-url]
  [![Build Status][travis-image]][travis-url]
  [![Downloads Stats][npm-downloads]][npm-url]

</p>

<p align="center">
  O sistema visa gerenciar e notificar eventos (palestras, cursos etc.) da escola dos servidores.
</p>

## Features

 * Acessibilidade
 * Notificação no app por e-mail e via mensagem no celular
 * Testes de Unidade e Teste de Integração no backend
 * 100% de code coverage com testes unitários e E2E no frontend
 * Desenvolvido utilizando ES6, ES7
 * Utilização de containers para facilitar o desenvolvimento e a publicação.
 * Todos os arquivos passando pelo `ng lint`, ou seja, sem nenhum erro encontrado pelo lint

 ### developed

 * Acessibilidade
 * Desenvolvido utilizando ES6, ES7
 * Utilização de containers para facilitar o desenvolvimento e a publicação.
 * Todos os arquivos passando pelo `ng lint`, ou seja, sem nenhum erro encontrado pelo lint

## Getting Started

### Prerequisites

Você precisará ter o [Docker](https://docs.docker.com/install/) e o [Docker Compose](https://docs.docker.com/compose/install/) instalado.

### Installing

```
docker-compose up
```

### Note

Caso não aconteça a comunicação do server com o banco de dados (MongoDB)
1. stop o container sge_server
2. start o projeto SGE-API `dotnet run`

### Containers

1. mongo
2. mongo-express
3. sge_mongo-seed
4. sge_server
5. sge_client
6. redis
7. rabbitmq:3-management

## Built With

### Client

- [Angular v7](https://angular.io/)
- [Ionic 4](https://ionicframework.com/docs)
- [RxJS](https://rxjs-dev.firebaseapp.com/)
- [Reactive Forms](https://angular.io/guide/reactive-forms)

### Server

- [.NET Core 2.1](https://dotnet.microsoft.com/)
- [Autofac](https://autofac.org/)
- [Redis](https://redis.io/)
- [Swashbuckle](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-3.0&tabs=visual-studio)
(Acesse através do endereço http://localhost:5000/ ou clicando [aqui](http://localhost:5000/))

### Database

- [mongodb](https://www.mongodb.com/)

Sugestão de ferramenta para acesso ao mongodb: [MongoDB Compass](https://www.mongodb.com/products/compass)

> Autenticação: **Usuário:** root **Senha:** SGEMongo2019!

### Admin Interface

- [mongo-express](https://github.com/mongo-express/mongo-express)

Acesse através do endereço http://localhost:8081/ ou clicando [aqui](http://localhost:8081/)

> Autenticação: **Usuário:** sgetjmt **Senha:** SGEExpress2019!

### Rabbitmq Management

Acesse através do endereço http://localhost:15672/ ou clicando [aqui](http://localhost:15672/)

> Autenticação: **Usuário:** rabbitmq **Senha:** rabbitmq

### Others

- [Docker](https://www.docker.com/)
- [NGINX](https://www.nginx.com/)

## Projects reference

### My

- [telephone-book](https://github.com/edipojuan/telephone-book)
- [easy-search](https://github.com/edipojuan/easy-search)
- [rastreador-correios](https://github.com/edipojuan/rastreador-correios)
- [book-store-app](https://github.com/edipojuan/book-store-app)
- [pwa-test](https://github.com/edipojuan/pwa-test)

### Others

- [cep-promise](https://github.com/filipedeschamps/cep-promise)
- [EquinoxProject](https://github.com/EduardoPires/EquinoxProject)
- [enjoy.cqrs](https://github.com/ircnelson/enjoy.cqrs)
- [SGP-WEB](sgpweb.tjmt.jus.br)
- [curso-angular](https://github.com/loiane/curso-angular)

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
