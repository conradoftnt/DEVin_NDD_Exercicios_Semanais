[M1S06] - Ex 9 - Manipulação de DOM

-   Utilize o seguinte HTML como base para o seu exercício:
    <!DOCTYPE html>
    <html>
      <head>
        <meta charset="UTF-8" />
        <title>Document</title>
      </head>
      <body>
        <h1>Titulo</h1>
        <p>subtítulo</p>
        <p id="descricao">Lista de afazeres</p>
        <ul>
          <li class="itens">Ex 1</li>
          <li class="itens">Ex 2</li>
          <li class="itens">Ex 3</li>
          <li class="itens">Ex 4</li>
        </ul>
      </body>
    </html>

-   No arquivo js crie uma função e adicione as seguintes variáveis:
    -- titulo: conterá a primeira tag h1;
    -- descricao: conterá a tag com id = descricao;
    -- listaItens: conterá todas as tags com classe = itens;
    -- Atribua para as variáveis os elementos solicitados utilizando querySelector e querySelectorAll
    -- Imprima os valores das variáveis utilizando console.log

-   Importe o arquivo js em sua página html

-   Vincule a função criada com o evento de onload do body da página
