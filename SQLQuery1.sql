create table pessoa(
cod_pessoa int primary key identity(1,1),
nome varchar(60),
data_nascimento date,
tipo char(1)) -- C é cliente, F é Fornecedor
create table mercadorias(
cod_mercadorias int primary key identity(1,1),
nome varchar(60),
validade date,
alcool char(1), -- A contém alcool, N não contém alcool
saldo_estoque int,
valor_produto decimal(8,2));
create table movimentacao(
cod_movimentacao int primary key identity(1,1),
cod_pessoas_cli int references pessoa(cod_pessoa),
cod_pessoas_for int references pessoa(cod_pessoa),
data_movimentacao date);
create table movimentacaomercadoria(
cod_movimentacao_mercadoria int primary key identity(1,1),
cod_movimentacao int references movimentacao(cod_movimentacao),
cod_mercadoria int references mercadorias(cod_mercadorias),
quantidade int);
