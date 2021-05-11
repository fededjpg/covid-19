<?php
include_once ($_SERVER['DOCUMENT_ROOT']."/querys/semaforo.php");

$api = new Semaforo();
header("Content-type: application/json"); 

if ($_SERVER['REQUEST_METHOD'] == "GET") {
    $api->getAllState();
} else if ($_SERVER['REQUEST_METHOD'] == "POST") {
    $datos = json_decode(file_get_contents('php://input'));
    if(isset($datos->estado) && isset($datos->color) && isset($datos->casos) && isset($datos->muertes)){
        $items = array(
                    'estado' => $datos->estado,
                    'color' => $datos->color,
                    'casos' => $datos->casos,
                    'muertes' => $datos->muertes
                );
                $api->addState($items);
    } else {
        $api->error("ah ocurrido un error al agregar");
    }
} else if ($_SERVER['REQUEST_METHOD'] == "PUT") {
    $datos = json_decode(file_get_contents('php://input'));

    if (isset($datos->id) && isset($datos->estado) && isset($datos->color) && isset($datos->casos) && isset($datos->muertes)) {
        $id = $datos->id;
        $estado = $datos->estado;
        $color = $datos->color;
        $casos = $datos->casos;
        $muertes = $datos->muertes;

        $items = array(
            'id' => $id,
            'estado' => $estado,
            'color' => $color,
            'casos' => $casos,
            'muertes' => $muertes
        );


        $api->updateState($items);
    } else {
        $api->error("ah ocurrido un error al actualizar");
    }
} else if ($_SERVER['REQUEST_METHOD'] == "DELETE") {
    $datos = json_decode(file_get_contents('php://input'));
    $id = $datos->id;
    if (is_numeric($id)) {
        $api->deleteState($id);
    } else {
        $api->error("Los parametros son incorrectos");
    }
} else {
    $api->error("metodo erroneo");
}
