const fetchAPI = async (url, method) => {
    try {
        const response = await fetch(url, {
            method: method,
        });

        if (!response.ok) {
            const err = await response.json();
            return console.log(`Ocorreu o seguinte erro: ${err.message}`);
        }
        return await response.json();
    } catch (e) {
        alert(
            `Ocorreu um erro na solicitação, favor verificar os dados inseridos!`,
        );
    }
};

const consultarEndereco = async () => {
    const UF = document.getElementById("UF").value;

    if (!UF) {
        alert("O campo da unidade federativa (UF) precida ser preenchido!");
        return;
    }

    if (UF.length !== 2) {
        alert(
            "O campo da unidade federativa (UF) foi preenchido com um valor inválido!",
        );
        return;
    }

    const cidade = document.getElementById("cidade").value;

    if (!cidade) {
        alert("O campo da cidade precida ser preenchido!");
        return;
    }

    const rua = document.getElementById("rua").value;

    if (!rua) {
        alert("O campo da rua precida ser preenchido!");
        return;
    }

    const response = await fetchAPI(
        `https://viacep.com.br/ws/${UF}/${cidade}/${rua}/json/`,
        "GET",
    );

    console.log(response);

    if (response.length === 0) {
        const notFound = document.createElement("p");
        notFound.id = "resposta";
        notFound.innerText = `Nenhum CEP encontrado para o endereço: ${UF}, ${cidade}, ${rua}.`;
        const resposta = document.getElementById("resposta");
        resposta.replaceWith(notFound);
    } else {
        const tabela = document.createElement("table");
        const cabecalhoTabela = document.createElement("tr");
        const cabecalho = [
            "cep",
            "logradouro",
            "complemento",
            "bairro",
            "localidade",
            "uf",
            "ddd",
        ];
        cabecalho.forEach((item) => {
            const coluna = document.createElement("td");
            coluna.innerText = item.toUpperCase();
            cabecalhoTabela.appendChild(coluna);
        });
        tabela.appendChild(cabecalhoTabela);
        tabela.id = "resposta";

        response.forEach((item) => {
            const linha = document.createElement("tr");
            cabecalho.forEach((elemento) => {
                const coluna = document.createElement("td");
                coluna.innerText = item[elemento];
                linha.appendChild(coluna);
            });
            tabela.appendChild(linha);
        });

        const resposta = document.getElementById("resposta");
        resposta.replaceWith(tabela);
    }
};
