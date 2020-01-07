using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AppOperadorLambda.Clases;

namespace AppOperadorLambda
{
    public partial class formContacto : Form
    {
        public formContacto()
        {
            InitializeComponent();
            cargarContactos();
        }

        private void cargarContactos()
        {
            List<Contacto> contactos = new List<Contacto>() {
                  new Contacto("Slade",
  "Arlett",
  "sarlett0@ycombinator.com",
  "264-414-7740",
  "Masculino",
  "Pácora",
  32),new Contacto("Sloane",
  "Tew",
  "stew1@baidu.com",
  "584-345-1750",
  "Masculino",
  "Debre Zeyit",
  23),new Contacto("Othilia",
  "Swigger",
  "oswigger2@fotki.com",
  "691-114-5548",
  "Femenino",
  "Choca do Mar",
  34),new Contacto("Hailee",
  "Lintott",
  "hlintott3@github.com",
  "865-522-4439",
  "Femenino",
  "Guaiúba",
  35),new Contacto("Gris",
  "Gaspero",
  "ggaspero4@yellowpages.com",
  "487-986-8733",
  "Masculino",
  "Chiri-Yurt",
  37),new Contacto("Estrellita",
  "Kemston",
  "ekemston5@163.com",
  "485-199-4398",
  "Femenino",
  "La’ershan",
  37),new Contacto("Jannelle",
  "Gaukroger",
  "jgaukroger6@sbwire.com",
  "174-444-0260",
  "Femenino",
  "Cabeço de Vide",
  22),new Contacto("Barrie",
  "Stuchbury",
  "bstuchbury7@senate.gov",
  "833-725-1881",
  "Femenino",
  "Sanya",
  31),new Contacto("Ceciley",
  "Parlour",
  "cparlour8@jalbum.net",
  "636-133-0842",
  "Femenino",
  "Ciburial",
  22),new Contacto("Gran",
  "Ritmeier",
  "gritmeier9@netscape.com",
  "770-485-2649",
  "Masculino",
  "Eschweiler",
  40),new Contacto("Alvina",
  "Toupe",
  "atoupea@mozilla.org",
  "918-337-5757",
  "Femenino",
  "Shigu",
  20),new Contacto("Clevey",
  "Gillis",
  "cgillisb@ameblo.jp",
  "163-922-6169",
  "Masculino",
  "Budaka",
  44),new Contacto("Isidor",
  "Mence",
  "imencec@upenn.edu",
  "494-630-9715",
  "Masculino",
  "Rokietnica",
  34),new Contacto("Aleksandr",
  "Lattimer",
  "alattimerd@123-reg.co.uk",
  "561-232-8762",
  "Masculino",
  "Delray Beach",
  23),new Contacto("Erin",
  "Ault",
  "eaulte@imgur.com",
  "498-808-0836",
  "Femenino",
  "Ushirombo",
  41),new Contacto("Alidia",
  "Cullinane",
  "acullinanef@ifeng.com",
  "952-290-7836",
  "Femenino",
  "Morro do Chapéu",
  18),new Contacto("Dedie",
  "Averall",
  "daverallg@exblog.jp",
  "148-825-7653",
  "Femenino",
  "Almafuerte",
  24),new Contacto("Cassandra",
  "Farr",
  "cfarrh@pbs.org",
  "703-250-8065",
  "Femenino",
  "Vicente Guerrero",
  31),new Contacto("Wendall",
  "Cockney",
  "wcockneyi@comcast.net",
  "324-489-0775",
  "Masculino",
  "Kabin Buri",
  34),new Contacto("Gar",
  "Brownbridge",
  "gbrownbridgej@utexas.edu",
  "771-685-9417",
  "Masculino",
  "Lidingö",
  21),new Contacto("Jeffy",
  "Dumingo",
  "jdumingok@w3.org",
  "153-514-8942",
  "Masculino",
  "Kukuluk",
  32),new Contacto("Marisa",
  "Hazelgrove",
  "mhazelgrovel@woothemes.com",
  "276-228-5927",
  "Femenino",
  "Challas",
  29),new Contacto("Ricki",
  "Landes",
  "rlandesm@nasa.gov",
  "303-538-4390",
  "Masculino",
  "Olyka",
  23),new Contacto("Melisandra",
  "Gilvear",
  "mgilvearn@wordpress.org",
  "862-940-1996",
  "Femenino",
  "Ushuaia",
  23),new Contacto("Gian",
  "Ace",
  "gaceo@soup.io",
  "460-111-0759",
  "Masculino",
  "Jiaqu",
  38),new Contacto("Ulises",
  "Hadwin",
  "uhadwinp@google.com.au",
  "640-914-4313",
  "Masculino",
  "Kuala Terengganu",
  40),new Contacto("Ephrayim",
  "Girdlestone",
  "egirdlestoneq@bloglovin.com",
  "942-113-9582",
  "Masculino",
  "Brok",
  20),new Contacto("Suzette",
  "Yashanov",
  "syashanovr@mapy.cz",
  "671-142-0268",
  "Femenino",
  "Syrskoye",
  30),new Contacto("Quint",
  "Crehan",
  "qcrehans@cbsnews.com",
  "553-374-0052",
  "Masculino",
  "Ćmielów",
  27),new Contacto("Zollie",
  "de Clercq",
  "zdeclercqt@edublogs.org",
  "649-139-6129",
  "Masculino",
  "Chakou",
  26)
            };
            foreach (Contacto contacto in contactos)
            {
                listaContactos.Add(contacto);
            }
        }

        private void accion_Filtrar(object sender, System.EventArgs e)
        {
            IList<Contacto> listado = new List<Contacto>();
            foreach (Contacto contacto in listaContactos.List)
            {
                listado.Add(contacto);
            }

            // Filtrado para contactos femeninos (expresiones normales)
            var filtroFemenino = from contacto in listado
                                 where
                                 contacto.Sexo.Equals("Femenino")
                                 orderby contacto.Edad descending
                                 select new
                                 {
                                     contacto.Nombre,
                                     contacto.Apellido,
                                     contacto.Sexo,
                                     contacto.Edad
                                 };

            tablaFemeninos.DataSource = filtroFemenino.ToList();

            // Filtrado para contactos masculinos (expresiones lambda)
            var filtroMasculino = listado
                .Where(n => n.Sexo.Equals("Masculino"))
                .OrderByDescending(n => n.Edad)
                .Select(n => new
                {
                    n.Nombre,
                    n.Apellido,
                    n.Sexo,
                    n.Edad
                });

            tablaMasculinos.DataSource = filtroMasculino.ToList();

            //Filtrado para contactos mayores a 30 años
            var filtroMenoresEdad = listado
                .Where(n => n.Edad > 30)
                .OrderByDescending(n => n.Edad)
                .Select(n => new
                {
                    n.Nombre,
                    n.Apellido,
                    n.Sexo,
                    n.Edad
                });

            tablaMenoresEdad.DataSource = filtroMenoresEdad.ToList();
        }
    }
}
