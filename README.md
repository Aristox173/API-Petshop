# ApiPetshop
Esta API proporciona endpoints para gestionar clientes y productos de una tienda de mascotas.
## Tecnologías Utilizadas
* ASP.NET Core
* Entity Framework Core
* Microsoft SQL Server
## Configuración
1. Clona este repositorio en tu máquina local.
2. Asegúrate de tener .NET Core SDK instalado.
3. Configura la cadena de conexión a la base de datos en el archivo appsettings.json.

```
"ConnectionStrings": {
  "ConnectionStr": "TuCadenaDeConexion"
}
```
4. Ejecuta las migraciones para crear la base de datos:
```
dotnet ef database update
```
## Endpoints
### Cliente
* GET /api/cliente: Obtiene la lista de clientes.
* GET /api/cliente/{id}: Obtiene un cliente por su ID.
* POST /api/cliente: Agrega un nuevo cliente.
* PUT /api/cliente/{id}: Actualiza los datos de un cliente existente.
* DELETE /api/cliente/{id}: Elimina un cliente por su ID.
### Producto
* GET /api/producto: Obtiene la lista de productos.
* GET /api/producto/{id}: Obtiene un producto por su ID.
* POST /api/producto: Agrega un nuevo producto.
* PUT /api/producto/{id}: Actualiza los datos de un producto existente.
* DELETE /api/producto/{id}: Elimina un producto por su ID.
## Uso
1. Ejecuta la aplicación:
```
dotnet run
```
2. Accede a la documentación de la API en http://localhost:5000/swagger.
