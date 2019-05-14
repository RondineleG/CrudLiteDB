 
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
 