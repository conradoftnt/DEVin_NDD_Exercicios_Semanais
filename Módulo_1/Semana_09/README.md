## [M1S09] - Ex 1 - Variáveis, Types e Arrow function

Crie um arquivo typescript com o nome exercicio01.ts e no corpo do arquivo crie 3 variáveis, cada um delas com a seguinte instrução:

    1- exampleLet - sendo uma variável não constante e de escopo local do tipo numérico com a sua idade como valor.
    2- exampleConst - sendo uma variável constante e de escopo local do tipo string com o seu nome como valor.
    3- exampleVar - sendo uma variável não constante e de escopo global do tipo string com a concatenação da seguinte frase: “Olá meu nome é ”+exampleConst +” e tenho ”+exampleLet+” anos.”;

---

## [M1S09] - Ex 2 - Variáveis, Types e Arrow function

Crie um arquivo typescript com o nome exercicio02.ts, em uma função, do tipo arrow function, some dois números inteiros e adicione o seu retorno a uma variável local chamada sum e imprima no console.log o resultado. Os valores a serem somados devem ser passados como parâmetros da função e você que irá escolher os valores, não esqueça de declarar o tipo do retorno e o tipo dos parâmetros.

---

## [M1S09] - Ex 3 - Objetos, Classes e Propriedades

Crie um arquivo typescript com o nome exercicio03.ts, com o auxílio do objeto já criado abaixo e utilizando o conhecimento aprendido em propriedades popule valores escolhidos por você para cada propriedade do objeto.
OBS: No atributo cadeiras popule o array com no mínimo 4 cadeiras e logo após imprima em um console.log() o objeto completo.o:

    let aluno:{
    nome: string,
    matricula: number,
    ativo: boolean,
    cadeiras: string[] }

---

## [M1S09] - Ex 4 - Objetos, Classes e Propriedades

Crie um arquivo typescript com o nome exercicio04.ts, nele crie uma classe chamada Filme com os atributos nome do tipo string, anoDeLancamento do tipo number e diretor do tipo string. Fora do escopo dessa classe, instancie ela e preencha os campos acessando seus atributos por meio do ponto (.).

---

## [M1S09] - Ex 5 - Modifiers e Construtores

Crie um arquivo typescript com o nome exercicio05.ts, nele siga as instruções abaixo;
Para treinar o uso de construtores crie uma classe chamada **Animal** com os atributos **nome:string**, **raca:string**, **corPelagem: string** e **peso:number**. Nele chame e popule todos os atributos pelo construtor como no exemplo em anexo:

---

## [M1S09] - Ex 6 - Modifiers e Construtores

Para treinar classes e modificadores de acesso, em um arquivo chamado exercicio06.ts crie 2 classes.

-   A primeira será chamada de **Conta**, ela terá os atributos _numero_ do tipo numérico, _saldo_ também do tipo numérico, _estaAtiva_ do tipo boleano e _dono_ do tipo string. Sendo eles todos **protegidos**.
-   Construa o método _construtor_ recebendo todos os parâmetros correspondentes aos atributos e depois popule com esses parâmetros os atributos da classe.
-   A segunda classe se chama **ContaEmpresa** ela terá apenas o atributo _limiteDeDeposito_ do tipo numérico e será **privado**, além disso ele sempre será 1000, ou seja, ele já será declarado com o valor 1000.
-   A classe **ContaEmpresa** estende a classe **Conta**.
-   Seu construtor apenas irá popular as variáveis da super classe **Conta**.
-   Na classe **ContaEmpresa** irá existir um método chamado _deposito()_ que recebe um parâmetro “valor” do tipo numerico, além disso outro método será chamado _imprimeValorConta()_.
-   O método _deposito()_ irá pegar o saldo da conta e somar com o valor que ele recebe como parâmetro só se tiver dentro do limite da conta.
-   Já a função _imprimeValorConta()_ irá dar um console.log no saldo da conta.

Depois da construção das classes e métodos, deposite 3500 reais chamando a função _deposito()_, sabendo que o limite máximo é 1000 antes de confirmar a soma e verifique se o valor recebido é menor ou igual a 1000. Depois disso chame a função _imprimeValorConta()_ e imprima o valor total, ou seja, 3500.

---

## [M1S09] - Ex 7 - Interfaces e Módulos

Em um arquivo chamado exercicio07.ts crie uma interface chamada **Pessoa** com os seguintes atributos: _nome_ do tipo string, _idade_ do tipo numérico, _rua_ do tipo string. Além disso, crie um método chamado _cadastrar()_.

As classes **Aluno** e **Funcionario** que irá ser implementada pela classe **Pessoa** e terão os seguintes atributos:

**Aluno** - _matricula_ do tipo numérico e _cadeiras_ do tipo array de strings.
**Funcionario** - _identificador_ do tipo numérico e _setor_ do tipo string.

O exercício consiste em implementar o método requerido pela interface **Pessoa** às classes **Aluno** e **Funcionario**. O método deverá imprimir em um console.log todas as informações sobre o aluno e funcionário cadastrado.

---

## [M1S09] - Ex 8 - Interfaces e Módulos

Agora, usando a interface criada anteriormente transfira ela para outro arquivo e usando seus conhecimentos sobre importação de módulo faça as declarações necessárias para as classes **Funcionário** e **Aluno** usar a interface.

---

## [M1S09] - Ex 9 - Revisão geral

Crie um arquivo chamado exercicio09.ts crie uma interface chamada **Produto**, nela terá os atributos **nome:**string, **valor:**number, **codigo:** number, **quantidade:** number, **emEstoque:** boolean e apenas declare um método chamado _comprar()_, esse método é **opcional** e recebe como parâmetro _produto_ do tipo _Produto_ e _quantidade_ do tipo number. Em um projeto angular, na pasta **assets** adicione o arquivo exercicio09.ts e siga as instruções abaixo:

-   No html do component ( app.component.html ) apague todo o código e cole esse código:

<h2>
  		Total da compra: {{ valorTotal }}
</h2>

-   Criar a variável _valorTotal_ do tipo number no _app.component.ts_
-   A classe no _app.component.ts_ deve ser implementada com a interface que criamos no arquivo exercicio09.ts, ou seja, faça a importação correta na classe.
-   Deverá ser declarado todos os atributos da interface com os devidos tipos e todos com o modificador privado.
-   Crie o objeto abaixo:

        sofa:Produto = {
        nome: "Sofá 4 lugares",
        valor: 120,
        codigo: 1,
        quantidade: 30,
        emEstoque: true

    };

-   Crie também o método _comprar()_ com os seus parâmetros e implemente ele para que se o produto passado estiver em estoque ( emEstoque == true ) ele multiplique o valor do produto pela quantidade ( valor * quantidade ) e diminua essa quantidade, da quantidade do objeto criado no passo acima ( produto.quantidade = produto.quantidade - quantidade ).
    No método **ngOnInit** chame a função *comprar()* passando como parâmetro o objeto *sofa* e *30*, na linha de baixo chame o mesmo método passando nos parâmetros novamente o objeto *sofa* e *10\*.
    Rode o projeto com “ng serve” e veja o resultado em tela.

---

## [M1S09] - Ex 10 - Revisão geral

Crie um arquivo chamado exercicio10.ts, lá crie uma classe chamada **Aluno** com 3 atributos: o atributo **privado** _nome_ do tipo string, o atributo **privado** _matricula_ do tipo number e o atributo **público** _passou_ do tipo boolean. Lá, também crie uma interface chamada **Nota** com 3 atributos: **cadeira:**string, **ponto:**number e **aluno** do tipo Aluno, classe que criamos acima. Agora em um projeto angular, na pasta **assets** adicione o arquivo exercicio10.ts e siga as instruções abaixo:

-   Na classe **Aluno**, no arquivo exercicio10.ts, cole o código abaixo:

        aprovado(media: number){
            if(media >= 7 ){
                this.passou = true;
            }else{
                this.passou = false;
            }
            return this.passou;
         }

-   Faça a importação da interface e classe criada no exercicio10.ts no **app.component.ts**.
-   A classe **AppComponent** deve estender da classe **Aluno**.
-   Também na classe **AppComponent** crie 2 variáveis: _media_ do tipo number e _passou_ do tipo boolean.
-   No **ngOnInit** cole o código abaixo:

        let aluno1: Aluno = new Aluno("Jonas", 7);
            let notas: Nota[] = [
                {
                    cadeira: "Geografia",
                    ponto: 4,
                    aluno: aluno1
                },
                {
                    cadeira: "Geografia",
                    ponto: 8,
                    aluno: aluno1
                },
                {
                    cadeira: "Geografia",
                    ponto: 3,
                    aluno: aluno1
                },
                {
                    cadeira: "Geografia",
                    ponto: 10,
                    aluno: aluno1
                }
            ]

            //implemente o resto do código aqui


            this.passou = this.aprovado(this.media);

Agora onde há o comentário “implemente o resto do código aqui” faça um laço para percorrer todo o array da variável _let notas_ e ir somando cada ponto para que depois seja calculada sua média. Armazene a media na variável _this.media_ e imprima em tela o _this.passou_ através do double mustache ( {{ }} ) no seu **app.component.html**.
