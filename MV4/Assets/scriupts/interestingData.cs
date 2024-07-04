using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InterestingData : MonoBehaviour
{

    public string[] interestingData = new string[]
{
        "Los aguacates son una fruta, no una verdura. Técnicamente se consideran una baya de una sola semilla, lo creas o no.",
        "La Torre Eiffel puede ser 15 cm más alta durante el verano. Todo tiene una explicación, se debe a la expansión térmica que significa que el hierro se calienta, las partículas ganan energía cinética y     ocupan más espacio.",
        "La tripofobia es el miedo a los agujeros muy juntos. O más específicamente, 'una aversión a la vista de patrones irregulares o grupos de pequeños agujeros o protuberancias'.",
        "Australia es más ancha que la Luna. La Luna tiene 3400 km de diámetro, mientras que el diámetro de Australia de este a oeste es de casi 4000 km.",
        "'Melifluo' es un sonido que resulta agradablemente suave y musical al escucharlo. ¿Conocías esta palabra?",
        "Las Spice Girls se llamaban originalmente Touch. 'Cuando empezamos [con el nombre Touch], éramos bastante sosas', dijo Mel C a The Guardian en 2018. 'Sentíamos que teníamos que encajar en un    molde'.",
        "Los dientes humanos son la única parte del cuerpo que no puede curarse por sí misma. Los dientes están recubiertos de esmalte, que no es un tejido vivo.",
        "En Suiza es ilegal tener una sola cobaya. Se considera maltrato animal porque son seres sociales y se sienten solos.",
        "Los antiguos romanos solían echar un trozo de pan tostado en el vino para tener buena salud, de ahí que brindemos.",
        "El corazón de las gambas se encuentra en la cabeza. También tienen un sistema circulatorio abierto, lo que significa que no tienen arterias y sus órganos flotan directamente en la sangre.",
        "Amy Poehler sólo tenía siete años más que Rachel McAdams cuando asumió el papel de 'mamá guay' en 'Chicas malas'. Rachel tenía 25 años como Regina George, Amy tenía 32 como su madre.",
        "La gente es más creativa en la ducha. Cuando nos duchamos con agua caliente, experimentamos un mayor flujo de dopamina que nos hace más creativos.",
        "Los conejos bebé se llaman gazapos. ¡Qué bonito!",
        "El unicornio es el animal nacional de Escocia. Al parecer, se eligió por su relación con el dominio y la caballerosidad, así como con la pureza y la inocencia en la mitología celta.",
        "El primer avión voló el 17 de diciembre de 1903. Wilbur y Orville Wright realizaron cuatro breves vuelos en Kitty Hawk, Carolina del Norte, con su primera aeronave a motor, también conocida como el     primer avión.",
        "Venus es el único planeta que gira en el sentido de las agujas del reloj. Viaja alrededor del sol una vez cada 225 días terrestres, pero gira en el sentido de las agujas del reloj una vez cada 243      días.",
        "La nuez moscada es un alucinógeno. La especia contiene miristicina, un compuesto natural que tiene efectos alteradores de la mente si se ingiere en grandes dosis.",
        "Una botella de Borgoña francesa de 73 años se convirtió en la botella de vino más cara jamás vendida en una subasta en 2018, al alcanzar los 558.000 dólares (unos 439.300 euros). La botella de      Romanee-Conti de 1945 se vendió en Sotheby por más de 17 veces su estimación original de 32.000 dólares.",
        "Las artes solía ser un deporte olímpico. Entre 1912 y 1948, los eventos deportivos internacionales otorgaban medallas a la música, la pintura, la escultura y la arquitectura.",
        "El gorro de cocinero tiene 100 pliegues. Al parecer, pretende representar las 100 formas en que se puede cocinar un huevo.",
        "En 2014, hubo un 'match' de Tinder en la Antártida. Dos investigadores coincidieron en la aplicación global de citas en la parte más remota del mundo: un hombre que trabajaba en la estación antártica     McMurdo de Estados Unidos y una mujer que acampaba a 45 minutos en helicóptero. ¿Qué posibilidades hay?",
        "El himno nacional español no tiene letra. La 'Marcha Real' es uno de los cuatro únicos himnos nacionales del mundo (junto con los de Bosnia y Herzegovina, Kosovo y San Marino) que no tienen letra   oficial.",
        "La palabra japonesa 'Kuchi zamishi' es el acto de comer cuando no se tiene hambre porque, literalmente, 'la boca se siente sola'. Nosotras lo hacemos a menudo.",
        "La probabilidad de que exista una langosta azul es de una entre dos millones. Las langostas azules son de ese color debido a una anomalía genética que hace que produzcan más cantidad de una     determinada proteína que de otras.",
        "Los átomos que conforman nuestro cuerpo tienen más de 13.700 millones de años ya que son los mismos que se formaron durante el Big Bang.",
        "Sólo hay una letra que no aparece en el nombre de ningún estado americano. Hay una Z en Arizona y una X en Texas, pero ninguna Q en ninguno de ellos.",
        "Las icónicas suelas rojas de los zapatos Louboutin se inspiraron en Andy Warhol. El dibujo del artista pop de los años 60, 'Flowers', llamó la atención del famoso diseñador y le dio la idea de añadir     la famosa suela a sus diseños.",
        "El libro 'A la recherche du temps perdu', de Marcel Proust, contiene unos 9.609.000 caracteres, lo que lo convierte en el libro más largo del mundo. El título se traduce como 'Recuerdo de las cosas     pasadas'.",
        "Google Images se creó literalmente después de que Jennifer López llevara ese famoso vestido en los Grammy del año 2000. Tanta gente buscaba su 'look' que el motor de búsqueda añadió una función de      buscar imágenes.",
        "El reloj del Big Ben se detuvo a las 22:07 horas del 27 de mayo de 2005, probablemente debido a una temperatura extremadamente alta de 31,8 grados centígrados.",
        "Walt Disney es actualmente el que más premios de la Academia tiene. Disney ganó 26 premios Oscar a lo largo de su carrera y fue nominado un total de 59 veces.",
        "Hay una fruta que sabe a pudding de chocolate. Al parecer, hay una fruta originaria de América Central y del Sur llamada zapote negro que sabe a chocolate y a natillas dulces.",
        "La Reina Isabel II tenía formación en mecánica. Con 16 años se incorporó a la bolsa de trabajo británica y aprendió los fundamentos de la reparación de camiones. Al parecer, sabía reparar neumáticos    y  motores. ¿Hay algo que la Reina no pudiera hacer?",
        "Las cabezas de la Isla de Pascua tienen cuerpo. Hablamos de esas icónicas cabezas de piedra, ya las conoces. En la década de 2010, los arqueólogos descubrieron que dos de las figuras de las islas del     Pacífico tenían torsos que medían hasta 10 metros.",
        "Los M&M llevan el nombre de los empresarios que los crearon. Pero, ¿qué significan las M? Forrest Mars y Bruce Murrie, que al parecer no tenían la mejor relación, ya que Mars echó a Murrie y se hizo     con su 20% de participación en el negocio antes de que se convirtiera en el caramelo más vendido en Estados Unidos. Mala suerte.",
        "Las palomas pueden distinguir entre Picasso y Monet. Un estudio realizado en 1995 demuestra que las aves pueden diferenciar entre los dos artistas.",
        "El polvo que vemos a contraluz por el resplandor que entra por las ventanas, está compuesto en un 90% por nuestras células muertas.",
        "Los actores que ponen voz a Mickey y Minnie se han casado en la vida real. Russi Taylor (Minnie) y Wayne Allwine (Mickey) se casaron en 1991.",
        "Se puede escuchar el latido de una ballena azul a más de 3 kilómetros de distancia. Las ballenas azules pesan una media de entre 130.000 y 150.000 kg, y su corazón pesa aproximadamente 180 kg.",
        "La última letra añadida al alfabeto inglés fue la 'J'. La letra data de 1524, y antes se utilizaba la letra 'i' para los sonidos 'i' y 'j'.",
        "Existe una palabra para designar a alguien que opina sobre algo de lo que no sabe nada. Un 'Ultracrepidario' es alguien que opina más allá de sus conocimientos. Así lo define la RAE.",
        "La lengua se compone de 16 músculos individuales.",
        "Nadie es capaz de suicidarse conteniendo el aliento por sí mismo.",
        "El logotipo de Chupa Chups fue diseñado por Salvador Dalí. El artista surrealista diseñó el logotipo en 1969.",
        "El ketchup se vendía como medicina. El condimento se recetó y vendió a personas con indigestión en 1834.",
        "La distancia a pie más larga del mundo es de 22.531 kilómetros. Se puede ir andando desde Magadán, en Rusia, hasta Ciudad del Cabo, en Sudáfrica. No hay que volar ni navegar, sólo puentes y     carreteras  abiertas. ¿Algún viajero valiente se anima a hacerlo?",
        "La Luna tiene terremotos lunares. Se producen debido a las tensiones de las mareas relacionadas con la distancia entre la Luna y la Tierra.",
        "Los humanos son los únicos animales que se ruborizan. Al parecer, también somos los únicos animales que experimentan vergüenza. Esto se debe a que es una emoción compleja que implica entender las   opiniones de otras personas.",
        "Todos los relojes en 'Pulp Fiction' marcan las 4:20. Parece que vamos a tener que volver a ver la película para averiguarlo.",
        "Kim Kardashian tiene una cláusula de 'glamour' en su testamento. Establece que si alguna vez se encuentra en una situación en la que no pueda arreglarse ella misma, no pueda comunicarse o esté      inconsciente, alguien tiene que asegurarse de que su pelo, sus uñas y su maquillaje estén perfectos."
};
}