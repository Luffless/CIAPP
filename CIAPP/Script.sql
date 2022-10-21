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

create table processo (
	id int not null,
	varaorigem varchar(60) not null,
	numeroartigopenal int not null,
	penaoriginaria varchar(60) not null,
	horascumprir int not null,
	acordopersecucaopenal boolean not null,
	datainicio date not null,
	datatermino date not null,
	id_prestador int not null
);

alter table processo
add constraint pk_processo primary key(id),
add constraint fk_processo foreign key(id_prestador) references prestador(id);

create table processo_entidade (
	id_processo int not null,
	id_entidade int not null,
	horascumprir int not null,
	datainicio date not null,
	datatermino date not null
);

alter table processo_entidade
add constraint pk_processo_entidade primary key(id_processo, id_entidade),
add constraint fk_processo_entidade_1 foreign key(id_processo) references processo(id),
add constraint fk_processo_entidade_2 foreign key(id_entidade) references entidade(id);

create table atividade (
	id_processo int not null,
	id_entidade int not null,
	descricao varchar(60) not null
);

alter table atividade
add constraint pk_atividade primary key(id_processo, id_entidade, descricao),
add constraint fk_atividade_1 foreign key(id_processo) references processo(id),
add constraint fk_atividade_2 foreign key(id_entidade) references entidade(id);

create table frequencia (
	id_processo int not null,
	id_entidade int not null,
	datafrequencia date not null,
	horascumpridas int not null,
	observacao varchar(255)
);

alter table frequencia
add constraint pk_frequencia primary key(id_processo, id_entidade, datafrequencia),
add constraint fk_frequencia_1 foreign key(id_processo) references processo(id),
add constraint fk_frequencia_2 foreign key(id_entidade) references entidade(id);