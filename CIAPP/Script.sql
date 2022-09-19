create table entidade (
    id integer not null,
	razaoSocial varchar(60) not null,
    telefone bigint not null,
	email varchar(60) not null unique,
	dataCredenciamento date not null,
    dataDescredenciamento date,
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

create table usuario (
    id integer not null,
	nome varchar(60) not null,
    login varchar(30) not null unique,
    senha char(32) not null,
	email varchar(60) not null unique,
    tipo varchar(8) not null,
	id_entidade integer
);

alter table usuario
add constraint pk_usuario primary key(id),
add constraint fk_usuario foreign key(id_entidade) references entidade(id);

insert into usuario (id, nome, login, senha, email, tipo) values (0,'Admin','admin', '8a89e2c6bb99f438a671108c3c0f5c3f', 'admin@ucs.br', 'Fórum');