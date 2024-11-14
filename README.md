# Roll a Ball

Roll a Ball es un juego de Unity donde el jugador controla una bola con el objetivo de recolectar 12 monedas por nivel para avanzar. A medida que progresas, nuevos niveles se desbloquean. La bola puede saltar, y un enemigo controlado por IA sigue al jugador y puede eliminarlo en algunos niveles. El juego incluye un menú de inicio y un selector de niveles para navegar entre los niveles desbloqueados.

## Tabla de Contenidos 📑

1. [Comenzando 🚀](#comenzando)
    - [Pre-requisitos 📋](#pre-requisitos)
    - [Instalación 🔧](#instalación)
2. [Guía de Juego 🎮](#guia)
3. [Características Técnicas 🔍](#caracteristicas)
4. [Construido con 🛠️](#construido)
5. [Autora ✒️](#autora)

<a id="comenzando"></a>
## Comenzando 🚀

Sigue estas instrucciones para clonar el proyecto y probarlo en tu entorno local.

<a id="pre-requisitos"></a>
### Pre-requisitos 📋

Para ejecutar este proyecto necesitas:

- Unity 2022.3 o superior.
- Git (opcional, para clonar el repositorio).

<a id="instalacion"></a>
### Instalación 🔧

1. Clona el repositorio en tu máquina local:

```
git clone https://github.com/SaraCS21/Roll-a-Ball.git
```

2. Abre Unity y selecciona la opción de "Abrir Proyecto". Navega hasta la carpeta donde clonaste el repositorio y ábrelo.

<a id="guia"></a>
## Guía del Juego 🎮

### Objetivo del Juego

Recolecta las 12 monedas en cada nivel para avanzar. Cada nivel desbloqueado te llevará a un nuevo desafío y, en algunos de estos, mientras evitas a un enemigo que intentará eliminarte.

### Controles

- **Movimiento**: Usa las teclas de dirección o las teclas WASD para mover la bola.
- **Salto**: Presiona la barra espaciadora para hacer que la bola salte.

### Funcionalidades Especiales

- **Desbloqueo de Niveles**: Los niveles se desbloquean al completar los anteriores.
- **Menú de Inicio y Selector de Niveles**: Desde el menú inicial puedes seleccionar un nivel desbloqueado.

<a id="caracteristicas"></a>
## Características Técnicas 🔍

Este proyecto cumple con varios requisitos de desarrollo destacados en Unity:

1. **Configuración del juego**: El proyecto fue configurado siguiendo los pasos iniciales de *Setting up the game*.
2. **Movimiento del Jugador**: Implementación del movimiento del jugador en todas direcciones, de acuerdo con las recomendaciones de *Moving the player*.
3. **Movimiento de la Cámara**: La cámara sigue al jugador, como se explica en *Moving the camera*.
4. **Creación de Muros**: Los muros se implementaron como obstáculos, siguiendo el tutorial de *Creating the walls*.
5. **Creación de Pickups**: Las monedas (pickups) son necesarias para avanzar, como en *Creating collectibles*.
6. **Puntuación del Jugador**: Cada moneda recolectada suma puntos al marcador del jugador.
7. **Reinicio de Partida**: El jugador puede terminar el juego y volver al inicio o reiniciar el nivel.
8. **Escenas y Niveles**: Transiciones entre niveles con una estructura de desbloqueo progresivo.
9. **Salto de la Bola**: Implementado el salto de la bola, que agrega complejidad a la movilidad del jugador.
10. **Enemigo con IA**: Se incluye un enemigo que sigue al jugador usando IA y genera un desafío añadido.
11. **Personalización de Modelos 3D**: Los coleccionables del juego ahora usan un modelo 3D de moneda en lugar de los modelos básicos, y cada objeto 3D cuenta con skins personalizadas para diferenciarlos según su función.
12. **Música y Efectos Sonoros**: El juego incluye música de fondo y efectos sonoros que mejoran la experiencia inmersiva del jugador.
13. **Nivel con VR**: El nivel final funciona con la implementación de VR.

<a id="construido"></a>
## Construido con 🛠️

* [![Unity](https://img.shields.io/badge/unity-%23000000.svg?style=for-the-badge&logo=unity&logoColor=white)](https://unity.com/es) - Motor de juego utilizado para el desarrollo general y la lógica interactiva del proyecto.
* [![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)](https://learn.microsoft.com/es-es/dotnet/csharp/) - Lenguaje de programación empleado para la creación de scripts y la funcionalidad.
* [![Adobe Illustrator](https://img.shields.io/badge/adobe%20illustrator-%23FF9A00.svg?style=for-the-badge&logo=adobe%20illustrator&logoColor=white)](https://www.adobe.com/es/products/illustrator.html) - Herramienta de diseño gráfico usada para crear botones y elementos visuales del proyecto.

<a id="autora"></a>
## Autora ✒️

* **Sara del Pino Cabrera Sánchez** - *Trabajo Inicial* - [SaraCS21](https://github.com/SaraCS21)
