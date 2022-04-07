const fetchAPI = async (url, method) => {
    const response = await fetch(url, {
        method: method
    });

    if (!response.ok) {
        const err = await response.json();
        return console.log('Ocorreu o seguinte erro:', err.message);
    };
    return await response.json();
};

const buscaCEP = async () => {
    const CEP = document.getElementById("CEP").value;

    if (!CEP) {
        alert("Você precisa digitar um CEP...")
        return;
    };

    if (CEP.length !== 8) {
        alert("O CEP digitado é inválido!");
        return;
    }

    const response = await fetchAPI(`https://viacep.com.br/ws/${CEP}/json/`, "GET");
    console.log(response);

    if (response.erro) {
        alert("Não foi possível consultar o CEP digitado...");
        return;
    }

    const mostraCEP = document.createElement("p");
    mostraCEP.innerText = `${response.logradouro}, ${response.complemento ? `${response.complemento} - ` : ""}${response.bairro} - ${response.localidade}/${response.uf}`;
    document.body.appendChild(mostraCEP);
}