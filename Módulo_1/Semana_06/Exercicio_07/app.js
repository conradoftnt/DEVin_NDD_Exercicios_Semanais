const fetchAPI = async (url, method) => {
    const response = await fetch(url, {
        method: method,
    });

    if (!response.ok) {
        const err = await response.json();
        return console.log(`Ocorreu o seguinte erro: ${err.message}`);
    };
    return await response.json();
};

const consultarEndereco = async () => {

    const UF = document.getElementById("UF").value;

    if (!UF) {
        alert("O campo da unidade federativa (UF) precida ser preenchido!");
        return;
    }

    if (UF.length !== 2) {
        alert("O campo da unidade federativa (UF) foi preenchido com um valor inválido!");
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

    const response = await fetchAPI(`https://viacep.com.br/ws/${UF}/${cidade}/${rua}/json/`, "GET");
    console.log(response);
};