<?php
include_once ($_SERVER['DOCUMENT_ROOT']."/querys/casos.php");
$api = new Casos();
if($_SERVER['REQUEST_METHOD'] == "GET"){
if(isset($_GET['id'])){
    $id = $_GET['id'];
    if(is_numeric($id)){
        $api->getOneCase($id);
    }else{
        $api->error("Los parametros son incorrectos");
    }
}else{
    $api->getAllCase();
}
}else if($_SERVER['REQUEST_METHOD'] == "POST"){
    $datos = json_decode(file_get_contents('php://input'));

if(isset($datos->municipios) && isset($datos->casos) && isset($datos->tasa_incidencia)){
    $municipios = $datos->municipios;
    $casos = $datos->casos;
    $incidencia = $datos->tasa_incidencia;

    
    $items = array(
        'municipios' => $municipios,
        'casos' => $casos,
        'tasa_incidencia' => $incidencia
    );

    $api->addCase($items);
}else{
    $api->error("ah ocurrido un error al agregar");
}
}else if($_SERVER['REQUEST_METHOD'] == "PUT"){      
    $datos = json_decode(file_get_contents('php://input'));

if(isset($datos->id) && isset($datos->municipios) && isset($datos->casos) && isset($datos->tasa_incidencia)){
    $municipios = $datos->municipios;
    $casos = $datos->casos;
    $incidencia = $datos->tasa_incidencia;
    $id = $datos->id;

    
    $items = array(
        'id' => $id,
        'municipio' => $municipios,
        'caso' => $casos,
        'tasa_incidencia' => $incidencia
    );

    $api->updateCase($items);
}else{
    $api->error("ah ocurrido un error al actualizar");
}
}else if($_SERVER['REQUEST_METHOD'] == "DELETE"){
    $datos = json_decode(file_get_contents('php://input'));

if(isset($datos->id)){
    $id = $datos->id;
    if(is_numeric($id)){
        $api->deleteCase($id);
    }else{
        $api->error("Los parametros son incorrectos");
    }   
}else{
    $api->error("ha ocurrido un error");
}
}else{
    $api->error("error en la api");
}
