<?php
include("libreria.php");
function pasarMayuscula($texto)
{

    return strtoupper($texto);
}

function escribirNombre(){
    echo "mi nombre es pepito";
}


?>
<html>
    <head>
        <meta charset="UTF-8">
        <title>Funciones</title>
    </head>
    <body>
        <?php escribirNombre();?>
        <br>
        <?php echo "hola usted se llama: ".pasarMayuscula(pasarChokita("angelito"));?>
    </body>
</html>