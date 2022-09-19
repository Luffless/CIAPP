create table usuario (
    id integer not null,
	nome varchar(60) not null,
	email varchar(60) not null unique,
    login varchar(30) not null unique,
    senha char(32) not null
);

alter table usuario
add constraint pk_usuario primary key(id);

insert into usuario values (0, 'Admin', 'admin@ucs.br', 'admin', '8a89e2c6bb99f438a671108c3c0f5c3f');

create table entidade (
    id integer not null,
	razaosocial varchar(60) not null,
    telefone bigint not null,
	email varchar(60) not null unique,
	datacredenciamento date not null,
    datadescredenciamento date,
	observacao varchar(255),
	rua varchar(50) not null,
	numero int not null,
	complemento varchar(60),
	bairro varchar(30) not null,
	municipio varchar(30) not null,
	cep char(9) not null,
	estado varchar(30) not null
);

alter table entidade
add constraint pk_entidade primary key(id);