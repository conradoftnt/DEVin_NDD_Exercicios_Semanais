//Vai ocorrer um erro no console caso a promise de errado, por conta de não haver um catch de tratamento.

const sleep = (valor) => {
    return new Promise ((res, req) => {
        setTimeout(() => {
            if(valor){
                res(console.log(valor));
            } else {
                req(console.log("Failed"));
            }
        }, 3000);
    });
};

sleep("Teste");