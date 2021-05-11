$(document).ready(function () {
  let url2 = "http://covid-19.test/api/casos.php";

  $.ajax({
    url: url2,
    dataSrc: "",
    type: "GET",
    success: function (data) {
      var myObj = JSON.parse(data);
      var obj = myObj["casos"];
      $("#example2").DataTable({
        data: obj,
        columns: [
          { data: "id" },
          { data: "municipio" },
          { data: "caso" },
          { data: "tasa_de_incidencia" },
        ],
        responsive: true,
        language: {
          sProcessing: "Procesando...",
          sLengthMenu: "Mostrar _MENU_ registros",
          sZeroRecords: "No se encontraron resultados",
          sEmptyTable: "Ningún dato disponible en esta tabla",
          sInfo:
            "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
          sInfoEmpty:
            "Mostrando registros del 0 al 0 de un total de 0 registros",
          sInfoFiltered: "(filtrado de un total de _MAX_ registros)",
          sSearch: "Buscar:",
          sInfoThousands: ",",
          sLoadingRecords: "Cargando...",
          oPaginate: {
            sFirst: "Primero",
            sLast: "Último",
            sNext: "Siguiente",
            sPrevious: "Anterior",
          },
          oAria: {
            sSortAscending:
              ": Activar para ordenar la columna de manera ascendente",
            sSortDescending:
              ": Activar para ordenar la columna de manera descendente",
          },
          buttons: {
            copy: "Copiar",
            colvis: "Visibilidad",
          },
        },
      });
    },
  });
});
