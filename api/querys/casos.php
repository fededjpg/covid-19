<?php
include_once ($_SERVER['DOCUMENT_ROOT']."/querys/queryCasos.php");

class Casos
{
    function getAllCase()
    {
        $caso = new QueryCasos();
        $casos = array();
        $casos["casos"] = array();

        $result = $caso->getAllCase();

        if ($result->rowCount() > 0) {
            foreach ($result as $value) {
                $item = array(
                    'id' => $value['id'],
                    'municipio' => $value['municipios'],
                    'caso' => $value['casos'],
                    'tasa_de_incidencia' => $value['tasa_incidencia']
                );
                array_push($casos["casos"], $item);
            }

            $this->printJson($casos);
        } else {
            $this->error("no hay elemtos registrados");
        }
    }
    function getOneCase($id)
    {
        $case = new QueryCasos();
        $cases = array();
        $cases['caso'] = array();

        $result = $case->getOneCase($id);

        if ($result->rowCount() === 1) {
            foreach ($result as $value) {
                $item = array(
                    'id' => $value['id'],
                    'municipio' => $value['municipios'],
                    'caso' => $value['casos'],
                    'tasa de incidencia' => $value['tasa_incidencia']
                );
                array_push($cases["caso"], $item);
            }

            $this->printJson($cases);
        } else {
            $this->error("no hay elementos registrados");
        }
    }

    function addCase($casos)
    {
        $case = new QueryCasos();
        $result = $case->addCase($casos);
        $this->exito("Nuevo caso resgitrado");
    }
    function updateCase($casos){
        $case = new QueryCasos();
        $result = $case->UpdateCase($casos);
        $this->exito("Se ha actializado correctamente");
    }
    function deleteCase($id){
        $case = new QueryCasos();
        $cases = array(); 
        $cases['items'] = array();

        $result = $case->deleteCase($id);

        if($result->rowCount() === 1){
            $this->exito("Se elimino con exito");

        }else{
           $this->error("no hay elementos registrados");
        }


    }


    function exito($success)
    {
        echo json_encode(array('mensaje' => $success), JSON_PRETTY_PRINT);
    }
    function printJson($array)
    {
        echo json_encode($array, JSON_PRETTY_PRINT);
    }

    function error($mensaje)
    {
        echo  json_encode(array('mensaje' => $mensaje), JSON_PRETTY_PRINT);
    }
}
