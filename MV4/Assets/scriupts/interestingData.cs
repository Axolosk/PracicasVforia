using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InterestingData : MonoBehaviour
{

    public string[] interestingData = new string[]
{
        "Los aguacates son una fruta, no una verdura. T�cnicamente se consideran una baya de una sola semilla, lo creas o no.",
        "La Torre Eiffel puede ser 15 cm m�s alta durante el verano. Todo tiene una explicaci�n, se debe a la expansi�n t�rmica que significa que el hierro se calienta, las part�culas ganan energ�a cin�tica y     ocupan m�s espacio.",
        "La tripofobia es el miedo a los agujeros muy juntos. O m�s espec�ficamente, 'una aversi�n a la vista de patrones irregulares o grupos de peque�os agujeros o protuberancias'.",
        "Australia es m�s ancha que la Luna. La Luna tiene 3400 km de di�metro, mientras que el di�metro de Australia de este a oeste es de casi 4000 km.",
        "'Melifluo' es un sonido que resulta agradablemente suave y musical al escucharlo. �Conoc�as esta palabra?",
        "Las Spice Girls se llamaban originalmente Touch. 'Cuando empezamos [con el nombre Touch], �ramos bastante sosas', dijo Mel C a The Guardian en 2018. 'Sent�amos que ten�amos que encajar en un    molde'.",
        "Los dientes humanos son la �nica parte del cuerpo que no puede curarse por s� misma. Los dientes est�n recubiertos de esmalte, que no es un tejido vivo.",
        "En Suiza es ilegal tener una sola cobaya. Se considera maltrato animal porque son seres sociales y se sienten solos.",
        "Los antiguos romanos sol�an echar un trozo de pan tostado en el vino para tener buena salud, de ah� que brindemos.",
        "El coraz�n de las gambas se encuentra en la cabeza. Tambi�n tienen un sistema circulatorio abierto, lo que significa que no tienen arterias y sus �rganos flotan directamente en la sangre.",
        "Amy Poehler s�lo ten�a siete a�os m�s que Rachel McAdams cuando asumi� el papel de 'mam� guay' en 'Chicas malas'. Rachel ten�a 25 a�os como Regina George, Amy ten�a 32 como su madre.",
        "La gente es m�s creativa en la ducha. Cuando nos duchamos con agua caliente, experimentamos un mayor flujo de dopamina que nos hace m�s creativos.",
        "Los conejos beb� se llaman gazapos. �Qu� bonito!",
        "El unicornio es el animal nacional de Escocia. Al parecer, se eligi� por su relaci�n con el dominio y la caballerosidad, as� como con la pureza y la inocencia en la mitolog�a celta.",
        "El primer avi�n vol� el 17 de diciembre de 1903. Wilbur y Orville Wright realizaron cuatro breves vuelos en Kitty Hawk, Carolina del Norte, con su primera aeronave a motor, tambi�n conocida como el     primer avi�n.",
        "Venus es el �nico planeta que gira en el sentido de las agujas del reloj. Viaja alrededor del sol una vez cada 225 d�as terrestres, pero gira en el sentido de las agujas del reloj una vez cada 243      d�as.",
        "La nuez moscada es un alucin�geno. La especia contiene miristicina, un compuesto natural que tiene efectos alteradores de la mente si se ingiere en grandes dosis.",
        "Una botella de Borgo�a francesa de 73 a�os se convirti� en la botella de vino m�s cara jam�s vendida en una subasta en 2018, al alcanzar los 558.000 d�lares (unos 439.300 euros). La botella de      Romanee-Conti de 1945 se vendi� en Sotheby por m�s de 17 veces su estimaci�n original de 32.000 d�lares.",
        "Las artes sol�a ser un deporte ol�mpico. Entre 1912 y 1948, los eventos deportivos internacionales otorgaban medallas a la m�sica, la pintura, la escultura y la arquitectura.",
        "El gorro de cocinero tiene 100 pliegues. Al parecer, pretende representar las 100 formas en que se puede cocinar un huevo.",
        "En 2014, hubo un 'match' de Tinder en la Ant�rtida. Dos investigadores coincidieron en la aplicaci�n global de citas en la parte m�s remota del mundo: un hombre que trabajaba en la estaci�n ant�rtica     McMurdo de Estados Unidos y una mujer que acampaba a 45 minutos en helic�ptero. �Qu� posibilidades hay?",
        "El himno nacional espa�ol no tiene letra. La 'Marcha Real' es uno de los cuatro �nicos himnos nacionales del mundo (junto con los de Bosnia y Herzegovina, Kosovo y San Marino) que no tienen letra   oficial.",
        "La palabra japonesa 'Kuchi zamishi' es el acto de comer cuando no se tiene hambre porque, literalmente, 'la boca se siente sola'. Nosotras lo hacemos a menudo.",
        "La probabilidad de que exista una langosta azul es de una entre dos millones. Las langostas azules son de ese color debido a una anomal�a gen�tica que hace que produzcan m�s cantidad de una     determinada prote�na que de otras.",
        "Los �tomos que conforman nuestro cuerpo tienen m�s de 13.700 millones de a�os ya que son los mismos que se formaron durante el Big Bang.",
        "S�lo hay una letra que no aparece en el nombre de ning�n estado americano. Hay una Z en Arizona y una X en Texas, pero ninguna Q en ninguno de ellos.",
        "Las ic�nicas suelas rojas de los zapatos Louboutin se inspiraron en Andy Warhol. El dibujo del artista pop de los a�os 60, 'Flowers', llam� la atenci�n del famoso dise�ador y le dio la idea de a�adir     la famosa suela a sus dise�os.",
        "El libro 'A la recherche du temps perdu', de Marcel Proust, contiene unos 9.609.000 caracteres, lo que lo convierte en el libro m�s largo del mundo. El t�tulo se traduce como 'Recuerdo de las cosas     pasadas'.",
        "Google Images se cre� literalmente despu�s de que Jennifer L�pez llevara ese famoso vestido en los Grammy del a�o 2000. Tanta gente buscaba su 'look' que el motor de b�squeda a�adi� una funci�n de      buscar im�genes.",
        "El reloj del Big Ben se detuvo a las 22:07 horas del 27 de mayo de 2005, probablemente debido a una temperatura extremadamente alta de 31,8 grados cent�grados.",
        "Walt Disney es actualmente el que m�s premios de la Academia tiene. Disney gan� 26 premios Oscar a lo largo de su carrera y fue nominado un total de 59 veces.",
        "Hay una fruta que sabe a pudding de chocolate. Al parecer, hay una fruta originaria de Am�rica Central y del Sur llamada zapote negro que sabe a chocolate y a natillas dulces.",
        "La Reina Isabel II ten�a formaci�n en mec�nica. Con 16 a�os se incorpor� a la bolsa de trabajo brit�nica y aprendi� los fundamentos de la reparaci�n de camiones. Al parecer, sab�a reparar neum�ticos    y  motores. �Hay algo que la Reina no pudiera hacer?",
        "Las cabezas de la Isla de Pascua tienen cuerpo. Hablamos de esas ic�nicas cabezas de piedra, ya las conoces. En la d�cada de 2010, los arque�logos descubrieron que dos de las figuras de las islas del     Pac�fico ten�an torsos que med�an hasta 10 metros.",
        "Los M&M llevan el nombre de los empresarios que los crearon. Pero, �qu� significan las M? Forrest Mars y Bruce Murrie, que al parecer no ten�an la mejor relaci�n, ya que Mars ech� a Murrie y se hizo     con su 20% de participaci�n en el negocio antes de que se convirtiera en el caramelo m�s vendido en Estados Unidos. Mala suerte.",
        "Las palomas pueden distinguir entre Picasso y Monet. Un estudio realizado en 1995 demuestra que las aves pueden diferenciar entre los dos artistas.",
        "El polvo que vemos a contraluz por el resplandor que entra por las ventanas, est� compuesto en un 90% por nuestras c�lulas muertas.",
        "Los actores que ponen voz a Mickey y Minnie se han casado en la vida real. Russi Taylor (Minnie) y Wayne Allwine (Mickey) se casaron en 1991.",
        "Se puede escuchar el latido de una ballena azul a m�s de 3 kil�metros de distancia. Las ballenas azules pesan una media de entre 130.000 y 150.000 kg, y su coraz�n pesa aproximadamente 180 kg.",
        "La �ltima letra a�adida al alfabeto ingl�s fue la 'J'. La letra data de 1524, y antes se utilizaba la letra 'i' para los sonidos 'i' y 'j'.",
        "Existe una palabra para designar a alguien que opina sobre algo de lo que no sabe nada. Un 'Ultracrepidario' es alguien que opina m�s all� de sus conocimientos. As� lo define la RAE.",
        "La lengua se compone de 16 m�sculos individuales.",
        "Nadie es capaz de suicidarse conteniendo el aliento por s� mismo.",
        "El logotipo de Chupa Chups fue dise�ado por Salvador Dal�. El artista surrealista dise�� el logotipo en 1969.",
        "El ketchup se vend�a como medicina. El condimento se recet� y vendi� a personas con indigesti�n en 1834.",
        "La distancia a pie m�s larga del mundo es de 22.531 kil�metros. Se puede ir andando desde Magad�n, en Rusia, hasta Ciudad del Cabo, en Sud�frica. No hay que volar ni navegar, s�lo puentes y     carreteras  abiertas. �Alg�n viajero valiente se anima a hacerlo?",
        "La Luna tiene terremotos lunares. Se producen debido a las tensiones de las mareas relacionadas con la distancia entre la Luna y la Tierra.",
        "Los humanos son los �nicos animales que se ruborizan. Al parecer, tambi�n somos los �nicos animales que experimentan verg�enza. Esto se debe a que es una emoci�n compleja que implica entender las   opiniones de otras personas.",
        "Todos los relojes en 'Pulp Fiction' marcan las 4:20. Parece que vamos a tener que volver a ver la pel�cula para averiguarlo.",
        "Kim Kardashian tiene una cl�usula de 'glamour' en su testamento. Establece que si alguna vez se encuentra en una situaci�n en la que no pueda arreglarse ella misma, no pueda comunicarse o est�      inconsciente, alguien tiene que asegurarse de que su pelo, sus u�as y su maquillaje est�n perfectos."
};
}