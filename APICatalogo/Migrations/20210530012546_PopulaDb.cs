using Microsoft.EntityFrameworkCore.Migrations;

namespace APICatalogo.Migrations
{
    public partial class PopulaDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Insert into ""Categorias""(""Nome"", ""ImagemUrl"") Values('Bebidas', 'http://www.macoratti.net/Imagens/1.jpg')");
            migrationBuilder.Sql(@"Insert into ""Categorias""(""Nome"", ""ImagemUrl"") Values('Lanches', 'http://www.macoratti.net/Imagens/2.jpg')");
            migrationBuilder.Sql(@"Insert into ""Categorias""(""Nome"", ""ImagemUrl"") Values('Sobremesas', 'http://www.macoratti.net/Imagens/3.jpg')");

            migrationBuilder.Sql(@"Insert into ""Produtos""(""Nome"", ""Descricao"", ""Preco"", ""ImagemUrl"", ""Estoque"", ""DataCadastro"", ""CategoriaId"")" +
                "Values('Coca-Cola Diet', 'Refrigerante de cola', 5.45, 'http://www.macoratti.net/Imagens/coca.jpg', 50, now(), " +
                @"(SELECT ""CategoriaId"" from ""Categorias"" where ""Nome""='Bebidas'))");
            migrationBuilder.Sql(@"Insert into ""Produtos""(""Nome"", ""Descricao"", ""Preco"", ""ImagemUrl"", ""Estoque"", ""DataCadastro"", ""CategoriaId"")" +
                "Values('Lanche de Atum', 'Lanche de Atum com maionese', 8.50, 'http://www.macoratti.net/Imagens/atum.jpg', 10, now(), " +
                @"(SELECT ""CategoriaId"" from ""Categorias"" where ""Nome""='Lanches'))");
            migrationBuilder.Sql(@"Insert into ""Produtos""(""Nome"", ""Descricao"", ""Preco"", ""ImagemUrl"", ""Estoque"", ""DataCadastro"", ""CategoriaId"")" +
                "Values('Pudim 100g', 'Pudim de leite condensado 100g', 6.75, 'http://www.macoratti.net/Imagens/pudim.jpg', 20, now(), " +
                @"(SELECT ""CategoriaId"" from ""Categorias"" where ""Nome""='Sobremesas'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"delete from ""Categorias""");
            migrationBuilder.Sql(@"delete from ""Produtos""");
        }
    }
}
