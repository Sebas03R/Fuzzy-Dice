# Calculadora de Pedidos

Una aplicación de Windows Forms en C# que calcula el total de un pedido basado en la cantidad de artículos seleccionados y aplica impuestos, descuentos y cargos de envío según ciertas condiciones.

## Resumen

La aplicación permite al usuario ingresar la cantidad de tres tipos diferentes de artículos (dados, dados especiales y miniaturas) y calcula el costo total del pedido, aplicando impuestos, descuentos y cargos de envío según las reglas establecidas. Además, se proporcionan funcionalidades para ingresar la cantidad de artículos y ver los resultados detallados.

## Uso de Ejemplo

1. Ingrese la cantidad de cada tipo de artículo (dados, dados especiales, miniaturas).
2. Seleccione las opciones de "Envío Gratis" si la cantidad total de artículos supera un límite.
3. Habilite o deshabilite la opción de "Descuento por Pedido Mayor a $500".
4. Haga clic en el botón "Calcular Pedido" para obtener los resultados detallados, incluyendo impuestos, descuentos y costos de envío.

## Funcionalidades

- **Cálculo Detallado:** Proporciona resultados detallados, incluyendo impuestos, descuentos y costos de envío.
- **Validación de Entrada:** Se asegura de que solo se ingresen números válidos en los campos de cantidad.
- **Impuestos y Descuentos:** Aplica impuestos del 5%, descuentos del 7% para pedidos mayores a $500.
- **Cargos de Envío:** Aplica un cargo de envío de $1.50, a menos que la cantidad total de artículos sea superior a 20, en cuyo caso el envío es gratuito.

## Capturas de Pantalla

![Calculadora de Pedidos](https://i.imgur.com/5rGLRb7.png)
