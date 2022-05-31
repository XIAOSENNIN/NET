<?php

    $variable = "valor";
    $variable2 = 123;

    //array vacio;

    $arreglo = array("index"=>"la clave del cajero es 1234","danko"=>"danko");
    $arreglo[] = "este es el dato 1";
    $arreglo[] = "este es el dato 2";
    $arreglo[] = "este es el dato 3";
    $arreglo[10] = "valor del codigo 10";
    $arreglo['demo'] = "hola esto es un demo";
    print_r($arreglo);

    foreach ($arreglo as $tmp) {
        echo $tmp."<br>";
    }

    $alumnos = array();
    $alumnos[] = "DANKO";
    $alumnos[] = "RENATO";
    $alumnos[] = "CATALINA";
    $alumnos[] = "";
    $alumnos[] = "";
    $alumnos[] = "";
    $alumnos[] = "";
?>
<!--
<html>
    <head>
        <meta charset="UTF-8">
        <title>Array</title>
    </head>
    <body>
        
    </body>
</html>
-->