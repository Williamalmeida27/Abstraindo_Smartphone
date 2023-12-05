## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. Você deve criar as suas classes de acordo com o diagrama abaixo:
![Diagrama de classe smartphone](https://github.com/digitalinnovationone/trilha-net-poo-desafio/raw/main/Imagens/diagrama.png)

##Diagrama classes

**Regras e validações**
A classe Smartphone deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.

A classe Nokia e Iphone devem ser classes filhas de Smartphone.
O método InstalarAplicativo são sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.