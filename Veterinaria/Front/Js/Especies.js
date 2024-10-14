jQuery(function () {
    //Registrar los botones para responder al evento click
    $("#dvMenu").load("../Paginas/Menu.html")
});


async function Consultar() {
    /*
        let: Variable de tipo local a la función
        var: Variable "global" a la página
        const: Constante, y se utiliza para los objetos en js
    */
    let IdEspecie = $("#txtCodigoEspecie").val();
    try {
        //Vamos a invocar el servicio con fetch (Por definición es asíncrono, pero se debe ejecutar con await para volverlo síncrono)
        const Resultado = await fetch("http://localhost:44353/api/Especies/ConsultarXIdEspecie?IdEspecie=" + IdEspecie,
            {
                method: "GET",
                mode: "cors",
                headers: { "Content-Type": "application/json" }
            });
        //Se captura la respuesta que está en formato json y se convierto en un objeto de javascript
        const Respuesta = await Resultado.json();

        $("#txtNombreEspecie").val(Respuesta.NombreEspecie);
    }
    catch (error) {
        $("#dvMensaje").html(error);
    }
}
function Insertar() {
    EjecutarComando("POST", "Insertar");
}
function Actualizar() {
    EjecutarComando("PUT", "Actualizar");
}
function Eliminar() {
    EjecutarComando("DELETE", "Eliminar");
}

async function EjecutarComando(Metodo, Funcion) {
    const especie = new Especie($("#txtNombreEspecie").val());
    try {
        const Resultado = await fetch("http://localhost:44353/api/Especies/" + Funcion,
            {
                method: Metodo,
                mode: "cors",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify(especie)
            });
        //Se captura la respuesta que está en formato json y se convierto en un objeto de javascript
        const Respuesta = await Resultado.json();
        $("#dvMensaje").html(Respuesta);
    }
    catch (error) {
        $("#dvMensaje").html(error);
    }
}

class Especies {
    constructor(IdEspecie, NombreEspecie) {
        this.IdRaza = IdEspecie;
        this.NombreRaza = NombreEspecie;
    }
}