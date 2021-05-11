<?php 
include_once ($_SERVER['DOCUMENT_ROOT']."/querys/querySemaforo.php");

class Semaforo{
    function getAllState(){
        $semaforo = new QuerySemaforo();
        $semaforos = array();

        $result = $semaforo->getAllState();

        if($result->rowCount() >0 ){
            foreach ($result as $value) {
                $item = array(
                    'id' => $value['id'],
                    'estado'=> $value['estados'],
                    'color'=> $value['color'],
                    'casos'=> $value['casos'],
                    'muertes' => $value['muertes']
                );
                array_push($semaforos, $item);
            }

           $this->printJson($semaforos);

        }else{
           $this->error("no hay elemtos registrados");
        }
    }

    
    function addState($states)
    {
        $state = new QuerySemaforo();
        $result = $state->addState($states);
        $this->exito("Nuevo estado resgitrado");
    }
    function updateState($states){
        $state = new QuerySemaforo();
        $result = $state->updateState($states);
        $this->exito("Se ha actializado el estado correctamente");
    }
    function deleteState($id){
        $state = new QuerySemaforo();
        $cases = array(); 
        $cases['items'] = array();

        $result = $state->deleteState($id);

        if($result->rowCount() === 1){
            $this->exito("Se elimino con exito el estado");

        }else{
           $this->error("no hay elementos registrados");
        }


    }


    function exito($success){
        echo json_encode(array('mensaje' => $success));
    }
    function printJson($array){
        echo  json_encode($array, JSON_PRETTY_PRINT);
    }

    function error($mensaje){
        echo json_encode(array('mensaje'=> $mensaje));
    }
}