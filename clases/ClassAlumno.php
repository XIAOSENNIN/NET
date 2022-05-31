<?php 
    class Alumno
    {
        private $Apellidos;
        private $Nombres;

        function __construct($ape,$nom)
        {
            $this->Apellidos = $ape;
            $this->Nombres = $nom;
        }

        public function get_Apellidos()
        {
            return $this->Apellidos;
        }

        public function get_Nombres()
        {
            return $this->Nombres;
        }

    }


?>