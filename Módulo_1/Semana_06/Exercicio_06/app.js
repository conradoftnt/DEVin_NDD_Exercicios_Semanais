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
    const cidade = document.getElementById("cidade").value;
    const rua = document.getElementById("rua").value;
    const response = await fetchAPI(`https://viacep.com.br/ws/${UF}/${cidade}/${rua}/json/`, "GET");
    console.log(response);
};