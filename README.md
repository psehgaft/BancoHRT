# BancoHRT

Aplicación .NET que simula el cajero automático de un banco, desarrollada en C# con Windows Forms.

## Descripción

BancoHRT modela las operaciones básicas de un cajero bancario: gestión de clientes, cuentas y movimientos, con una interfaz gráfica de escritorio. El proyecto incluye las clases de dominio `Banco`, `Cliente` y `Cuenta`, además de los formularios principales de la aplicación.

## Estructura del proyecto

- `BancoHRT.sln` — solución de Visual Studio
- `BancoHRT/` — código fuente de la aplicación
  - `Program.cs` — punto de entrada
  - `Form1.cs` — formulario principal
  - `Banco.cs`, `Cliente.cs`, `Cuenta.cs` — clases de dominio
  - `DiagramaBanco.cd` — diagrama de clases
- `LICENSE` — licencia GNU GPL v3

## Requisitos

- Windows con .NET Framework
- Visual Studio (2017 o superior recomendado)

## Uso

1. Abre `BancoHRT.sln` en Visual Studio.
2. Compila la solución (Build → Build Solution).
3. Ejecuta la aplicación (F5) e interactúa con el cajero simulado.

## Licencia

Este proyecto está bajo la Licencia Pública General de GNU v3 (GPL-3.0). Consulta el archivo `LICENSE` para más detalles.
