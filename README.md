Biblioteca
Este proyecto simula una biblioteca con funcionalidades básicas de gestión de libros y usuarios. Los elementos principales son los siguientes:

Libro: Clase que representa un libro con atributos como título, autor, año de publicación, ISBN, y estado de préstamo. Incluye métodos para mostrar detalles y generar el ISBN de forma automática.

LibroFiccion: Clase que hereda de Libro y agrega el atributo de género. Sobrescribe el método para mostrar detalles.

LibroCiencia: Clase que hereda de Libro y agrega el atributo de campo científico. Sobrescribe el método para mostrar detalles.

Usuario: Clase que representa a un usuario con atributos como nombre, número de identificación y una lista de libros prestados. Incluye métodos para agregar, verificar y remover libros prestados.

Biblioteca: Clase que gestiona la colección de libros y usuarios. Ofrece métodos para agregar libros y usuarios, buscar libros por diferentes criterios, prestar y devolver libros.

Instrucciones de Uso
Crear una instancia de la clase Biblioteca.
Agregar libros y usuarios a la biblioteca mediante los métodos AgregarLibro y AgregarUsuario.
Utilizar los métodos de búsqueda para encontrar libros por autor, título o ISBN.
Prestar y devolver libros utilizando los métodos PrestarLibro y DevolverLibro.
Verificar detalles de libros y usuarios mediante los métodos MostrarDetalles.
