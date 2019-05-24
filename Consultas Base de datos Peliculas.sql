use BibliotecaPeliculas
/*muestra todas las peliculas y su categoria*/
select nombre, categoria from Pelicula

/*muestra las peliculas con una categoria especifica*/
select * from Pelicula where categoria = 'fantasia'

/*muestra todas las peliculas que tiene un cliente*/
select nombre from Pelicula where cliente = '2468'

/*muestra una pelicula en especifico*/
select nombre from Pelicula where nombre = 'harry potter y la orden del fenix'

/*muestra todas las visitas*/
select * from Pelicula

/*muestra datos del cliente*/
select * from Cliente
