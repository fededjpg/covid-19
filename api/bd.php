<?php
class Conexion{
    private $host;
    private $db;
    private $user;
    private $pass;
    public $tabla;
    // public $conexion;

    public function __construct()
    {
        $this->host = "localhost";
        $this->db = "covid-19";
        $this->user= "root";
        $this->pass="";
    }

        public function conectar(){
            try {
            $connection = "mysql:host=". $this->host. ";dbname=". $this->db;

            $options = [
                PDO::ATTR_ERRMODE            => PDO::ERRMODE_EXCEPTION,
                PDO::ATTR_EMULATE_PREPARES   => false,
            ];

            $pdo = new PDO($connection, $this->user, $this->pass);
            return $pdo;
            

            } catch (PDOEXCEPTION $e) {
                print_r('Error connection: ' . $e->getMessage());
            }

        }
}


