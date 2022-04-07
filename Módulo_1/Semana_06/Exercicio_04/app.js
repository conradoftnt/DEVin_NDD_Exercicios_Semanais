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
}