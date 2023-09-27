using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoutiqueCafe.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prix = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EstPopulaire = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Produits",
                columns: new[] { "Id", "Description", "EstPopulaire", "ImageUrl", "Nom", "Prix" },
                values: new object[,]
                {
                    { 1, "Le café Americano est une boisson classique à base d'espresso, simple mais satisfaisante. Il est préparé en ajoutant de l'eau chaude à une dose d'espresso, ce qui dilue l'intensité et donne un café riche et audacieux avec une finale douce. Cette boisson polyvalente peut être dégustée seule ou avec un peu de crème, ce qui en fait un choix populaire auprès des amateurs de café du monde entier. Que vous ayez besoin d'un remontant le matin ou d'un coup de pouce à midi, l'Americano est un choix fiable qui ne manque jamais de répondre à vos attentes.", false, "https://res.cloudinary.com/durcypdqc/image/upload/v1675704066/Coffee%20Shop%20Asp%20.NET%20Core%20Assets/americano_gorkrx.png", "Americano", 10m },
                    { 2, "Le café Cortado est une boisson à base de café traditionnelle espagnole qui a gagné en popularité dans le monde entier. C'est un café doux et crémeux qui combine des parts égales d'espresso et de lait chaud, créant un équilibre parfait entre une saveur de café intense et une onctuosité riche. Ce café est parfait pour les amateurs de café qui souhaitent un peu de douceur dans leur café sans sacrifier sa saveur robuste. Le café Cortado est préparé à partir de grains d'espresso de haute qualité, fraîchement infusés et combinés avec du lait cuit à la vapeur pour créer un café velouté, onctueux et savoureux. Que vous soyez amateur de café ou amateur de café, le café Cortado est le café parfait pour commencer votre journée ou pour le déguster l'après-midi. Essayez notre café Cortado aujourd'hui et découvrez le goût unique et satisfaisant de cette boisson à base de café traditionnelle espagnole.", true, "https://res.cloudinary.com/durcypdqc/image/upload/v1675704067/Coffee%20Shop%20Asp%20.NET%20Core%20Assets/cortado_rs5lwa.png", "Cortado", 10m },
                    { 3, "Le café moka est un mélange riche et crémeux qui allie la saveur audacieuse du café à la douceur du chocolat. Cette délicieuse boisson est parfaite pour ceux qui aiment le goût du chocolat mais qui apprécient également un bon café. Le café moka est préparé avec une dose d'espresso, de lait cuit à la vapeur et de sirop de chocolat. Le résultat est une boisson onctueuse et crémeuse avec un goût sucré et chocolaté et une finale de café prononcée. Que vous recherchiez une gourmandise sucrée et gourmande ou un remontant le matin, le café Moka saura satisfaire vos envies. Obtenez votre dose de cette délicieuse boisson dès aujourd'hui et découvrez le mariage parfait du café et du chocolat !", false, "https://res.cloudinary.com/durcypdqc/image/upload/v1675704066/Coffee%20Shop%20Asp%20.NET%20Core%20Assets/mocha_a80hlu.png", "Mocha", 14m },
                    { 4, "Le café Macchiato est une boisson classique à base d'espresso avec une saveur riche et crémeuse et une texture douce et veloutée. Fabriquée à partir de grains de café de haute qualité sélectionnés à la main, cette boisson est le remontant parfait pour les amateurs de café qui recherchent un goût fort et audacieux sans l'amertume ou la dureté de l'espresso traditionnel. Avec une couche de lait dense et moussé qui repose sur l'espresso, le café Macchiato est l'équilibre parfait entre la saveur audacieuse du café et la douceur crémeuse. Que vous soyez un professionnel occupé ayant besoin d'un coup de pouce matinal ou un amateur d'espresso à la recherche d'une expérience de café plus raffinée, le café Macchiato est le choix ultime pour tous ceux qui aiment le café. Alors pourquoi attendre ? Visitez notre boutique de café en ligne dès aujourd'hui et essayez un café Macchiato dès aujourd'hui !", true, "https://res.cloudinary.com/durcypdqc/image/upload/v1675704064/Coffee%20Shop%20Asp%20.NET%20Core%20Assets/macchiato_jelmpv.png", "Macchiato", 4m },
                    { 5, "Le Flat White Coffee est une boisson classique à base d’espresso qui est un incontournable dans les cafés du monde entier. Ce café onctueux et crémeux est composé d'espresso parfaitement tirés, recouverts de lait cuit à la vapeur velouté et d'une fine couche de micromousse. Cela donne au Flat White sa texture douce et crémeuse caractéristique et une riche saveur de café équilibrée par la douceur du lait. Le Flat White est un café parfait pour ceux qui aiment un goût de café fort avec une touche de douceur. Que vous soyez un amateur de café ou que vous recherchiez simplement un délicieux café pour commencer votre journée, un Flat White de notre magasin est le choix parfait !", false, "https://res.cloudinary.com/durcypdqc/image/upload/v1675704064/Coffee%20Shop%20Asp%20.NET%20Core%20Assets/flat-white_icl8cr.png", "Flat White", 8m },
                    { 6, "Le café décaféiné, également connu sous le nom de café décaféiné, est une boisson à base de café dont la majorité de sa teneur en caféine a été supprimée. C'est une option parfaite pour ceux qui apprécient le goût et l'arôme du café, mais qui souhaitent éviter les effets stimulants de la caféine. Le café décaféiné est composé à 100 % de grains Arabica, soigneusement torréfiés pour faire ressortir leur douceur naturelle et leur saveur riche. Que vous soyez un amateur de café ou que vous recherchiez simplement une tasse de café réconfortante, le café décaféiné est le choix parfait. Il offre tout le goût délicieux du café ordinaire, sans la nervosité de la caféine, ce qui en fait un choix idéal pour siroter tard le soir, pour prendre un remontant le matin ou l'après-midi, ou simplement lorsque vous souhaitez vous détendre et savourer une tasse de café. Alors pourquoi attendre ? Offrez-vous une délicieuse tasse de café décaféiné aujourd'hui et savourez le goût du café, sans caféine.", false, "https://res.cloudinary.com/durcypdqc/image/upload/v1675704069/Coffee%20Shop%20Asp%20.NET%20Core%20Assets/decaf-coffee_p3bth2.png", "Decaf", 3m },
                    { 7, "Le café irlandais est une boisson chaude et réconfortante qui combine la saveur audacieuse du café avec la douceur douce du whisky irlandais et une touche de crème. Notre version de ce cocktail classique est composée de café riche et audacieux et du meilleur whisky irlandais pour un équilibre parfait de saveurs. La crème est doucement fouettée jusqu'à obtenir une consistance lisse et versée sur le café, créant une couche luxueuse et crémeuse qui équilibre la chaleur du whisky. Que vous recherchiez une boisson agréable par une journée froide ou un dernier verre amusant après une soirée, le café irlandais est un choix parfait. Commandez le vôtre dès aujourd'hui et découvrez le mélange parfait de café et de whisky.", true, "https://res.cloudinary.com/durcypdqc/image/upload/v1675704079/Coffee%20Shop%20Asp%20.NET%20Core%20Assets/Irish_Coffee_ncjb0t.png", "Irish Coffee", 6m },
                    { 8, "Le café glacé est une façon rafraîchissante et délicieuse de savourer votre café, parfait pour les chaudes journées d'été ou pour tous ceux qui recherchent un remontant frais. Notre café glacé est préparé à partir de café fraîchement moulu de haute qualité, qui est ensuite refroidi et servi sur de la glace. Nous utilisons uniquement les meilleurs grains de café, torréfiés de manière experte pour faire ressortir leur saveur riche et corsée, garantissant que chaque gorgée soit un régal. Notre café glacé est disponible dans une variété de saveurs, notamment le noir classique, la vanille, le caramel et le moka, ce qui en fait le choix idéal pour les amateurs de café de tous les goûts. Alors pourquoi attendre ? Offrez-vous un verre de café glacé froid et rafraîchissant dès aujourd'hui !", false, "https://res.cloudinary.com/durcypdqc/image/upload/v1675704079/Coffee%20Shop%20Asp%20.NET%20Core%20Assets/Iced_Coffee_o2nenz.png", "Iced Coffee", 5m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produits");
        }
    }
}
