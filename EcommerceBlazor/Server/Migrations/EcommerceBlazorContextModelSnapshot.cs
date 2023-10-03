﻿// <auto-generated />
using System;
using EcommerceBlazor.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommerceBlazor.Server.Migrations
{
    [DbContext(typeof(EcommerceBlazorContext))]
    partial class EcommerceBlazorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EcommerceBlazor.Shared.Categoria", b =>
                {
                    b.Property<int>("Categoria_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Categoria_ID"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Categoria_ID");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            Categoria_ID = 1,
                            Nome = "Livros",
                            Url = "livros"
                        },
                        new
                        {
                            Categoria_ID = 2,
                            Nome = "Filmes",
                            Url = "filmes"
                        },
                        new
                        {
                            Categoria_ID = 3,
                            Nome = "Video Games",
                            Url = "video-games"
                        });
                });

            modelBuilder.Entity("EcommerceBlazor.Shared.Produto", b =>
                {
                    b.Property<int>("Produto_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Produto_ID"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlImagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Produto_ID");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produto");

                    b.HasData(
                        new
                        {
                            Produto_ID = 1,
                            CategoriaId = 1,
                            Descricao = "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.",
                            Featured = true,
                            Nome = "The Hitchhiker's Guide to the Galaxy",
                            UrlImagem = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg"
                        },
                        new
                        {
                            Produto_ID = 2,
                            CategoriaId = 1,
                            Descricao = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]",
                            Featured = false,
                            Nome = "Ready Player One",
                            UrlImagem = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg"
                        },
                        new
                        {
                            Produto_ID = 3,
                            CategoriaId = 1,
                            Descricao = "Mil Novecentos e Oitenta e Quatro (em inglês: Nineteen Eighty-Four), muitas vezes publicado como 1984, é um romance distópico da autoria do escritor britânico George Orwell e publicado em 1949.[1][2] O romance é ambientado na Pista de Pouso Número 1 (anteriormente conhecida como Grã-Bretanha), uma província do superestado da Oceania, em um mundo de guerra perpétua, vigilância governamental onipresente e manipulação pública e histórica. Os habitantes deste superestado são ditados por um",
                            Featured = false,
                            Nome = "Nineteen Eighty-Four",
                            UrlImagem = "https://upload.wikimedia.org/wikipedia/pt/7/74/1984cover.jpg"
                        },
                        new
                        {
                            Produto_ID = 4,
                            CategoriaId = 2,
                            Descricao = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                            Featured = false,
                            Nome = "The Matrix",
                            UrlImagem = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg"
                        },
                        new
                        {
                            Produto_ID = 5,
                            CategoriaId = 2,
                            Descricao = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                            Featured = true,
                            Nome = "Back to the Future",
                            UrlImagem = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg"
                        },
                        new
                        {
                            Produto_ID = 6,
                            CategoriaId = 2,
                            Descricao = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.",
                            Featured = false,
                            Nome = "Toy Story",
                            UrlImagem = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg"
                        },
                        new
                        {
                            Produto_ID = 7,
                            CategoriaId = 3,
                            Descricao = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                            Featured = false,
                            Nome = "Half-Life 2",
                            UrlImagem = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg"
                        },
                        new
                        {
                            Produto_ID = 8,
                            CategoriaId = 3,
                            Descricao = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                            Featured = false,
                            Nome = "Diablo II",
                            UrlImagem = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png"
                        },
                        new
                        {
                            Produto_ID = 9,
                            CategoriaId = 3,
                            Descricao = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                            Featured = true,
                            Nome = "Day of the Tentacle",
                            UrlImagem = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg"
                        },
                        new
                        {
                            Produto_ID = 10,
                            CategoriaId = 3,
                            Descricao = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                            Featured = false,
                            Nome = "Xbox",
                            UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg"
                        },
                        new
                        {
                            Produto_ID = 11,
                            CategoriaId = 3,
                            Descricao = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                            Featured = false,
                            Nome = "Super Nintendo Entertainment System",
                            UrlImagem = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg"
                        });
                });

            modelBuilder.Entity("EcommerceBlazor.Shared.ProdutoVariante", b =>
                {
                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("TipoProdutoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecoOriginal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProdutoId", "TipoProdutoId");

                    b.HasIndex("TipoProdutoId");

                    b.ToTable("ProdutoVariante");

                    b.HasData(
                        new
                        {
                            ProdutoId = 1,
                            TipoProdutoId = 2,
                            Preco = 9.99m,
                            PrecoOriginal = 19.99m
                        },
                        new
                        {
                            ProdutoId = 1,
                            TipoProdutoId = 3,
                            Preco = 7.99m,
                            PrecoOriginal = 0m
                        },
                        new
                        {
                            ProdutoId = 1,
                            TipoProdutoId = 4,
                            Preco = 19.99m,
                            PrecoOriginal = 29.99m
                        },
                        new
                        {
                            ProdutoId = 2,
                            TipoProdutoId = 2,
                            Preco = 7.99m,
                            PrecoOriginal = 14.99m
                        },
                        new
                        {
                            ProdutoId = 3,
                            TipoProdutoId = 2,
                            Preco = 6.99m,
                            PrecoOriginal = 0m
                        },
                        new
                        {
                            ProdutoId = 4,
                            TipoProdutoId = 5,
                            Preco = 3.99m,
                            PrecoOriginal = 0m
                        },
                        new
                        {
                            ProdutoId = 4,
                            TipoProdutoId = 6,
                            Preco = 9.99m,
                            PrecoOriginal = 0m
                        },
                        new
                        {
                            ProdutoId = 4,
                            TipoProdutoId = 7,
                            Preco = 19.99m,
                            PrecoOriginal = 0m
                        },
                        new
                        {
                            ProdutoId = 5,
                            TipoProdutoId = 5,
                            Preco = 3.99m,
                            PrecoOriginal = 0m
                        },
                        new
                        {
                            ProdutoId = 6,
                            TipoProdutoId = 5,
                            Preco = 2.99m,
                            PrecoOriginal = 0m
                        },
                        new
                        {
                            ProdutoId = 7,
                            TipoProdutoId = 8,
                            Preco = 19.99m,
                            PrecoOriginal = 29.99m
                        },
                        new
                        {
                            ProdutoId = 7,
                            TipoProdutoId = 9,
                            Preco = 69.99m,
                            PrecoOriginal = 0m
                        },
                        new
                        {
                            ProdutoId = 7,
                            TipoProdutoId = 10,
                            Preco = 49.99m,
                            PrecoOriginal = 59.99m
                        },
                        new
                        {
                            ProdutoId = 8,
                            TipoProdutoId = 8,
                            Preco = 9.99m,
                            PrecoOriginal = 24.99m
                        },
                        new
                        {
                            ProdutoId = 9,
                            TipoProdutoId = 8,
                            Preco = 14.99m,
                            PrecoOriginal = 0m
                        },
                        new
                        {
                            ProdutoId = 10,
                            TipoProdutoId = 1,
                            Preco = 159.99m,
                            PrecoOriginal = 299m
                        },
                        new
                        {
                            ProdutoId = 11,
                            TipoProdutoId = 1,
                            Preco = 79.99m,
                            PrecoOriginal = 399m
                        });
                });

            modelBuilder.Entity("EcommerceBlazor.Shared.TipoProduto", b =>
                {
                    b.Property<int>("TipoProduto_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoProduto_ID"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipoProduto_ID");

                    b.ToTable("TipoProduto");

                    b.HasData(
                        new
                        {
                            TipoProduto_ID = 1,
                            Nome = "Default"
                        },
                        new
                        {
                            TipoProduto_ID = 2,
                            Nome = "Paperback"
                        },
                        new
                        {
                            TipoProduto_ID = 3,
                            Nome = "E-Book"
                        },
                        new
                        {
                            TipoProduto_ID = 4,
                            Nome = "Audiobook"
                        },
                        new
                        {
                            TipoProduto_ID = 5,
                            Nome = "Stream"
                        },
                        new
                        {
                            TipoProduto_ID = 6,
                            Nome = "Blu-ray"
                        },
                        new
                        {
                            TipoProduto_ID = 7,
                            Nome = "VHS"
                        },
                        new
                        {
                            TipoProduto_ID = 8,
                            Nome = "PC"
                        },
                        new
                        {
                            TipoProduto_ID = 9,
                            Nome = "PlayStation"
                        },
                        new
                        {
                            TipoProduto_ID = 10,
                            Nome = "Xbox"
                        });
                });

            modelBuilder.Entity("EcommerceBlazor.Shared.Usuario", b =>
                {
                    b.Property<int>("Usuario_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Usuario_ID"));

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("SenhaHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("SenhaSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Usuario_ID");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("EcommerceBlazor.Shared.Produto", b =>
                {
                    b.HasOne("EcommerceBlazor.Shared.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("EcommerceBlazor.Shared.ProdutoVariante", b =>
                {
                    b.HasOne("EcommerceBlazor.Shared.Produto", "Produto")
                        .WithMany("Variantes")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcommerceBlazor.Shared.TipoProduto", "TipoProduto")
                        .WithMany()
                        .HasForeignKey("TipoProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("TipoProduto");
                });

            modelBuilder.Entity("EcommerceBlazor.Shared.Produto", b =>
                {
                    b.Navigation("Variantes");
                });
#pragma warning restore 612, 618
        }
    }
}
