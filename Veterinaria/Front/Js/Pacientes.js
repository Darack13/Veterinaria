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
    let Identificacion = $("#txtCodigoPaciente").val();
    try {
        //Vamos a invocar el servicio con fetch (Por definición es asíncrono, pero se debe ejecutar con await para volverlo síncrono)
        const Resultado = await fetch("http://localhost:44353/api/Pacientes/ConsultarXIdentificacion?Identificacion=" + Identificacion,
            {
                method: "GET",
                mode: "cors",
                headers: { "Content-Type": "application/json" }
            });
        //Se captura la respuesta que está en formato json y se convierto en un objeto de javascript
        const Respuesta = await Resultado.json();

        $("#txtNombrePaciente").val(Respuesta.NombrePaciente);
        $("#cboRaza").val(Respuesta.cboIdRaza);
        $("#cboSexo").val(Respuesta.cboSexo);
        $("#txtFechaNacimiento").val(Respuesta.FechaNacimiento.split('T')[0]);        
        $("#txtPeso").val(Respuesta.Peso);
        $("#txtIdCliente").val(Respuesta.IdCliente);
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
    const paciente = new Paciente($("#txtNombrePaciente").val(), $("#cboRaza").val(), $("#cboSexo").val(),
        $("#txtFechaNacimiento").val(),$("#txtPeso").val(),$("#txtIdCliente").val());
    try {
        const Resultado = await fetch("http://localhost:44353/api/Pacientes/" + Funcion,
            {
                method: Metodo,
                mode: "cors",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify(paciente)
            });
        //Se captura la respuesta que está en formato json y se convierto en un objeto de javascript
        const Respuesta = await Resultado.json();
        $("#dvMensaje").html(Respuesta);
    }
    catch (error) {
        $("#dvMensaje").html(error);
    }
}

class Pacientes {
    constructor(CodigoPaciente, NombrePaciente, cboIdRaza, cboSexo, FechaNacimiento, Peso, IdCliente) {
        this.CodigoPaciente = CodigoPaciente;
        this.NombrePaciente = NombrePaciente;
        this.cboIdRaza = cboIdRaza;
        this.cboSexo = cboSexo;
        this.FechaNacimiento = FechaNacimiento;
        this.Peso = Peso;
        this.IdCliente = IdCliente;
    }
}