<!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <link rel="stylesheet" href="./style.css?v=8298">
  <link rel="stylesheet" href="https://cdn.datatables.net/1.10.23/css/dataTables.bootstrap4.min.css">
  <link rel="stylesheet" href="https://cdn.datatables.net/responsive/2.2.6/css/responsive.bootstrap4.min.css">
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-eOJMYsd53ii+scO/bJGFsiCZc+5NDVN2yr8+0RDqr0Ql0h+rP48ckxlpbzKgwra6" crossorigin="anonymous">
  <title>Document</title>
</head>

<body>

  <div class=" shadow-lg gap-2 h-full mt-4 text-center">
    <h1>Semaforo de la Republica Mexicana</h1>
    <input type="search" placeholder="Buscar Estado" class="mb-2 border-2 focus:outline-none buscar-estado">
    <section class="mb-20 grid grid-cols-4 h-80 overflow-y-auto datos-semaforo">
      <div class="red"></div>
      <div class="orange"></div>
      <div class="yellow"></div>
      <div class="green"></div>

    </section>
  </div>

  <div class=" shadow-lg gap-2 h-full mt-4 text-center">
    <h1>Casos Covid en el Estado de Chiapas</h1>
    <table id="example2" class="mt-20 table table-striped table-bordered" style="width:100%"">
    <thead>
        <tr>
            <th>
                Id
            </th>
            <th>
                Municipios
            </th>
            <th>
                Casos
            </th>
            <th>
                Tasa de incidencia
            </th>
        </tr>
    </thead>
    <tbody id=" casos">

      </tbody>
    </table>
  </div>
</body>


<script src="https://code.jquery.com/jquery-3.5.1.js"></script>
<script src="https://cdn.datatables.net/1.10.24/js/jquery.dataTables.min.js"></script>
<script src="https://cdn.datatables.net/responsive/2.2.7/js/dataTables.responsive.min.js"></script>
<!-- <script src="https://cdn.datatables.net/responsive/2.2.7/js/responsive.bootstrap5.min.js"></script> -->
<script src="./js/jquerymain.js?v=452933876"></script>
<script src="./js/main.js?v=89429384"></script>

</html>