create database recuperacao_po2_bd;
use recuperacao_po2_bd;

create table Carro(
id_car int primary key auto_increment,
marca_car varchar(300),
modelo_car varchar(250),
anoDeFabricacao_car int,
anoDoModelo_car int,
numeroDePortas_car int,
tipoDeCarroceria_car varchar(75),
cor_car varchar (75),
numeroDoChassi_car varchar(17),
numeroDoMotor_car varchar(10), 
tipoDeCombustivel_car varchar(100),
capacidadeDoTanque_car double,
potenciaDoMotor_car double,
tipoDeTransmissao_car varchar(40),
tipoDeTracao_car varchar(30),
renavam_car varchar(11),
numeroDaPlaca_car varchar(7),
dataDeLicenciamento_car date,
dataDaUltimaInspecaoVeicular_car date
);