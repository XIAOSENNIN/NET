<?php 
    include("ClassAlumno.php");
    $apellido = "perez";
    $nombre = "juanito";
    $Juan = new Alumno("perez","juanito");

    echo $Juan->get_Nombres();
    echo "<br>";
    echo $Juan->get_Apellidos();

?>