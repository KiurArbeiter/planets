using TARpe22MauiPlanets.Models;


namespace TARpe22MauiPlanets.Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "  The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the smallest planet in the Solar " +
                "System and the closest to the Sun. Its orbit around the Sun takes " +
                "87.97 Earth days, the shortest of all the Sun's planets. " +
                "It is named after the Roman god Mercurius (Mercury), god " +
                "of commerce, messenger of the gods, and mediator between gods " +
                "and mortals, corresponding to the Greek god Hermes (Ἑρμῆς). Like " +
                "Venus, Mercury orbits the Sun within Earth's orbit as an inferior " +
                "planet; its apparent distance from the Sun as viewed from Earth " +
                "never exceeds 28°.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/05/pia19422-mercury.jpg"
                }
            },

            new()
            {
                Name = "Venus",
                Subtitle = "  The pressure cooker",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. It is sometimes " +
                "called Earth's \"sister\" or \"twin\" planet as it is almost as large " +
                "and has a similar composition. As an interior planet to Earth, Venus " +
                "(like Mercury) appears in Earth's sky never far from the Sun, either as " +
                "morning star or evening star. Aside from the Sun and Moon, Venus is the " +
                "brightest natural object in Earth's sky, capable of casting visible " +
                "shadows on Earth in dark conditions and being visible to the naked eye " +
                "in broad daylight.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://static01.nyt.com/images/2020/09/22/science/19SCI-OUTTHERE-VENUS1/19SCI-OUTTHERE-VENUS1-articleLarge.jpg?quality=75&auto=webp&disable=upscale",
                    "https://www.jhuapl.edu/sites/default/files/2023-01/20210603_image1_med.jpg",
                    "https://science.nasa.gov/wp-content/uploads/2023/09/Venus.jpg?w=4096&format=jpeg"
                }
            },

            new()
            {
                Name = "Earth",
                Subtitle = "  The cradle of life",
                HeroImage = "earth.png",
                Description = "Earth is the third planet from the Sun and the " +
                "only place known in the universe where life has originated and " +
                "found habitability. While Earth may not contain the largest " +
                "volumes of water in the Solar System, only Earth sustains liquid " +
                "surface water, extending over 70.8% of the Earth with its ocean, " +
                "making Earth an ocean world. Earth's polar regions currently " +
                "retain most of all other water with large sheets of ice covering " +
                "ocean and land, dwarfing Earth's groundwater, lakes, rivers and " +
                "atmospheric water.",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },

                        new()
            {
                Name = " Mars",
                Subtitle = "  The iron planet",
                HeroImage = "mars.png",
                Description = "Mars is the fourth planet from the Sun – a dusty, " +
                            "cold, desert world with a very thin atmosphere. " +
                            "Mars is also a dynamic planet with seasons, polar " +
                            "ice caps, canyons, extinct volcanoes, and evidence " +
                            "that it was even more active in the past.",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },

            new()
            {
                Name = " Jupiter",
                Subtitle = "  The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and " +
                "the largest in the Solar System. It is a gas giant with " +
                "a mass more than two and a half times that of all the " +
                "other planets in the Solar System combined, and slightly " +
                "less than one one-thousandth the mass of the Sun.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/2/2b/Jupiter_and_its_shrunken_Great_Red_Spot.jpg",
                    "https://images.delfi.ee/media-api-image-cropper/v1/54dd75e0-b7dc-11eb-b2a3-a99842433e6e.jpg?noup&w=1200&h=711&ch=0.687&cw=1&cx=0&cy=0.0931&r=16:9",
                    "https://i.ytimg.com/vi/3afEX8a2jPg/maxresdefault.jpg"
                }
            },

                        new()
            {
                Name = " Saturn",
                Subtitle = "  The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and " +
                            "the second-largest in the Solar System, after " +
                            "Jupiter. It is a gas giant with an average " +
                            "radius of about nine and a half times that " +
                            "of Earth. It has only one-eighth the average " +
                            "density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c7/Saturn_during_Equinox.jpg/800px-Saturn_during_Equinox.jpg",
                    "https://www.digitec.ch/im/Files/7/5/0/6/9/3/0/3/shutterstock_167745412621.png?impolicy=ProductTileImage&resizeWidth=1136&resizeHeight=568&cropWidth=1136&cropHeight=568",
                    "https://a57.foxnews.com/static.foxnews.com/foxnews.com/content/uploads/2023/05/1200/675/Ring-Rocks.jpg?ve=1&tl=1"
                }
            },

            new()
            {
                Name = " Uranus",
                Subtitle = "  The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. " +
                "It is named after Greek sky deity Uranus (Caelus), who in " +
                "Greek mythology is the father of Cronus (Saturn), a grandfather " +
                "of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus " +
                "has the third-largest planetary radius and fourth-largest " +
                "planetary mass in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://lovethenightsky.com/wp-content/uploads/2020/12/image-3.jpeg",
                    "https://www.funkidslive.com/wp-content/uploads/2022/10/yto1u-i1pvi-1024x585.jpg",
                    "https://images.ctfassets.net/cnu0m8re1exe/5kMBUaBzV7Iq03C7e1ZsTZ/215894a6a88e73580d2cfe5370a88af5/shutterstock_1666194169.jpg?fm=jpg&fl=progressive&w=660&h=433&fit=fill"
                }
            },

            new()
            {
                Name = " Neptune",
                Subtitle = "  The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth planet from the Sun and " +
                "the farthest known planet in the Solar System. It is the " +
                "fourth-largest planet in the Solar System by diameter, the " +
                "third-most-massive planet, and the densest giant planet. " +
                "It is 17 times the mass of Earth, and slightly more " +
                "massive than its near-twin Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2023/09/PIA01492-1.jpg",
                    "https://images.squarespace-cdn.com/content/v1/5fa5ec79661ee904d2973ca0/1678752888290-2A53B1ST09WTKNPYW35R/neptune.png",
                    "https://science.nasa.gov/wp-content/uploads/2023/09/PIA01492-1.jpg"
                }
            },
            new()
            {
                Name = " Pluto",
                Subtitle = "  Dwarf planet",
                HeroImage = "Pluto.png",
                Description = "Pluto is a dwarf planet located in a distant region of our solar system beyond Neptune known as the Kuiper Belt. " +
                "Pluto was long considered our ninth planet, but the International Astronomical " +
                "Union reclassified Pluto as a dwarf planet in 2006. ",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://science.nasa.gov/wp-content/uploads/2023/09/pluto_natural_color_20150714_detail.jpg",
                    "https://i0.wp.com/www.sciencenews.org/wp-content/uploads/2021/08/082821_pluto_feat.jpg?resize=1440%2C700&ssl=1",
                    "https://planetary.s3.amazonaws.com/web/assets/pictures/20151106_crop_p_color2_enhanced_release-superenhanced-2k-dc-ir-zld.png"
                },
            },
            new()
            {
                Name = " Ceres",
                Subtitle = "  Dwarf",
                HeroImage = "ceres.png",
                Description = "Dwarf planet Ceres is the largest object in the asteroid belt between Mars and Jupiter, and it's the only dwarf " +
                "planet located in the inner solar system. It was the first member of the asteroid belt to be discovered when  " +
                "Giuseppe Piazzi spotted it in 1801. When NASA's Dawn arrived in 2015, Ceres became the first dwarf planet to " +
                "be explored by a spacecraft. ",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/7/76/Ceres_-_RC3_-_Haulani_Crater_%2822381131691%29_%28cropped%29.jpg",
                    "https://media2.spaceref.com/news/2022/ooceres.jpg",
                    "https://static.wikia.nocookie.net/space-sailors/images/2/24/Ceres1.png/revision/latest?cb=20210418214220"
                },
            },
            new()
            {
                Name = "  Haumea",
                Subtitle = "Secret Santa",
                HeroImage = "haumea.png",
                Description = " " +
                "Dwarf planet Haumea was originally designated 2003 EL61 (and nicknamed Santa by one discovery team)." +
                "  Haumea is located in the Kuiper Belt," +
                "  a doughnut-shaped region of icy bodies beyond the orbit of Neptune." +
                "  Haumea is an oval-shaped dwarf planet that is roughly the same size as Pluto." +
                "  It is one of the fastest rotating large objects in our solar system. ",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Haumea_Rotation.gif/213px-Haumea_Rotation.gif",
                    "https://astrophotographylens.com/cdn/shop/articles/Haumea.jpg?v=1693095371&width=1000",
                    "https://media.istockphoto.com/id/1211739638/photo/haumea-dwarf-planet-rotating-in-the-outer-space-3d-render.jpg?s=612x612&w=0&k=20&c=3bkcnYwR3p70yfaTVNxBMS9AqScR8RGNVsgVBGCZTZ4="
                }
            },
            new()
            {
                Name = " MakeMake",
                Subtitle = "  Dwarf planet",
                HeroImage = "MakeMake.png",
                Description = "a donut-shaped region of icy bodies beyond the orbit of Neptune. " +
                " Makemake is slightly smaller than Pluto, and is the second-brightest object in the Kuiper Belt as seen from Earth while Pluto is the brightest. "+
                ". It takes about 305 Earth years for this dwarf planet to make one trip around the Sun. ",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://astronz.nz/cdn/shop/articles/makemake.png?v=1682129134",
                    "https://astrophotographylens.com/cdn/shop/articles/Makemake.jpg?v=1693095521",
                    "https://t3.ftcdn.net/jpg/02/71/65/72/360_F_271657225_YpXVrmeDE5mnqvWkmkHTiFoKN2SAY8xx.jpg"
                },
            },
            new()
            {
                Name = " Eris",
                Subtitle = "  Dwarf planet",
                HeroImage = "Eris.png",
                Description = "Eris was discovered on Jan. 5, 2005, from data obtained on Oct. 21, 2003, during a Palomar Observatory" +
                "survey of the outer solar system by Mike Brown, a professor of planetary astronomy at the California Institute" +
                "of Technology; Chad Trujillo of the Gemini Observatory; and David Rabinowitz of Yale University.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://i.natgeofe.com/n/495a21cb-c570-43d8-b5f7-3dfbedb91932/42531.jpg",
                    "https://xalqqazeti.az/uploads/news/41958/17001416213730312658_1200x630.jpg",
                    "https://i.cbc.ca/1.1936894.1381378170!/httpImage/hi-852-eris-eso1142a.jpg"
                },
            },

    };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizedPlanets = planets.OrderBy(item => random.Next());

            return randomizedPlanets.Take(2).ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
