Este archivo `README.md` debe estar en la raíz de la carpeta abierta en Visual Studio Code; en caso contrario deben usar el comando **File|Open Folder...** para abrir la carpeta que lo contiene.

En este problema deben demostrar que saben cómo distribuir responsabilidades utilizando el patrón Expert.

Sean las siguientes tarjetas CRC de las clases `Publication` y `PublicationItem`:

<table id="card">
    <tr>
        <td align="center" colspan="2">
            <p><b>Publication</b></p>
        </td>
    </tr>
    <tr>
        <td>
            <p>Conocer la fecha final de la publicación</p>
            <p>Conocer los ítems publicados y agregar y remover ítems a la publicación</p>
            <p>Obtener el texto de la publicación para mostrar</p>
        </td>
        <td>
            <p>PublicationItem</p>
        </td>
    </tr>
</table>

El texto de la publicación luce así:
```bash
Fecha: 31/3/2021
1 de 'Caja de cartón' a $23
4 de 'Placa de cartón' a $56
```

������ El formato preciso del texto de la publicación no es importante **en la medida que incluya para cada ítem publicado la cantidad, el nombre del material y el precio**. Noten que la cantidad y el precio son responsabilidades de la clase `PublicationItem` y el nombre del material es una responsabilidad de conocer de la clase `Material`.

<table id="card">
    <tr>
        <td align="center" colspan="2">
            <p><b>PublicationItem</b></p>
        </td>
    </tr>
    <tr>
        <td>
            <p>Conocer el material publicado</p>
            <p>Conocer la cantidad del material</p>
            <p>Conocer el precio del material</p>
        </td>
        <td>
            <p>Material</p>
        </td>
    </tr>
</table>

**Consigna:**

Dadas estas tarjetas CRC y el código correspondiente en las carpetas `src` y `test`, completar el código que falta para:

1. Determinar qué clase debe tener la responsabilidad de conocer el costo total de una publicación.
2. Que pasen todos los casos de prueba provistos

⚠️ No deben modificar los casos de prueba.

������ El costo total de una publicación se calcula como la suma de los sub totales de sus ítems, y el sub total de un ítem se calculo como el producto de la cantidad por el precio del ítem.