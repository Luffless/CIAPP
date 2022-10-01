create table usuario (
    id int not null,
	nome varchar(60) not null,
	email varchar(60) not null unique,
    login varchar(30) not null unique,
    senha char(32) not null
);

alter table usuario
add constraint pk_usuario primary key(id);

insert into usuario values (0, 'Admin', 'admin@ucs.br', 'admin', '8a89e2c6bb99f438a671108c3c0f5c3f');

create table entidade (
    id int not null,
	cnpj char(18) not null unique,
	razaosocial varchar(60) not null,
    telefone bigint not null,
	email varchar(60) not null unique,
	datacredenciamento date not null,
    datadescredenciamento date,
	observacao varchar(255),
	logradouro varchar(50) not null,
	numero int not null,
	complemento varchar(60),
	bairro varchar(30) not null,
	municipio varchar(30) not null,
	cep char(9) not null,
	estado varchar(30) not null
);

alter table entidade
add constraint pk_entidade primary key(id);

create table prestador (
    id int not null,
	cpf char(14) not null unique,
	nome varchar(60) not null,
	datanascimento date not null,
	naturalidade varchar(30) not null,
	estadocivil varchar(20) not null,
	foto bytea not null,
	telefone bigint not null,
	etnia varchar(30) not null,
	sexo varchar(9) not null,
	profissao varchar(60) not null,
	rendafamiliar decimal not null,
	religiao varchar(30) not null,
	grauinstrucao varchar(30) not null,
	recebebeneficio boolean not null,
	usaalcool boolean not null,
	usadrogas boolean not null,
	observacao varchar(255),
	logradouro varchar(50) not null,
	numero int not null,
	complemento varchar(60),
	bairro varchar(30) not null,
	municipio varchar(30) not null,
	cep char(9) not null,
	estado varchar(30) not null
);

alter table prestador
add constraint pk_prestador primary key(id);

create table parentesco (
	id_prestador int not null,
	nome varchar(60) not null,
	grauparentesco varchar(20) not null
);

alter table parentesco
add constraint pk_parentesco primary key(id_prestador, nome),
add constraint fk_parentesco foreign key(id_prestador) references prestador(id);

create table habilidade (
	id_prestador int not null,
	descricao varchar(60) not null
);

alter table habilidade
add constraint pk_habilidade primary key(id_prestador, descricao),
add constraint fk_habilidade foreign key(id_prestador) references prestador(id);

create table deficiencia (
	id_prestador int not null,
	descricao varchar(60) not null
);

alter table deficiencia
add constraint pk_deficiencia primary key(id_prestador, descricao),
add constraint fk_deficiencia foreign key(id_prestador) references prestador(id);

create table doenca (
	id_prestador int not null,
	descricao varchar(60) not null
);

alter table doenca
add constraint pk_doenca primary key(id_prestador, descricao),
add constraint fk_doenca foreign key(id_prestador) references prestador(id);