# 📱 DIO - Trilha .NET - Programação orientada a objetos

## Desafio de Projeto - Sistema de Celulares
Projeto desenvolvido como parte da trilha de **.NET da DIO**, com foco em aplicar os conceitos de **programação orientada a objetos** (POO) em um sistema simples de gerenciamento de celulares.

## Objetivo da Resolução
Modelar um sistema baseado em uma **classe abstrata** para representar um celular genérico e duas classes concretas que herdam e implementam comportamentos específicos para os modelos **Nokia** e **iPhone**.


## Diagrama de Classes
![Diagrama classes](Imagens/diagrama.png)

##  Tecnologias Utilizadas
- .NET 9 / .NET Core
- C#
- Programação orientada a objetos (POO)
- Console Application

## Estrutura do Projeto

### Classe `Smartphone` (Abstrata)
- Propriedades:
  - `Numero` (pública)
  - `Modelo`, `IMEI`, `Memoria` (privadas ou protegidas)
- Métodos:
  - `Ligar()`
  - `ReceberLigacao()`
  - `InstalarAplicativo(string nomeApp)` *(abstrato)*

### Classe `Nokia`
- Herda de `Smartphone`
- Implementa o método `InstalarAplicativo` com comportamento específico

### Classe `Iphone`
- Herda de `Smartphone`
- Implementa o método `InstalarAplicativo` com comportamento específico

##  Execução do Programa
A aplicação pode ser executada via terminal. No `Program.cs`, instancie objetos das classes `Nokia` e `Iphone`, utilize os métodos herdados e veja o comportamento polimórfico do método `InstalarAplicativo`.

