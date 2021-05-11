<?php
include_once ($_SERVER['DOCUMENT_ROOT']."/bd.php");

class QuerySemaforo extends Conexion{

    function getAllState(){
        $query = $this->conectar()->query("SELECT * FROM semaforos");
        return $query;
    }
    function addState($state){
        $query = $this->conectar()->prepare("INSERT INTO semaforos (estados, color, casos, muertes) VALUES (:estado, :color, :casos, :muertes)");
        $query->execute(['estado'=> $state['estado'], 'color' => $state['color'], 'casos' => $state['casos'], 'muertes' => $state['muertes']]);
        return $query; 
    }

    function updateState($state){
        $query = $this->conectar()->prepare("UPDATE semaforos SET estados  = :estado, color = :color, casos = :casos, muertes = :muertes WHERE id = :id");
        $query->execute(['id'=> $state['id'], 'estado'=> $state['estado'], 'color' => $state['color'], 'casos' => $state['casos'], 'muertes' => $state['muertes']]);
        return $query;
    }

    function deleteState($id){
        $query = $this->conectar()->prepare("DELETE FROM semaforos WHERE id = :id");
        $query->execute(['id' => $id]);
        return $query;
    }

}