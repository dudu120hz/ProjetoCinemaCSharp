# Projeto Cinema Simples em C#
Neste projeto eu simulo a compra e venda de ingressoas de cinema em C#.

## Classe AMolde
Nesta classe, eu declaro os cinco métodos abstratos:
* Data (recebe parâmetros);
* TresD (não recebe parâmetros);
* Horario (não recebe parâmetros);
* ValorIngresso (não recebe parâmetros);
* Pagamento (não recebe parâmetros);

Que são os principais métodos do projeto, que faz todo código funcionar.
   
## Classe Cinema
Nesta classe, os cinco métodos abstratos da Classe AMolde, são herdados e abstraídos.

## Classe Program
Nesta classe, quatro objetos são instanciados a partir da Classe Cinema, e o código principal é feito.