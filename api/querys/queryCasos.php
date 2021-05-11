<?php
include_once ($_SERVER['DOCUMENT_ROOT']."/bd.php");
class QueryCasos extends Conexion{
    function getAllCase(){
     $query = $this->conectar()->query("SELECT * FROM casos");
     return $query;   
    }

    function getOneCase($id){
        $query = $this->conectar()->prepare("SELECT * FROM casos WHERE id= :id");
        $query->execute(['id'=>$id]);
        return $query;
    }

    function addCase($case){
        $query = $this->conectar()->prepare("INSERT INTO casos (municipios, casos, tasa_incidencia) VALUES (:municipios, :casos, :tasa_incidencia)");
        $query->execute(['municipios'=> $case['municipios'], 'casos' => $case['casos'], 'tasa_incidencia' => $case['tasa_incidencia']]);
        return $query; 
    }

    function UpdateCase($case){
        $query = $this->conectar()->prepare("UPDATE casos SET municipios  = :municipio, casos = :caso, tasa_incidencia = :tasa_incidencia WHERE id = :id");
        $query->execute(['id'=> $case['id'], 'municipio'=> $case['municipio'], 'caso' => $case['caso'], 'tasa_incidencia' => $case['tasa_incidencia']]);
        return $query;
    }

    function deleteCase($id){
        $query = $this->conectar()->prepare("DELETE FROM casos WHERE id = :id");
        $query->execute(['id' => $id]);
        return $query;
    }
}