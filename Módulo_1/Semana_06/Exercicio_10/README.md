[M1S06] - Ex 10 - Manipulação de DOM

-   Utilize o código abaixo como base para implementar o exercício:

<!DOCTYPE html>
<html>
  <head>
    <meta charset="UTF-8" />
    <title>Document</title>
    <style>
      .azul {
        color: blue;
      }
      .vermelho {
        color: red;
      }
    </style>
  </head>
  <body>
    <ul>
      <li class="azul">Item</li>
      <li class="vermelho">Item</li>
      <li class="azul">Item</li>
      <li class="vermelho">Item</li>
      <li class="azul">Item</li>
      <li class="vermelho">Item</li>
    </ul>
    <button>Inverter</button>
  </body>
</html>

-   Implementar função para inverter as classes (itens com azul terão a classe vermelho e vermelho terão a classe azul)
    -- Use o document.querySelectorAll() para obter uma lista de elementos;
    -- Percorra os elementos utilizando um laço de repetição;
    -- Utilizando uma estrutura de condicionais, verifique as classes;
    -- O uso do classList.remove e classList.add será útil

-   Vincule a função criada com o evento de click do botão Inverter
