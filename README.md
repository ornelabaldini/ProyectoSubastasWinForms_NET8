# Sistema de Subastas - WinForms .NET 8

Gestión de múltiples subastas simultáneas desarrollada en **C#** con **Windows Forms (.NET 8)**.  

Permite:
- Crear subastas con subastador, artículo, puja inicial, incremento, fecha, horario y duración.  
- Administrar postores con identificación única, permitiendo que participen en varias subastas al mismo tiempo.  
- Determinar automáticamente el ganador, el monto a pagar y la diferencia con la puja inicial al finalizar la subasta.  

## Estructura del proyecto
- **Models:** Entidades como `Subasta` y `Postor`.  
- **Services:** Lógica de negocio (ej. cálculo de ganador).  
- **Repository:** Manejo de datos.  
- **Views:** Formularios de Windows Forms.  

## Tecnologías
- C#  
- Windows Forms (.NET 8)  
