 
        function somenteNumeros(numero)
        {
        var regex = /[^0-9.]/;
        regex.lastIndex = 0;
        var campo = numero;
        if (regex.test(campo.value))
        {
            alert("Digite Apenas Numeros");
            campo.value = "";
        }
    }

function Enviar() {

    var nome = document.getElementById("nomeid");

    if (nome.value != "") {
        alert('Obrigado sr(a) ' + nome.value + ' os seus dados foram encaminhados com sucesso');
    }

}